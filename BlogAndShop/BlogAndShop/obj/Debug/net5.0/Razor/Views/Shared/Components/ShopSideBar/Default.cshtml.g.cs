#pragma checksum "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\ShopSideBar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84d50ba8d4f9156542e6d45f3519e12ec7bcbf7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ShopSideBar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ShopSideBar/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84d50ba8d4f9156542e6d45f3519e12ec7bcbf7c", @"/Views/Shared/Components/ShopSideBar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ceabd4d967b8778eff27795061a7867938385b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ShopSideBar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogAndShop.Data.ViewModel.Product.LinkGroupHeaderViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link px-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""col-12 col-sm-12 col-md-12 col-lg-3 mb--60"">


	<!-- CATEGORIES -->
	<nav class=""nav-deep nav-deep-light mb-4 shadow-xs shadow-none-md shadow-none-xs px-4 pb-3 p-0-md p-0-xs rounded"">

		<!-- mobile trigger : categories -->
		<button class=""clearfix btn btn-toggle btn-sm btn-block text-align-left shadow-md border rounded mb-1 d-block d-lg-none"" data-target=""#nav_responsive"" data-toggle-container-class=""d-none d-sm-block bg-white shadow-md border animate-fadein rounded p-3"">
			<span class=""group-icon px-2 py-2 float-start"">
				<i class=""fi fi-bars-2""></i>
				<i class=""fi fi-close""></i>
			</span>

			<span class=""h5 py-2 m-0 float-start"">
				???????? ????
			</span>
		</button>

		<!-- desktop only -->
		<h5 class=""pt-3 pb-3 m-0 d-none d-lg-block"">
			???????? ????
		</h5>


		<!-- navigation -->
		<ul id=""nav_responsive"" class=""nav flex-column d-none d-lg-block"">

");
#nullable restore
#line 30 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\ShopSideBar\Default.cshtml"
             foreach (var cat in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<li class=\"nav-item\">\r\n\r\n");
#nullable restore
#line 34 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\ShopSideBar\Default.cshtml"
                     if (cat.SubGroups.Any())
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<a class=\"nav-link px-0\"");
            BeginWriteAttribute("href", " href=\"", 1121, "\"", 1128, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t<span class=\"group-icon\">\r\n\t\t\t\t\t\t\t\t<i class=\"fi fi-arrow-end\"></i>\r\n\t\t\t\t\t\t\t\t<i class=\"fi fi-arrow-down\"></i>\r\n\t\t\t\t\t\t\t</span>\r\n\r\n\t\t\t\t\t\t\t<span class=\"px-2 d-inline-block\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 43 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\ShopSideBar\Default.cshtml"
                           Write(cat.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t</a>\r\n");
            WriteLiteral("\t\t\t\t\t\t<ul class=\"nav flex-column px-3\">\r\n\t\t\t\t\t\t\t<li class=\"nav-item\">\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84d50ba8d4f9156542e6d45f3519e12ec7bcbf7c6938", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 50 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\ShopSideBar\Default.cshtml"
                               Write(cat.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\ShopSideBar\Default.cshtml"
                                                                                                       WriteLiteral(cat.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 53 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\ShopSideBar\Default.cshtml"
                             foreach (var sub in cat.SubGroups)
							{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<li class=\"nav-item\">\r\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84d50ba8d4f9156542e6d45f3519e12ec7bcbf7c10174", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 58 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\ShopSideBar\Default.cshtml"
                                   Write(sub.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\ShopSideBar\Default.cshtml"
                                                                                                           WriteLiteral(sub.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 61 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\ShopSideBar\Default.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</ul>\r\n");
#nullable restore
#line 63 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\ShopSideBar\Default.cshtml"

					}
					else
					{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84d50ba8d4f9156542e6d45f3519e12ec7bcbf7c13576", async() => {
                WriteLiteral("\r\n\r\n\r\n\t\t\t\t\t\t\t<span class=\"px-2 d-inline-block\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 72 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\ShopSideBar\Default.cshtml"
                           Write(cat.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\ShopSideBar\Default.cshtml"
                                                                                                    WriteLiteral(cat.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 75 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\ShopSideBar\Default.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</li>\r\n");
#nullable restore
#line 77 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\ShopSideBar\Default.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</ul>\r\n\r\n\t</nav>\r\n\t<!-- /CATEGORIES -->\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BlogAndShop.Data.ViewModel.Product.LinkGroupHeaderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
