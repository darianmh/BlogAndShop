#pragma checksum "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90694eb413523379dcd746f96919ccd96a6ef25d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
using BlogAndShop.Services.Classes.Date;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90694eb413523379dcd746f96919ccd96a6ef25d", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ceabd4d967b8778eff27795061a7867938385b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogAndShop.Data.ViewModel.PostInfo.BlogListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-12 col-md-6 mb-5 position-relative text-dark clearfix text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bs-validate d-block bg-white shadow-primary-xs px-4 py-5 mt--100 text-center rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
  
	ViewBag.metaDescription = Model.Description;
	ViewBag.metaTitle = Model.Title;
	ViewBag.metaKeywords = Model.Keywords;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- start :: blog content -->\r\n<section>\r\n\t<div class=\"container\">\r\n\r\n\t\t<div class=\"row\">\r\n\r\n\t\t\t");
#nullable restore
#line 17 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
       Write(await Component.InvokeAsync("BlogSideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<div class=\"col-lg-9 order-2 order-lg-2\">\r\n\r\n");
#nullable restore
#line 20 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
                 if (Model.Posts.Any())
				{
					var featurePost = Model.Posts.First();

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<!-- FEATURED POST : ALWAYS LAST ADDED -->\r\n\t\t\t\t\t<div class=\"clearfix mb--100\">\r\n\r\n\t\t\t\t\t\t<figure class=\"d-block text-center overlay-dark-hover overlay-opacity-2 rounded overflow-hidden h--300\">\r\n\t\t\t\t\t\t\t<img class=\"img-fluid rounded\"");
            BeginWriteAttribute("src", " src=\"", 748, "\"", 778, 1);
#nullable restore
#line 27 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
WriteAttributeValue("", 754, featurePost.BannerImage, 754, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 779, "\"", 803, 1);
#nullable restore
#line 27 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
WriteAttributeValue("", 785, featurePost.Title, 785, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t</figure>\r\n\r\n");
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t<h2 class=\"h3 h4-xs font-weight-medium\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90694eb413523379dcd746f96919ccd96a6ef25d8155", async() => {
#nullable restore
#line 36 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
                                                                                                                               Write(featurePost.Title);

#line default
#line hidden
#nullable disable
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
                                                                                                WriteLiteral(featurePost.PreferUrl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t</h2>\r\n\r\n\t\t\t\t\t\t<p class=\"d-block text-muted fs--14\">\r\n\t\t\t\t\t\t\tتاریخ: <time");
            BeginWriteAttribute("datetime", " datetime=\"", 1415, "\"", 1476, 1);
#nullable restore
#line 40 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1426, featurePost.CreateDateTime.ToString("yyyy-MM-dd"), 1426, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
                                                                                                  Write(featurePost.CreateDateTime.ToPeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</time>\r\n\t\t\t\t\t\t\t<span>( ");
#nullable restore
#line 41 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
                               Write(featurePost.VisitCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;<i class=\"fi fi-eye\"></i> )</span>\r\n\t\t\t\t\t\t</p>\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<!-- /FEATURED POST : ALWAYS LAST ADDED -->\r\n");
#nullable restore
#line 46 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
				}
				else
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<p>موردی یافت نشد.</p>\r\n");
#nullable restore
#line 50 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<!-- posts -->\r\n");
#nullable restore
#line 52 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
                 if (Model.Posts.Count > 1)
				{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"row\">\r\n\r\n");
#nullable restore
#line 57 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
                         for (int i = 1; i < Model.Posts.Count; i++)
						{
							var item = Model.Posts[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<!-- post -->\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90694eb413523379dcd746f96919ccd96a6ef25d13324", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\t\t\t\t\t\t\t\t<figure class=\"d-block text-center overlay-dark-hover overlay-opacity-2 rounded overflow-hidden h--300\" data-background-image=\"");
#nullable restore
#line 66 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
                                                                                                                                                          Write(item.BannerImage);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n\t\t\t\t\t\t\t\t\t<img class=\"img-fluid rounded h-100\"");
                BeginWriteAttribute("src", " src=\"", 2545, "\"", 2568, 1);
#nullable restore
#line 67 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2551, item.BannerImage, 2551, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2569, "\"", 2586, 1);
#nullable restore
#line 67 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2575, item.Title, 2575, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t</figure>\r\n\r\n\r\n\t\t\t\t\t\t\t\t<p class=\"mt-3 fs--20 mb-2\">\r\n\t\t\t\t\t\t\t\t\t<span class=\"h6-xs text-dark d-block\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 73 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</span>\r\n\r\n\t\t\t\t\t\t\t\t\t<span class=\"d-block text-muted font-regular fs--14\">\r\n\t\t\t\t\t\t\t\t\t\tتاریخ: <time");
                BeginWriteAttribute("datetime", " datetime=\"", 2829, "\"", 2883, 1);
#nullable restore
#line 77 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2840, item.CreateDateTime.ToString("yyyy-MM-dd"), 2840, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 77 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
                                                                                                       Write(item.CreateDateTime.ToPeString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</time>\r\n\t\t\t\t\t\t\t\t\t\t<span>( ");
#nullable restore
#line 78 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
                                           Write(item.VisitCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp;<i class=\"fi fi-eye\"></i> )</span>\r\n\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t</p>\r\n\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
                                                                              WriteLiteral(item.PreferUrl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t<!-- /post -->\r\n");
#nullable restore
#line 84 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 87 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<!-- /posts -->\r\n\t\t\t\t<!-- pagination : center -->\r\n\t\t\t\t");
#nullable restore
#line 90 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Blog\Index.cshtml"
           Write(await Component.InvokeAsync("AdminPagination", Model.ListPaginationModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t<!-- /pagination : center -->\r\n\t\t\t\t<!-- Forum -->\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90694eb413523379dcd746f96919ccd96a6ef25d19766", async() => {
                WriteLiteral(@"
					<div class=""py-4 col-lg-8 ml-lg-auto mr-lg-auto"">

						<h3 class=""mb-0"">وارد بحث شوید</h3>
						<p class=""lead mb-5 text-muted"">Get for free our tips, tricks &amp; news</p>

						<input required placeholder=""ایمیل"" name=""subscriber_email"" class=""form-control text-center mb-2"" type=""email""");
                BeginWriteAttribute("value", " value=\"", 3739, "\"", 3747, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-primary btn-block\">\r\n\t\t\t\t\t\t\tورود به انجمن\r\n\t\t\t\t\t\t</button>\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t<!-- /Forum -->\r\n\r\n\r\n\t\t\t</div>\r\n\r\n\r\n\t\t</div>\r\n\r\n\t</div>\r\n</section>\r\n<!-- end :: blog content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogAndShop.Data.ViewModel.PostInfo.BlogListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
