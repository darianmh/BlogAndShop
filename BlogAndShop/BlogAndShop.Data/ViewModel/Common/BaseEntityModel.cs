using System;
using BlogAndShop.Data.Classes;

namespace BlogAndShop.Data.ViewModel.Common
{
    /// <summary>
    /// every item that inherits this class, will register in data base
    /// </summary>
    public class BaseEntityModel : BaseEntityModel<int>
    {
    }
    public class BaseEntityModel<TId>
    {
        [AdminKey]
        public TId Id { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}