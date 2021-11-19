using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BlogAndShop.Classes;
using BlogAndShop.Controllers.Admin;
using BlogAndShop.Model;

namespace BlogAndShop.Services
{
    public static class AdminPanelService
    {
        #region Fields


        #endregion
        #region Methods

        /// <summary>
        /// یافتن کنترلر های ادمین
        /// تنظیم نام آها و لینک آنها
        /// </summary>
        /// <returns></returns>
        public static List<AdminPanelLinkGroup> GetLinks()
        {
            var groupedLinks = GetControllerGroups(AssemblyHelper.AdminControllers);
            var links = GetLinksGroupModel(groupedLinks);
            return links;
        }

        public static List<Type> GetAllController(Assembly assembly)
        {
            var allType = assembly.GetTypes();
            var allControllers = allType.Where(x => x.IsSubclassOf(typeof(BaseAdminController)));
            return AssemblyHelper.AdminControllers = allControllers.ToList();
        }

        #endregion
        #region Utilities

        private static List<AdminPanelLinkGroup> GetLinksGroupModel(List<AdminPanelLinkTemp> groupedLinks)
        {
            var groups = groupedLinks.GroupBy(x => x.Group);
            var result = new List<AdminPanelLinkGroup>();
            foreach (var temp in groups)
            {
                var model = new AdminPanelLinkGroup()
                {
                    Group = temp.Key,
                    Links = GetLinksModel(temp.ToList())
                };
                result.Add(model);
            }
            return result;
        }

        private static List<AdminPanelLink> GetLinksModel(List<AdminPanelLinkTemp> list)
        {
            return list.Select(x => new AdminPanelLink()
            {
                LinkUrl = x.LinkUrl,
                Name = x.Name
            }).ToList();
        }

        private static List<AdminPanelLinkTemp> GetControllerGroups(List<Type> allControllers)
        {
            var result = new List<AdminPanelLinkTemp>();
            foreach (var controller in allControllers)
            {
                var attr = (AdminFilterNameAttribute)controller.GetCustomAttribute(typeof(AdminFilterNameAttribute));
                if (attr == null) continue;
                var url = controller.Name.Replace("Controller", String.Empty);
                var model = new AdminPanelLinkTemp { Group = attr.Group, Name = attr.Name, LinkUrl = url };
                result.Add(model);
            }

            return result;
        }



        #endregion
        #region Ctor

        #endregion


    }
}
