#pragma checksum "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdaedb94254617f9c991c0dcc25ad705f89606dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_DetailsTemplate_Default), @"mvc.1.0.view", @"/Views/Shared/Components/DetailsTemplate/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\_ViewImports.cshtml"
using BlogAndShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\_ViewImports.cshtml"
using BlogAndShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
using BlogAndShop.Data.ViewModel.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdaedb94254617f9c991c0dcc25ad705f89606dc", @"/Views/Shared/Components/DetailsTemplate/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ceabd4d967b8778eff27795061a7867938385b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_DetailsTemplate_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogAndShop.Data.ViewModel.Utilities.EditCreateTemplateViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<div>\r\n</div>\r\n");
#nullable restore
#line 6 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
 foreach (var item in Model)
{
	var check = false;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"form-group mb-3\">\r\n");
#nullable restore
#line 10 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
         if (item.ObjectType != EditCreateTemplateType.Hidden)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<label");
            BeginWriteAttribute("for", " for=\'", 299, "\'", 315, 1);
#nullable restore
#line 12 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
WriteAttributeValue("", 305, item.Name, 305, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
                               Write(item.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 13 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
			if (item.ObjectType == EditCreateTemplateType.DbList || item.ObjectType == EditCreateTemplateType.Enum || item.ObjectType == EditCreateTemplateType.DbListMulti || item.ObjectType == EditCreateTemplateType.EnumMulti)
			{
				if (item.ListForOptionList != null)
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
                     foreach (var option in item.ListForOptionList)
					{
						if (option.Selected)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<p>");
#nullable restore
#line 21 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
                          Write(option.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 22 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
						}
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
                     
				}
				check = true;
			}

			else if (item.ObjectType == EditCreateTemplateType.HtmlEditor)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<p class=\"border p-3\">");
#nullable restore
#line 30 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
                                 Write(Html.Raw(item.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 31 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"

				check = true;
			}
			else if (item.ObjectType == EditCreateTemplateType.TextArea)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<p class=\"border p-3\">");
#nullable restore
#line 36 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
                                 Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 37 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
				check = true;
			}
			else if (item.ObjectType == EditCreateTemplateType.File)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<img class=\"w-100 img-fluid rounded\"");
            BeginWriteAttribute("src", " src=\"", 1195, "\"", 1212, 1);
#nullable restore
#line 41 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
WriteAttributeValue("", 1201, item.Value, 1201, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"...\">\r\n");
#nullable restore
#line 42 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
				check = true;
			}
			else if (item.ObjectType == EditCreateTemplateType.Bool)
			{
				var checkVal = (bool)item.Value == true ? "بله" : "خیر";

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<p>");
#nullable restore
#line 47 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
              Write(checkVal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 48 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
				check = true;
			}
			if (!check)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<p>");
#nullable restore
#line 52 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
              Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 53 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
			}
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n");
#nullable restore
#line 56 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\DetailsTemplate\Default.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BlogAndShop.Data.ViewModel.Utilities.EditCreateTemplateViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
