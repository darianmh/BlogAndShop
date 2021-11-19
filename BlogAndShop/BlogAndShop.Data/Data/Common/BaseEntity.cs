using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogAndShop.Data.Data.Common
{
    /// <summary>
    /// every item that inherits this class, will register in data base
    /// </summary>

    public class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }


        public virtual SelectListItem GetSelectListItem()
        {
            return new SelectListItem(Id.ToString(), Id.ToString());
        }
    }
    public class BaseEntity : BaseEntity<int>
    {
    }
}