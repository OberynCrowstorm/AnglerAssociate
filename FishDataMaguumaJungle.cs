using System.Collections.Generic;
using Oberyn.AnglerAssociate.Models;

namespace Oberyn.AnglerAssociate.Data
{
    public static class FishDataMaguumaJungle
    {
        public static readonly List<Fish> All = new List<Fish>
        {
            new Fish
            {
                Name = "Brackish Goby",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 0,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Piranha",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.OpenWater,
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 7,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Snook",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 14,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Oscar",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.SaltwaterFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 1,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Silver Drum",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.SaltwaterFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 8,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Surubim",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.SaltwaterFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 15,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Bicuda",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.FreshwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 2,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Payara",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.FreshwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 9,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Maguuma Trout",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.SaltwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 16,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Pacu",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.FreshwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterTropicalFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 3,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Peacock Bass",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.FreshwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterTropicalFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 10,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Wolffish",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.SaltwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LowlandOffshoreFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LowlandShoreFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreSaltwaterJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.SaltwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.SaltwaterTropicalFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.ShoreSaltwaterJanthirFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 17,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Arowana",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.FreshwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 4,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Sardinata",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.FreshwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 11,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Maguuma Jack",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.SaltwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 18,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Golden Dorado",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.FreshwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FreshwaterFish, Power = 500 },
                },
                Bait = Bait.SparkflyLarva,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 5,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Jundia",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.FreshwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FreshwaterFish, Power = 500 },
                },
                Bait = Bait.SparkflyLarva,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 12,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Rainbow Glowfish",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.SaltwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterFish, Power = 550 },
                },
                Bait = Bait.Sardine,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 19,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Arapaima",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.FreshwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FreshwaterFish, Power = 500 },
                },
                Bait = Bait.SparkflyLarva,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 6,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Goliath Grouper",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.SaltwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterFish, Power = 550 },
                },
                Bait = Bait.Sardine,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 13,
                FoundIn = "Maguuma"
            },
            new Fish
            {
                Name = "Royal Starfish",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.MaguumaJungle,
                Location = Location.MaguumaJungle,
                Hole1 = FishingHole.SaltwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Maguuma Fisher",
                CollectionId = 6344,
                AvidCollection = "Avid Maguuma Fisher",
                AvidCollectionId = 6475,
                BitIndex = 20,
                FoundIn = "Maguuma"
            }
        };
    }
}