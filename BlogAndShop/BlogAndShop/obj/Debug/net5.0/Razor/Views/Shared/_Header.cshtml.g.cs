#pragma checksum "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dc8bee7de785ba7c0428309f8e0dd9aa297e8be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
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
#line 1 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\_Header.cshtml"
using BlogAndShop.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dc8bee7de785ba7c0428309f8e0dd9aa297e8be", @"/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ceabd4d967b8778eff27795061a7867938385b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand m-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("js-ajax-search sow-search sow-search-mobile-float d-flex-1-1-auto mx-5 m-0-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mainNavDocumentation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link nav-link-caret-hide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mainNavShop"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"

<header id=""header"" class=""shadow-xs"">


	<!-- NAVBAR -->
	<div class=""container position-relative"">


		<nav class=""navbar navbar-expand-lg navbar-light justify-content-lg-between justify-content-md-inherit"">

			<div class=""align-items-start"">

				<!-- mobile menu button : show -->
				<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarMainNav"" aria-controls=""navbarMainNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
					<svg width=""25"" viewBox=""0 0 20 20"">
						<path d=""M 19.9876 1.998 L -0.0108 1.998 L -0.0108 -0.0019 L 19.9876 -0.0019 L 19.9876 1.998 Z""></path>
						<path d=""M 19.9876 7.9979 L -0.0108 7.9979 L -0.0108 5.9979 L 19.9876 5.9979 L 19.9876 7.9979 Z""></path>
						<path d=""M 19.9876 13.9977 L -0.0108 13.9977 L -0.0108 11.9978 L 19.9876 11.9978 L 19.9876 13.9977 Z""></path>
						<path d=""M 19.9876 19.9976 L -0.0108 19.9976 L -0.0108 17.9976 L 19.9876 17.9976 L 19.9876 19.9976 Z""></path>
					</svg>
				</button>

				<!");
            WriteLiteral("--\r\n\t\t\t\t\tLogo : height: 70px max\r\n\t\t\t\t-->\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dc8bee7de785ba7c0428309f8e0dd9aa297e8be9321", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 1307, "\"", 1338, 1);
#nullable restore
#line 34 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 1313, await Html.GetSiteLogo(), 1313, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width: 110px !important; height: 70px !important;\"");
                BeginWriteAttribute("alt", " alt=\"", 1397, "\"", 1428, 1);
#nullable restore
#line 34 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 1403, await Html.GetSiteName(), 1403, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

			</div>


			<!--

				[SOW] SEARCH SUGGEST PLUGIN
				++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++
				PLEASE READ DOCUMENTATION
				documentation/plugins-sow-search-suggest.html
				++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++ ++

			-->
");
            WriteLiteral("\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dc8bee7de785ba7c0428309f8e0dd9aa297e8be11989", async() => {
                WriteLiteral(@"
				<div class=""sow-search-input w-100"">

					<!-- rounded: form-control-pill -->
					<div class=""input-group-over d-flex align-items-center w-100 h-100 rounded form-control-pill"">

						<input placeholder=""?????????? ???? ????????"" name=""key"" type=""text"" class=""form-control-sow-search form-control form-control-lg b-0 bg-light""");
                BeginWriteAttribute("value", " value=\"", 3228, "\"", 3236, 0);
                EndWriteAttribute();
                WriteLiteral(@" autocomplete=""off"">

						<span class=""sow-search-buttons"">

							<!-- search button -->
							<button aria-label=""Global Search"" type=""submit"" class=""btn shadow-none m-0 px-3 py-2 bg-transparent text-muted"">
								<i class=""fi fi-search fs--20 m-0""></i>
							</button>

							<!-- close : mobile only (d-inline-block d-lg-none) -->
							<a href=""javascript:;"" class=""btn-sow-search-toggler btn btn-light shadow-none m-0 p-2 d-inline-block d-lg-none"">
								<i class=""fi fi-close fs--20 m-0""></i>
							</a>

						</span>

					</div>

				</div>

				<!-- search suggestion container -->
				<div class=""sow-search-container w-100 p-0 hide shadow-md"" id=""sow-search-container"">
					<div class=""sow-search-container-wrapper"">

						<!-- main search container -->
						<div class=""sow-search-loader p-3 text-center hide"">
							<i class=""fi fi-circle-spin fi-spin text-muted fs--30""></i>
						</div>

						<!--
							AJAX CONTENT CONTAINER
							SHOULD ALWAYS BE AS IT I");
                WriteLiteral(@"S : NO COMMENTS OR EVEN SPACES!
						-->
						<div class=""sow-search-content rounded w-100 scrollable-vertical""></div>

					</div>
				</div>
				<!-- /search suggestion container -->
				<!--

					overlay combinations:
						overlay-dark opacity-* [1-9]
						overlay-light opacity-* [1-9]

				-->
				<div class=""sow-search-backdrop overlay-dark opacity-3 hide""></div>

			");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
			<!-- /SEARCH -->
			<!-- OPTIONS -->
			<ul class=""list-inline list-unstyled mb-0 d-flex align-items-end"">

				<!-- mobile : search toggler -->
				<li class=""list-inline-item mx-1 dropdown d-inline-block d-lg-none"">

					<a href=""#!"" class=""btn-sow-search-toggler btn btn-sm btn-light rounded-circle"" aria-label=""Search"" data-toggle=""dropdown"" aria-expanded=""false"" aria-haspopup=""true"">
						<i class=""fi fi-search m-0""></i>
					</a>

				</li>

				<!-- join us button -->
				");
#nullable restore
#line 142 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\_Header.cshtml"
           Write(await Html.PartialAsync("_Login"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

			</ul>
			<!-- /OPTIONS -->


		</nav>

	</div>
	<!-- /NAVBAR -->




	<div class=""clearfix"">

		<!-- line -->
		<hr class=""m-0 opacity-5"">

		<div class=""container"">

			<nav class=""navbar h-auto navbar-expand-lg navbar-light justify-content-lg-between justify-content-md-inherit"">


				<!-- Menu -->
				<!--

					Dropdown Classes (should be added to primary .dropdown-menu only, dropdown childs are also affected)
						.dropdown-menu-dark 		- dark dropdown (desktop only, will be white on mobile)
						.dropdown-menu-hover 		- open on hover
						.dropdown-menu-clean 		- no background color on hover
						.dropdown-menu-invert 		- open dropdown in oposite direction (left|right, according to RTL|LTR)
						.dropdown-menu-uppercase 	- uppercase text (font-size is scalled down to 13px)
						.dropdown-click-ignore 		- keep dropdown open on inside click (useful on forms inside dropdown)

						Repositioning long dropdown childs (Example: Pages->Account)
							.dropdown-me");
            WriteLiteral(@"nu-up-n100 		- open up with top: -100px
							.dropdown-menu-up-n100 		- open up with top: -150px
							.dropdown-menu-up-n180 		- open up with top: -180px
							.dropdown-menu-up-n220 		- open up with top: -220px
							.dropdown-menu-up-n250 		- open up with top: -250px
							.dropdown-menu-up 			- open up without negative class


						Dropdown prefix icon (optional, if enabled in variables.scss)
							.prefix-link-icon .prefix-icon-dot 		- link prefix
							.prefix-link-icon .prefix-icon-line 	- link prefix
							.prefix-link-icon .prefix-icon-ico 		- link prefix
							.prefix-link-icon .prefix-icon-arrow 	- link prefix

						.nav-link.nav-link-caret-hide 	- no dropdown icon indicator on main link
						.nav-item.dropdown-mega 		- required ONLY on fullwidth mega menu

				-->
				<div class=""collapse navbar-collapse"" id=""navbarMainNav"">


					<!-- MOBILE MENU NAVBAR -->
					<div class=""navbar-xs d-none"">
						<!-- .sticky-top -->
						<!-- mobile menu button : close --");
            WriteLiteral(@">
						<button class=""navbar-toggler pt-0"" type=""button"" data-toggle=""collapse"" data-target=""#navbarMainNav"" aria-controls=""navbarMainNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
							<svg width=""20"" viewBox=""0 0 20 20"">
								<path d=""M 20.7895 0.977 L 19.3752 -0.4364 L 10.081 8.8522 L 0.7869 -0.4364 L -0.6274 0.977 L 8.6668 10.2656 L -0.6274 19.5542 L 0.7869 20.9676 L 10.081 11.679 L 19.3752 20.9676 L 20.7895 19.5542 L 11.4953 10.2656 L 20.7895 0.977 Z""></path>
							</svg>
						</button>

						<!--
							Mobile Menu Logo
							Logo : height: 70px max
						-->
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dc8bee7de785ba7c0428309f8e0dd9aa297e8be19411", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 7938, "\"", 7969, 1);
#nullable restore
#line 214 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\_Header.cshtml"
WriteAttributeValue("", 7944, await Html.GetSiteLogo(), 7944, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"110\" height=\"70\" alt=\"...\">\r\n\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<!-- /MOBILE MENU NAVBAR -->\r\n\t\t\t\t\t<!-- NAVIGATION -->\r\n\t\t\t\t\t<ul class=\"navbar-nav navbar-sm\">\r\n\r\n\t\t\t\t\t\t<!-- home -->\r\n\t\t\t\t\t\t<li class=\"nav-item dropdown\">\r\n\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dc8bee7de785ba7c0428309f8e0dd9aa297e8be21563", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<span>????????</span>\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t</li>\r\n\r\n\r\n\r\n\r\n\t\t\t\t\t\t<!-- shop -->\r\n\t\t\t\t\t\t<li class=\"nav-item dropdown\">\r\n\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dc8bee7de785ba7c0428309f8e0dd9aa297e8be23276", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<span>??????????????</span>\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t<!-- shop -->\r\n\t\t\t\t\t\t<li class=\"nav-item dropdown\">\r\n\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dc8bee7de785ba7c0428309f8e0dd9aa297e8be24979", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<span>??????????</span>\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t<!-- category -->\r\n");
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t<!-- blog category -->\r\n\r\n\t\t\t\t\t\t");
#nullable restore
#line 256 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\_Header.cshtml"
                   Write(await Component.InvokeAsync("HeaderBlogGroups"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\t\t\t\t\t\t<!-- book store -->\r\n\t\t\t\t\t\t<li class=\"nav-item dropdown\">\r\n\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dc8bee7de785ba7c0428309f8e0dd9aa297e8be27093", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t<span>????????????????</span>\r\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

						</li>
						<!-- social links -->
						<li class=""nav-item dropdown"">

							<a href=""https://social.ls1.ir"" class=""nav-link nav-link-caret-hide"">
								<span>???????? ?????? ??????????????</span>
							</a>

						</li>
						<!-- social : mobile only (d-block d-sm-none)-->

						<li class=""nav-item d-block d-sm-none text-center mb-4"">
							");
#nullable restore
#line 278 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\_Header.cshtml"
                       Write(await Component.InvokeAsync("SocialMedias"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t</ul>\r\n\t\t\t\t\t<!-- /NAVIGATION -->\r\n\r\n\r\n\r\n\r\n\t\t\t\t</div>\r\n\r\n\r\n\t\t\t\t<!-- desktop social -->\r\n\t\t\t\t<div class=\"float-end d-none d-lg-inline-block d-xl-inline-block d-xl-none\">\r\n\r\n\t\t\t\t\t");
#nullable restore
#line 293 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\_Header.cshtml"
               Write(await Component.InvokeAsync("SocialMedias"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t</div>\r\n\t\t\t\t<!-- /desktop social -->\r\n\r\n\t\t\t</nav>\r\n\r\n\t\t</div>\r\n\t</div>\r\n\r\n</header>");
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
