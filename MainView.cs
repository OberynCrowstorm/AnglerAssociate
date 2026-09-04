using System;
using System.Collections.Generic;
using System.Linq;
using Blish_HUD;
using Blish_HUD.Content;
using Blish_HUD.Controls;
using Blish_HUD.Modules.Managers;
using Microsoft.Xna.Framework;
using Oberyn.AnglerAssociate.Data;
using Oberyn.AnglerAssociate.Models;
using Oberyn.AnglerAssociate.Services;

namespace Oberyn.AnglerAssociate.Controls
{
    public class MainView : Panel
    {
        // (Region, icon filename, tooltip) - one badge per top-level region. Global has
        // no badge of its own; the Tyria badge covers both, per the "Tyria & Global"
        // decision (Global fish aren't tied to any specific map anyway).
        private static readonly (Region Region, string IconFile, string Tooltip)[] RegionBadges =
        {
            (Region.Tyria, "tyria.png", "Tyria & Global"),
            (Region.Orr, "orr.png", "Orr"),
            (Region.MaguumaJungle, "maguuma.png", "Maguuma Jungle"),
            (Region.CrystalDesert, "crystal_desert.png", "Crystal Desert"),
            (Region.Cantha, "cantha.png", "Cantha"),
            (Region.HornOfMaguuma, "horn_of_maguuma.png", "Horn of Maguuma"),
            (Region.Janthir, "janthir.png", "Janthir"),
            (Region.Castora, "castora.png", "Castora"),
        };

        // Same 8 regions, filename convention "portrait_{same base name as the badge}.png" -
        // e.g. Janthir's badge is janthir.png, its portrait is portrait_janthir.png. Not
        // required to exist yet; missing files just mean no portrait shows for that region
        // until it's added, rather than breaking anything.
        private static readonly Dictionary<Region, string> RegionPortraitFiles = new Dictionary<Region, string>
        {
            { Region.Tyria, "portrait_tyria.png" },
            { Region.Orr, "portrait_orr.png" },
            { Region.MaguumaJungle, "portrait_maguuma.png" },
            { Region.CrystalDesert, "portrait_crystal_desert.png" },
            { Region.Cantha, "portrait_cantha.png" },
            { Region.HornOfMaguuma, "portrait_horn_of_maguuma.png" },
            { Region.Janthir, "portrait_janthir.png" },
            { Region.Castora, "portrait_castora.png" },
        };

        private readonly ContentsManager _contentsManager;
        private readonly AchievementProgressService _achievementProgress;
        private readonly Label _dailyLabel;
        private readonly DayNightBanner _tyriaBanner;
        private readonly DayNightBanner _canthaBanner;
        private readonly List<(Region Region, Image Image)> _regionBadges = new List<(Region, Image)>();
        private readonly Dictionary<Region, AsyncTexture2D> _regionColorTextures = new Dictionary<Region, AsyncTexture2D>();
        private readonly Dictionary<Region, AsyncTexture2D> _regionPortraitTextures = new Dictionary<Region, AsyncTexture2D>();
        private Image _regionPortrait;
        private AsyncTexture2D _regionNullTexture;
        private Region? _selectedRegion; // null = no filter, show every region
        private readonly Dropdown _achievementDropdown;
        private readonly Dropdown _baitDropdown;
        private TextBox _holeFilterSearchBox;
        private Panel _holeFilterPopup;
        private readonly List<Panel> _holeFilterResultControls = new List<Panel>();
        private List<(string Display, FishingHole Hole)> _holeFilterOptions = new List<(string, FishingHole)>();
        private FishingHole? _selectedHoleFilter; // null = no filter
        private readonly Checkbox _availableNowCheckbox;
        private readonly Checkbox _hideCollectedCheckbox;
        private readonly TextBox _searchBox;
        private readonly Image _refreshButton;
        private readonly Panel _tableRows;
        private readonly List<Panel> _rowControls = new List<Panel>();
        private Label _allCollectedLabel;
        private readonly Dictionary<string, Bait> _baitDisplayToValue = new Dictionary<string, Bait>();

        // --- Table header/rows vs fish detail view toggle ---
        private Panel _tableHeaderPanel;
        private Panel _detailPanel;

        // --- Fish detail view ---
        private Fish _detailFish;
        private Label _detailFishNameLabel;
        private Panel _detailInfoPanel;
        private Panel _holeRowsPanel;
        private readonly List<Panel> _holeRowControls = new List<Panel>();

        // Region -> Map -> Area shown as three parallel columns (not a replacing stack) -
        // clicking a region/map bolds it and populates the column to its right.
        private const int ColumnWidth = 170;   // Map / Nearest Waypoint columns
        private const int RegionColumnWidth = 110; // narrower - swapped with Fishing Hole per feedback
        private Panel _regionColumnPanel;
        private readonly List<Panel> _regionColumnControls = new List<Panel>();
        private Panel _mapColumnPanel;
        private readonly List<Panel> _mapColumnControls = new List<Panel>();
        private Panel _areaColumnPanel;
        private readonly List<Panel> _areaColumnControls = new List<Panel>();
        private List<PlaceNode> _currentRegions;
        private PlaceNode _selectedRegionNode;
        private PlaceNode _selectedMapNode;

        private const int RowHeight = 40;
        private const int TableTop = 25;


        public MainView(ContentsManager contentsManager, AchievementProgressService achievementProgress, int contentHeight)
        {
            _contentsManager = contentsManager;
            _achievementProgress = achievementProgress;

            _dailyLabel = new Label
            {
                Parent = this,
                Text = $"Today's daily: {DailyFisherRotation.GetToday()}",
                Location = new Point(0, 0),
                Width = 300,
                Height = 24,
            };

            _tyriaBanner = new DayNightBanner(contentsManager, "tyria", "Tyria", Cycle.Tyria)
            {
                Parent = this,
                Location = new Point(0, 40),
            };

            _canthaBanner = new DayNightBanner(contentsManager, "cantha", "Cantha/Castora", Cycle.CanthaCastora)
            {
                Parent = this,
                Location = new Point(130, 40),
            };

            var searchLabel = new Label
            {
                Parent = this,
                Text = "Search fish",
                Location = new Point(0, 460),
                Width = 250,
                Height = 20,
            };

            _searchBox = new TextBox
            {
                Parent = this,
                PlaceholderText = "Fish name...",
                Location = new Point(0, 480),
                Width = 225,
                Height = 24,
            };
            _searchBox.TextChanged += (s, e) => RebuildRows();

            var searchClearButton = new Label
            {
                Parent = this,
                Text = "X",
                Location = new Point(228, 480),
                Width = 22,
                Height = 24,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Middle,
                BasicTooltipText = "Clear search",
            };
            searchClearButton.LeftMouseButtonReleased += (s, e) =>
            {
                _searchBox.Text = string.Empty;
                RebuildRows();
            };

            _refreshButton = new Image
            {
                Parent = this,
                Texture = contentsManager.GetTexture("icons/reload.png"),
                Location = new Point(0, 520),
                Size = new Point(32, 32),
                BasicTooltipText = "Refresh achievement progress",
            };
            _refreshButton.Click += async (s, e) =>
            {
                await _achievementProgress.RefreshAsync();
                RefreshLiveData();
                RebuildRows();
            };

            const int filterX = 320; // shifted left 20px from the clock area, freeing room for the detail view's scrollbar
            const int colWidth = 200;
            const int colGap = 20;
            int col1 = filterX;
            int col2 = filterX + colWidth + colGap;
            int col3 = filterX + 2 * (colWidth + colGap);
            int y = 0;

            var regionLabel = new Label { Parent = this, Text = "Filter by region", Location = new Point(col1, y), Width = colWidth * 2 + colGap, Height = 20 };
            y += 20;

            _regionNullTexture = contentsManager.GetTexture("icons/null.png");

            const int badgeSize = 40;
            const int badgeGap = 8;
            int bx = col1;
            foreach (var badge in RegionBadges)
            {
                var colorTexture = contentsManager.GetTexture($"icons/{badge.IconFile}");
                _regionColorTextures[badge.Region] = colorTexture;
                _regionPortraitTextures[badge.Region] = contentsManager.GetTexture($"icons/{RegionPortraitFiles[badge.Region]}");

                var badgeImage = new Image
                {
                    Parent = this,
                    Texture = colorTexture,
                    Location = new Point(bx, y),
                    Size = new Point(badgeSize, badgeSize),
                    BasicTooltipText = badge.Tooltip,
                };

                var capturedRegion = badge.Region;
                badgeImage.Click += (s, e) =>
                {
                    _selectedRegion = _selectedRegion == capturedRegion ? (Region?)null : capturedRegion;
                    RefreshRegionBadgeTextures();
                    RebuildAchievementDropdown();
                    RebuildBaitDropdown();
                    RebuildHoleFilterOptions();
                    RebuildRows();
                };

                _regionBadges.Add((badge.Region, badgeImage));
                bx += badgeSize + badgeGap;
            }

            // Sits in the empty upper-right corner, above the table's "Time" column -
            // genuinely unused space, and roomier than the narrow clock-to-table gap was.
            const int portraitWidth = 80;
            const int portraitHeight = 110;
            const int portraitX = 940;
            _regionPortrait = new Image
            {
                Parent = this,
                Location = new Point(portraitX, 0),
                Size = new Point(portraitWidth, portraitHeight),
                Visible = false,
            };

            RefreshRegionBadgeTextures();

            _hideCollectedCheckbox = new Checkbox
            {
                Parent = this,
                Text = "Hide collected",
                Location = new Point(col3, y),
                Checked = false,
            };
            _hideCollectedCheckbox.CheckedChanged += (s, e) => RebuildRows();

            _availableNowCheckbox = new Checkbox
            {
                Parent = this,
                Text = "Show only available now",
                Location = new Point(col3, y + 25),
                Checked = false,
            };
            _availableNowCheckbox.CheckedChanged += (s, e) => RebuildRows();
            y += 45; // as tight as this can go without overlapping the 40px-tall badge row above

            var achievementLabel = new Label { Parent = this, Text = "Filter by achievement", Location = new Point(col1, y), Width = colWidth, Height = 20 };
            var baitLabel = new Label { Parent = this, Text = "Filter by bait", Location = new Point(col2, y), Width = colWidth, Height = 20 };
            var holeFilterLabel = new Label { Parent = this, Text = "Filter by fishing hole", Location = new Point(col3, y), Width = colWidth, Height = 20 };
            y += 20;

            _achievementDropdown = new Dropdown { Parent = this, Location = new Point(col1, y), Width = colWidth };
            _achievementDropdown.ValueChanged += (s, e) => RebuildRows();

            _baitDropdown = new Dropdown { Parent = this, Location = new Point(col2, y), Width = colWidth };
            _baitDropdown.ValueChanged += (s, e) => RebuildRows();

            _holeFilterSearchBox = new TextBox
            {
                Parent = this,
                PlaceholderText = "Type to search...",
                Location = new Point(col3, y),
                Width = colWidth,
            };
            _holeFilterSearchBox.TextChanged += (s, e) => RenderHoleFilterResults();

            var holeFilterClearButton = new Label
            {
                Parent = this,
                Text = "X",
                Location = new Point(col3 + colWidth - 22, y),
                Width = 22,
                Height = 24,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Middle,
                BasicTooltipText = "Clear hole filter",
            };
            holeFilterClearButton.LeftMouseButtonReleased += (s, e) =>
            {
                _holeFilterSearchBox.Text = string.Empty;
                _selectedHoleFilter = null;
                RenderHoleFilterResults();
                RebuildRows();
            };

            // Popup only - overlays whatever's beneath it, doesn't push the table down.
            // High ZIndex so it draws above the table rows it may overlap while open.
            _holeFilterPopup = new Panel
            {
                Parent = this,
                Location = new Point(col3, y + 26),
                Width = colWidth,
                Height = 280,
                CanScroll = true,
                ShowBorder = true,
                BackgroundColor = new Color(20, 20, 20, 235), // near-opaque so popup text doesn't bleed into the table beneath it
                Visible = false,
                ZIndex = 100,
            };
            y += 40;

            // --- Table ---
            BuildTableHeader(filterX, y);

            const int tableWidth = 732; // +20 vs filterX's -20, keeps the right edge anchored where it was

            _tableRows = new Panel
            {
                Parent = this,
                Location = new Point(filterX, y + TableTop),
                Width = tableWidth,
                Height = Math.Max(contentHeight - (y + TableTop) - 10, 100),
                CanScroll = true,
            };

            _allCollectedLabel = new Label
            {
                Parent = this,
                Location = new Point(filterX, y + TableTop),
                Width = tableWidth,
                Height = 40,
                HorizontalAlignment = HorizontalAlignment.Center,
                Visible = false,
            };

            // Detail view occupies exactly the same footprint as the header+rows above -
            // toggled with them, everything else (banners, filters, search) stays visible.
            int detailTop = y;
            int detailHeight = Math.Max(contentHeight - detailTop - 10, 100);
            BuildDetailPanel(contentsManager, filterX, detailTop, tableWidth, detailHeight);

            // Initial population
            RebuildAchievementDropdown();
            RebuildBaitDropdown();
            RebuildHoleFilterOptions();
            RebuildRows();
        }
        public void RefreshLiveData()
        {
            _tyriaBanner.Refresh();
            _canthaBanner.Refresh();
            _dailyLabel.Text = $"Today's daily: {DailyFisherRotation.GetToday()}";
        }

        // --- Fish detail view: static scaffolding, built once ---
        private void BuildDetailPanel(ContentsManager contentsManager, int x, int y, int width, int height)
        {
            var headerFont = GameService.Content.GetFont(
                ContentService.FontFace.Menomonia, ContentService.FontSize.Size16, ContentService.FontStyle.Bold);

            _detailPanel = new Panel { Parent = this, Location = new Point(x, y), Width = width, Height = height, Visible = false };

            var exitButton = new Image
            {
                Parent = _detailPanel,
                Texture = contentsManager.GetTexture("icons/arrow_up.png"),
                Location = new Point(0, 0),
                Size = new Point(32, 32),
                BasicTooltipText = "Back to fish list",
            };
            exitButton.Click += (s, e) => HideDetailView();

            _detailFishNameLabel = new Label
            {
                Parent = _detailPanel,
                Font = headerFont,
                Location = new Point(40, 0),
                Width = 300,
                Height = 32,
                VerticalAlignment = VerticalAlignment.Middle,
            };
            // _detailInfoPanel (Rarity/Bait/Time) sits at y=32, height RowHeight(40) -> ends
            // at y=72, rebuilt per fish in RebuildDetailInfo(). contentTop below must clear it.

            const int leftPaneNameWidth = 170; // swapped with Region - hole names truncate more/worse
            const int leftPanePowerWidth = 50;
            const int leftPaneContentWidth = leftPaneNameWidth + leftPanePowerWidth;
            const int scrollMargin = 20; // clear space so the scrollbar doesn't render over row text
            const int leftPaneWidth = leftPaneContentWidth + scrollMargin;
            const int colGap = 10;
            int col1X = leftPaneWidth + colGap;
            int col2X = col1X + RegionColumnWidth + colGap;
            int col3X = col2X + ColumnWidth + colGap;
            const int contentTop = 100;
            int columnHeight = Math.Max(height - contentTop - 10, 100);

            new Label { Parent = _detailPanel, Text = "Fishing Hole", Font = headerFont, Location = new Point(0, contentTop - 20), Width = leftPaneNameWidth, Height = 20 };
            new Label { Parent = _detailPanel, Text = "Power", Font = headerFont, Location = new Point(leftPaneNameWidth, contentTop - 20), Width = leftPanePowerWidth, Height = 20, HorizontalAlignment = HorizontalAlignment.Center };

            _holeRowsPanel = new Panel
            {
                Parent = _detailPanel,
                Location = new Point(0, contentTop),
                Width = leftPaneWidth,
                Height = columnHeight,
                CanScroll = true,
            };

            new Label
            {
                Parent = _detailPanel,
                Text = "Region",
                Font = headerFont,
                Location = new Point(col1X, contentTop - 20),
                Width = RegionColumnWidth,
                Height = 20,
                BasicTooltipText = "Select a fishing hole on the left to see where to find it.",
            };
            new Label
            {
                Parent = _detailPanel,
                Text = "Map",
                Font = headerFont,
                Location = new Point(col2X, contentTop - 20),
                Width = ColumnWidth,
                Height = 20,
                BasicTooltipText = "Select a region to see the list of maps with this hole.",
            };
            new Label
            {
                Parent = _detailPanel,
                Text = "Nearest Waypoint",
                Font = headerFont,
                Location = new Point(col3X, contentTop - 20),
                Width = ColumnWidth,
                Height = 20,
                BasicTooltipText = "Select a map to see the list of the nearest waypoints.",
            };

            _regionColumnPanel = new Panel { Parent = _detailPanel, Location = new Point(col1X, contentTop), Width = RegionColumnWidth, Height = columnHeight, CanScroll = true };
            _mapColumnPanel = new Panel { Parent = _detailPanel, Location = new Point(col2X, contentTop), Width = ColumnWidth, Height = columnHeight, CanScroll = true };
            _areaColumnPanel = new Panel { Parent = _detailPanel, Location = new Point(col3X, contentTop), Width = ColumnWidth, Height = columnHeight, CanScroll = true };
        }

        private void ShowFishDetail(Fish fish)
        {
            _detailFish = fish;
            _detailFishNameLabel.Text = fish.Name;

            RebuildDetailInfo();
            RebuildHoleRows();

            _currentRegions = null;
            _selectedRegionNode = null;
            _selectedMapNode = null;
            RenderRegionColumn();
            RenderMapColumn();
            RenderAreaColumn();

            _tableHeaderPanel.Visible = false;
            _tableRows.Visible = false;
            _allCollectedLabel.Visible = false;
            _detailPanel.Visible = true;
        }

        private void HideDetailView()
        {
            _detailPanel.Visible = false;
            _tableHeaderPanel.Visible = true;
            _tableRows.Visible = true;
        }

        // Rarity/Bait/Time row under the fish name - reuses the same cell builders the
        // main table uses, so bait/time icons render identically in both places.
        private void RebuildDetailInfo()
        {
            _detailInfoPanel?.Dispose();

            const int rarityWidth = 100;
            const int baitWidth = 80;
            const int timeWidth = 80;
            const int groupWidth = rarityWidth + baitWidth + timeWidth;

            int groupX = Math.Max((_detailPanel.Width - groupWidth) / 2, 40);
            _detailInfoPanel = new Panel { Parent = _detailPanel, Location = new Point(groupX, 32), Width = groupWidth, Height = RowHeight };

            new Label
            {
                Parent = _detailInfoPanel,
                Text = _detailFish.Rarity.ToString(),
                TextColor = RarityColors.Get(_detailFish.Rarity),
                Location = new Point(0, 0),
                Width = rarityWidth,
                Height = RowHeight,
                VerticalAlignment = VerticalAlignment.Middle,
                HorizontalAlignment = HorizontalAlignment.Center,
            };

            BuildBaitCell(_detailInfoPanel, _detailFish, new Point(rarityWidth, 0));
            BuildTimeOfDayCell(_detailInfoPanel, _detailFish, new Point(rarityWidth + baitWidth, 0));
        }

        private void RebuildHoleRows()
        {
            foreach (var row in _holeRowControls)
                row.Dispose();
            _holeRowControls.Clear();

            const int nameWidth = 170;
            const int powerWidth = 50;
            const int rowWidth = nameWidth + powerWidth;

            if (_detailFish.AllHoles.Count == 0)
            {
                // Open Water was deliberately excluded from the Acquisition data (its
                // power varies too wildly by map to track meaningfully) - say so plainly
                // rather than looking like the fish is just missing data.
                bool isOpenWater = _detailFish.Hole1 == FishingHole.OpenWater
                    || _detailFish.Hole2 == FishingHole.OpenWater
                    || _detailFish.Hole3 == FishingHole.OpenWater
                    || _detailFish.Hole4 == FishingHole.OpenWater;

                var emptyRow = new Panel { Parent = _holeRowsPanel, Location = new Point(0, 0), Width = rowWidth, Height = RowHeight };
                new Label
                {
                    Parent = emptyRow,
                    Text = isOpenWater ? "Any Open Water hole" : "No catch-location data available.",
                    Location = new Point(0, 0),
                    Width = rowWidth,
                    Height = RowHeight,
                    VerticalAlignment = VerticalAlignment.Middle,
                };
                _holeRowControls.Add(emptyRow);
                return;
            }

            int rowY = 0;
            foreach (var entry in _detailFish.AllHoles)
            {
                var row = new Panel { Parent = _holeRowsPanel, Location = new Point(0, rowY), Width = rowWidth, Height = RowHeight };

                var holeText = EnumDisplay.Format(entry.Hole);
                var nameLabel = new Label
                {
                    Parent = row,
                    Text = TruncateToWidth(holeText, nameWidth),
                    BasicTooltipText = holeText,
                    Location = new Point(0, 0),
                    Width = nameWidth,
                    Height = RowHeight,
                    VerticalAlignment = VerticalAlignment.Middle,
                };
                var powerLabel = new Label
                {
                    Parent = row,
                    Text = entry.Power.ToString(),
                    Location = new Point(nameWidth, 0),
                    Width = powerWidth,
                    Height = RowHeight,
                    VerticalAlignment = VerticalAlignment.Middle,
                    HorizontalAlignment = HorizontalAlignment.Center,
                };

                var capturedHole = entry.Hole;
                row.Click += (s, e) => SelectHole(capturedHole);
                nameLabel.Click += (s, e) => SelectHole(capturedHole);
                powerLabel.Click += (s, e) => SelectHole(capturedHole);

                _holeRowControls.Add(row);
                rowY += RowHeight;
            }
        }

        // Clicking any Hole row always resets Region/Map/Area entirely, discarding
        // whatever was previously selected - matches the same reset behavior a
        // different Hole should always have.
        private void SelectHole(FishingHole hole)
        {
            _currentRegions = HolePlaces.ByHole.TryGetValue(hole, out var places) ? places : new List<PlaceNode>();
            _selectedRegionNode = null;
            _selectedMapNode = null;

            RenderRegionColumn();
            RenderMapColumn();
            RenderAreaColumn();
        }

        private void SelectRegion(PlaceNode region)
        {
            _selectedRegionNode = region;
            _selectedMapNode = null;

            RenderRegionColumn();
            RenderMapColumn();
            RenderAreaColumn();
        }

        private void SelectMap(PlaceNode map)
        {
            _selectedMapNode = map;

            RenderMapColumn();
            RenderAreaColumn();
        }

        private void RenderRegionColumn()
        {
            foreach (var c in _regionColumnControls)
                c.Dispose();
            _regionColumnControls.Clear();

            var boldFont = GameService.Content.GetFont(
                ContentService.FontFace.Menomonia, ContentService.FontSize.Size16, ContentService.FontStyle.Bold);

            bool hasRegions = _currentRegions != null && _currentRegions.Count > 0;
            if (!hasRegions)
                return;

            int rowY = 0;
            foreach (var node in _currentRegions)
            {
                var row = new Panel { Parent = _regionColumnPanel, Location = new Point(0, rowY), Width = RegionColumnWidth, Height = RowHeight };
                var label = new Label
                {
                    Parent = row,
                    Text = TruncateToWidth(node.Label, RegionColumnWidth),
                    BasicTooltipText = node.Label,
                    Location = new Point(0, 0),
                    Width = RegionColumnWidth,
                    Height = RowHeight,
                    VerticalAlignment = VerticalAlignment.Middle,
                };
                if (node == _selectedRegionNode)
                    label.Font = boldFont;

                var capturedNode = node;
                row.Click += (s, e) => SelectRegion(capturedNode);
                label.Click += (s, e) => SelectRegion(capturedNode);

                _regionColumnControls.Add(row);
                rowY += RowHeight;
            }
        }

        private void RenderMapColumn()
        {
            foreach (var c in _mapColumnControls)
                c.Dispose();
            _mapColumnControls.Clear();

            var boldFont = GameService.Content.GetFont(
                ContentService.FontFace.Menomonia, ContentService.FontSize.Size16, ContentService.FontStyle.Bold);

            var maps = _selectedRegionNode?.Children;
            bool hasMaps = maps != null && maps.Count > 0;
            if (!hasMaps)
                return;

            int rowY = 0;
            foreach (var node in maps)
            {
                var row = new Panel { Parent = _mapColumnPanel, Location = new Point(0, rowY), Width = ColumnWidth, Height = RowHeight };
                var label = new Label
                {
                    Parent = row,
                    Text = TruncateToWidth(node.Label, ColumnWidth),
                    BasicTooltipText = node.Label,
                    Location = new Point(0, 0),
                    Width = ColumnWidth,
                    Height = RowHeight,
                    VerticalAlignment = VerticalAlignment.Middle,
                };
                if (node == _selectedMapNode)
                    label.Font = boldFont;

                var capturedNode = node;
                row.Click += (s, e) => SelectMap(capturedNode);
                label.Click += (s, e) => SelectMap(capturedNode);

                _mapColumnControls.Add(row);
                rowY += RowHeight;
            }
        }

        private void RenderAreaColumn()
        {
            foreach (var c in _areaColumnControls)
                c.Dispose();
            _areaColumnControls.Clear();

            var areas = _selectedMapNode?.Children;
            bool hasAreas = areas != null && areas.Count > 0;
            if (!hasAreas)
                return;

            int rowY = 0;
            foreach (var node in areas)
            {
                var row = new Panel { Parent = _areaColumnPanel, Location = new Point(0, rowY), Width = ColumnWidth, Height = RowHeight };

                string tooltip = "Click to copy to clipboard";
                if (LocationWaypoints.ByName.TryGetValue(node.Label, out var area) && !string.IsNullOrEmpty(area.SpecialNote))
                    tooltip += "\n" + area.SpecialNote;
                if (node.Label.Length > (int)(ColumnWidth / PixelsPerChar))
                    tooltip = node.Label + "\n" + tooltip;

                var label = new Label
                {
                    Parent = row,
                    Text = TruncateToWidth(node.Label, ColumnWidth),
                    Location = new Point(0, 0),
                    Width = ColumnWidth,
                    Height = RowHeight,
                    VerticalAlignment = VerticalAlignment.Middle,
                };

                row.BasicTooltipText = tooltip;
                label.BasicTooltipText = tooltip;

                var capturedLabel = node.Label;
                row.Click += (s, e) => CopyWaypoint(capturedLabel);
                label.Click += (s, e) => CopyWaypoint(capturedLabel);

                _areaColumnControls.Add(row);
                rowY += RowHeight;
            }
        }

        private static void CopyWaypoint(string areaName)
        {
            if (!LocationWaypoints.ByName.TryGetValue(areaName, out var area) || string.IsNullOrEmpty(area.Waypoint))
                return;

            CopyToClipboard(area.Waypoint);
        }

        // Clipboard access requires an STA thread on .NET Framework - Blish HUD's main
        // thread isn't guaranteed to be STA, so this spins up a short-lived one.
        private static void CopyToClipboard(string text)
        {
            var thread = new System.Threading.Thread(() =>
            {
                try
                {
                    System.Windows.Forms.Clipboard.SetText(text);
                }
                catch
                {
                    // best-effort - clipboard access can fail for reasons outside our control
                }
            });
            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();
            thread.Join();
        }

        // Tyria's badge stands in for both Region.Tyria and Region.Global.
        private static bool MatchesRegion(Fish fish, Region region)
        {
            if (region == Region.Tyria)
                return fish.Region == Region.Tyria || fish.Region == Region.Global;

            return fish.Region == region;
        }

        private void RefreshRegionBadgeTextures()
        {
            foreach (var (region, image) in _regionBadges)
            {
                bool highlighted = _selectedRegion == null || _selectedRegion == region;
                image.Texture = highlighted ? _regionColorTextures[region] : _regionNullTexture;
            }

            if (_selectedRegion.HasValue && _regionPortraitTextures.TryGetValue(_selectedRegion.Value, out var portraitTexture))
            {
                _regionPortrait.Texture = portraitTexture;
                _regionPortrait.Visible = true;
            }
            else
            {
                _regionPortrait.Visible = false;
            }
        }

        private void BuildTableHeader(int x, int y)
        {
            string[] headers = { "Fish", "Found in", "Rarity", "Hole", "Bait", "Time" };
            int[] widths = { 150, 170, 100, 130, 80, 80 }; // sums to 710, within the 712px table width

            _tableHeaderPanel = new Panel { Parent = this, Location = new Point(x, y), Width = 710, Height = 24 };

            var headerFont = GameService.Content.GetFont(
                ContentService.FontFace.Menomonia, ContentService.FontSize.Size16, ContentService.FontStyle.Bold);

            int cx = 0;
            for (int i = 0; i < headers.Length; i++)
            {
                new Label
                {
                    Parent = _tableHeaderPanel,
                    Text = headers[i],
                    Font = headerFont,
                    Location = new Point(cx, 0),
                    Width = widths[i],
                    Height = 24,
                    HorizontalAlignment = i == 0 ? HorizontalAlignment.Left : HorizontalAlignment.Center,
                };
                cx += widths[i];
            }
        }

        private void RebuildAchievementDropdown()
        {
            _achievementDropdown.Items.Clear();
            _achievementDropdown.Items.Add("All");

            var sourceFish = _selectedRegion == null
                ? FishCatalog.All
                : FishCatalog.All.Where(f => MatchesRegion(f, _selectedRegion.Value));

            // Avid collections only become selectable once their base collection is done -
            // matches how the game itself gates Avid progress behind the base collection.
            var names = new SortedSet<string>();
            foreach (var f in sourceFish.Where(f => f.Collection != null))
            {
                names.Add(f.Collection);

                if (f.AvidCollection != null && _achievementProgress.IsCollectionDone(f.CollectionId))
                    names.Add(f.AvidCollection);
            }

            foreach (var name in names)
                _achievementDropdown.Items.Add(name);

            _achievementDropdown.SelectedItem = "All";
        }

        private void RebuildBaitDropdown()
        {
            _baitDropdown.Items.Clear();
            _baitDisplayToValue.Clear();
            _baitDropdown.Items.Add("All");

            var sourceFish = _selectedRegion == null
                ? FishCatalog.All
                : FishCatalog.All.Where(f => MatchesRegion(f, _selectedRegion.Value));

            var baits = sourceFish
                .Select(f => f.Bait)
                .Distinct()
                .OrderBy(b => b.ToString());

            foreach (var bait in baits)
            {
                var display = EnumDisplay.Format(bait);
                _baitDropdown.Items.Add(display);
                _baitDisplayToValue[display] = bait;
            }

            _baitDropdown.SelectedItem = "All";
        }

        // Every real hole a fish can be caught at, from both Hole1-4 and AllHoles - this
        // is the "what can I catch right here" lookup, so it deliberately draws from both
        // sources rather than just the Acquisition-derived AllHoles list.
        private void RebuildHoleFilterOptions()
        {
            var sourceFish = _selectedRegion == null
                ? FishCatalog.All
                : FishCatalog.All.Where(f => MatchesRegion(f, _selectedRegion.Value));

            var holes = new SortedDictionary<string, FishingHole>();

            foreach (var f in sourceFish)
            {
                foreach (var hole in new[] { f.Hole1, f.Hole2, f.Hole3, f.Hole4 })
                {
                    if (hole.HasValue && hole.Value != FishingHole.Any)
                        holes[EnumDisplay.Format(hole.Value)] = hole.Value;
                }

                foreach (var entry in f.AllHoles)
                    holes[EnumDisplay.Format(entry.Hole)] = entry.Hole;
            }

            _holeFilterOptions = holes.Select(kv => (kv.Key, kv.Value)).ToList();

            // If switching regions made the currently-selected hole unavailable, clear it
            // rather than silently keep filtering on a hole that's no longer an option here.
            if (_selectedHoleFilter.HasValue && !_holeFilterOptions.Any(o => o.Hole == _selectedHoleFilter.Value))
            {
                _selectedHoleFilter = null;
                _holeFilterSearchBox.Text = string.Empty;
            }

            RenderHoleFilterResults();
        }

        // Popup list of matching holes, filtered live as the person types. Only shown
        // while there's search text - stays hidden otherwise, and closes again once a
        // result is clicked (which is what actually applies the table filter).
        private void RenderHoleFilterResults()
        {
            foreach (var row in _holeFilterResultControls)
                row.Dispose();
            _holeFilterResultControls.Clear();

            string searchText = _holeFilterSearchBox.Text?.Trim();
            _holeFilterPopup.Visible = !string.IsNullOrEmpty(searchText);
            if (string.IsNullOrEmpty(searchText))
                return;

            var matches = _holeFilterOptions
                .Where(o => o.Display.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);

            int rowY = 0;
            foreach (var option in matches)
            {
                var row = new Panel { Parent = _holeFilterPopup, Location = new Point(0, rowY), Width = 180, Height = RowHeight };
                var label = new Label { Parent = row, Text = option.Display, Location = new Point(0, 0), Width = 180, Height = RowHeight, VerticalAlignment = VerticalAlignment.Middle };

                var capturedOption = option;
                void SelectThis()
                {
                    _selectedHoleFilter = capturedOption.Hole;
                    _holeFilterSearchBox.Text = capturedOption.Display;
                    _holeFilterPopup.Visible = false;
                    RebuildRows();
                }
                row.Click += (s, e) => SelectThis();
                label.Click += (s, e) => SelectThis();

                _holeFilterResultControls.Add(row);
                rowY += RowHeight;
            }
        }

        // Any and Open Water are both "catchable pretty much anywhere" in practice, so a
        // fish tagged with either should match whichever specific hole is selected here
        // too - not just when Any/Open Water itself is picked.
        private static bool FishMatchesHole(Fish fish, FishingHole hole)
        {
            if (IsWildcardHole(fish.Hole1) || IsWildcardHole(fish.Hole2)
                || IsWildcardHole(fish.Hole3) || IsWildcardHole(fish.Hole4))
                return true;

            return FishHasExactHole(fish, hole);
        }

        private static bool IsWildcardHole(FishingHole? hole)
        {
            return hole == FishingHole.Any || hole == FishingHole.OpenWater;
        }

        // Genuinely tagged with this hole (not just matching via the Any wildcard) - used
        // to sort real matches ahead of Any-wildcard matches when a hole filter is active.
        private static bool FishHasExactHole(Fish fish, FishingHole hole)
        {
            if (fish.Hole1 == hole || fish.Hole2 == hole || fish.Hole3 == hole || fish.Hole4 == hole)
                return true;

            return fish.AllHoles.Any(entry => entry.Hole == hole);
        }

        private void RebuildRows()
        {
            foreach (var row in _rowControls)
                row.Dispose();
            _rowControls.Clear();

            bool onlyAvailableNow = _availableNowCheckbox.Checked;
            bool hideCollected = _hideCollectedCheckbox.Checked;
            string searchText = _searchBox.Text?.Trim();

            IEnumerable<Fish> fish;
            string achievementFilter = null;

            if (!string.IsNullOrEmpty(searchText))
            {
                fish = FishCatalog.All.Where(f =>
                    f.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);
            }
            else
            {
                achievementFilter = _achievementDropdown.SelectedItem;
                string baitFilter = _baitDropdown.SelectedItem;

                fish = _selectedRegion == null
                    ? FishCatalog.All
                    : FishCatalog.All.Where(f => MatchesRegion(f, _selectedRegion.Value));

                if (achievementFilter != null && achievementFilter != "All")
                    fish = fish.Where(f => f.Collection == achievementFilter || f.AvidCollection == achievementFilter);

                if (baitFilter != null && baitFilter != "All" && _baitDisplayToValue.TryGetValue(baitFilter, out var baitValue))
                    fish = fish.Where(f => f.Bait == baitValue);

                if (_selectedHoleFilter.HasValue)
                {
                    var holeValue = _selectedHoleFilter.Value;
                    // exact matches for the selected hole first, Any-wildcard matches after
                    fish = fish.Where(f => FishMatchesHole(f, holeValue))
                               .OrderByDescending(f => FishHasExactHole(f, holeValue));
                }

                if (onlyAvailableNow)
                    fish = fish.Where(IsAvailableNow);

                if (hideCollected)
                {
                    fish = fish.Where(f =>
                    {
                        bool viewingAvid = achievementFilter != null && achievementFilter != "All"
                            && f.AvidCollection == achievementFilter;

                        return viewingAvid
                            ? !_achievementProgress.IsFishCaughtForAvid(f)
                            : !_achievementProgress.IsFishCaught(f);
                    });
                }
            }

            var fishList = fish.ToList();

            int rowY = 0;
            foreach (var f in fishList)
            {
                var row = BuildRow(f, rowY);
                _rowControls.Add(row);
                rowY += RowHeight;
            }

            // Celebrate rather than just showing an empty table when hiding collected
            // fish for a specific achievement leaves nothing to show.
            bool showAllCollected = hideCollected && fishList.Count == 0
                && achievementFilter != null && achievementFilter != "All";

            _allCollectedLabel.Visible = showAllCollected;
            if (showAllCollected)
                _allCollectedLabel.Text = $"All fish collected for {achievementFilter}! Tasty, tasty ambergris!";
        }

        private static bool IsAvailableNow(Fish fish)
        {
            if (fish.Cycle == Cycle.Global)
                return fish.TimeOfDay == TimeOfDay.Any;

            var (state, _) = TyrianClock.GetState(fish.Cycle);
            return fish.IsCatchableAt(state);
        }

        private Panel BuildRow(Fish fish, int y)
        {
            var row = new Panel
            {
                Parent = _tableRows,
                Location = new Point(0, y),
                Width = 710,
                Height = RowHeight,
            };

            var nameLabel = new Label { Parent = row, Text = fish.Name, Location = new Point(0, 0), Width = 150, Height = RowHeight, VerticalAlignment = VerticalAlignment.Middle, BasicTooltipText = "Click for fishing hole details" };
            nameLabel.Click += (s, e) => ShowFishDetail(fish);
            new Label { Parent = row, Text = FormatFoundInShort(fish), BasicTooltipText = FormatFoundInFull(fish), Location = new Point(150, 0), Width = 170, Height = RowHeight, VerticalAlignment = VerticalAlignment.Middle, HorizontalAlignment = HorizontalAlignment.Center };
            new Label { Parent = row, Text = fish.Rarity.ToString(), TextColor = RarityColors.Get(fish.Rarity), Location = new Point(320, 0), Width = 100, Height = RowHeight, VerticalAlignment = VerticalAlignment.Middle, HorizontalAlignment = HorizontalAlignment.Center };
            new Label { Parent = row, Text = FormatHolesShort(fish), BasicTooltipText = FormatHolesFull(fish), Location = new Point(420, 0), Width = 130, Height = RowHeight, VerticalAlignment = VerticalAlignment.Middle, HorizontalAlignment = HorizontalAlignment.Center };

            BuildBaitCell(row, fish, new Point(550, 0));

            BuildTimeOfDayCell(row, fish, new Point(630, 0));

            return row;
        }

        private const double PixelsPerChar = 7.0;

        private static string TruncateToWidth(string text, int columnWidthPx)
        {
            int maxChars = (int)(columnWidthPx / PixelsPerChar);
            if (text.Length <= maxChars)
                return text;

            return text.Substring(0, Math.Max(maxChars - 3, 1)) + "...";
        }
        private static string FormatFoundInShort(Fish fish)
        {
            if (string.IsNullOrEmpty(fish.FoundIn))
                return EnumDisplay.Format(fish.Location);

            var firstPart = fish.FoundIn.Split(new[] { " and ", "," }, StringSplitOptions.None)[0].Trim();
            bool hasMore = firstPart.Length < fish.FoundIn.Length;

            var shortText = hasMore ? $"{firstPart}, ..." : firstPart;
            return TruncateToWidth(shortText, 170);
        }

        private static string FormatFoundInFull(Fish fish)
        {
            return string.IsNullOrEmpty(fish.FoundIn)
                ? EnumDisplay.Format(fish.Location)
                : fish.FoundIn;
        }

        private void BuildTimeOfDayCell(Panel row, Fish fish, Point location)
        {
            var textures = TimeOfDayIcons.GetTextures(_contentsManager, fish);
            var tooltip = FormatTimeOfDayFull(fish);
            const int iconSize = 28;
            const int gap = 4;
            int totalWidth = textures.Count * iconSize + (textures.Count - 1) * gap;
            int startX = location.X + (80 - totalWidth) / 2;
            int iconY = location.Y + (RowHeight - iconSize) / 2;

            for (int i = 0; i < textures.Count; i++)
            {
                new Image
                {
                    Parent = row,
                    Texture = textures[i],
                    Location = new Point(startX + i * (iconSize + gap), iconY),
                    Size = new Point(iconSize, iconSize),
                    BasicTooltipText = tooltip,
                };
            }
        }

        private void BuildBaitCell(Panel row, Fish fish, Point location)
        {
            var texture = BaitIcons.GetTexture(fish.Bait);
            if (texture != null)
            {
                new Image
                {
                    Parent = row,
                    Texture = texture,
                    Location = new Point(location.X + 24, (RowHeight - 32) / 2),
                    Size = new Point(32, 32),
                    BasicTooltipText = EnumDisplay.Format(fish.Bait),
                };
            }
            else
            {
                var baitText = EnumDisplay.Format(fish.Bait);
                new Label
                {
                    Parent = row,
                    Text = TruncateToWidth(baitText, 80),
                    BasicTooltipText = baitText,
                    Location = location,
                    Width = 80,
                    Height = RowHeight,
                    VerticalAlignment = VerticalAlignment.Middle,
                    HorizontalAlignment = HorizontalAlignment.Center,
                };
            }
        }

        private static string FormatHolesShort(Fish fish)
        {
            var holes = new[] { fish.Hole1, fish.Hole2, fish.Hole3, fish.Hole4 }
                .Where(h => h.HasValue)
                .Select(h => EnumDisplay.Format(h.Value))
                .ToList();

            if (holes.Count == 0) return "Any";
            var shortText = holes.Count == 1 ? holes[0] : $"{holes[0]}, ...";
            return TruncateToWidth(shortText, 130);
        }

        private static string FormatHolesFull(Fish fish)
        {
            var holes = new[] { fish.Hole1, fish.Hole2, fish.Hole3, fish.Hole4 }
                .Where(h => h.HasValue)
                .Select(h => EnumDisplay.Format(h.Value));

            var joined = string.Join(", ", holes);
            return string.IsNullOrEmpty(joined) ? "Any" : joined;
        }

        private static string FormatTimeOfDayFull(Fish fish)
        {
            if (fish.TimeOfDay == TimeOfDay.Any)
            {
                return fish.HigherChance.HasValue
                    ? $"Any (favors {fish.HigherChance})"
                    : "Any";
            }

            if (fish.TimeOfDay2.HasValue)
            {
                var text = $"{fish.TimeOfDay}/{fish.TimeOfDay2}";
                return fish.HigherChance.HasValue ? $"{text} (favors {fish.HigherChance})" : text;
            }

            return fish.TimeOfDay.ToString();
        }
    }
}