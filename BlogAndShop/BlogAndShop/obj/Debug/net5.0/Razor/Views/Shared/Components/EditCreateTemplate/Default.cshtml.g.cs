#pragma checksum "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ad64055eddeed657593c206e1a35801a704b70b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_EditCreateTemplate_Default), @"mvc.1.0.view", @"/Views/Shared/Components/EditCreateTemplate/Default.cshtml")]
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
#line 2 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
using BlogAndShop.Data.ViewModel.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ad64055eddeed657593c206e1a35801a704b70b", @"/Views/Shared/Components/EditCreateTemplate/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ceabd4d967b8778eff27795061a7867938385b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_EditCreateTemplate_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogAndShop.Data.ViewModel.Utilities.EditCreateTemplateViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
  
	var selectItemCount = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
 foreach (var item in Model)
{
	string requiredText = "";
	var check = false;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"form-group mb-3\">\r\n");
#nullable restore
#line 12 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
         if (item.ObjectType == EditCreateTemplateType.Hidden)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<input class=\'form-control text-box single-line\' data-val=\'true\'");
            BeginWriteAttribute("id", " id=\'", 404, "\'", 419, 1);
#nullable restore
#line 14 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
WriteAttributeValue("", 409, item.Name, 409, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\'", 420, "\'", 437, 1);
#nullable restore
#line 14 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
WriteAttributeValue("", 427, item.Name, 427, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\'hidden\'");
            BeginWriteAttribute("value", " value=\'", 452, "\'", 471, 1);
#nullable restore
#line 14 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
WriteAttributeValue("", 460, item.Value, 460, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 15 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
		}
		else
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<label");
            BeginWriteAttribute("for", " for=\'", 502, "\'", 518, 1);
#nullable restore
#line 18 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
WriteAttributeValue("", 508, item.Name, 508, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                               Write(item.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\t\t\t<p>");
#nullable restore
#line 19 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
          Write(Html.ValidationMessage(item.Name, new { @class = "text text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 20 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
			if (item.IsRequired)
			{
				requiredText = $" data-val-required='{item.DisplayName} ???????? ???????? ??????.' ";
			}
			if (item.ObjectType == EditCreateTemplateType.DbList || item.ObjectType == EditCreateTemplateType.Enum || item.ObjectType == EditCreateTemplateType.DbListMulti || item.ObjectType == EditCreateTemplateType.EnumMulti)
			{
				if (item.ListForOptionList != null)
				{
					selectItemCount++;
					var selectImages = new Dictionary<string, string>();
					var optionCount = 0;
					var multiple = item.ObjectType == EditCreateTemplateType.DbListMulti || item.ObjectType == EditCreateTemplateType.EnumMulti ? "multiple='multiple'" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<select");
            BeginWriteAttribute("id", " id=\'", 1304, "\'", 1319, 1);
#nullable restore
#line 32 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
WriteAttributeValue("", 1309, item.Name, 1309, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\'", 1320, "\'", 1337, 1);
#nullable restore
#line 32 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
WriteAttributeValue("", 1327, item.Name, 1327, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 32 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                                         Write(requiredText);

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"form-control bs-select\" data-live-search=\"true\" data-actions-box=\"true\" ");
#nullable restore
#line 32 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                                                                                                                                      Write(multiple);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n");
#nullable restore
#line 33 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                         foreach (var option in item.ListForOptionList)
						{
							if (option.Selected)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ad64055eddeed657593c206e1a35801a704b70b10000", async() => {
#nullable restore
#line 37 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                                                             Write(option.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                   WriteLiteral(option.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
							}
							else
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ad64055eddeed657593c206e1a35801a704b70b12258", async() => {
#nullable restore
#line 41 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                                         Write(option.Text);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                   WriteLiteral(option.Value);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 42 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
							}
							if (option.HasImage)
							{
								var idName = $"bs-select-{selectItemCount}-{optionCount}";
								selectImages.Add(idName, option.ImagePath);
								optionCount++;
							}
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</select>\r\n");
#nullable restore
#line 51 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"

					if (selectImages.Any())
					{
						

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                         foreach (var image in selectImages)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<script>\r\n\t\t\t\t\t\t\t\tsetTimeout(function () {\r\n\t\t\t\t\t\t\t\t\tvar html = \'<img src=\"");
#nullable restore
#line 58 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                                     Write(image.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\';\r\n\t\t\t\t\t\t\t\t\t$(\"#");
#nullable restore
#line 59 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                   Write(image.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").parent().append(html);\r\n\t\t\t\t\t\t\t\t\t$(\"#");
#nullable restore
#line 60 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                   Write(image.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").parent().addClass(\'option_backgroundImage\');\r\n\t\t\t\t\t\t\t\t}, 6000);\r\n\r\n\t\t\t\t\t\t\t</script>\r\n");
#nullable restore
#line 64 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                         
					}
				}
				check = true;
			}

			else if (item.ObjectType == EditCreateTemplateType.HtmlEditor)
			{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<input");
            BeginWriteAttribute("id", " id=\'", 2441, "\'", 2456, 1);
#nullable restore
#line 73 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
WriteAttributeValue("", 2446, item.Name, 2446, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\'", 2457, "\'", 2474, 1);
#nullable restore
#line 73 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
WriteAttributeValue("", 2464, item.Name, 2464, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"hidden\" />\r\n");
#nullable restore
#line 74 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"

				var id = $"{item.Name}_1";

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div");
            BeginWriteAttribute("id", " id=\'", 2536, "\'", 2544, 1);
#nullable restore
#line 76 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
WriteAttributeValue("", 2541, id, 2541, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\'", 2545, "\'", 2555, 1);
#nullable restore
#line 76 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
WriteAttributeValue("", 2552, id, 2552, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"richtexteditor\" style=\"width: 960px; margin: 0 auto;\">\r\n\t\t\t\t\t");
#nullable restore
#line 77 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
               Write(Html.Raw(item.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n");
            WriteLiteral("\t\t\t\t<script>\r\n\t\t\t\t\tvar editor1 = new RichTextEditor(document.getElementById(\"");
#nullable restore
#line 81 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                                                         Write(id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"));\r\n\t\t\t\t\tdocument.getElementById(\"");
#nullable restore
#line 82 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").value = editor1.getHTMLCode();\r\n\t\t\t\t\teditor1.attachEvent(\"change\", function () {\r\n\t\t\t\t\t\tdocument.getElementById(\"");
#nullable restore
#line 84 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").value = editor1.getHTMLCode();\r\n\t\t\t\t\t});\r\n\t\t\t\t</script>\r\n");
#nullable restore
#line 87 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"

				check = true;
			}
			else if (item.ObjectType == EditCreateTemplateType.TextArea)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<textarea");
            BeginWriteAttribute("id", " id=\'", 3085, "\'", 3100, 1);
#nullable restore
#line 92 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
WriteAttributeValue("", 3090, item.Name, 3090, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\'", 3101, "\'", 3118, 1);
#nullable restore
#line 92 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
WriteAttributeValue("", 3108, item.Name, 3108, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" rows=\"3\">");
#nullable restore
#line 92 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                                                                     Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n");
#nullable restore
#line 93 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
				check = true;
			}
			else if (item.ObjectType == EditCreateTemplateType.File || item.ObjectType == EditCreateTemplateType.File)
			{
				

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
           Write(await Html.PartialAsync("_FileUpload", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                                             
				check = true;
			}
			//for number or decimal only
			var stepsCounter = "";
			if (item.ObjectType == EditCreateTemplateType.Number)
			{
				stepsCounter = "1";
			}
			else if (item.ObjectType == EditCreateTemplateType.Decimal)
			{
				stepsCounter = "0.01";
			}
			else if (item.ObjectType == EditCreateTemplateType.Bool)
			{
				var checkedItem = (bool)item.Value == true ? "checked='checked'" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<label class=\"form-switch form-switch-pill form-switch-primary d-block\">\r\n\t\t\t\t\t<input type=\"checkbox\" value=\"true\"");
            BeginWriteAttribute("name", " name=\"", 3912, "\"", 3929, 1);
#nullable restore
#line 114 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
WriteAttributeValue("", 3919, item.Name, 3919, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 3930, "\"", 3945, 1);
#nullable restore
#line 114 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
WriteAttributeValue("", 3935, item.Name, 3935, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 114 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                                                                     Write(checkedItem);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n\t\t\t\t\t<i data-on=\"??????\" data-off=\"??????\"></i>\r\n\t\t\t\t</label>\r\n");
#nullable restore
#line 117 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
				check = true;
			}
			if (!check)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<input class=\'form-control text-box single-line\' data-val=\'true\' ");
#nullable restore
#line 121 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                                                            Write(requiredText);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 121 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                                                                          Write(stepsCounter);

#line default
#line hidden
#nullable disable
            WriteLiteral(" id=\'");
#nullable restore
#line 121 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' name=\'");
#nullable restore
#line 121 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                                                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' type=\'");
#nullable restore
#line 121 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                                                                                                                                Write(item.TypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' value=\'");
#nullable restore
#line 121 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
                                                                                                                                                                       Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'>\r\n");
#nullable restore
#line 122 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
			}
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n");
#nullable restore
#line 125 "E:\Projects\BlogAndShopSite\BlogAndShop\BlogAndShop\Views\Shared\Components\EditCreateTemplate\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BlogAndShop.Data.ViewModel.Utilities.EditCreateTemplateViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
