#pragma checksum "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWithCloudStorage\ImageSharingWithCloudStorage\Views\Images\ListAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65b2fcad427bf0400c4d1eb79edda09b85cd772c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Images_ListAll), @"mvc.1.0.view", @"/Views/Images/ListAll.cshtml")]
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
#line 1 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWithCloudStorage\ImageSharingWithCloudStorage\Views\_ViewImports.cshtml"
using ImageSharingWithCloudStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWithCloudStorage\ImageSharingWithCloudStorage\Views\_ViewImports.cshtml"
using ImageSharingWithCloudStorage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b2fcad427bf0400c4d1eb79edda09b85cd772c", @"/Views/Images/ListAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d97587848d85dcec025d373f7ac4c02f226bc9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Images_ListAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ImageSharingWithCloudStorage.Models.Image>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWithCloudStorage\ImageSharingWithCloudStorage\Views\Images\ListAll.cshtml"
  
    ViewBag.Title = "All Images";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWithCloudStorage\ImageSharingWithCloudStorage\Views\Images\ListAll.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<table>\r\n    <tr>\r\n        <th>Caption</th>\r\n        <th>Uploader</th>\r\n        <th>Tag</th>\r\n        <th>Actions</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWithCloudStorage\ImageSharingWithCloudStorage\Views\Images\ListAll.cshtml"
     foreach (var image in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 21 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWithCloudStorage\ImageSharingWithCloudStorage\Views\Images\ListAll.cshtml"
           Write(image.Caption);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWithCloudStorage\ImageSharingWithCloudStorage\Views\Images\ListAll.cshtml"
           Write(image.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWithCloudStorage\ImageSharingWithCloudStorage\Views\Images\ListAll.cshtml"
           Write(image.Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65b2fcad427bf0400c4d1eb79edda09b85cd772c5750", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWithCloudStorage\ImageSharingWithCloudStorage\Views\Images\ListAll.cshtml"
                                          WriteLiteral(image.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 32 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWithCloudStorage\ImageSharingWithCloudStorage\Views\Images\ListAll.cshtml"
                 if (ViewBag.UserName.Equals(image.User.UserName))
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <!-- TODO add Edit and Delete links -->\r\n\r\n                    ");
#nullable restore
#line 37 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWithCloudStorage\ImageSharingWithCloudStorage\Views\Images\ListAll.cshtml"
                           
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\ellio\git\Enterprise-Cloud-Computing-CS526\ImageSharingWithCloudStorage\ImageSharingWithCloudStorage\Views\Images\ListAll.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ImageSharingWithCloudStorage.Models.Image>> Html { get; private set; }
    }
}
#pragma warning restore 1591
