using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blish_HUD;
using Gw2Sharp.WebApi.V2.Models;
using Oberyn.AnglerAssociate.Models;

namespace Oberyn.AnglerAssociate.Services
{
    //Fetch /v2/account/achievements once and cache the result; if something changes later, callers should reinvoke on both load and SubtokenUnload
    public class AchievementProgressService
    {
        private static readonly Logger Logger = Logger.GetLogger(typeof(AchievementProgressService));
        private readonly Dictionary<int, HashSet<int>> _completedBits = new Dictionary<int, HashSet<int>>();
        private readonly Dictionary<int, bool> _achievementDone = new Dictionary<int, bool>();

        public bool IsLoaded { get; private set; }

        public async Task RefreshAsync()
        {
            var apiManager = AnglerAssociateModule.Instance.Gw2ApiManager;

            if (!apiManager.HasPermissions(new[] { TokenPermission.Account, TokenPermission.Progression }))
            {
                Logger.Debug("Skipping achievement refresh - missing account/progression permission.");
                IsLoaded = false;
                return;
            }

            try
            {
                var achievements = await apiManager.Gw2ApiClient.V2.Account.Achievements.GetAsync();

                _completedBits.Clear();
                _achievementDone.Clear();

                foreach (var achievement in achievements)
                {
                    _achievementDone[achievement.Id] = achievement.Done;
                    _completedBits[achievement.Id] = achievement.Bits != null
                        ? new HashSet<int>(achievement.Bits)
                        : new HashSet<int>();
                }

                IsLoaded = true;
                Logger.Debug("Loaded {0} account achievements.", achievements.Count);
            }
            catch (Exception ex)
            {
                Logger.Warn(ex, "Failed to load account achievements.");
                IsLoaded = false;
            }
        }

        // Only show Avid collection on completing the basic collection
        public bool IsCollectionDone(int? collectionId)
        {
            return collectionId.HasValue
                && _achievementDone.TryGetValue(collectionId.Value, out var done)
                && done;
        }

        // Check individual achievement (fish) unlocks
        public bool IsFishCaught(Fish fish)
        {
            if (fish.CollectionId == null || fish.BitIndex == null)
                return false;

            return IsBitCaught(fish.CollectionId.Value, fish.BitIndex.Value);
        }

        // Same bit index, but checked against the Avid collection's own ID - Avid is
        // tracked as a genuinely separate achievement server-side, not just a flag on
        // the base one, so it needs its own completion check.
        public bool IsFishCaughtForAvid(Fish fish)
        {
            if (fish.AvidCollectionId == null || fish.BitIndex == null)
                return false;

            return IsBitCaught(fish.AvidCollectionId.Value, fish.BitIndex.Value);
        }

        // Per the GW2 API's own docs: "If an achievement is done, the in-progress bits
        // are not displayed" - a fully completed achievement can come back with no
        // bits array at all. So completion has to be checked first; falling through to
        // bits only applies while the achievement is still in progress.
        private bool IsBitCaught(int collectionId, int bitIndex)
        {
            if (_achievementDone.TryGetValue(collectionId, out var done) && done)
                return true;

            return _completedBits.TryGetValue(collectionId, out var bits)
                && bits.Contains(bitIndex);
        }
    }
}