#pragma checksum "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HomeBrandSlider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43ddb5fec09b82ec3ada2e2c65a4a8c3f16e92ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HomeBrandSlider_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HomeBrandSlider/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43ddb5fec09b82ec3ada2e2c65a4a8c3f16e92ae", @"/Views/Shared/Components/HomeBrandSlider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ceabd4d967b8778eff27795061a7867938385b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HomeBrandSlider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogAndShop.Data.ViewModel.Product.BrandModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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


<section class=""border-top border-bottom p-0"">
	<div class=""container"">

		<!--

			SWIPER SLIDER

		-->
		<div class=""swiper-container""
			 data-swiper='{
							""slidesPerView"": 5,
							""spaceBetween"": 10,
							""autoplay"": true,
							""loop"": true,
							""pagination"": { ""type"": ""bullets"" },
							""breakpoints"": {
								""1200"": { ""slidesPerView"": ""4"" },
								""1024"": { ""slidesPerView"": ""3"" },
								""0"": 	{ ""slidesPerView"": ""2"" }
							}
						}'>

			<!--

				NOTE: do not use lazy when loop is true!

			-->
			<div class=""swiper-wrapper"">

");
#nullable restore
#line 35 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HomeBrandSlider\Default.cshtml"
                 foreach (var item in Model)
				{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<!-- slider -->\r\n\t\t\t\t\t<div class=\"swiper-slide\">\r\n\r\n\r\n\t\t\t\t\t\t<div class=\"lazy bg-white shadow-xs shadow-md-hover transition-all-ease-250 transition-hover-top rounded show-hover-container p-3 my-1\">\r\n\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43ddb5fec09b82ec3ada2e2c65a4a8c3f16e92ae5415", async() => {
                WriteLiteral("\r\n\r\n\t\t\t\t\t\t\t\t<figure class=\"m-0 text-center\">\r\n\t\t\t\t\t\t\t\t\t<img width=\"200\" height=\"71\" class=\"opacity-4\"");
                BeginWriteAttribute("src", " src=\"", 1117, "\"", 1133, 1);
#nullable restore
#line 47 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HomeBrandSlider\Default.cshtml"
WriteAttributeValue("", 1123, item.Logo, 1123, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1134, "\"", 1150, 1);
#nullable restore
#line 47 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HomeBrandSlider\Default.cshtml"
WriteAttributeValue("", 1140, item.Logo, 1140, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t</figure>\r\n\r\n\r\n\t\t\t\t\t\t\t");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-brandId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HomeBrandSlider\Default.cshtml"
                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["brandId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-brandId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["brandId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 56 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HomeBrandSlider\Default.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t</div>\r\n\r\n\r\n\r\n\t\t</div>\r\n\t\t<!-- /SWIPER SLIDER -->\r\n\r\n\t</div>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BlogAndShop.Data.ViewModel.Product.BrandModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
