using System.Collections.Generic;

namespace BlogAndShop.Data.Classes
{
    public class DbModelInfo<T>
    {
        public List<T> List { get; set; }
        public int TotalCount { get; set; }
    }
}