#pragma checksum "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a70d133a7e9c976c1df5b9a82cc12bb3af9edb31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
#line 1 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
using BlogAndShop.Services.Classes.Date;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
using BlogAndShop.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
using BlogAndShop.Services.Classes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a70d133a7e9c976c1df5b9a82cc12bb3af9edb31", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ceabd4d967b8778eff27795061a7867938385b", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogAndShop.Data.ViewModel.Product.BookListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-12 col-md-6 mb-5 position-relative text-dark clearfix text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 6 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
  
	ViewBag.metaDescription = "???????????? ???????? ???? ?? ???????? ?????? ??????????????";
	ViewBag.metaTitle = "????????????????";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- start :: blog content -->\r\n<section>\r\n\t<div class=\"container\">\r\n\r\n\t\t<div class=\"row\">\r\n\r\n\t\t\t");
#nullable restore
#line 18 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
       Write(await Component.InvokeAsync("BlogSideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<div class=\"col-lg-9 order-2 order-lg-2\">\r\n\r\n");
#nullable restore
#line 21 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
                 if (!Model.Posts.Any())
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<p>?????????? ???????? ??????.</p>\r\n");
#nullable restore
#line 24 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
				}
				else
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<!-- posts -->\r\n\t\t\t\t\t<div class=\"row\">\r\n\r\n");
#nullable restore
#line 30 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
                         foreach (var item in Model.Posts)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t");
            WriteLiteral("<!-- post -->\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a70d133a7e9c976c1df5b9a82cc12bb3af9edb316306", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\t\t\t\t\t\t\t\t<figure class=\"d-block text-center overlay-dark-hover overlay-opacity-2 rounded overflow-hidden h--300\" data-background-image=\"");
#nullable restore
#line 38 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
                                                                                                                                                          Write(await Html.GetMediaPath(item.BannerImageId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n\t\t\t\t\t\t\t\t\t<img class=\"img-fluid rounded h-100\"");
                BeginWriteAttribute("src", " src=\"", 1296, "\"", 1346, 1);
#nullable restore
#line 39 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
WriteAttributeValue("", 1302, await Html.GetMediaPath(item.BannerImageId), 1302, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1347, "\"", 1364, 1);
#nullable restore
#line 39 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
WriteAttributeValue("", 1353, item.Title, 1353, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t</figure>\r\n\r\n\r\n\t\t\t\t\t\t\t\t<p class=\"mt-3 fs--20 mb-2\">\r\n\t\t\t\t\t\t\t\t\t<span class=\"h6-xs text-dark d-block\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 45 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</span>\r\n\r\n\t\t\t\t\t\t\t\t\t<span class=\"d-block text-muted font-regular fs--14\">\r\n\t\t\t\t\t\t\t\t\t\t??????????: <time");
                BeginWriteAttribute("datetime", " datetime=\"", 1607, "\"", 1661, 1);
#nullable restore
#line 49 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
WriteAttributeValue("", 1618, item.CreateDateTime.ToString("yyyy-MM-dd"), 1618, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 49 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
                                                                                                       Write(item.CreateDateTime.ToPeString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</time>\r\n\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t</p>\r\n\r\n\t\t\t\t\t\t\t");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
            WriteLiteral("<!-- /post -->\r\n");
#nullable restore
#line 55 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<!-- /posts -->\r\n");
#nullable restore
#line 59 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<!-- pagination : center -->\r\n\t\t\t\t");
#nullable restore
#line 61 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Index.cshtml"
           Write(await Component.InvokeAsync("AdminPagination", Model.ListPaginationModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t<!-- /pagination : center -->\r\n\r\n\r\n\t\t\t</div>\r\n\r\n\r\n\t\t</div>\r\n\r\n\t</div>\r\n</section>\r\n<!-- end :: blog content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogAndShop.Data.ViewModel.Product.BookListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
