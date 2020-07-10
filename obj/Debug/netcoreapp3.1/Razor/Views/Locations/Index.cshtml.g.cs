#pragma checksum "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Locations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea9d0f2ccd9016cf73d9eb1af3ec8ef25b229a40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Locations_Index), @"mvc.1.0.view", @"/Views/Locations/Index.cshtml")]
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
#line 1 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\_ViewImports.cshtml"
using Crunch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\_ViewImports.cshtml"
using Crunch.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\_ViewImports.cshtml"
using Crunch.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea9d0f2ccd9016cf73d9eb1af3ec8ef25b229a40", @"/Views/Locations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a13b96ed4794bec2fae1a69c0ba5e842643c7752", @"/Views/_ViewImports.cshtml")]
    public class Views_Locations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChangeGymViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/locations.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Locations\Index.cshtml"
  
    ViewData["Title"] = "Locations";
    if (ViewData["Layout"] != null)
        Layout = ViewData["Layout"].ToString();


#line default
#line hidden
#nullable disable
            WriteLiteral("<section id=\"locations\">\r\n    <div class=\"header\">\r\n        <h1>Find a Crunch Gym Near You</h1>\r\n        <div class=\"search\">\r\n            <input class=\"custom-selector\" type=\"text\" autocomplete=\"off\"");
            BeginWriteAttribute("name", " name=\"", 360, "\"", 367, 0);
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Filter by State/Province\">\r\n            <ul class=\"custom-options hidden\">\r\n");
#nullable restore
#line 14 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Locations\Index.cshtml"
                 foreach (Gym gym in Model.gyms)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 16 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Locations\Index.cshtml"
                   Write(gym.gymLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 17 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Locations\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n\r\n            <i class=\"fas fa-chevron-down \"></i>\r\n        </div>\r\n    </div>\r\n    <hr>\r\n\r\n    <div class=\"locations \">\r\n");
#nullable restore
#line 26 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Locations\Index.cshtml"
         foreach (Gym gym in Model.gyms)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"location \">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ea9d0f2ccd9016cf73d9eb1af3ec8ef25b229a405883", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 850, "~/image/Location/", 850, 17, true);
#nullable restore
#line 29 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Locations\Index.cshtml"
AddHtmlAttributeValue("", 867, gym.image, 867, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <h2>");
#nullable restore
#line 30 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Locations\Index.cshtml"
               Write(gym.gymLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>");
#nullable restore
#line 31 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Locations\Index.cshtml"
              Write(gym.gymAdress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>");
#nullable restore
#line 32 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Locations\Index.cshtml"
              Write(gym.gymNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"xmiles-away\">12 miles away</p>\r\n            </div>\r\n");
#nullable restore
#line 35 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Locations\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</section>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea9d0f2ccd9016cf73d9eb1af3ec8ef25b229a408529", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChangeGymViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591