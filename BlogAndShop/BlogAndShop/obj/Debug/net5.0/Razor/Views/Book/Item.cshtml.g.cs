#pragma checksum "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0fe7367c152d2cce53d3e7eba060f0a967d58e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Item), @"mvc.1.0.view", @"/Views/Book/Item.cshtml")]
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
#line 1 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
using BlogAndShop.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
using BlogAndShop.Services.Classes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
using CommonConfiguration.Core.Services.Classes.Date;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0fe7367c152d2cce53d3e7eba060f0a967d58e5", @"/Views/Book/Item.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ceabd4d967b8778eff27795061a7867938385b", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Item : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogAndShop.Data.ViewModel.Product.DownloadItemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Read", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-pill btn-soft"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
  
	ViewBag.metaDescription = Model.Description;
	ViewBag.metaTitle = Model.Title;
	ViewBag.metaKeywords = Model.Keywords;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- start :: blog content -->\r\n<section>\r\n\t<div class=\"container\">\r\n\r\n\t\t<div class=\"row\">\r\n\r\n\t\t\t");
#nullable restore
#line 18 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
       Write(await Component.InvokeAsync("BlogSideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<div class=\"col-lg-9 order-2 order-lg-1\">\r\n\r\n\t\t\t\t<div class=\"mb-4\">\r\n\r\n\r\n\t\t\t\t\t<nav aria-label=\"breadcrumb\">\r\n\t\t\t\t\t\t<ol class=\"breadcrumb fs--14 mb-3\">\r\n\t\t\t\t\t\t\t<li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0fe7367c152d2cce53d3e7eba060f0a967d58e56156", async() => {
                WriteLiteral("خانه");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t<li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0fe7367c152d2cce53d3e7eba060f0a967d58e57564", async() => {
                WriteLiteral("کتابخانه");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t<li class=\"breadcrumb-item\"><a href=\"#\">");
#nullable restore
#line 28 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
                                                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\t\t\t\t\t\t</ol>\r\n\t\t\t\t\t</nav>\r\n\r\n\t\t\t\t\t<p class=\"d-block text-muted fs--14\">\r\n\t\t\t\t\t\tتاریخ ارسال: <time");
            BeginWriteAttribute("datetime", " datetime=\"", 975, "\"", 1030, 1);
#nullable restore
#line 33 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
WriteAttributeValue("", 986, Model.CreateDateTime.ToString("yyyy-MM-dd"), 986, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
                                                                                              Write(Model.CreateDateTime.ToPeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</time>\r\n\t\t\t\t\t</p>\r\n\r\n\t\t\t\t</div>\r\n\r\n\r\n\r\n\t\t\t\t<div class=\"row\">\r\n\r\n\t\t\t\t\t<div class=\"col-lg-4 col-md-4 order-1 mb-5\">\r\n\r\n\r\n\t\t\t\t\t\t<!-- FEATURED POST : ALWAYS LAST ADDED -->\r\n\t\t\t\t\t\t<div class=\"clearfix mb-5\">\r\n\r\n\t\t\t\t\t\t\t<img class=\"img-fluid w-100 h--500\"");
            BeginWriteAttribute("src", " src=\"", 1315, "\"", 1366, 1);
#nullable restore
#line 48 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
WriteAttributeValue("", 1321, await Html.GetMediaPath(Model.BannerImageId), 1321, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1367, "\"", 1385, 1);
#nullable restore
#line 48 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
WriteAttributeValue("", 1373, Model.Title, 1373, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t</div>\r\n\r\n\r\n\t\t\t\t\t<div class=\"col-lg-8 col-md-8 order-2 mb-5\">\r\n\r\n\t\t\t\t\t\t<h1 class=\"h3 h4-xs font-weight-medium mb-0\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 58 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</h1>\r\n\t\t\t\t\t\t<hr />\r\n\t\t\t\t\t\t<div class=\"clearfix mb-5\">\r\n\t\t\t\t\t\t\t<a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 1638, "\"", 1691, 1);
#nullable restore
#line 62 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
WriteAttributeValue("", 1645, await Html.GetMediaPath(Model.DownloadPathId), 1645, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark btn-pill btn-soft\">\r\n\t\t\t\t\t\t\t\t<i class=\"fi fi-arrow-download\"></i>\r\n\t\t\t\t\t\t\t\tدانلود\r\n\t\t\t\t\t\t\t</a>\r\n");
#nullable restore
#line 66 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
                             if (Model.Extension.Contains("pdf", StringComparison.OrdinalIgnoreCase))
							{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0fe7367c152d2cce53d3e7eba060f0a967d58e512583", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<i class=\"fi fi-eye\"></i>\r\n\t\t\t\t\t\t\t\t\tمطالعه\r\n\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
                                                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 73 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<p>");
#nullable restore
#line 76 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
					</div>

				</div>

				<!-- /FEATURED POST : ALWAYS LAST ADDED -->
				<!--
				.article-format class will add some slightly formattings for a good text visuals.
				This is because most editors are not ready formatted for bootstrap
				Blog content should come inside this container, as it is from database!
				src/scss/_core/base/_typography.scss
				-->


				<p class=""text-muted border-bottom pb-2 fs--13 mt--60"">
					آخرین بروز رسامی: ");
#nullable restore
#line 91 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Book\Item.cshtml"
                                 Write(Model.UpdateDateTime.ToPeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</p>\r\n\r\n\r\n\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t</div>\r\n</section>\r\n<!-- end :: blog content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogAndShop.Data.ViewModel.Product.DownloadItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
