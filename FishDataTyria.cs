using System.Collections.Generic;
using Oberyn.AnglerAssociate.Models;

namespace Oberyn.AnglerAssociate.Data
{
    public static class FishDataTyria
    {
        public static readonly List<Fish> All = new List<Fish>
        {
            new Fish
            {
                Name = "Bitterling",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.OpenWater,
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 0,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Bream",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.OpenWater,
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 7,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Cutthroat Trout",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.OpenWater,
                Bait = Bait.FishEgg,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 14,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Bluegill",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.NoxiousWaterFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 1,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Brook Trout",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.NoxiousWaterFish, Power = 500 },
                },
                Bait = Bait.FishEgg,
                TimeOfDay = TimeOfDay.Dusk,
                TimeOfDay2 = TimeOfDay.Dawn,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 8,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Smallmouth Bass",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.NoxiousWaterFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 15,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Rock Bass",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 2,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Catfish",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 9,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Black Crappie",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.NoxiousWaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.NoxiousWaterFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 16,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Largemouth Bass",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 3,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Rainbow Trout",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BarrensFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BloodstoneInfusedPondFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterJanthirFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                },
                Bait = Bait.FishEgg,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 10,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Yellow Perch",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.NoxiousWaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.NoxiousWaterFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 17,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Golden Trout",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.FishEgg,
                TimeOfDay = TimeOfDay.Dusk,
                TimeOfDay2 = TimeOfDay.Dawn,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 4,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Ripsaw Catfish",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 11,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Warmouth",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.NoxiousWaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.NoxiousWaterFish, Power = 500 },
                },
                Bait = Bait.LightningBug,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 18,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Gar",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.FreshwaterMinnow,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 5,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Giant Catfish",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.FreshwaterMinnow,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 12,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Aquatic Frog",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.NoxiousWaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.NoxiousWaterFish, Power = 500 },
                },
                Bait = Bait.LightningBug,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 19,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Muskellunge",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.FreshwaterMinnow,
                TimeOfDay = TimeOfDay.Dusk,
                TimeOfDay2 = TimeOfDay.Dawn,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 6,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Old Whiskers",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.FreshwaterMinnow,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 13,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Branded Eel",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Ascalon,
                Hole1 = FishingHole.NoxiousWaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.NoxiousWaterFish, Power = 500 },
                },
                Bait = Bait.LightningBug,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Ascalonian Fisher",
                CollectionId = 6330,
                AvidCollection = "Avid Ascalonian Fisher",
                AvidCollectionId = 6484,
                BitIndex = 20,
                FoundIn = "Ascalon"
            },
            new Fish
            {
                Name = "Krytan Crawfish",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.PollutedLakeFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 0,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Speckled Perch",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 7,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Spotted Flounder",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandOffshoreFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LowlandShoreFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreSaltwaterJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.ShoreSaltwaterJanthirFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 14,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Delavan Guppy",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedLakeFish, Power = 400 },
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.PollutedLakeFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.RiverFish, Power = 350 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 1,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Round Goby",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedLakeFish, Power = 400 },
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.LowlandShoreFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreSaltwaterJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.PollutedLakeFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.RiverFish, Power = 350 },
                    new FishHoleEntry { Hole = FishingHole.ShoreSaltwaterJanthirFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 8,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Sailfin Molly",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedLakeFish, Power = 400 },
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.PollutedLakeFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.RiverFish, Power = 350 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 15,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Steelhead Trout",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.RiverFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BrackishJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandShoreFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.RiverFish, Power = 350 },
                },
                Bait = Bait.FishEgg,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 2,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Striped Bass",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedLakeFish, Power = 400 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.PollutedLakeFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 9,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Swampblight Lamprey",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 16,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Croaker",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.RiverFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.RiverFish, Power = 350 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 3,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Black Bass",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedLakeFish, Power = 400 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.PollutedLakeFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 10,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Silver Moony",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 17,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Divinity Angelfin",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.RiverFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.RiverFish, Power = 350 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 4,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Quagmire Eel",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedLakeFish, Power = 400 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.PollutedLakeFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 11,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Krytan Puffer",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 18,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Queenfish",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.RiverFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.RiverFish, Power = 350 },
                },
                Bait = Bait.FreshwaterMinnow,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 5,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Royal Pike",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedLakeFish, Power = 400 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.PollutedLakeFish, Power = 500 },
                },
                Bait = Bait.FreshwaterMinnow,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 12,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Holy Mackerel",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                },
                Bait = Bait.Shrimpling,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 19,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Mud Skate",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.RiverFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.RiverFish, Power = 350 },
                },
                Bait = Bait.FreshwaterMinnow,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 6,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Slaughterfish",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.PollutedLakeFish, Power = 500 },
                },
                Bait = Bait.FreshwaterMinnow,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 13,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Black Lionfish",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.Kryta,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                },
                Bait = Bait.Shrimpling,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Krytan Fisher",
                CollectionId = 6068,
                AvidCollection = "Avid Krytan Fisher",
                AvidCollectionId = 6263,
                BitIndex = 20,
                FoundIn = "Kryta"
            },
            new Fish
            {
                Name = "Alewife",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BorealFish, Power = 450 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 0,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Icefish",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BarrensFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BloodstoneInfusedPondFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterJanthirFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 7,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Snow Crab",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LowlandOffshoreFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LowlandShoreFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreSaltwaterJanthirFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 14,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Alpine Char",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BarrensFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BloodstoneInfusedPondFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BorealFish, Power = 450 },
                    new FishHoleEntry { Hole = FishingHole.BrackishJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandOffshoreFish, Power = 600 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 1,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Grayling",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BorealFish, Power = 450 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 8,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Walleye",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BarrensFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BloodstoneInfusedPondFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BorealFish, Power = 450 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterJanthirFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 15,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "White Bass",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BarrensFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BloodstoneInfusedPondFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterJanthirFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 2,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Northern Pike",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BarrensFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BloodstoneInfusedPondFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterJanthirFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 9,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Boreal Cod",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.BorealFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BorealFish, Power = 450 },
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandOffshoreFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LowlandShoreFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreSaltwaterJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.ShoreSaltwaterJanthirFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 16,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Sockeye",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BarrensFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BloodstoneInfusedPondFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BrackishJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterJanthirFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 3,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "King Salmon",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.LakeFish,
                Hole2 = FishingHole.RareFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BarrensFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BloodstoneInfusedPondFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BrackishJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterJanthirFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandOffshoreFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LowlandShoreFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreSaltwaterJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.ShoreSaltwaterJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.BorealFish, Power = 450 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 10,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Icy Lumpfish",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.BorealFish,
                Hole2 = FishingHole.RareFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BorealFish, Power = 450 },
                    new FishHoleEntry { Hole = FishingHole.BrackishJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 17,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Chain Pickerel",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.BorealFish, Power = 450 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 4,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Beacon's Perch",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.BorealFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BorealFish, Power = 450 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 11,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Mystic Remora",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.BorealFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BorealFish, Power = 450 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Dusk,
                TimeOfDay2 = TimeOfDay.Dawn,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 18,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Cerulean Salamander",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.RamshornSnail,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 5,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Lornar's Bass",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BarrensFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.RamshornSnail,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 12,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Snowflake Eel",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.BorealFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BorealFish, Power = 450 },
                    new FishHoleEntry { Hole = FishingHole.LowlandOffshoreFish, Power = 600 },
                },
                Bait = Bait.RamshornSnail,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 19,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Glacial Snakehead",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.LakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FreshwaterJanthirFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.Shrimpling,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 6,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Alabaster Oscar",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.BorealFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BorealFish, Power = 450 },
                    new FishHoleEntry { Hole = FishingHole.LowlandShoreFish, Power = 550 },
                },
                Bait = Bait.RamshornSnail,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 13,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Halibut",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.ShiverpeakMountains,
                Hole1 = FishingHole.BorealFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BarrensFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BloodstoneInfusedPondFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BorealFish, Power = 450 },
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandOffshoreFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LowlandShoreFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreSaltwaterJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.ShoreSaltwaterJanthirFish, Power = 650 },
                },
                Bait = Bait.Shrimpling,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Shiverpeaks Fisher",
                CollectionId = 6179,
                AvidCollection = "Avid Shiverpeaks Fisher",
                AvidCollectionId = 6153,
                BitIndex = 20,
                FoundIn = "Shiverpeaks"
            },
            new Fish
            {
                Name = "Volcanic Blackfish",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.RingOfFire,
                Hole1 = FishingHole.OpenWater,
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ring of Fire Fisher",
                CollectionId = 6489,
                AvidCollection = "Avid Ring of Fire Fisher",
                AvidCollectionId = 6339,
                BitIndex = 0,
                FoundIn = "Draconis Mons"
            },
            new Fish
            {
                Name = "Flayfin",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.RingOfFire,
                Hole1 = FishingHole.VolcanicFish,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.VolcanicFish, Power = 750 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ring of Fire Fisher",
                CollectionId = 6489,
                AvidCollection = "Avid Ring of Fire Fisher",
                AvidCollectionId = 6339,
                BitIndex = 1,
                FoundIn = "Draconis Mons"
            },
            new Fish
            {
                Name = "Garnet Ram",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.RingOfFire,
                Hole1 = FishingHole.VolcanicFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.VolcanicFish, Power = 750 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Ring of Fire Fisher",
                CollectionId = 6489,
                AvidCollection = "Avid Ring of Fire Fisher",
                AvidCollectionId = 6339,
                BitIndex = 2,
                FoundIn = "Draconis Mons"
            },
            new Fish
            {
                Name = "Fire Eel",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.RingOfFire,
                Hole1 = FishingHole.VolcanicFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.VolcanicFish, Power = 750 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ring of Fire Fisher",
                CollectionId = 6489,
                AvidCollection = "Avid Ring of Fire Fisher",
                AvidCollectionId = 6339,
                BitIndex = 3,
                FoundIn = "Draconis Mons"
            },
            new Fish
            {
                Name = "Glowing Coalfish",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.RingOfFire,
                Hole1 = FishingHole.VolcanicFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.VolcanicFish, Power = 750 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ring of Fire Fisher",
                CollectionId = 6489,
                AvidCollection = "Avid Ring of Fire Fisher",
                AvidCollectionId = 6339,
                BitIndex = 4,
                FoundIn = "Draconis Mons"
            },
            new Fish
            {
                Name = "Magma Ray",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.RingOfFire,
                Hole1 = FishingHole.VolcanicFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.VolcanicFish, Power = 750 },
                },
                Bait = Bait.LavaBeetle,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Ring of Fire Fisher",
                CollectionId = 6489,
                AvidCollection = "Avid Ring of Fire Fisher",
                AvidCollectionId = 6339,
                BitIndex = 5,
                FoundIn = "Draconis Mons"
            },
            new Fish
            {
                Name = "Stone Guiyu",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.RingOfFire,
                Hole1 = FishingHole.VolcanicFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.VolcanicFish, Power = 750 },
                },
                Bait = Bait.LavaBeetle,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ring of Fire Fisher",
                CollectionId = 6489,
                AvidCollection = "Avid Ring of Fire Fisher",
                AvidCollectionId = 6339,
                BitIndex = 6,
                FoundIn = "Draconis Mons"
            },
            new Fish
            {
                Name = "Firemouth",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.RingOfFire,
                Hole1 = FishingHole.OpenWater,
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ring of Fire Fisher",
                CollectionId = 6489,
                AvidCollection = "Avid Ring of Fire Fisher",
                AvidCollectionId = 6339,
                BitIndex = 7,
                FoundIn = "Ember Bay"
            },
            new Fish
            {
                Name = "Igneous Rockfish",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.RingOfFire,
                Hole1 = FishingHole.CoastalFish,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ring of Fire Fisher",
                CollectionId = 6489,
                AvidCollection = "Avid Ring of Fire Fisher",
                AvidCollectionId = 6339,
                BitIndex = 8,
                FoundIn = "Ember Bay"
            },
            new Fish
            {
                Name = "Redtail Catfish",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.RingOfFire,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Ring of Fire Fisher",
                CollectionId = 6489,
                AvidCollection = "Avid Ring of Fire Fisher",
                AvidCollectionId = 6339,
                BitIndex = 9,
                FoundIn = "Ember Bay"
            },
            new Fish
            {
                Name = "Geyser Batfin",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.RingOfFire,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ring of Fire Fisher",
                CollectionId = 6489,
                AvidCollection = "Avid Ring of Fire Fisher",
                AvidCollectionId = 6339,
                BitIndex = 10,
                FoundIn = "Ember Bay"
            },
            new Fish
            {
                Name = "Flamefin Betta",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.RingOfFire,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Ring of Fire Fisher",
                CollectionId = 6489,
                AvidCollection = "Avid Ring of Fire Fisher",
                AvidCollectionId = 6339,
                BitIndex = 11,
                FoundIn = "Ember Bay"
            },
            new Fish
            {
                Name = "Scorpion Fish",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.RingOfFire,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                },
                Bait = Bait.LavaBeetle,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Ring of Fire Fisher",
                CollectionId = 6489,
                AvidCollection = "Avid Ring of Fire Fisher",
                AvidCollectionId = 6339,
                BitIndex = 12,
                FoundIn = "Ember Bay"
            },
            new Fish
            {
                Name = "Dunkleosteus",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.Tyria,
                Location = Location.RingOfFire,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                },
                Bait = Bait.LavaBeetle,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Ring of Fire Fisher",
                CollectionId = 6489,
                AvidCollection = "Avid Ring of Fire Fisher",
                AvidCollectionId = 6339,
                BitIndex = 13,
                FoundIn = "Ember Bay"
            }
        };
    }
}