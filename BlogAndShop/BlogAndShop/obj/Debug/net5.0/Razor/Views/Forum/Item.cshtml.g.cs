#pragma checksum "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4da7cbb560fd0dd6e3b42b8ca875caa2e0cc58b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_Item), @"mvc.1.0.view", @"/Views/Forum/Item.cshtml")]
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
#line 1 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"
using BlogAndShop.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"
using CommonConfiguration.Core.Services.Classes.Date;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4da7cbb560fd0dd6e3b42b8ca875caa2e0cc58b0", @"/Views/Forum/Item.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ceabd4d967b8778eff27795061a7867938385b", @"/Views/_ViewImports.cshtml")]
    public class Views_Forum_Item : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogAndShop.Data.ViewModel.Forum.ForumItemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("nofollow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("newCommentForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bs-validate d-block bg-white shadow-primary-xs rounded p-3 mb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!-- PAGE TITLE -->\r\n<section class=\"bg-white p--30\">\r\n\t<div class=\"container\">\r\n\r\n\t\t<h1 class=\"h2\">\r\n\t\t\tانجمن\r\n\t\t</h1>\r\n\r\n\t\t<nav aria-label=\"breadcrumb\">\r\n\t\t\t<ol class=\"breadcrumb fs--14\">\r\n\t\t\t\t<li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4da7cbb560fd0dd6e3b42b8ca875caa2e0cc58b06995", async() => {
                WriteLiteral("انجمن");
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
            WriteLiteral("</li>\r\n\t\t\t\t<li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 15 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"
                                                                  Write(Model.ForumTitleModel.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t</ol>\r\n\t\t</nav>\r\n\r\n\t</div>\r\n</section>\r\n<!-- /PAGE TITLE -->\r\n<!-- FAQ -->\r\n<section class=\"p--30\">\r\n\t<div class=\"container\">\r\n\r\n\t\t<div class=\"row\">\r\n\r\n\t\t\t");
#nullable restore
#line 28 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"
       Write(await Component.InvokeAsync("ForumSideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

			<div class=""col-12 col-lg-8"">

				<!--
					.article-format class will add some slightly formattings for a good text visuals.
					This is because most editors are not ready formatted for bootstrap
					Blog content should come inside this container, as it is from database!
					src/scss/_core/base/_typography.scss
				-->
				<div class=""bg-white p-5 p-4-xs rounded-xl article-format"">

					<!-- COMMENTS -->
					<div class=""clearfix mt-5"">
						<p>
							");
#nullable restore
#line 43 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"
                       Write(Html.Raw(Model.ForumTitleModel.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t<!-- LIST COMMENTS -->\r\n\t\t\t\t\t\t<h3 class=\"font-weight-light mb-4\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 47 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"
                       Write(Model.ForumTitleModel.ForumComments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" نظر\r\n\t\t\t\t\t\t</h3>\r\n\r\n\r\n");
#nullable restore
#line 51 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"
                         foreach (var item in Model.ForumTitleModel.ForumComments)
						{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"							<!-- Comment 1 + Reply -->
							<div class=""media mb-4"">

								<!-- avatar : as background -->
								<div class=""w--100 text-center"">
									<div class=""w--70 h--70 mb-1 rounded-circle d-inline-block bg-light bg-cover"">
										<i class=""fi fi-user-male fs--40 d-block mt-1 text-gray-500""></i>
									</div>
									<span class=""d-block text-dark"">");
#nullable restore
#line 62 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"
                                                               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t<small class=\"d-block text-dark fs--12\">");
#nullable restore
#line 63 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"
                                                                       Write(item.CreateDateTime.ToPeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t\t<div class=\"media-body\">\r\n\t\t\t\t\t\t\t\t\t<p>\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 68 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"
                                   Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<!-- /Comment 1 + Reply -->\r\n");
#nullable restore
#line 74 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<!-- /LIST COMMENTS -->\r\n\r\n\t\t\t\t\t\t<div id=\"NewComment\">\r\n");
#nullable restore
#line 78 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"
                             if (User.Identity == null || !User.Identity.IsAuthenticated)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"alert alert-primary\" role=\"alert\">\r\n\t\t\t\t\t\t\t\t\tبرای نظر گذاشتن باید وارد شوید\r\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4da7cbb560fd0dd6e3b42b8ca875caa2e0cc58b012887", async() => {
                WriteLiteral("ورود");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ReturnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral("/Forum/Item/");
#nullable restore
#line 82 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"
                                                                                                                       WriteLiteral(Model.ForumTitleModel.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ReturnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ReturnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ReturnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 84 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<!-- already logged in -->\r\n\t\t\t\t\t\t\t\t<span class=\"d-block text-muted fs--12 mb-1\">\r\n\t\t\t\t\t\t\t\t\tنظر گذاشتن با نام: <b>");
#nullable restore
#line 89 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"
                                                     Write(await Html.GetUserName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>.\r\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4da7cbb560fd0dd6e3b42b8ca875caa2e0cc58b016190", async() => {
                WriteLiteral("خروج");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</span>\r\n");
            WriteLiteral("\t\t\t\t\t\t\t\t<!-- Write Comment Form -->\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4da7cbb560fd0dd6e3b42b8ca875caa2e0cc58b017754", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<input type=\"hidden\" name=\"ForumId\" id=\"ForumId\"");
                BeginWriteAttribute("value", " value=\"", 3083, "\"", 3116, 1);
#nullable restore
#line 95 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"
WriteAttributeValue("", 3091, Model.ForumTitleModel.Id, 3091, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
									<div class=""clearfix mb-3"">

										<div class=""form-label-group"">
											<textarea required rows=""3"" id=""Text""
													  data-output-target="".js-form-advanced-char-left""
													  class=""form-control js-form-advanced-char-count-down""
													  maxlength=""3000"" placeholder=""نظر شما""></textarea>
											<label for=""comment_description"">نظر شما</label>
										</div>

										<span class=""fs--12 text-muted text-align-end float-end mt-1"">
											کاراکتر های باقیمانده: <span class=""js-form-advanced-char-left"">3000</span>
										</span>

									</div>



									<button type=""submit"" class=""btn btn-primary btn-sm"">
										ارسال نظر
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t<!-- /Write Comment Form -->\r\n");
#nullable restore
#line 119 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Item.cshtml"

							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t<!-- /COMMENTS -->\r\n\t\t\t\t</div>\r\n\r\n\t\t\t</div>\r\n\r\n\t\t</div>\r\n\r\n\t</div>\r\n</section>\r\n<!-- /FAQ -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogAndShop.Data.ViewModel.Forum.ForumItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
