#pragma checksum "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\MyBookings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bee286e619c952633f3c7a09ccd2c256eb253d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MemberArea_MyBookings), @"mvc.1.0.view", @"/Views/MemberArea/MyBookings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bee286e619c952633f3c7a09ccd2c256eb253d7", @"/Views/MemberArea/MyBookings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a13b96ed4794bec2fae1a69c0ba5e842643c7752", @"/Views/_ViewImports.cshtml")]
    public class Views_MemberArea_MyBookings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookClassViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/myBookings.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\MyBookings.cshtml"
  
    ViewData["Title"] = "My Bookings";
    Layout = "~/Views/Shared/ViewModelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""content "">
    <div class=""container80"">
        <h2 class=""heading"">My Bookings</h2>
        <div class=""table"">
            <div id=""myModal"" class=""modal"">
                <!-- Modal content -->
                <div class=""modal-content"">
                    <span class=""close"">&times;</span>
                    <h2 class=""header"">Confirm</h2>
                    <p>Are you sure you wanna cancel this class?</p>
                    <div class=""modal-buttons"">
                        <a class=""button cancel-yes"">Yes,Cancel</a>
                        <a id=""blue"" class=""button "">No</a>
                    </div>
                </div>
            </div>
            <table>
                <thead>
                    <tr>
                        <th>Date &amp; Time</th>
                        <th>Gym Name</th>
                        <th>Class Name</th>
                        <th id=""button-row"">Can't Attend?</th>
                    </tr>
                </thead>
      ");
            WriteLiteral("          <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\MyBookings.cshtml"
                     if (Model.classesTable.Count == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td colspan=\"4\">\r\n                                No bookings made\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\MyBookings.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\MyBookings.cshtml"
                     foreach (Class aClass in Model.classesTable)
                    {
                        if (DateTime.Compare(DateTime.Now, aClass.dateTime) == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 47 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\MyBookings.cshtml"
                               Write(aClass.dateTime.ToString("dd MMMM yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\MyBookings.cshtml"
                               Write(aClass.gym.gymLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\MyBookings.cshtml"
                               Write(aClass.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>Thanks for Joining!</td>\r\n                            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\MyBookings.cshtml"

                        }
                        else
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 58 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\MyBookings.cshtml"
                               Write(aClass.dateTime.ToString("dd MMMM yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 59 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\MyBookings.cshtml"
                               Write(aClass.gym.gymLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 60 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\MyBookings.cshtml"
                               Write(aClass.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 2370, "\"", 2442, 1);
#nullable restore
#line 61 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\MyBookings.cshtml"
WriteAttributeValue("", 2377, Url.Action("Cancel","MemberArea",new { ClassID=aClass.ClassID }), 2377, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"cancel-anchor modalButton\">Cancel</a></td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\MyBookings.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1bee286e619c952633f3c7a09ccd2c256eb253d79306", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookClassViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591