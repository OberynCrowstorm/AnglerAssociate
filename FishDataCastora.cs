using System.Collections.Generic;
using Oberyn.AnglerAssociate.Models;

namespace Oberyn.AnglerAssociate.Data
{
    public static class FishDataCastora
    {
        public static readonly List<Fish> All = new List<Fish>
        {
            new Fish
            {
                Name = "Castoran Milkfish",
                Rarity = Rarity.Basic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Castora,
                Location = Location.Castora,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterTropicalFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterTropicalFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Castora Fisher",
                CollectionId = 8900,
                AvidCollection = "Avid Castora Fisher",
                AvidCollectionId = 8973,
                BitIndex = 0,
                FoundIn = "Castora"
            },
            new Fish
            {
                Name = "Castoran Sea Bass",
                Rarity = Rarity.Basic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Castora,
                Location = Location.Castora,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterTropicalFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterTropicalFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Castora Fisher",
                CollectionId = 8900,
                AvidCollection = "Avid Castora Fisher",
                AvidCollectionId = 8973,
                BitIndex = 1,
                FoundIn = "Castora"
            },
            new Fish
            {
                Name = "Great Bearded Goatfish",
                Rarity = Rarity.Fine,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Castora,
                Location = Location.Castora,
                Hole1 = FishingHole.SaltwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterTropicalFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Castora Fisher",
                CollectionId = 8900,
                AvidCollection = "Avid Castora Fisher",
                AvidCollectionId = 8973,
                BitIndex = 2,
                FoundIn = "Shipwreck Strand"
            },
            new Fish
            {
                Name = "Bluefin Barratuna",
                Rarity = Rarity.Fine,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Castora,
                Location = Location.Castora,
                Hole1 = FishingHole.SaltwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterTropicalFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Castora Fisher",
                CollectionId = 8900,
                AvidCollection = "Avid Castora Fisher",
                AvidCollectionId = 8973,
                BitIndex = 3,
                FoundIn = "Shipwreck Strand"
            },
            new Fish
            {
                Name = "Seaweed-Cutting Scythetail",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Castora,
                Location = Location.Castora,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterTropicalFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterTropicalFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Castora Fisher",
                CollectionId = 8900,
                AvidCollection = "Avid Castora Fisher",
                AvidCollectionId = 8973,
                BitIndex = 4,
                FoundIn = "Castora"
            },
            new Fish
            {
                Name = "Bearded Sunfish",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Castora,
                Location = Location.Castora,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterTropicalFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterTropicalFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Castora Fisher",
                CollectionId = 8900,
                AvidCollection = "Avid Castora Fisher",
                AvidCollectionId = 8973,
                BitIndex = 5,
                FoundIn = "Castora"
            },
            new Fish
            {
                Name = "Ruby-Scaled Goatfish",
                Rarity = Rarity.Rare,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Castora,
                Location = Location.Castora,
                Hole1 = FishingHole.SaltwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterTropicalFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                HigherChance = TimeOfDay.Night,
                Collection = "Castora Fisher",
                CollectionId = 8900,
                AvidCollection = "Avid Castora Fisher",
                AvidCollectionId = 8973,
                BitIndex = 6,
                FoundIn = "Shipwreck Strand"
            },
            new Fish
            {
                Name = "Sapphire-Scaled Moonfish",
                Rarity = Rarity.Rare,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Castora,
                Location = Location.Castora,
                Hole1 = FishingHole.SaltwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterTropicalFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                HigherChance = TimeOfDay.Day,
                Collection = "Castora Fisher",
                CollectionId = 8900,
                AvidCollection = "Avid Castora Fisher",
                AvidCollectionId = 8973,
                BitIndex = 7,
                FoundIn = "Shipwreck Strand"
            },
            new Fish
            {
                Name = "Emerald-Scaled Grouper",
                Rarity = Rarity.Rare,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Castora,
                Location = Location.Castora,
                Hole1 = FishingHole.SaltwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterTropicalFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Castora Fisher",
                CollectionId = 8900,
                AvidCollection = "Avid Castora Fisher",
                AvidCollectionId = 8973,
                BitIndex = 8,
                FoundIn = "Shipwreck Strand"
            },
            new Fish
            {
                Name = "Castoran Bicorn",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Castora,
                Location = Location.Castora,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterTropicalFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterTropicalFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Castora Fisher",
                CollectionId = 8900,
                AvidCollection = "Avid Castora Fisher",
                AvidCollectionId = 8973,
                BitIndex = 9,
                FoundIn = "Castora"
            },
            new Fish
            {
                Name = "Illustrious Opah",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Castora,
                Location = Location.Castora,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterTropicalFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterTropicalFish, Power = 650 },
                },
                Bait = Bait.Shrimpling,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Castora Fisher",
                CollectionId = 8900,
                AvidCollection = "Avid Castora Fisher",
                AvidCollectionId = 8973,
                BitIndex = 10,
                FoundIn = "Castora"
            },
            new Fish
            {
                Name = "Elusive Boxcrab",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Castora,
                Location = Location.Castora,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FreshwaterTropicalFish, Power = 650 },
                },
                Bait = Bait.SparkflyLarva,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Castora Fisher",
                CollectionId = 8900,
                AvidCollection = "Avid Castora Fisher",
                AvidCollectionId = 8973,
                BitIndex = 11,
                FoundIn = "Castora"
            },
            new Fish
            {
                Name = "Secret Squid",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Castora,
                Location = Location.Castora,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterTropicalFish, Power = 650 },
                },
                Bait = Bait.Nightcrawler,
                TimeOfDay = TimeOfDay.Any,
                HigherChance = TimeOfDay.Day,
                Collection = "Castora Fisher",
                CollectionId = 8900,
                AvidCollection = "Avid Castora Fisher",
                AvidCollectionId = 8973,
                BitIndex = 12,
                FoundIn = "Shipwreck Strand"
            },
            new Fish
            {
                Name = "Illusive Jellycrab",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Castora,
                Location = Location.Castora,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FreshwaterTropicalFish, Power = 650 },
                },
                Bait = Bait.Nightcrawler,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Castora Fisher",
                CollectionId = 8900,
                AvidCollection = "Avid Castora Fisher",
                AvidCollectionId = 8973,
                BitIndex = 13,
                FoundIn = "Starlit Weald"
            }
        };
    }
}