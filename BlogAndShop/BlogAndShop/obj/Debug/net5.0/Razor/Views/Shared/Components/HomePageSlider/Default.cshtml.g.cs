#pragma checksum "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HomePageSlider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b14238bfa4f1f6328e3e14662e29d94abac4d95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_HomePageSlider_Default), @"mvc.1.0.view", @"/Views/Shared/Components/HomePageSlider/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b14238bfa4f1f6328e3e14662e29d94abac4d95", @"/Views/Shared/Components/HomePageSlider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ceabd4d967b8778eff27795061a7867938385b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_HomePageSlider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogAndShop.Data.ViewModel.HomePage.HomeBannerModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<section class=""swiper-container swiper-btn-group swiper-btn-group-end text-white p-0 h-50vh overflow-hidden""
		 data-swiper='{
					""slidesPerView"": 1,
					""spaceBetween"": 0,
					""autoplay"": { ""delay"" : 3500, ""disableOnInteraction"": false },
					""loop"": true,
					""pagination"": { ""type"": ""bullets"" }
				}'>

	<div class=""swiper-wrapper h-100"">

");
#nullable restore
#line 15 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HomePageSlider\Default.cshtml"
           var count = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HomePageSlider\Default.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<!-- slide ");
#nullable restore
#line 18 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HomePageSlider\Default.cshtml"
                  Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n\t\t\t<div class=\"h-100 swiper-slide d-middle bg-white overlay-dark overlay-opacity-2 d-middle bg-cover\"");
            BeginWriteAttribute("style", " style=\"", 617, "\"", 665, 3);
            WriteAttributeValue("", 625, "background-image:url(\'", 625, 22, true);
#nullable restore
#line 19 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HomePageSlider\Default.cshtml"
WriteAttributeValue("", 647, item.BannerPath, 647, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 663, "\')", 663, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t<div class=\"container z-index-10 text-white text-center-xs\">\r\n\r\n\t\t\t\t\t");
#nullable restore
#line 22 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HomePageSlider\Default.cshtml"
               Write(Html.Raw(item.HtmlContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<!-- /slide ");
#nullable restore
#line 27 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HomePageSlider\Default.cshtml"
                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("-->\r\n");
#nullable restore
#line 28 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\HomePageSlider\Default.cshtml"
			count++;
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div>\r\n\r\n\t<!-- Add Arrows -->\r\n\t<div class=\"swiper-button-next swiper-button-white\"></div>\r\n\t<div class=\"swiper-button-prev swiper-button-white\"></div>\r\n\r\n\t<!-- Add Pagination -->\r\n\t<div class=\"swiper-pagination\"></div>\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BlogAndShop.Data.ViewModel.HomePage.HomeBannerModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
