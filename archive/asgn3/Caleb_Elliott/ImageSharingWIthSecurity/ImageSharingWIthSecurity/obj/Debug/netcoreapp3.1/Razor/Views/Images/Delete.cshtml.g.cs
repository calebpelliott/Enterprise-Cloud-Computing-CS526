#pragma checksum "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWIthSecurity\ImageSharingWIthSecurity\Views\Images\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e607f9ec98d0d615d48b1ba168199ccdfab07c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Images_Delete), @"mvc.1.0.view", @"/Views/Images/Delete.cshtml")]
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
#line 1 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWIthSecurity\ImageSharingWIthSecurity\Views\_ViewImports.cshtml"
using ImageSharingWithSecurity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWIthSecurity\ImageSharingWIthSecurity\Views\_ViewImports.cshtml"
using ImageSharingWithSecurity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWIthSecurity\ImageSharingWIthSecurity\Views\Images\Delete.cshtml"
using ImageSharingWithSecurity.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e607f9ec98d0d615d48b1ba168199ccdfab07c5", @"/Views/Images/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2866ac68f4b151f85647edc6a447cdf66bd31a17", @"/Views/_ViewImports.cshtml")]
    public class Views_Images_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ImageSharingWithSecurity.Models.ImageView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DoDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Images", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWIthSecurity\ImageSharingWIthSecurity\Views\Images\Delete.cshtml"
  
    ViewBag.Title = "Delete Image";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 9 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWIthSecurity\ImageSharingWIthSecurity\Views\Images\Delete.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e607f9ec98d0d615d48b1ba168199ccdfab07c56277", async() => {
                WriteLiteral("\r\n\r\n    <fieldset>\r\n        <legend>Edit Image Information</legend>\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e607f9ec98d0d615d48b1ba168199ccdfab07c56620", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 16 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWIthSecurity\ImageSharingWIthSecurity\Views\Images\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n        <p>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e607f9ec98d0d615d48b1ba168199ccdfab07c58397", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 393, "~/", 393, 2, true);
#nullable restore
#line 19 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWIthSecurity\ImageSharingWIthSecurity\Views\Images\Delete.cshtml"
AddHtmlAttributeValue("", 395, ImagesController.imageContextPath(Model.Id), 395, 46, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </p>\r\n\r\n        <p>Image id: ");
#nullable restore
#line 22 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWIthSecurity\ImageSharingWIthSecurity\Views\Images\Delete.cshtml"
                Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n        <p>Tag: ");
#nullable restore
#line 24 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWIthSecurity\ImageSharingWIthSecurity\Views\Images\Delete.cshtml"
           Write(Model.TagName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n        <p>Caption: ");
#nullable restore
#line 26 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWIthSecurity\ImageSharingWIthSecurity\Views\Images\Delete.cshtml"
               Write(Model.Caption);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n        <p>\r\n            Description:\r\n            <br />");
#nullable restore
#line 30 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWIthSecurity\ImageSharingWIthSecurity\Views\Images\Delete.cshtml"
             Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </p>\r\n\r\n        <p>Date taken: ");
#nullable restore
#line 33 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWIthSecurity\ImageSharingWIthSecurity\Views\Images\Delete.cshtml"
                  Write(Model.DateTaken.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n        <p>Uploader: ");
#nullable restore
#line 35 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWIthSecurity\ImageSharingWIthSecurity\Views\Images\Delete.cshtml"
                Write(Model.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\r\n        <p>\r\n            <input type=\"submit\" value=\"Confirm Delete\" />\r\n        </p>\r\n    </fieldset>\r\n\r\n    <p>");
#nullable restore
#line 42 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWIthSecurity\ImageSharingWIthSecurity\Views\Images\Delete.cshtml"
  Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e607f9ec98d0d615d48b1ba168199ccdfab07c512410", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 43 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWIthSecurity\ImageSharingWIthSecurity\Views\Images\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ImageSharingWithSecurity.Models.ImageView> Html { get; private set; }
    }
}
#pragma warning restore 1591