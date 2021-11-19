using System;

namespace BlogAndShop.Data.Classes
{
    /// <summary>
    /// set editor mode to Enum List in admin panel edit template and fill from enum type
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class EnumListAttribute : Attribute
    {
        /// <summary>
        /// type of enum
        /// </summary>
        public Type EnumType { get; set; }
        public EnumListAttribute(Type enumType)
        {
            EnumType = enumType;
        }
    }
}