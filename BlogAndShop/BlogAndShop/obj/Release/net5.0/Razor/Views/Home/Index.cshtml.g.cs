#pragma checksum "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0c11f7041349b47e13d86a253a316c0cdccf42d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0c11f7041349b47e13d86a253a316c0cdccf42d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ceabd4d967b8778eff27795061a7867938385b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--\r\nSWIPER\r\n\r\nButtons position:\r\n.swiper-btn-group-start\r\n.swiper-btn-group-end\r\n-->\r\n");
#nullable restore
#line 8 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("HomePageSlider"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- /SWIPER -->\r\n<!-- BRANDS -->\r\n");
#nullable restore
#line 11 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("HomeBrandSlider"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- /BRANDS -->\r\n<!-- Exclusive -->\r\n");
#nullable restore
#line 14 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("HomeSalesProduct"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- /Exclusive -->\r\n<!-- block : about us -->\r\n");
#nullable restore
#line 17 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("HomeAbout"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- /block : about us -->\r\n<!-- Best gategory -->\r\n\r\n");
#nullable restore
#line 21 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("HomeTopCategories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- /Best gategory -->\r\n<!-- Categories -->\r\n");
#nullable restore
#line 24 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("HomeTop6Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Categories -->\r\n<!-- Best Deals + News -->\r\n");
#nullable restore
#line 27 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("HomeSuggestedProductsPosts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- /Best Deals + News -->\r\n<!-- block : testimonials -->\r\n\r\n");
#nullable restore
#line 31 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("HomeRecentForum"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- /block : testimonials -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
