#pragma checksum "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Forum\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d903915a7b38c55662bfe9fa5bb67ad6ac5bb3bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_Index), @"mvc.1.0.view", @"/Views/Forum/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d903915a7b38c55662bfe9fa5bb67ad6ac5bb3bd", @"/Views/Forum/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ceabd4d967b8778eff27795061a7867938385b", @"/Views/_ViewImports.cshtml")]
    public class Views_Forum_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<!-- PAGE TITLE -->\r\n<section class=\"bg-white p--30\">\r\n\t<div class=\"container\">\r\n\r\n\t\t<h1 class=\"h2\">\r\n\t\t\tانجمن\r\n\t\t</h1>\r\n\r\n\t\t<nav aria-label=\"breadcrumb\">\r\n\t\t\t<ol class=\"breadcrumb fs--14\">\r\n\t\t\t\t<li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d903915a7b38c55662bfe9fa5bb67ad6ac5bb3bd4922", async() => {
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
            WriteLiteral(@"</li>
				<li class=""breadcrumb-item active"" aria-current=""page"">انجمن</li>
			</ol>
		</nav>

	</div>
</section>
<!-- /PAGE TITLE -->
<!-- FAQ -->
<section class=""p--30"">
	<div class=""container"">

		<div class=""row"">

			<div class=""col-12 col-lg-4"">
				<div class=""sticky-kit"">

					<nav class=""nav-deep nav-deep-light"">

						<ul id=""list-example"" class=""nav flex-column nav-default shadow-md rounded-xl bg-white p--10"">
							<li class=""nav-item px-3 py-2"">
								<h2 class=""h5 font-weight-normal text-primary"">
									دسته بندی مباحث
								</h2>
							</li>

							<li class=""nav-item"">
								<a class=""nav-link py-3"" href=""#spy1"">
									<i class=""fs--13 fi fi-arrow-end-slim""></i>
									<span>Advanced photo options</span>
								</a>
							</li>

							<li class=""nav-item"">
								<a class=""nav-link py-3""");
            BeginWriteAttribute("href", " href=\"", 1165, "\"", 1172, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t<i class=\"fs--13 fi fi-arrow-end-slim\"></i>\r\n\t\t\t\t\t\t\t\t\t<span>\r\n\t\t\t\t\t\t\t\t\t\tگروه 2\r\n\t\t\t\t\t\t\t\t\t</span>\r\n\t\t\t\t\t\t\t\t</a>\r\n\r\n\t\t\t\t\t\t\t\t<ul class=\"nav flex-column px-3\">\r\n\t\t\t\t\t\t\t\t\t<li class=\"nav-item\">\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d903915a7b38c55662bfe9fa5bb67ad6ac5bb3bd7632", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\tگروه 2\r\n\t\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t\t\t\t\t<li class=\"nav-item\">\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d903915a7b38c55662bfe9fa5bb67ad6ac5bb3bd9222", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\tگروه 2 - 1\r\n\t\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t<li class=\"nav-item\">\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d903915a7b38c55662bfe9fa5bb67ad6ac5bb3bd10812", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\tگروه 2 - 2\r\n\t\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
									</li>
								</ul>
							</li>
						</ul>

					</nav>

				</div>
			</div>

			<div class=""col-12 col-lg-8"">

				<!--
					.article-format class will add some slightly formattings for a good text visuals.
					This is because most editors are not ready formatted for bootstrap
					Blog content should come inside this container, as it is from database!
					src/scss/_core/base/_typography.scss
				-->
				<div class=""bg-white p-5 p-4-xs rounded-xl article-format"">
");
            WriteLiteral("\t\t\t\t\t<div>\r\n\r\n\t\t\t\t\t\t<h2 class=\"h4 text-primary font-weight-normal\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d903915a7b38c55662bfe9fa5bb67ad6ac5bb3bd12931", async() => {
                WriteLiteral("Advanced photo options");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            WriteLiteral(@"</h2>
						<p>If you're Tweeting from the Twitter for iOS or Twitter for Android apps, you can enhance, apply a filter, crop an image, and add stickers to a photo.</p>
						<ul class=""list-inline my-4"">
							<li class=""list-inline-item d-block-xs m-0-xs"">
								<a href=""#"" class=""btn btn-light py-1 px-2 mb-1 fs--14 d-block-xs text-align-start js-togglified"">

									<span class=""group-icon"">
										<i class=""fi fi-user-male""></i>
										<i class=""fi fi-user-male text-primary""></i>
									</span>

									<span>53 کاربر</span>
								</a>

							</li>

							<li class=""list-inline-item d-block-xs m-0-xs"">
								<a href=""#"" class=""btn btn-light py-1 px-2 mb-1 fs--14 d-block-xs text-align-start js-togglified"">

									<span class=""group-icon"">
										<i class=""fi fi-chat""></i>
										<i class=""fi fi-chat text-primary""></i>
									</span>

									<span>53 پاسخ</span>
								</a>

							</li>

							<li class=""list-inline-item d-block-xs m-0-xs"">
	");
            WriteLiteral(@"							<a href=""#"" class=""btn btn-light py-1 px-2 mb-1 fs--14 d-block-xs text-align-start js-togglified"">

									<span class=""group-icon"">
										<i class=""fi fi-plus""></i>
										<i class=""fi fi-plus text-primary""></i>
									</span>

									<span>ورود به بحث</span>
								</a>

							</li>
						</ul>

					</div>
");
            WriteLiteral("\t\t\t\t\t<div>\r\n\r\n\t\t\t\t\t\t<h2 class=\"h4 text-primary font-weight-normal\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d903915a7b38c55662bfe9fa5bb67ad6ac5bb3bd15862", async() => {
                WriteLiteral("Advanced photo options");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            WriteLiteral(@"</h2>
						<p>If you're Tweeting from the Twitter for iOS or Twitter for Android apps, you can enhance, apply a filter, crop an image, and add stickers to a photo.</p>
						<ul class=""list-inline my-4"">
							<li class=""list-inline-item d-block-xs m-0-xs"">
								<a href=""#"" class=""btn btn-light py-1 px-2 mb-1 fs--14 d-block-xs text-align-start js-togglified"">

									<span class=""group-icon"">
										<i class=""fi fi-user-male""></i>
										<i class=""fi fi-user-male text-primary""></i>
									</span>

									<span>53 کاربر</span>
								</a>

							</li>

							<li class=""list-inline-item d-block-xs m-0-xs"">
								<a href=""#"" class=""btn btn-light py-1 px-2 mb-1 fs--14 d-block-xs text-align-start js-togglified"">

									<span class=""group-icon"">
										<i class=""fi fi-chat""></i>
										<i class=""fi fi-chat text-primary""></i>
									</span>

									<span>53 پاسخ</span>
								</a>

							</li>

							<li class=""list-inline-item d-block-xs m-0-xs"">
	");
            WriteLiteral(@"							<a href=""#"" class=""btn btn-light py-1 px-2 mb-1 fs--14 d-block-xs text-align-start js-togglified"">

									<span class=""group-icon"">
										<i class=""fi fi-plus""></i>
										<i class=""fi fi-plus text-primary""></i>
									</span>

									<span>ورود به بحث</span>
								</a>

							</li>
						</ul>

					</div>
");
            WriteLiteral("\t\t\t\t\t<div>\r\n\r\n\t\t\t\t\t\t<h2 class=\"h4 text-primary font-weight-normal\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d903915a7b38c55662bfe9fa5bb67ad6ac5bb3bd18793", async() => {
                WriteLiteral("Advanced photo options");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            WriteLiteral(@"</h2>
						<p>If you're Tweeting from the Twitter for iOS or Twitter for Android apps, you can enhance, apply a filter, crop an image, and add stickers to a photo.</p>
						<ul class=""list-inline my-4"">
							<li class=""list-inline-item d-block-xs m-0-xs"">
								<a href=""#"" class=""btn btn-light py-1 px-2 mb-1 fs--14 d-block-xs text-align-start js-togglified"">

									<span class=""group-icon"">
										<i class=""fi fi-user-male""></i>
										<i class=""fi fi-user-male text-primary""></i>
									</span>

									<span>53 کاربر</span>
								</a>

							</li>

							<li class=""list-inline-item d-block-xs m-0-xs"">
								<a href=""#"" class=""btn btn-light py-1 px-2 mb-1 fs--14 d-block-xs text-align-start js-togglified"">

									<span class=""group-icon"">
										<i class=""fi fi-chat""></i>
										<i class=""fi fi-chat text-primary""></i>
									</span>

									<span>53 پاسخ</span>
								</a>

							</li>

							<li class=""list-inline-item d-block-xs m-0-xs"">
	");
            WriteLiteral(@"							<a href=""#"" class=""btn btn-light py-1 px-2 mb-1 fs--14 d-block-xs text-align-start js-togglified"">

									<span class=""group-icon"">
										<i class=""fi fi-plus""></i>
										<i class=""fi fi-plus text-primary""></i>
									</span>

									<span>ورود به بحث</span>
								</a>

							</li>
						</ul>

					</div>

				</div>

			</div>

		</div>

	</div>
</section>
<!-- /FAQ -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
