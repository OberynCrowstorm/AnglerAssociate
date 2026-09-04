using System.Collections.Generic;
using Oberyn.AnglerAssociate.Models;

namespace Oberyn.AnglerAssociate.Data
{
    public static class FishDataJanthir
    {
        public static readonly List<Fish> All = new List<Fish>
        {
            new Fish
            {
                Name = "Lowland Grunt",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.Janthir,
                Hole1 = FishingHole.FreshwaterFish,
                Hole2 = FishingHole.BrackishJanthirFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandShoreFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                HigherChance = TimeOfDay.Day,
                Collection = "Janthir Fisher",
                CollectionId = 8168,
                AvidCollection = "Avid Janthir Fisher",
                AvidCollectionId = 8246,
                BitIndex = 0,
                FoundIn = "Lowland Shore"
            },
            new Fish
            {
                Name = "Shaderock Salamander",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.Janthir,
                Hole1 = FishingHole.SaltwaterFish,
                Hole2 = FishingHole.BrackishJanthirFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BrackishJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterJanthirFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandOffshoreFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LowlandShoreFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Janthir Fisher",
                CollectionId = 8168,
                AvidCollection = "Avid Janthir Fisher",
                AvidCollectionId = 8246,
                BitIndex = 1,
                FoundIn = "Lowland Shore"
            },
            new Fish
            {
                Name = "Mohawk Bream",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.Janthir,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandOffshoreFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LowlandShoreFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                HigherChance = TimeOfDay.Day,
                Collection = "Janthir Fisher",
                CollectionId = 8168,
                AvidCollection = "Avid Janthir Fisher",
                AvidCollectionId = 8246,
                BitIndex = 2,
                FoundIn = "Lowland Shore"
            },
            new Fish
            {
                Name = "Spectacled Lumper",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.Janthir,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandOffshoreFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LowlandShoreFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                HigherChance = TimeOfDay.Night,
                Collection = "Janthir Fisher",
                CollectionId = 8168,
                AvidCollection = "Avid Janthir Fisher",
                AvidCollectionId = 8246,
                BitIndex = 3,
                FoundIn = "Lowland Shore"
            },
            new Fish
            {
                Name = "Violet Screamer",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.Janthir,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandOffshoreFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LowlandShoreFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                HigherChance = TimeOfDay.Night,
                Collection = "Janthir Fisher",
                CollectionId = 8168,
                AvidCollection = "Avid Janthir Fisher",
                AvidCollectionId = 8246,
                BitIndex = 4,
                FoundIn = "Lowland Shore"
            },
            new Fish
            {
                Name = "Viperfish",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.Janthir,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BrackishJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.LowlandOffshoreFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LowlandShoreFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                HigherChance = TimeOfDay.Night,
                Collection = "Janthir Fisher",
                CollectionId = 8168,
                AvidCollection = "Avid Janthir Fisher",
                AvidCollectionId = 8246,
                BitIndex = 5,
                FoundIn = "Lowland Shore"
            },
            new Fish
            {
                Name = "Juvenile Frogfish",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.Janthir,
                Hole1 = FishingHole.FreshwaterFish,
                Hole2 = FishingHole.BrackishJanthirFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BrackishJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterJanthirFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.LowlandBrackishFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                HigherChance = TimeOfDay.Night,
                Collection = "Janthir Fisher",
                CollectionId = 8168,
                AvidCollection = "Avid Janthir Fisher",
                AvidCollectionId = 8246,
                BitIndex = 6,
                FoundIn = "Janthir Syntri"
            },
            new Fish
            {
                Name = "Flowerhead",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.Janthir,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BrackishJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterJanthirFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreSaltwaterJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.ShoreSaltwaterJanthirFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                HigherChance = TimeOfDay.Day,
                Collection = "Janthir Fisher",
                CollectionId = 8168,
                AvidCollection = "Avid Janthir Fisher",
                AvidCollectionId = 8246,
                BitIndex = 7,
                FoundIn = "Janthir Syntri"
            },
            new Fish
            {
                Name = "Queen Parrotfish",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.Janthir,
                Hole1 = FishingHole.SaltwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreSaltwaterJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.ShoreSaltwaterJanthirFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Janthir Fisher",
                CollectionId = 8168,
                AvidCollection = "Avid Janthir Fisher",
                AvidCollectionId = 8246,
                BitIndex = 8,
                FoundIn = "Janthir Syntri"
            },
            new Fish
            {
                Name = "Indigo Drakefish",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.Janthir,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BrackishJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.FreshwaterJanthirFish, Power = 600 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreSaltwaterJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.ShoreSaltwaterJanthirFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Janthir Fisher",
                CollectionId = 8168,
                AvidCollection = "Avid Janthir Fisher",
                AvidCollectionId = 8246,
                BitIndex = 9,
                FoundIn = "Janthir Syntri"
            },
            new Fish
            {
                Name = "Longhorn Boxfish",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.Janthir,
                Hole1 = FishingHole.SaltwaterFish,
                Hole2 = FishingHole.BrackishJanthirFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BrackishJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.OffshoreSaltwaterJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.ShoreSaltwaterJanthirFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Janthir Fisher",
                CollectionId = 8168,
                AvidCollection = "Avid Janthir Fisher",
                AvidCollectionId = 8246,
                BitIndex = 10,
                FoundIn = "Janthir Syntri"
            },
            new Fish
            {
                Name = "Mouse-Eared Octopus",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.Janthir,
                Hole1 = FishingHole.SaltwaterFish,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.OffshoreSaltwaterJanthirFish, Power = 650 },
                    new FishHoleEntry { Hole = FishingHole.ShoreSaltwaterJanthirFish, Power = 650 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                HigherChance = TimeOfDay.Night,
                Collection = "Janthir Fisher",
                CollectionId = 8168,
                AvidCollection = "Avid Janthir Fisher",
                AvidCollectionId = 8246,
                BitIndex = 11,
                FoundIn = "Janthir Syntri"
            },
            new Fish
            {
                Name = "Fishtailed Frog",
                Rarity = Rarity.Fine,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.MistburnedBarrens,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BarrensFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BloodstoneInfusedPondFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Mistburned Barrens Fisher",
                CollectionId = 8554,
                AvidCollection = null,
                AvidCollectionId = null,
                BitIndex = 0,
                FoundIn = "Mistburned Barrens"
            },
            new Fish
            {
                Name = "Feathered Snail",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.MistburnedBarrens,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BarrensFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BloodstoneInfusedPondFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Day,
                Collection = "Mistburned Barrens Fisher",
                CollectionId = 8554,
                AvidCollection = null,
                AvidCollectionId = null,
                BitIndex = 1,
                FoundIn = "Mistburned Barrens"
            },
            new Fish
            {
                Name = "Longbeak Parrotfish",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.MistburnedBarrens,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BarrensFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BloodstoneInfusedPondFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Dusk,
                TimeOfDay2 = TimeOfDay.Dawn,
                HigherChance = TimeOfDay.Day,
                Collection = "Mistburned Barrens Fisher",
                CollectionId = 8554,
                AvidCollection = null,
                AvidCollectionId = null,
                BitIndex = 2,
                FoundIn = "Mistburned Barrens"
            },
            new Fish
            {
                Name = "Spineback Crab",
                Rarity = Rarity.Rare,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.MistburnedBarrens,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BarrensFreshwaterFish, Power = 550 },
                    new FishHoleEntry { Hole = FishingHole.BloodstoneInfusedPondFish, Power = 550 },
                },
                Bait = Bait.Any,
                TimeOfDay = TimeOfDay.Dusk,
                TimeOfDay2 = TimeOfDay.Dawn,
                HigherChance = TimeOfDay.Night,
                Collection = "Mistburned Barrens Fisher",
                CollectionId = 8554,
                AvidCollection = null,
                AvidCollectionId = null,
                BitIndex = 3,
                FoundIn = "Mistburned Barrens"
            },
            new Fish
            {
                Name = "Angler Eel",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.MistburnedBarrens,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BarrensFreshwaterFish, Power = 550 },
                },
                Bait = Bait.SparkflyLarva,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Mistburned Barrens Fisher",
                CollectionId = 8554,
                AvidCollection = null,
                AvidCollectionId = null,
                BitIndex = 4,
                FoundIn = "Mistburned Barrens"
            },
            new Fish
            {
                Name = "Hermit Titancrab",
                Rarity = Rarity.Exotic,
                Cycle = Cycle.Tyria,
                Region = Region.Janthir,
                Location = Location.MistburnedBarrens,
                Hole1 = FishingHole.Any,
                AllHoles = new List<FishHoleEntry>
                {
                    new FishHoleEntry { Hole = FishingHole.BloodstoneInfusedPondFish, Power = 550 },
                },
                Bait = Bait.LavaBeetle,
                TimeOfDay = TimeOfDay.Any,
                Collection = "Mistburned Barrens Fisher",
                CollectionId = 8554,
                AvidCollection = null,
                AvidCollectionId = null,
                BitIndex = 5,
                FoundIn = "Mistburned Barrens"
            }
        };
    }
}