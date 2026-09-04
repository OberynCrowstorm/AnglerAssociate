using System.Collections.Generic;
using Oberyn.AnglerAssociate.Models;

namespace Oberyn.AnglerAssociate.Data
{
    public static class FishDataHornOfMaguuma
    {
        public static readonly List<Fish> All = new List<Fish>
        {
            new Fish
            {
                Name = "Fractured Fish",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedChannelFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.FracturedDesertFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.FracturedLakeFish, Power = 400 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 0,
                FoundIn = "Skywatch Archipelago and Inner Nayos"
            },
            new Fish
            {
                Name = "Queen's Flipper",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.FracturedLakeFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedLakeFish, Power = 400 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 1,
                FoundIn = "Skywatch Archipelago and Inner Nayos"
            },
            new Fish
            {
                Name = "Primal Maguuma Trout",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.FracturedFreshwaterFish,
                Hole2 = FishingHole.NayosianFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DeepSkywatchArchipelagoFish, Power = 0 },
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 2,
                FoundIn = "Skywatch Archipelago and Inner Nayos"
            },
            new Fish
            {
                Name = "Codmander",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.FracturedFreshwaterFish,
                Hole2 = FishingHole.NayosianFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DeepSkywatchArchipelagoFish, Power = 0 },
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 3,
                FoundIn = "Skywatch Archipelago and Inner Nayos"
            },
            new Fish
            {
                Name = "Jokopu",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.FracturedDesertFish,
                Hole2 = FishingHole.NayosianFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DeepSkywatchArchipelagoFish, Power = 0 },
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FracturedDesertFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 4,
                FoundIn = "Skywatch Archipelago and Inner Nayos"
            },
            new Fish
            {
                Name = "Empress Fish",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.FracturedChannelFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DeepSkywatchArchipelagoFish, Power = 0 },
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FracturedChannelFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                },
                Bait = Bait.Mackerel,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 5,
                FoundIn = "Skywatch Archipelago and Inner Nayos"
            },
            new Fish
            {
                Name = "Three-Eyed Carp",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.FracturedChannelFish,
                Hole2 = FishingHole.NayosianFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedChannelFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                },
                Bait = Bait.GlowWorm,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 6,
                FoundIn = "Skywatch Archipelago and Inner Nayos"
            },
            new Fish
            {
                Name = "Bastion Fish",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                Hole3 = FishingHole.NayosianFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.AstralFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.DeepTowerFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.SpireFish, Power = 600 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 7,
                FoundIn = "Amnytas and Inner Nayos"
            },
            new Fish
            {
                Name = "Natural Fish",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.AstralFish,
                Hole2 = FishingHole.SpireFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.AstralFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.DeepAmnytasFish, Power = 0 },
                    new FishHoleEntry { Hole = FishingHole.DeepTowerFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.SpireFish, Power = 600 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 8,
                FoundIn = "Amnytas and Inner Nayos"
            },
            new Fish
            {
                Name = "Knowledge Fish",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.AstralFish,
                Hole2 = FishingHole.NayosianFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.AstralFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.DeepAmnytasFish, Power = 0 },
                    new FishHoleEntry { Hole = FishingHole.DeepTowerFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 9,
                FoundIn = "Amnytas and Inner Nayos"
            },
            new Fish
            {
                Name = "Strength Fish",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.AstralFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.AstralFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.DeepAmnytasFish, Power = 0 },
                    new FishHoleEntry { Hole = FishingHole.DeepTowerFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 10,
                FoundIn = "Amnytas and Inner Nayos"
            },
            new Fish
            {
                Name = "Balance Fish",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                Hole3 = FishingHole.SpireFish,
                Hole4 = FishingHole.NayosianFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DeepAmnytasFish, Power = 0 },
                    new FishHoleEntry { Hole = FishingHole.DeepTowerFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.SpireFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.AstralFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Dusk,
                TimeOfDay2 = TimeOfDay.Dawn,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 11,
                FoundIn = "Amnytas anywhere, anytime, and found in Inner Nayos. However, it is commonly seen with Spire Fish during dawn and dusk"
            },
            new Fish
            {
                Name = "Obscure Fish",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.AstralFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.AstralFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.DeepAmnytasFish, Power = 0 },
                    new FishHoleEntry { Hole = FishingHole.DeepTowerFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                },
                Bait = Bait.LightningBug,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 12,
                FoundIn = "Amnytas and Inner Nayos"
            },
            new Fish
            {
                Name = "Celestial Fish",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.SpireFish,
                Hole2 = FishingHole.NayosianFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DeepTowerFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.SpireFish, Power = 600 },
                },
                Bait = Bait.FishEgg,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 13,
                FoundIn = "Amnytas and Inner Nayos"
            },
            new Fish
            {
                Name = "Daydream",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                Hole3 = FishingHole.NayosianFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 14,
                FoundIn = "Inner Nayos"
            },
            new Fish
            {
                Name = "Phantom Pollock",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                Hole3 = FishingHole.NayosianFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 15,
                FoundIn = "Inner Nayos"
            },
            new Fish
            {
                Name = "Buried Angst",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                Hole3 = FishingHole.DreamFish,
                Hole4 = FishingHole.NayosianFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 16,
                FoundIn = "Inner Nayos"
            },
            new Fish
            {
                Name = "Blightbob",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                Hole3 = FishingHole.NayosianFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                HigherChance = TimeOfDay.Night,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 17,
                FoundIn = "Inner Nayos"
            },
            new Fish
            {
                Name = "Frenzied Cephalopod",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                Hole3 = FishingHole.DreamFish,
                Hole4 = FishingHole.NayosianFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                HigherChance = TimeOfDay.Day,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 18,
                FoundIn = "Inner Nayos"
            },
            new Fish
            {
                Name = "Glutfish",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                Hole3 = FishingHole.NayosianFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                HigherChance = TimeOfDay.Day,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 19,
                FoundIn = "Inner Nayos"
            },
            new Fish
            {
                Name = "Maddened Mackerel",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.HornOfMaguuma,
                Location = Location.HornOfMaguuma,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                Hole3 = FishingHole.DreamFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DreamFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.NayosianFish, Power = 600 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Horn of Maguuma Fisher",
                CollectionId = 7114,
                AvidCollection = "Avid Horn of Maguuma Fisher",
                AvidCollectionId = 7804,
                BitIndex = 20,
                FoundIn = "Inner Nayos"
            }
        };
    }
}