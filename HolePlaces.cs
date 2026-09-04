using System.Collections.Generic;
using Oberyn.AnglerAssociate.Models;

namespace Oberyn.AnglerAssociate.Data
{
    // Region -> Map -> Area breakdown for every named Hole, feeding the right-pane
    // drill-down beneath a clicked Hole row. Generated from "NEW Hole by location".
    // Not fish-specific - shared across every fish that has a given Hole. Open Water
    // and Any are intentionally absent; they stay flat/non-expandable on the fish.
    public static class HolePlaces
    {
        public static readonly Dictionary<FishingHole, List<PlaceNode>> ByHole =
            new Dictionary<FishingHole, List<PlaceNode>>
        {
            { FishingHole.AstralFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Horn of Maguuma",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Amnytas",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bastion of Knowledge" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bastion of Strength" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bastion of the Natural" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.BarrensFreshwaterFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Janthir",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Mistburned Barrens",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Hidden Sacrarium" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Golden Lake" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.BloodstoneInfusedPondFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Janthir",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Mistburned Barrens",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Seer's March" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.BorealFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Ascalon",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Fireheart Rise",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Highland Thaw" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Maguuma Jungle",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Labyrinthine Cliffs",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bazaar Docks" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Shiverpeak Mountains",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Bitterfrost Frontier",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Blizzard Basin" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Hailstone Floe" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sorrow's Eclipse Sanctuary" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Dredgehaunt Cliffs",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Wyrmblood Lake" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Frostgorge Sound",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Dimotiki Waters" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Drakkar Spurs" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Grimstone Mol" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Maladar's Inlet" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Talabaroop Waves" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Sea of Lamentation" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Watchful Fjord" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Thunderhead Peaks",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Dredgeways" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Ice Floe" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.BrackishJanthirFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Janthir",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Janthir Syntri",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Echoing Hills" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Old Hutment Site" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "River's Maw" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Slithering Outskirts" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Storm's Border" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.CavernFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Cantha",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Dragon's End",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Flooded Basin" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Harvest Complex" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Mother's Lament" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Jade Whirl" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Unwaking Waters" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Western Vale" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Gyala Delve",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Jade Pools" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Deep" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.ChannelFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Cantha",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "New Kaineng City",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bori Ward" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Grub Lane" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Lutgardis Plaza" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Ministry Ward" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "North Lab" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Old Kaineng" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Petrified Woods" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.CoastalFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Cantha",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "New Kaineng City",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Kaineng Docks" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Naksi Bay" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sotdae Landing" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Heart of Maguuma",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Ember Bay",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Ashen Skerries" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Burning Grotto" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Caliph's Steps" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Fractured Caldera" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Lava Flats" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Osprey Pillars" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Performance Field" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Skritt Anchorage" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Smoldering Inlet" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sopor Titanum" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sulfurous Deep" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Kryta",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Bloodtide Coast",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Archen Foreland" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Dredgehat Isle" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Flooded Castavall" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Merchantman's Strait" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Mournful Depths" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sanguine Bay" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sorrowful Sound" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Vindar's Lagoon" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Gendarran Fields",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Cornucopian Fields" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Kessex Hills",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Wizard's Fief" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Lion's Arch",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Grand Piazza" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Inner Harbor" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sanctum Harbor" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Southsun Cove",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Captain's Retreat" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Dappled Shores" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Owain's Refuge" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Pearl Islet" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sawtooth Bay" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Southsun Shoals" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Southsun Strait" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Maguuma Jungle",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Labyrinthine Cliffs",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bazaar Docks" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.DeepAmnytasFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Horn of Maguuma",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Inner Nayos",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Old Settlement" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.DeepFishingHole, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Cantha",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Arborstone",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Arborstone" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.DeepInnerNayosFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Horn of Maguuma",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Inner Nayos",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Commons" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.DeepSkywatchArchipelagoFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Horn of Maguuma",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Inner Nayos",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Defiled Cradle" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.DeepTowerFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Horn of Maguuma",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "The Wizard's Tower",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Wizard's Tower" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.DeepWorldClassFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Horn of Maguuma",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Inner Nayos",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Spire of Dreams" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.DeepWorldSaltwaterFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Horn of Maguuma",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Inner Nayos",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Old Settlement" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.DesertFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Maguuma Jungle",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Labyrinthine Cliffs",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bazaar Docks" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Crystal Desert",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Crystal Oasis",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Amnoon Farms" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Amnoon Southern Outskirts" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bay of Elon" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Free City of Amnoon" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Kusini Crossing" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Desert Highlands",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Transcendent Bay" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Domain of Kourna",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bay of Gandara" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Corsair Landing" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Eastern Front" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Front Line" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Ntouka Pond" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Western Front" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Domain of Vabbi",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Garden of Seborhin" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Elon Riverlands",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Arid Gladefields" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Shallows of Despair" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Skimshallow Cove" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "The Desolation",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Silent Vale" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Spillway" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Windswept Haven",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Windswept Haven" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.DreamFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Horn of Maguuma",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Inner Nayos",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Defiled Cradle" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Commons" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Old Settlement" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.FracturedChannelFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Horn of Maguuma",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Skywatch Archipelago",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Jade Mech Habitation Zone 03" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.FracturedDesertFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Horn of Maguuma",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Skywatch Archipelago",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Skyward Marches" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.FracturedFreshwaterFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Horn of Maguuma",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Skywatch Archipelago",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Primal Maguuma" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.FracturedLakeFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Horn of Maguuma",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Skywatch Archipelago",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Stargaze Ridge" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.FreshwaterFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Heart of Maguuma",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Tangled Depths",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Teku Nuhoch" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Undergrowth Connector" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Gilded Hollow",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Gilded Hollow" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Lost Precipice",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Lost Precipice" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Janthir",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Hearth's Glow",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Hearth's Glow" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Maguuma Jungle",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Brisban Wildlands",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Gotala Cascade" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Skrittsburgh East End" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Venlin Vale" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Caledon Forest",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Treemarch Estuary" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Labyrinthine Cliffs",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bazaar Docks" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Metrica Province",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Fisher's Beach Bend" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Greyfern Expanses" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Hexane Regrade" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Jeztar Falls" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Loch Jezt" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Michoan Marsh" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Obscura Incline" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Mount Maelstrom",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Dierdre's Steps" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.FreshwaterJanthirFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Janthir",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Janthir Syntri",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Festering Basin" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Moldering Greenwood" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Hearth's Glow",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Hearth's Glow" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.FreshwaterTropicalFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Castora",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Eternity's Garden",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Artificer's Islet" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Ley-Drowned Quarry" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Pilgrim's Rest" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sanctum of the Divine" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Temple of Abnegation" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Temple of the Blessed Mantle" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Mothmarsh" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Venomgrove Observatory" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Shipwreck Strand",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Guarded Glades" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Riddled Cove" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Twisting Hollows" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Starlit Weald",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Command Complex" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Crumbling Precipice" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Lost Basilica" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Overgrown Thicket" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Shimmering Basin" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Skyshroud Canopy" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Winding Passage" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Tranquil Glen" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Untamed Crags" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.GrottoFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Cantha",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "The Echovald Wilds",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Lake Lutgardis" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Melandru's Hope" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Warden's Folly" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.LakeFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Cantha",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "The Echovald Wilds",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Lake Lutgardis" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Mori Village" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Qinkaishi Basin" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Ascalon",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Blazeridge Steppes",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Behem Gauntlet" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Diessa Plateau",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Blackblade Lake" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Breachwater Lake" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Fields of Ruin",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Gillfarn Plains" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Warrior's Crown" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Fireheart Rise",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Fuller Cistern" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Pig Iron Mine" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sati Passage" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Grothmar Valley",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Kralkatorrik's Emergence Zone" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sacnoth Stream" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Tribunes' Trench" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Iron Marches",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bloodfin Lake" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Ironhead Lake" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Lake Carnifex" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Monger's Sink" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sunken Halls of Clarent" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Plains of Ashford",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Ascalon Basin" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Ascalon City Ruins" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Lake Adorea" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Kryta",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Gendarran Fields",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Brigantine Isles" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Lake Bounty" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Lake Gendarr" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Lionbridge Expanse" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Provern Shore" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Vigilant Hills" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Harathi Hinterlands",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Arca Lake" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Guardian Lake" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Lake Doric",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Saidra's Haven" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Queensdale",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Clayent Falls" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Eastern Divinity Dam" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Godslost Swamp" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Lake Delavan" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Shire of Beetletun" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Maguuma Jungle",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Labyrinthine Cliffs",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bazaar Docks" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Shiverpeak Mountains",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Drizzlewood Coast",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Archstone Coast" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Breakroot Basin" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Dominion's Breach" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Legions' Alcove" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Lighthouse Point" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Petraj Overlook" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Port Cascadia" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sentinel Bay" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Wolf's Crossing" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Lornar's Pass",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Demon's Maw" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "False Lake" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Snowden Drifts",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Isenfall Lake" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Valslake" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Timberline Falls",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Gentle River" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Guilty Tears" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Mellaggan's Grotto" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Naui Waters" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Nonmoa Lake" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Wayfarer Foothills",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Darkriven Bluffs" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Doldenvan Passage" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Grawlenfjord" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.LowlandBrackishFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Janthir",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Lowland Shore",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Autumn's Vale" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Exorheic Falls" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Haar Mire" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Harvest Den" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Harvest Shore" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Tideland Outlet" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.LowlandFreshwaterFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Janthir",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Lowland Shore",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Autumn's Vale" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Tideland Outlet" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Hearth's Glow",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Hearth's Glow" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.LowlandOffshoreFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Janthir",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Lowland Shore",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Haar Mire" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Harvest Shore" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Tideland Outlet" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.LowlandShoreFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Janthir",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Lowland Shore",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Haar Mire" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Harvest Shore" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Tideland Outlet" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.MysteriousWatersFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Cantha",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Thousand Seas Pavilion",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Thousand Seas Pavilion" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.NayosianFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Horn of Maguuma",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Inner Nayos",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Defiled Cradle" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Heitor's Dominion" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Memory's Hollow" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Mourning's Shade" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Bleeding Wastes" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Commons" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Old Settlement" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.NoxiousWaterFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Ascalon",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Fields of Ruin",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Gillfarn Plains" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Tenaebron Lake" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Fireheart Rise",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Fuller Cistern" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Pig Iron Mine" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sloven Pitch" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Baelfire" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Iron Marches",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Lake Desolann" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.OffshoreFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Cantha",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Seitung Province",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Crystal Cave" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Eastern Wilds" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Haiju Lagoon" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Monastery Bay" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "North Peninsula" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Seitung Harbor" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Shinota Shore" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Zen Daijun" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Isle of Reflection",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Isle of Reflection" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Maguuma Jungle",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Labyrinthine Cliffs",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bazaar Docks" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Ruins of Orr",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Cursed Shore",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Harrowed Sea" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Mausollus Sea" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Shipyard" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Winterknell Shore" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Malchor's Leap",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Drowned Brine" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Jinx Isle" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Malchor's Fingers" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Midwater Hollows" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Mirror Bay" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Whisper Bay" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Siren's Landing",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Choking Depths" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Straits of Devastation",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sea of Elon" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Strait of Malediction" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Strait of Sacrilege" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Terzetto Bay" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Crystal Desert",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Domain of Istan",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Chalon Docks" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Churrhir Cliffs" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Corsair Flotilla" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Issnur Bay" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sea of Istan" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Sandswept Isles",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Chukara Sea" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sargol Sea" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Strait of Panube" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Tyrulu Sea" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.OffshoreSaltwaterJanthirFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Janthir",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Janthir Syntri",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Tumultuous Sea" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.PollutedLakeFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Kryta",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Kessex Hills",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Lychcroft Mere" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Viath Shore" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Viathan Lake" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Viathan's Arm" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.QuarryFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Cantha",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Dragon's End",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Archipelagos Rim" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Flooded Basin" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Outer Terrace" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Reaver's Ridge" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.RiverFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Kryta",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Bloodtide Coast",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Firth of Revanion" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Mentecki Pass" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Gendarran Fields",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Ascalon Settlement" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Lionbridge Expanse" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Northfields" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Witherflank River" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Harathi Hinterlands",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Arca Lake" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Greystone Rise" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Guardian Lake" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Splintered Teeth" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Trebuchet Bend" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Queensdale",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Clayent Falls" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Scaver Plateau" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Western Divinity Dam" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Maguuma Jungle",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Labyrinthine Cliffs",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bazaar Docks" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.SaltwaterFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Maguuma Jungle",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Caledon Forest",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Quetzal Bay" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Ventry Bay" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Labyrinthine Cliffs",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bazaar Docks" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Mount Maelstrom",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Benthic Kelp Beds" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Infinite Coil Reactor" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sunken Droknah" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Mire Sea" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Treacherous Depths" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Rata Sum",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Idea Incubation Lab" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Rata Sum Port Authority" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Sparkfly Fen",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Leeshore Gauntlet" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Ocean's Gullet" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Orvanic Shore" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Splintered Coast" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.SaltwaterTropicalFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Castora",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Shipwreck Strand",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Breezy Cay" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Glimmering Arches" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Hullgarden" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Jetsam Point" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Soaring Sands" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Comosus Isle",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Comosus Isle" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.ShoreFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Cantha",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Seitung Province",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Eastern Wilds" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Haiju Lagoon" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Monastery Bay" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "North Peninsula" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Seitung Harbor" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Shinota Shore" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Zen Daijun" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Isle of Reflection",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Isle of Reflection" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Maguuma Jungle",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Labyrinthine Cliffs",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bazaar Docks" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Ruins of Orr",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Cursed Shore",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Cathedral of Verdance" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Harrowed Sea" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Mausollus Sea" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Shipyard" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Winterknell Isle" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Winterknell Shore" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Malchor's Leap",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Cathedral of Eternal Radiance" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Crusted Shoals" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Drowned Brine" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Jinx Isle" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Mirror Bay" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Valley of Lyss" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Whisper Bay" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Siren's Landing",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bloated Beach" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Choking Depths" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Dwayna's Reliquary" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Melandru's Reliquary" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Merciless Shore" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Straits of Devastation",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Crippled Bridges" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Fort Trinity" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Shark's Teeth Archipelago" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Strait of Malediction" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Strait of Sacrilege" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Terzetto Bay" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Crystal Desert",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Domain of Istan",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Chalon Docks" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Churrhir Cliffs" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Corsair Flotilla" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Heretic's Arena" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Issnur Bay" },
                            }
                        },
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Sandswept Isles",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Atholma" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sargol Sea" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Strait of Panube" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Tyrulu Sea" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.ShoreSaltwaterJanthirFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Janthir",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Janthir Syntri",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Tumultuous Sea" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.SpireFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Horn of Maguuma",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Amnytas",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bastion of Balance" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bastion of the Celestial" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bastion of the Obscure" },
                            }
                        },
                    }
                },
            } },
            { FishingHole.VolcanicFish, new List<PlaceNode>
            {
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Ascalon",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Fireheart Rise",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Cozen Desolation" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Sloven Pitch" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "The Baelfire" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Maguuma Jungle",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Labyrinthine Cliffs",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Bazaar Docks" },
                            }
                        },
                    }
                },
                new PlaceNode
                {
                    Kind = PlaceNodeKind.Region,
                    Label = "Ring of Fire",
                    Children =
                    {
                        new PlaceNode
                        {
                            Kind = PlaceNodeKind.Map,
                            Label = "Draconis Mons",
                            Children =
                            {
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Eastern Boiling Sea" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Mariner Landing" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Titan's Throat" },
                                new PlaceNode { Kind = PlaceNodeKind.Area, Label = "Western Boiling Sea" },
                            }
                        },
                    }
                },
            } },
        };
    }
}