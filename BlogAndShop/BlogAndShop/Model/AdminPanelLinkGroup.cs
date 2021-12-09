using System.Collections.Generic;

namespace BlogAndShop.Model
{
    public class AdminPanelLinkGroup
    {
        public string Group { get; set; }
        public bool IsActive { get; set; }
        public List<AdminPanelLink> Links { get; set; }
    }
}