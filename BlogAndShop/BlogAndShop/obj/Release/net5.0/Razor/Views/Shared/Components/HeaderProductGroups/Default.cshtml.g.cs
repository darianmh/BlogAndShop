#pragma checksum "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HeaderProductGroups\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f2397f584fedc5923196bfd8204b555dfb0f169"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HeaderProductGroups_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HeaderProductGroups/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f2397f584fedc5923196bfd8204b555dfb0f169", @"/Views/Shared/Components/HeaderProductGroups/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ceabd4d967b8778eff27795061a7867938385b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HeaderProductGroups_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogAndShop.Data.ViewModel.Product.LinkGroupHeaderViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral(@"


<li class=""nav-item dropdown dropdown-mega"">

	<a href=""#"" id=""mainNavShopGategories"" class=""nav-link dropdown-toggle""
	   data-toggle=""dropdown""
	   aria-haspopup=""true""
	   aria-expanded=""False"">
		محصولات
	</a>

	<div aria-labelledby=""mainNavShopGategories"" class=""dropdown-menu dropdown-menu-hover dropdown-menu-clean"">
		<!-- Blog and Shop : Megamenu -->
		<ul class=""list-unstyled m-0 p-0"">
			<li class=""dropdown-item bg-transparent"">

");
#nullable restore
#line 20 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HeaderProductGroups\Default.cshtml"
                 if (Model.Any())
				{
					for (var row = 0; row * 4 < Model.Count; row++)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"row col-border-md\">\r\n");
#nullable restore
#line 25 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HeaderProductGroups\Default.cshtml"
                             for (var item = 0; item < 4; item++)
							{
								var num = (4 * row) + item;
								if (num >= Model.Count)
								{
									break;
								}
								var group = Model[num];

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"col-12 col-md-3\">\r\n\r\n\t\t\t\t\t\t\t\t\t<h3 class=\"h6 text-muted text-uppercase fs--14 mb-3\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2397f584fedc5923196bfd8204b555dfb0f1695709", async() => {
#nullable restore
#line 35 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HeaderProductGroups\Default.cshtml"
                                                                                                                                                            Write(group.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-group", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HeaderProductGroups\Default.cshtml"
                                                                                                                                          WriteLiteral(group.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["group"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-group", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["group"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 36 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HeaderProductGroups\Default.cshtml"
                                     if (group.SubGroups.Any())
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<ul class=\"prefix-link-icon prefix-icon-dot\">\r\n");
#nullable restore
#line 39 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HeaderProductGroups\Default.cshtml"
                                             for (var subNum = 0; subNum < (Math.Min(3, group.SubGroups.Count)); subNum++)
											{
												var sub = group.SubGroups[subNum];

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<li class=\"dropdown-item\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2397f584fedc5923196bfd8204b555dfb0f1699401", async() => {
#nullable restore
#line 43 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HeaderProductGroups\Default.cshtml"
                                                                                                                                           Write(sub.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-group", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HeaderProductGroups\Default.cshtml"
                                                                                                                           WriteLiteral(sub.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["group"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-group", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["group"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 45 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HeaderProductGroups\Default.cshtml"
											}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</ul>\r\n");
#nullable restore
#line 48 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HeaderProductGroups\Default.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 52 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HeaderProductGroups\Default.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 55 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HeaderProductGroups\Default.cshtml"
					}
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t</li>\r\n\t\t</ul>\r\n\t</div>\r\n\r\n</li>");
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
