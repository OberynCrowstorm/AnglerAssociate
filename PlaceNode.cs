using System.Collections.Generic;

namespace Oberyn.AnglerAssociate.Models
{
    public enum PlaceNodeKind
    {
        Region,
        Map,
        Area
    }
    public class PlaceNode
    {
        public PlaceNodeKind Kind { get; set; }
        public string Label { get; set; }
        public List<PlaceNode> Children { get; } = new List<PlaceNode>();

        public bool HasChildren => Children.Count > 0;
    }
}