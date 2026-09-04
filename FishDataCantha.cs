using System.Collections.Generic;
using Oberyn.AnglerAssociate.Models;

namespace Oberyn.AnglerAssociate.Data
{
    public static class FishDataCantha
    {
        public static readonly List<Fish> All = new List<Fish>
        {
            new Fish
            {
                Name = "Globefish",
                Rarity = Rarity.Basic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.OpenWater,
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 0,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Mullet",
                Rarity = Rarity.Basic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.OpenWater,
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 7,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Porgy",
                Rarity = Rarity.Basic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.OpenWater,
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 14,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Bluefin Trevally",
                Rarity = Rarity.Fine,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LowlandOffshoreFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreSaltwaterJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.ShoreFish, Power = 150 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 1,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Corvina",
                Rarity = Rarity.Fine,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                    new FishHoleEntry { Hole = FishingHole.ShoreFish, Power = 150 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 8,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Chestnut Sea Bream",
                Rarity = Rarity.Fine,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                    new FishHoleEntry { Hole = FishingHole.ShoreFish, Power = 150 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 15,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Cherry Salmon",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.ShoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BarrensFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BloodstoneInfusedPondFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BrackishJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterJanthirFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.ShoreFish, Power = 150 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 2,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Crimson Snapper",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 9,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Green Sawfish",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 16,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Cutlass Fish",
                Rarity = Rarity.Rare,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.ShoreFish,
                Hole2 = FishingHole.RareFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.ShoreFish, Power = 150 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 3,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Honeycomb Grouper",
                Rarity = Rarity.Rare,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 10,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Tripletail",
                Rarity = Rarity.Rare,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 17,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Stingray",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.ShoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.ShoreFish, Power = 150 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 4,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Humphead Wrasse",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 11,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Dragonet",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 18,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Spotted Stingray",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.ShoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterTropicalFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.ShoreFish, Power = 150 },
                },
                Bait = Bait.Shrimpling,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 5,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Skipjack Tuna",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Sardine,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 12,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Mega Prawn",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Sardine,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 19,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Fugu Fish",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.ShoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.SaltwaterTropicalFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.ShoreFish, Power = 150 },
                },
                Bait = Bait.Shrimpling,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 6,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Sailfish",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Sardine,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 13,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Sunfish",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.OffshoreFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreFish, Power = 200 },
                },
                Bait = Bait.Shrimpling,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Seitung Province Fisher",
                CollectionId = 6336,
                AvidCollection = "Avid Seitung Province Fisher",
                AvidCollectionId = 6264,
                BitIndex = 20,
                FoundIn = "Seitung Province"
            },
            new Fish
            {
                Name = "Shinota Blackfin",
                Rarity = Rarity.Basic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.ShinotaBlackfins,
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = null,
                CollectionId = null,
                AvidCollection = null,
                AvidCollectionId = null,
                BitIndex = null,
                FoundIn = null
            },
            new Fish
            {
                Name = "Daijun Blackfin",
                Rarity = Rarity.Basic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.SeitungProvince,
                Hole1 = FishingHole.OpenWater,
                Bait = Bait.HaijuMinnow,
                TimeOfDay = TimeOfDay.Any,
                Collection = null,
                CollectionId = null,
                AvidCollection = null,
                AvidCollectionId = null,
                BitIndex = null,
                FoundIn = null
            },
            new Fish
            {
                Name = "Flying Fish",
                Rarity = Rarity.Basic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 0,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Pollock",
                Rarity = Rarity.Basic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.OpenWater,
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 7,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Sea Perch",
                Rarity = Rarity.Basic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.FracturedFreshwaterFish, Power = 500 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 14,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Blowfish",
                Rarity = Rarity.Fine,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.ChannelFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                    new FishHoleEntry { Hole = FishingHole.FracturedChannelFish, Power = 250 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 1,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Emperor Fish",
                Rarity = Rarity.Fine,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.ChannelFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                    new FishHoleEntry { Hole = FishingHole.FracturedChannelFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 8,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Weever",
                Rarity = Rarity.Fine,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.ChannelFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                    new FishHoleEntry { Hole = FishingHole.FracturedChannelFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 15,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Emerald Snapper",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 2,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Kahawai",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 9,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Striped Barracuda",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.ChannelFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.ChannelFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.FracturedChannelFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 16,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Amberjack",
                Rarity = Rarity.Rare,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.CoastalFish,
                Hole2 = FishingHole.RareFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 3,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Pufferfish",
                Rarity = Rarity.Rare,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.CoastalFish,
                Hole2 = FishingHole.RareFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 10,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Dragonfish",
                Rarity = Rarity.Rare,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.ChannelFish,
                Hole2 = FishingHole.RareFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.ChannelFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.FracturedChannelFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 17,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Blue Dorado",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 4,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Sturgeon",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.ChannelFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.ChannelFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.FracturedChannelFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.MysteriousWatersFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 11,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Taimen",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.ChannelFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.ChannelFish, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.FracturedChannelFish, Power = 250 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Dusk,
                TimeOfDay2 = TimeOfDay.Dawn,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 18,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Giant Trevally",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                },
                Bait = Bait.Sardine,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 5,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Tarpon",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                },
                Bait = Bait.Shrimpling,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 12,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Starry Flounder",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.ChannelFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.ChannelFish, Power = 250 },
                },
                Bait = Bait.Sardine,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 19,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Bluefin Tuna",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreSaltwaterJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.BrackishJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.LowlandOffshoreFish, Power = 600 },
                },
                Bait = Bait.Mackerel,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 6,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Swordfish",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.CoastalFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CoastalFish, Power = 200 },
                },
                Bait = Bait.Mackerel,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 13,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Oarfish",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.NewKainengCity,
                Hole1 = FishingHole.ChannelFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.ChannelFish, Power = 250 },
                },
                Bait = Bait.Shrimpling,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Kaineng Fisher",
                CollectionId = 6342,
                AvidCollection = "Avid Kaineng Fisher",
                AvidCollectionId = 6192,
                BitIndex = 20,
                FoundIn = "New Kaineng"
            },
            new Fish
            {
                Name = "Freshwater Eel",
                Rarity = Rarity.Basic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.EchovaldWilds,
                Hole1 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DeepFishingHole, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.GrottoFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Echovald Wilds Fisher",
                CollectionId = 6258,
                AvidCollection = "Avid Echovald Wilds Fisher",
                AvidCollectionId = 6466,
                BitIndex = 0,
                FoundIn = "Echovald"
            },
            new Fish
            {
                Name = "Stone Loach",
                Rarity = Rarity.Basic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.EchovaldWilds,
                Hole1 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.GrottoFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Echovald Wilds Fisher",
                CollectionId = 6258,
                AvidCollection = "Avid Echovald Wilds Fisher",
                AvidCollectionId = 6466,
                BitIndex = 7,
                FoundIn = "Echovald"
            },
            new Fish
            {
                Name = "Black Carp",
                Rarity = Rarity.Fine,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.EchovaldWilds,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DeepFishingHole, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterTropicalFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.GrottoFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Echovald Wilds Fisher",
                CollectionId = 6258,
                AvidCollection = "Avid Echovald Wilds Fisher",
                AvidCollectionId = 6466,
                BitIndex = 1,
                FoundIn = "Echovald"
            },
            new Fish
            {
                Name = "Knifefish",
                Rarity = Rarity.Fine,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.EchovaldWilds,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DeepFishingHole, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.GrottoFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Echovald Wilds Fisher",
                CollectionId = 6258,
                AvidCollection = "Avid Echovald Wilds Fisher",
                AvidCollectionId = 6466,
                BitIndex = 8,
                FoundIn = "Echovald"
            },
            new Fish
            {
                Name = "Bullhead Catfish",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.EchovaldWilds,
                Hole1 = FishingHole.LakeFish,
                Hole2 = FishingHole.DeepFishingHole,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DeepFishingHole, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.GrottoFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Echovald Wilds Fisher",
                CollectionId = 6258,
                AvidCollection = "Avid Echovald Wilds Fisher",
                AvidCollectionId = 6466,
                BitIndex = 2,
                FoundIn = "Echovald"
            },
            new Fish
            {
                Name = "Snakehead",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.EchovaldWilds,
                Hole1 = FishingHole.GrottoFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.GrottoFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Echovald Wilds Fisher",
                CollectionId = 6258,
                AvidCollection = "Avid Echovald Wilds Fisher",
                AvidCollectionId = 6466,
                BitIndex = 9,
                FoundIn = "Echovald"
            },
            new Fish
            {
                Name = "Cherry Barb",
                Rarity = Rarity.Rare,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.EchovaldWilds,
                Hole1 = FishingHole.LakeFish,
                Hole2 = FishingHole.DeepFishingHole,
                Hole3 = FishingHole.RareFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DeepFishingHole, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.GrottoFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Echovald Wilds Fisher",
                CollectionId = 6258,
                AvidCollection = "Avid Echovald Wilds Fisher",
                AvidCollectionId = 6466,
                BitIndex = 3,
                FoundIn = "Echovald"
            },
            new Fish
            {
                Name = "Petrifish",
                Rarity = Rarity.Rare,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.EchovaldWilds,
                Hole1 = FishingHole.GrottoFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.GrottoFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Echovald Wilds Fisher",
                CollectionId = 6258,
                AvidCollection = "Avid Echovald Wilds Fisher",
                AvidCollectionId = 6466,
                BitIndex = 10,
                FoundIn = "Echovald"
            },
            new Fish
            {
                Name = "Amber Trout",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.EchovaldWilds,
                Hole1 = FishingHole.LakeFish,
                Hole2 = FishingHole.DeepFishingHole,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DeepFishingHole, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.GrottoFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Echovald Wilds Fisher",
                CollectionId = 6258,
                AvidCollection = "Avid Echovald Wilds Fisher",
                AvidCollectionId = 6466,
                BitIndex = 4,
                FoundIn = "Echovald"
            },
            new Fish
            {
                Name = "Albino Gourami",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.EchovaldWilds,
                Hole1 = FishingHole.GrottoFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.GrottoFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Echovald Wilds Fisher",
                CollectionId = 6258,
                AvidCollection = "Avid Echovald Wilds Fisher",
                AvidCollectionId = 6466,
                BitIndex = 11,
                FoundIn = "Echovald"
            },
            new Fish
            {
                Name = "Royal Featherback",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.EchovaldWilds,
                Hole1 = FishingHole.LakeFish,
                Hole2 = FishingHole.DeepFishingHole,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DeepFishingHole, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.GrottoFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.FreshwaterMinnow,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Echovald Wilds Fisher",
                CollectionId = 6258,
                AvidCollection = "Avid Echovald Wilds Fisher",
                AvidCollectionId = 6466,
                BitIndex = 5,
                FoundIn = "Echovald"
            },
            new Fish
            {
                Name = "Albino Axolotl",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.EchovaldWilds,
                Hole1 = FishingHole.GrottoFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.GrottoFish, Power = 300 },
                },
                Bait = Bait.GlowWorm,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Echovald Wilds Fisher",
                CollectionId = 6258,
                AvidCollection = "Avid Echovald Wilds Fisher",
                AvidCollectionId = 6466,
                BitIndex = 12,
                FoundIn = "Echovald"
            },
            new Fish
            {
                Name = "Melandru's Lurker",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.EchovaldWilds,
                Hole1 = FishingHole.LakeFish,
                Hole2 = FishingHole.DeepFishingHole,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.DeepFishingHole, Power = 250 },
                    new FishHoleEntry { Hole = FishingHole.GrottoFish, Power = 300 },
                    new FishHoleEntry { Hole = FishingHole.LakeFish, Power = 250 },
                },
                Bait = Bait.FreshwaterMinnow,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Echovald Wilds Fisher",
                CollectionId = 6258,
                AvidCollection = "Avid Echovald Wilds Fisher",
                AvidCollectionId = 6466,
                BitIndex = 6,
                FoundIn = "Echovald"
            },
            new Fish
            {
                Name = "Dark Sleeper",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.EchovaldWilds,
                Hole1 = FishingHole.GrottoFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.GrottoFish, Power = 300 },
                },
                Bait = Bait.GlowWorm,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Echovald Wilds Fisher",
                CollectionId = 6258,
                AvidCollection = "Avid Echovald Wilds Fisher",
                AvidCollectionId = 6466,
                BitIndex = 13,
                FoundIn = "Echovald"
            },
            new Fish
            {
                Name = "Boxfish",
                Rarity = Rarity.Basic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.DragonsEnd,
                Hole1 = FishingHole.OpenWater,
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Dragon's End Fisher",
                CollectionId = 6506,
                AvidCollection = "Avid Dragon's End Fisher",
                AvidCollectionId = 6402,
                BitIndex = 0,
                FoundIn = "Dragon's End"
            },
            new Fish
            {
                Name = "Rohu",
                Rarity = Rarity.Basic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.DragonsEnd,
                Hole1 = FishingHole.OpenWater,
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Dragon's End Fisher",
                CollectionId = 6506,
                AvidCollection = "Avid Dragon's End Fisher",
                AvidCollectionId = 6402,
                BitIndex = 7,
                FoundIn = "Dragon's End"
            },
            new Fish
            {
                Name = "Canthan Carp",
                Rarity = Rarity.Fine,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.DragonsEnd,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CavernFish, Power = 350 },
                    new FishHoleEntry { Hole = FishingHole.QuarryFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Dragon's End Fisher",
                CollectionId = 6506,
                AvidCollection = "Avid Dragon's End Fisher",
                AvidCollectionId = 6402,
                BitIndex = 1,
                FoundIn = "Dragon's End"
            },
            new Fish
            {
                Name = "Gourami",
                Rarity = Rarity.Fine,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.DragonsEnd,
                Hole1 = FishingHole.Any,
                Hole2 = FishingHole.OpenWater,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CavernFish, Power = 350 },
                    new FishHoleEntry { Hole = FishingHole.QuarryFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Dragon's End Fisher",
                CollectionId = 6506,
                AvidCollection = "Avid Dragon's End Fisher",
                AvidCollectionId = 6402,
                BitIndex = 8,
                FoundIn = "Dragon's End"
            },
            new Fish
            {
                Name = "Jade Lamprey",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.DragonsEnd,
                Hole1 = FishingHole.QuarryFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.QuarryFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Dragon's End Fisher",
                CollectionId = 6506,
                AvidCollection = "Avid Dragon's End Fisher",
                AvidCollectionId = 6402,
                BitIndex = 2,
                FoundIn = "Dragon's End"
            },
            new Fish
            {
                Name = "Toadfish",
                Rarity = Rarity.Masterwork,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.DragonsEnd,
                Hole1 = FishingHole.CavernFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CavernFish, Power = 350 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Dragon's End Fisher",
                CollectionId = 6506,
                AvidCollection = "Avid Dragon's End Fisher",
                AvidCollectionId = 6402,
                BitIndex = 9,
                FoundIn = "Dragon's End"
            },
            new Fish
            {
                Name = "Spotted Pufferfish",
                Rarity = Rarity.Rare,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.DragonsEnd,
                Hole1 = FishingHole.QuarryFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.QuarryFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Dragon's End Fisher",
                CollectionId = 6506,
                AvidCollection = "Avid Dragon's End Fisher",
                AvidCollectionId = 6402,
                BitIndex = 3,
                FoundIn = "Dragon's End"
            },
            new Fish
            {
                Name = "Sheatfish",
                Rarity = Rarity.Rare,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.DragonsEnd,
                Hole1 = FishingHole.CavernFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CavernFish, Power = 350 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Dragon's End Fisher",
                CollectionId = 6506,
                AvidCollection = "Avid Dragon's End Fisher",
                AvidCollectionId = 6402,
                BitIndex = 10,
                FoundIn = "Dragon's End"
            },
            new Fish
            {
                Name = "Giant Gourami",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.DragonsEnd,
                Hole1 = FishingHole.QuarryFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.QuarryFish, Power = 300 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Dragon's End Fisher",
                CollectionId = 6506,
                AvidCollection = "Avid Dragon's End Fisher",
                AvidCollectionId = 6402,
                BitIndex = 4,
                FoundIn = "Dragon's End"
            },
            new Fish
            {
                Name = "Unicorn Fish",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.DragonsEnd,
                Hole1 = FishingHole.CavernFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CavernFish, Power = 350 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Dragon's End Fisher",
                CollectionId = 6506,
                AvidCollection = "Avid Dragon's End Fisher",
                AvidCollectionId = 6402,
                BitIndex = 11,
                FoundIn = "Dragon's End"
            },
            new Fish
            {
                Name = "Jade Sea Turtle",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.DragonsEnd,
                Hole1 = FishingHole.QuarryFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.QuarryFish, Power = 300 },
                },
                Bait = Bait.Nightcrawler,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Dragon's End Fisher",
                CollectionId = 6506,
                AvidCollection = "Avid Dragon's End Fisher",
                AvidCollectionId = 6402,
                BitIndex = 5,
                FoundIn = "Dragon's End"
            },
            new Fish
            {
                Name = "Axolotl",
                Rarity = Rarity.Ascended,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.DragonsEnd,
                Hole1 = FishingHole.CavernFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CavernFish, Power = 350 },
                },
                Bait = Bait.Nightcrawler,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Dragon's End Fisher",
                CollectionId = 6506,
                AvidCollection = "Avid Dragon's End Fisher",
                AvidCollectionId = 6402,
                BitIndex = 12,
                FoundIn = "Dragon's End"
            },
            new Fish
            {
                Name = "Cuttlefish",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.DragonsEnd,
                Hole1 = FishingHole.QuarryFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.QuarryFish, Power = 300 },
                },
                Bait = Bait.Shrimpling,
                TimeOfDay = TimeOfDay.Night,
                Collection = "Dragon's End Fisher",
                CollectionId = 6506,
                AvidCollection = "Avid Dragon's End Fisher",
                AvidCollectionId = 6402,
                BitIndex = 6,
                FoundIn = "Dragon's End"
            },
            new Fish
            {
                Name = "Chambered Nautilus",
                Rarity = Rarity.Legendary,
                Cycle = Cycle.CanthaCastora,
                Region = Region.Cantha,
                Location = Location.DragonsEnd,
                Hole1 = FishingHole.CavernFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.CavernFish, Power = 350 },
                },
                Bait = Bait.Shrimpling,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Dragon's End Fisher",
                CollectionId = 6506,
                AvidCollection = "Avid Dragon's End Fisher",
                AvidCollectionId = 6402,
                BitIndex = 13,
                FoundIn = "Dragon's End"
            }
        };
    }
}