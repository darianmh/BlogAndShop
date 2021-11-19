using System;

namespace BlogAndShop.Data.Classes
{
    /// <summary>
    /// to set file upload for field in admin edit template
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class FileUploadAttribute : Attribute
    {

    }
}