#pragma checksum "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\Transport\Routes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa27f180e71b3e62c1facf1fb25a994cd5756eaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transport_Routes), @"mvc.1.0.view", @"/Views/Transport/Routes.cshtml")]
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
#line 1 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\_ViewImports.cshtml"
using TransportManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\_ViewImports.cshtml"
using TransportManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa27f180e71b3e62c1facf1fb25a994cd5756eaa", @"/Views/Transport/Routes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe9946fe7761a0482095b28c1168e6a3884b3c2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Transport_Routes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TransportManagementSystem.Models.Route>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\Transport\Routes.cshtml"
  
    ViewData["Title"] = "Routes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Routes</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa27f180e71b3e62c1facf1fb25a994cd5756eaa4120", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa27f180e71b3e62c1facf1fb25a994cd5756eaa5277", async() => {
                WriteLiteral("Log Out");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\Transport\Routes.cshtml"
           Write(Html.DisplayNameFor(model => model.RouteNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\Transport\Routes.cshtml"
           Write(Html.DisplayNameFor(model => model.VehicleNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\Transport\Routes.cshtml"
           Write(Html.DisplayNameFor(model => model.Stop1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\Transport\Routes.cshtml"
           Write(Html.DisplayNameFor(model => model.Stop2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\Transport\Routes.cshtml"
           Write(Html.DisplayNameFor(model => model.Stop3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\Transport\Routes.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\Transport\Routes.cshtml"
           Write(Html.DisplayFor(modelItem => item.RouteNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\Transport\Routes.cshtml"
           Write(Html.DisplayFor(modelItem => item.VehicleNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\Transport\Routes.cshtml"
           Write(Html.DisplayFor(modelItem => item.Stop1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\Transport\Routes.cshtml"
           Write(Html.DisplayFor(modelItem => item.Stop2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\Transport\Routes.cshtml"
           Write(Html.DisplayFor(modelItem => item.Stop3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\Transport\Routes.cshtml"
           Write(Html.ActionLink("Edit", "EditRoute", new {  RouteNumber=item.RouteNumber  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |              \r\n                ");
#nullable restore
#line 54 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\Transport\Routes.cshtml"
           Write(Html.ActionLink("Delete", "DeleteRoute", new { RouteNumber = item.RouteNumber }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "H:\Softura\Project A\TransportManagementSolution\TransportManagementSystem\Views\Transport\Routes.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TransportManagementSystem.Models.Route>> Html { get; private set; }
    }
}
#pragma warning restore 1591
