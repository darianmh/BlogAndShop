#pragma checksum "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "271de8ceb13258eb35a3c9d978f823716e388db9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AdminNewMessages_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AdminNewMessages/Default.cshtml")]
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
#line 1 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
using BlogAndShop.Services.Classes.Date;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
using BlogAndShop.Data.ViewModel.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"271de8ceb13258eb35a3c9d978f823716e388db9", @"/Views/Shared/Components/AdminNewMessages/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ceabd4d967b8778eff27795061a7867938385b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_AdminNewMessages_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogAndShop.Data.ViewModel.Admin.NewNotificationModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("clearfix dropdown-item font-weight-medium px-3 border-bottom border-light overflow-hidden shadow-md-hover bg-theme-color-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<li class=\"list-inline-item ml--6 mr--6 dropdown\">\r\n\r\n\t<a href=\"#\" id=\"dropdownMessageOptions\" class=\"btn btn-sm rounded-circle btn-light dropdown-toggle\" data-toggle=\"dropdown\" aria-expanded=\"false\" aria-haspopup=\"true\">\r\n");
#nullable restore
#line 8 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
          
			var count = Model.Count;
		

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
         if (count != 0)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<!-- badge -->\r\n\t\t\t<span class=\"badge badge-danger shadow-danger-md animate-pulse fs--10 p--3 mt--n3 position-absolute end-0\">");
#nullable restore
#line 14 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
                                                                                                                  Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 15 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
		<span class=""group-icon"">
			<i class=""fi fi-envelope-2""></i>
			<i class=""fi fi-close""></i>
		</span>
	</a>

	<div aria-labelledby=""dropdownMessageOptions"" class=""dropdown-menu dropdown-menu-clean dropdown-menu-navbar-autopos dropdown-menu-invert dropdown-click-ignore p-0 mt--18 fs--15 w--300"">

		<div class=""dropdown-header fs--14 py-3"">
");
#nullable restore
#line 26 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
             if (count == 0)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<span>?????????? ???????? ??????????</span>\r\n");
#nullable restore
#line 29 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
			}
			else
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<span>");
#nullable restore
#line 32 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
                 Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ???????? ????????</span>\r\n");
#nullable restore
#line 33 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\r\n\t\t<div class=\"dropdown-divider\"></div>\r\n");
#nullable restore
#line 37 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
         if (count != 0)
		{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"max-h-50vh scrollable-vertical\">\r\n");
#nullable restore
#line 41 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
                 foreach (var item in Model)
				{
					var controller = "";
					switch (item.NewNotificationType)
					{
						case NewNotificationType.Forum:
							{
								controller = "ForumTitle";
								break;
							}
						case NewNotificationType.Post:
							{
								controller = "Post";
								break;
							}
						default:
							{
								controller = "Product";
								break;
							}
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<!-- MESSAGE -->\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "271de8ceb13258eb35a3c9d978f823716e388db98783", async() => {
                WriteLiteral("\r\n\r\n\t\t\t\t\t\t<!-- subject -->\r\n\t\t\t\t\t\t<p class=\"fs--14 m-0 text-truncate font-weight-normal\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 67 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
                       Write(item.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t</p>\r\n\r\n\t\t\t\t\t\t<!-- date -->\r\n\t\t\t\t\t\t<small class=\"d-block fs--11 text-muted\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 72 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
                       Write(item.Date.ToPeString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t</small>\r\n\r\n\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
                           WriteLiteral(controller);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t<!-- /MESSAGE -->\r\n");
#nullable restore
#line 77 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n");
#nullable restore
#line 80 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\AdminNewMessages\Default.cshtml"

		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BlogAndShop.Data.ViewModel.Admin.NewNotificationModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
