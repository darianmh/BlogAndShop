#pragma checksum "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bcaeee9bcea06e642556a76805b9217f556e070"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Item), @"mvc.1.0.view", @"/Views/Blog/Item.cshtml")]
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
#line 1 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
using BlogAndShop.Services.Classes.Date;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
using BlogAndShop.Services.Classes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bcaeee9bcea06e642556a76805b9217f556e070", @"/Views/Blog/Item.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ceabd4d967b8778eff27795061a7867938385b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Item : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogAndShop.Data.ViewModel.PostInfo.PostModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Tag", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark bg-light fs--13 rounded py-2 px-3 m-1 text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("nofollow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-6 col-md-4 mb-5 position-relative text-dark clearfix text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bs-validate d-block bg-white shadow-primary-xs rounded p-3 mb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
  
	ViewBag.metaDescription = Model.Description;
	ViewBag.metaTitle = Model.Title;
	ViewBag.metaKeywords = Model.Keywords;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- start :: blog content -->\r\n<section>\r\n\t<div class=\"container\">\r\n\r\n\t\t<div class=\"row\">\r\n\r\n\t\t\t");
#nullable restore
#line 17 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
       Write(await Component.InvokeAsync("BlogSideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<div class=\"col-lg-9 order-2 order-lg-1\">\r\n\r\n\t\t\t\t<div class=\"mb-4\">\r\n\r\n\t\t\t\t\t<h1 class=\"h3 h4-xs font-weight-medium mb-0\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 23 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</h1>\r\n\r\n\t\t\t\t\t<nav aria-label=\"breadcrumb\">\r\n\t\t\t\t\t\t<ol class=\"breadcrumb fs--14 mb-3\">\r\n\t\t\t\t\t\t\t<li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bcaeee9bcea06e642556a76805b9217f556e0709004", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bcaeee9bcea06e642556a76805b9217f556e07010412", async() => {
                WriteLiteral("بلاگ");
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
#line 30 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                                                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\t\t\t\t\t\t</ol>\r\n\t\t\t\t\t</nav>\r\n\r\n\t\t\t\t\t<p class=\"d-block text-muted fs--14\">\r\n\t\t\t\t\t\tتاریخ ارسال: <time");
            BeginWriteAttribute("datetime", " datetime=\"", 1002, "\"", 1057, 1);
#nullable restore
#line 35 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
WriteAttributeValue("", 1013, Model.CreateDateTime.ToString("yyyy-MM-dd"), 1013, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                                                                                              Write(Model.CreateDateTime.ToPeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</time>\r\n\t\t\t\t\t</p>\r\n\r\n\t\t\t\t</div>\r\n\r\n\r\n\r\n\t\t\t\t<!-- FEATURED POST : ALWAYS LAST ADDED -->\r\n\t\t\t\t<div class=\"clearfix mb-5\">\r\n\r\n\t\t\t\t\t<img class=\"img-fluid w-100 h--500\"");
            BeginWriteAttribute("src", " src=\"", 1256, "\"", 1280, 1);
#nullable restore
#line 45 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
WriteAttributeValue("", 1262, Model.BannerImage, 1262, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1281, "\"", 1299, 1);
#nullable restore
#line 45 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
WriteAttributeValue("", 1287, Model.Title, 1287, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

				</div>
				<!-- /FEATURED POST : ALWAYS LAST ADDED -->
				<!--
					.article-format class will add some slightly formattings for a good text visuals.
					This is because most editors are not ready formatted for bootstrap
					Blog content should come inside this container, as it is from database!
					src/scss/_core/base/_typography.scss
				-->
				<div class=""article-format"">

					");
#nullable restore
#line 57 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
               Write(Html.Raw(Model.HtmlContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t</div>\r\n\r\n\r\n\t\t\t\t<p class=\"text-muted border-bottom pb-2 fs--13 mt--60\">\r\n\t\t\t\t\tآخرین بروز رسامی: ");
#nullable restore
#line 63 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                                 Write(Model.UpdateDateTime.ToPeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</p>\r\n\r\n\r\n\t\t\t\t<!-- Tags and share -->\r\n\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t<div class=\"col-6\">\r\n\r\n\t\t\t\t\t\t<h4 class=\"fs--13 text-muted\">\r\n\t\t\t\t\t\t\tتگ ها\r\n\t\t\t\t\t\t</h4>\r\n\r\n");
#nullable restore
#line 75 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                         foreach (var tag in Model.Tags)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bcaeee9bcea06e642556a76805b9217f556e07015407", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 78 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                           Write(tag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tagName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                                                                             WriteLiteral(tag.Title.GetRouteTextString());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tagName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tagName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tagName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 80 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t\t</div>\r\n\r\n");
            WriteLiteral("\t\t\t\t</div>\r\n\t\t\t\t<!-- /Tags and share -->\r\n\t\t\t\t<!-- Related Posts -->\r\n\t\t\t\t<h3 class=\"h5 mt-5 mb-4\">\r\n\t\t\t\t\tپست های مشابه\r\n\t\t\t\t</h3>\r\n\r\n\t\t\t\t<div class=\"row\">\r\n");
#nullable restore
#line 107 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                     foreach (var item in Model.RelatedPosts)
					{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<!-- post -->\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bcaeee9bcea06e642556a76805b9217f556e07019041", async() => {
                WriteLiteral("\r\n\r\n\t\t\t\t\t\t\t<figure class=\"d-block text-center overlay-dark-hover overlay-opacity-2 rounded overflow-hidden h--120\">\r\n\t\t\t\t\t\t\t\t<img class=\"img-fluid rounded\"");
                BeginWriteAttribute("src", " src=\"", 3466, "\"", 3489, 1);
#nullable restore
#line 114 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
WriteAttributeValue("", 3472, item.BannerImage, 3472, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3490, "\"", 3507, 1);
#nullable restore
#line 114 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
WriteAttributeValue("", 3496, item.Title, 3496, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t</figure>\r\n\r\n\t\t\t\t\t\t\t<p class=\"mt--20 fs--20 mb--6\">\r\n\t\t\t\t\t\t\t\t<span class=\"h6 text-dark d-block\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 119 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t</span>\r\n\r\n\t\t\t\t\t\t\t\t<span class=\"d-block text-muted font-regular fs--14\">\r\n\t\t\t\t\t\t\t\t\tتاریخ: <time");
                BeginWriteAttribute("datetime", " datetime=\"", 3741, "\"", 3795, 1);
#nullable restore
#line 123 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
WriteAttributeValue("", 3752, item.UpdateDateTime.ToString("yyyy-MM-dd"), 3752, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 123 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                                                                                                   Write(item.UpdateDateTime.ToPeString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</time>\r\n\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t</p>\r\n\r\n\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                                                                                          WriteLiteral(item.PreferUrl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t<!-- /post -->\r\n");
#nullable restore
#line 129 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"

					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</div>\r\n\t\t\t\t<!-- /Related Posts -->\r\n\t\t\t\t<!-- COMMENTS -->\r\n\t\t\t\t<div class=\"clearfix mt-5\">\r\n\t\t\t\t\t<h3 class=\"font-weight-light mb-4\">\r\n\t\t\t\t\t\tنظرات کاربران\r\n\t\t\t\t\t</h3>\r\n");
#nullable restore
#line 138 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                     if (!string.IsNullOrEmpty(Model.MessageText))
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<h3 class=\"alert alert-success\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 141 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                       Write(Model.MessageText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</h3>\r\n");
#nullable restore
#line 143 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
					}

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                     if (User.Identity.IsAuthenticated)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div id=\"replyAlert\"></div>\r\n\t\t\t\t\t\t<!-- Write Comment Form -->\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bcaeee9bcea06e642556a76805b9217f556e07025442", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t<input type=\"hidden\" name=\"ParentId\" id=\"CommentParentId\" />\r\n\t\t\t\t\t\t\t<input type=\"hidden\" name=\"PostId\"");
                BeginWriteAttribute("value", " value=\"", 4623, "\"", 4640, 1);
#nullable restore
#line 150 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
WriteAttributeValue("", 4631, Model.Id, 4631, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

							<div class=""clearfix mb-3"">

								<div class=""form-label-group"">
									<textarea required rows=""3"" name=""Text"" id=""comment_description""
											  data-output-target="".js-form-advanced-char-left""
											  class=""form-control js-form-advanced-char-count-down""
											  maxlength=""3000"" placeholder=""متن نظر""></textarea>
									<label for=""comment_description"">نظر شما</label>
								</div>

								<span class=""fs--12 text-muted text-align-end float-end mt-1"">
									کاراکترهای باقیمانده: <span class=""js-form-advanced-char-left"">3000</span>
								</span>

							</div>




							<button type=""submit"" class=""btn btn-primary btn-sm"">
								تایید نظر
							</button>
						");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t<!-- /Write Comment Form -->\r\n");
#nullable restore
#line 176 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
					}
					else
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"bs-validate d-block bg-white shadow-primary-xs rounded p-3 mb-5\">\r\n\t\t\t\t\t\t\t<p>برای نظر دادن وارد شوید.</p>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 182 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<!-- LIST COMMENTS -->\r\n\t\t\t\t\t<h3 class=\"font-weight-light mb-4\">\r\n\t\t\t\t\t\t");
#nullable restore
#line 185 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                   Write(Model.CommentsModel.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" نظر\r\n\t\t\t\t\t</h3>\r\n\r\n\r\n");
#nullable restore
#line 189 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                     foreach (var item in Model.CommentsModel)
					{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"						<!-- Comment 1 + Reply -->
						<div class=""media mb-4"">

							<!-- avatar : as background -->
							<div class=""w--100 text-center"">
								<div class=""w--70 h--70 mb-1 rounded-circle d-inline-block bg-light bg-cover"">
									<i class=""fi fi-user-male fs--40 d-block mt-1 text-gray-500""></i>
								</div>
								<span class=""d-block text-dark"">");
#nullable restore
#line 200 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                                                           Write(item.OwnerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t<small class=\"d-block text-dark fs--12\">");
#nullable restore
#line 201 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                                                                   Write(item.DateTime.ToPeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t<div class=\"media-body\">\r\n\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 205 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                              Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\t\t\t\t\t\t\t\t<!-- options -->\r\n\t\t\t\t\t\t\t\t<ul class=\"list-inline mt--20 mb--20\">\r\n\r\n\t\t\t\t\t\t\t\t\t<!-- reply -->\r\n\t\t\t\t\t\t\t\t\t<li class=\"list-inline-item\">\r\n\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\" class=\"js-ajax-modal btn btn-light py-1 px-2 fs--14\"");
            BeginWriteAttribute("onclick", "\r\n\t\t\t\t\t\t\t\t\t\t   onclick=\"", 6555, "\"", 6625, 5);
            WriteAttributeValue("", 6579, "ReplyPostComment(\'", 6579, 18, true);
#nullable restore
#line 214 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
WriteAttributeValue("", 6597, item.Id, 6597, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6605, "\',\'", 6605, 3, true);
#nullable restore
#line 214 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
WriteAttributeValue("", 6608, item.OwnerName, 6608, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6623, "\')", 6623, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"fi fi-plus\"></i>\r\n\t\t\t\t\t\t\t\t\t\t\t<span>پاسخ</span>\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t<!-- /reply -->\r\n\r\n\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t<!-- /options -->\r\n\t\t\t\t\t\t\t\t<!-- ... replies here ... -->\r\n\t\t\t\t\t\t\t\t<!-- REPLY -->\r\n");
#nullable restore
#line 226 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                                 foreach (var child in item.ChildrenComments)
								{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"									<div class=""media mb-4"">

										<!-- avatar : as background -->
										<div class=""w--100 text-center"">
											<div class=""w--70 h--70 mb-1 rounded-circle d-inline-block bg-light bg-cover"">
												<i class=""fi fi-user-male fs--40 d-block mt-1 text-gray-500""></i>
											</div>
											<span class=""d-block text-dark"">");
#nullable restore
#line 236 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                                                                       Write(child.OwnerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t\t\t<small class=\"d-block text-dark fs--12\">");
#nullable restore
#line 237 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                                                                               Write(child.DateTime.ToPeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"media-body\">\r\n\t\t\t\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 241 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
                                          Write(child.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

											<ul class=""list-inline mt--20 mb--20"">

												<!-- reply -->
												<li class=""list-inline-item"">

													<!--

													Replies are using an ajax modal!
													Replace with wordpress style, if wordpress used!

													This format can be used on custom blog CMS.

													-->
													<a href=""#"" class=""js-ajax-modal btn btn-light py-1 px-2 fs--14""");
            BeginWriteAttribute("onclick", "\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t   onclick=\"", 7906, "\"", 7981, 5);
            WriteAttributeValue("", 7933, "ReplyPostComment(\'", 7933, 18, true);
#nullable restore
#line 257 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
WriteAttributeValue("", 7951, child.Id, 7951, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7960, "\',\'", 7960, 3, true);
#nullable restore
#line 257 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
WriteAttributeValue("", 7963, child.OwnerName, 7963, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7979, "\')", 7979, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"fi fi-plus\"></i>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span>پاسخ</span>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</a>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<!-- /reply -->\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t</ul>\r\n\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 270 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<!-- /REPLY -->\r\n\r\n\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<!-- /Comment 1 + Reply -->\r\n");
#nullable restore
#line 277 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Item.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<!-- /LIST COMMENTS -->\r\n\r\n\r\n\r\n\t\t\t\t</div>\r\n\t\t\t\t<!-- /COMMENTS -->\r\n\r\n\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t</div>\r\n</section>\r\n<!-- end :: blog content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogAndShop.Data.ViewModel.PostInfo.PostModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
