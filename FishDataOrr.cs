using System.Collections.Generic;
using Oberyn.AnglerAssociate.Models;

namespace Oberyn.AnglerAssociate.Data
{
    public static class FishDataOrr
    {
        public static readonly List<Fish> All = new List<Fish>
        {
            new Fish
            {
                Name = "Dusky Grouper",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.OpenWater,
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Dusk,
                TimeOfDay2 = TimeOfDay.Dawn,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 0,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Ghostfish",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.OpenWater,
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 7,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Murkwater Darter",
                Rarity = Rarity.Basic,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.OpenWater,
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 14,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Albino Blindfish",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                    new FishHoleEntry { Hole = FishingHole.ShoreFish, Power = 150 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 1,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Dead Alewife",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                    new FishHoleEntry { Hole = FishingHole.ShoreFish, Power = 150 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 8,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Monkfish",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                    new FishHoleEntry { Hole = FishingHole.ShoreFish, Power = 150 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 15,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Viperfish",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 2,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Hagfish",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 9,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Dhuum Fish",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.ShoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.ShoreFish, Power = 150 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 16,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Abyssal Squid",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 3,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Spectral Jellyfish",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 10,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Frilled Shark",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.ShoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.ShoreFish, Power = 150 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 17,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Stargazer",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 4,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Orrian Anglerfish",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 11,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Man-of-War",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.ShoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.ShoreFish, Power = 150 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 18,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Blobfish",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Leech,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 5,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Giant Octopus",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Sardine,
                TimeOfDay = TimeOfDay.Dusk,
                TimeOfDay2 = TimeOfDay.Dawn,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 12,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Risen Sea Bass",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.ShoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.ShoreFish, Power = 150 },
                },
                Bait = Bait.Leech,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 19,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Benthic Behemoth",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Leech,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 6,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Shipwreck Moray",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Sardine,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 13,
                FoundIn = "Orr"
            },
            new Fish
            {
                Name = "Unholy Mackerel",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.Tyria,
                Region = Region.Orr,
                Location = Location.RuinsOfOrr,
                Hole1 = FishingHole.ShoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.ShoreFish, Power = 150 },
                },
                Bait = Bait.Leech,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Orrian Fisher",
                CollectionId = 6363,
                AvidCollection = "Avid Orrian Fisher",
                AvidCollectionId = 6227,
                BitIndex = 20,
                FoundIn = "Orr"
            }
        };
    }
}