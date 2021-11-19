using System;

namespace BlogAndShop.Classes
{
    public class AdminFilterNameAttribute : Attribute
    {
        public string Name { get; }
        public string Group { get; }
        public AdminFilterNameAttribute(string group, string name)
        {
            Name = name;
            Group = group;
        }
    }
}