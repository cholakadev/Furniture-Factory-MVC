#pragma checksum "C:\Users\gecho\Desktop\MentorMate - .Net\georgi-cholakov\.Net Track\Web-Security\FurnitureFactory-MVC-Project\FurnitureFactory-MVC-Project\Views\Orders\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eb34020cee4267777092d54b5db7dcfb5f73621"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Report), @"mvc.1.0.view", @"/Views/Orders/Report.cshtml")]
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
#line 1 "C:\Users\gecho\Desktop\MentorMate - .Net\georgi-cholakov\.Net Track\Web-Security\FurnitureFactory-MVC-Project\FurnitureFactory-MVC-Project\Views\_ViewImports.cshtml"
using FurnitureFactory_MVC_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gecho\Desktop\MentorMate - .Net\georgi-cholakov\.Net Track\Web-Security\FurnitureFactory-MVC-Project\FurnitureFactory-MVC-Project\Views\_ViewImports.cshtml"
using FurnitureFactory_MVC_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eb34020cee4267777092d54b5db7dcfb5f73621", @"/Views/Orders/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0dbb9c1fd5717f4906c11e55a2131a915530f68", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FurnitureFactory_MVC_Project.Models.ViewModels.OrderReport>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\gecho\Desktop\MentorMate - .Net\georgi-cholakov\.Net Track\Web-Security\FurnitureFactory-MVC-Project\FurnitureFactory-MVC-Project\Views\Orders\Report.cshtml"
  
    ViewData["Title"] = "Report";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Report</h1>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 12 "C:\Users\gecho\Desktop\MentorMate - .Net\georgi-cholakov\.Net Track\Web-Security\FurnitureFactory-MVC-Project\FurnitureFactory-MVC-Project\Views\Orders\Report.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 15 "C:\Users\gecho\Desktop\MentorMate - .Net\georgi-cholakov\.Net Track\Web-Security\FurnitureFactory-MVC-Project\FurnitureFactory-MVC-Project\Views\Orders\Report.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 18 "C:\Users\gecho\Desktop\MentorMate - .Net\georgi-cholakov\.Net Track\Web-Security\FurnitureFactory-MVC-Project\FurnitureFactory-MVC-Project\Views\Orders\Report.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 24 "C:\Users\gecho\Desktop\MentorMate - .Net\georgi-cholakov\.Net Track\Web-Security\FurnitureFactory-MVC-Project\FurnitureFactory-MVC-Project\Views\Orders\Report.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 28 "C:\Users\gecho\Desktop\MentorMate - .Net\georgi-cholakov\.Net Track\Web-Security\FurnitureFactory-MVC-Project\FurnitureFactory-MVC-Project\Views\Orders\Report.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 31 "C:\Users\gecho\Desktop\MentorMate - .Net\georgi-cholakov\.Net Track\Web-Security\FurnitureFactory-MVC-Project\FurnitureFactory-MVC-Project\Views\Orders\Report.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 34 "C:\Users\gecho\Desktop\MentorMate - .Net\georgi-cholakov\.Net Track\Web-Security\FurnitureFactory-MVC-Project\FurnitureFactory-MVC-Project\Views\Orders\Report.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 37 "C:\Users\gecho\Desktop\MentorMate - .Net\georgi-cholakov\.Net Track\Web-Security\FurnitureFactory-MVC-Project\FurnitureFactory-MVC-Project\Views\Orders\Report.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4eb34020cee4267777092d54b5db7dcfb5f736217620", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FurnitureFactory_MVC_Project.Models.ViewModels.OrderReport>> Html { get; private set; }
    }
}
#pragma warning restore 1591