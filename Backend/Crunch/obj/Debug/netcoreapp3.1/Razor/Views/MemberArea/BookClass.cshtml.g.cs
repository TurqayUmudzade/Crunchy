#pragma checksum "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41ffe7758e1606c7b91685b1b57bc0744a59fbf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MemberArea_BookClass), @"mvc.1.0.view", @"/Views/MemberArea/BookClass.cshtml")]
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
#line 6 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
using Crunch.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41ffe7758e1606c7b91685b1b57bc0744a59fbf3", @"/Views/MemberArea/BookClass.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a13b96ed4794bec2fae1a69c0ba5e842643c7752", @"/Views/_ViewImports.cshtml")]
    public class Views_MemberArea_BookClass : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookClassViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/book-class.js "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
  
    ViewData["Title"] = "BookClass";
    Layout = "~/Views/Shared/ViewModelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content "">
    <div class=""container80"">
        <div class=""header"">
            <h2>Book a class</h2>
        </div>
        <div class=""body"">
            <div class=""my-gym"">
                <span class=""tick-c""></span>
                <span class=""gym-name"">");
#nullable restore
#line 16 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                                  Write(Model.user.gym.gymLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"classes\">\r\n                <div class=\"classes-header\">\r\n                    <h4>");
#nullable restore
#line 20 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                   Write(DateTime.Now.ToString("MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n                <div class=\"calendar\">\r\n                    <div class=\"tab-nav\">\r\n                        <ul>\r\n");
#nullable restore
#line 25 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                             for (int i = 0; i < 7; i++)
                            {
                                String d = String.Concat("d", i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    <a href=\"#!\"");
            BeginWriteAttribute("id", " id=\"", 1020, "\"", 1027, 1);
#nullable restore
#line 29 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
WriteAttributeValue("", 1025, d, 1025, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"js-toggle-day \">\r\n                                        <span class=\"day\">");
#nullable restore
#line 30 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                                                     Write(DateTime.Today.AddDays(i).ToString("ddd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span class=\"date\">");
#nullable restore
#line 31 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                                                      Write(DateTime.Today.AddDays(i).Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 34 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                    <section>\r\n\r\n");
#nullable restore
#line 39 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                         for (int i = 0; i < 7; i++)
                        {
                            String a = String.Concat("a", i + 1);

                            List<Class> classes = Model.classes.ElementAt(i);
                            String hidden = "hidden";
                            if (i == 0)
                            {
                                 hidden = "";
                            }
                            else
                            {
                                 hidden = "hidden";
                            }



#line default
#line hidden
#nullable disable
            WriteLiteral("                            <article");
            BeginWriteAttribute("id", " id=\"", 2088, "\"", 2095, 1);
#nullable restore
#line 55 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
WriteAttributeValue("", 2093, a, 2093, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2096, "\"", 2118, 2);
            WriteAttributeValue("", 2104, "active", 2104, 6, true);
#nullable restore
#line 55 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
WriteAttributeValue(" ", 2110, hidden, 2111, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"class-container\">\r\n");
#nullable restore
#line 57 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                                     foreach (Class Aclass in classes)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div");
            BeginWriteAttribute("class", " class=\"", 2340, "\"", 2367, 3);
            WriteAttributeValue("", 2348, "class", 2348, 5, true);
#nullable restore
#line 59 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
WriteAttributeValue(" ", 2353, Aclass.type, 2354, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2366, "", 2367, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"details\">\r\n                                                <div class=\"time-duration\">\r\n                                                    <div class=\"time\">");
#nullable restore
#line 62 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                                                                 Write(Aclass.dateTime.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                    <div class=\"duration\">");
#nullable restore
#line 63 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                                                                     Write(Aclass.duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" mins</div>\r\n                                                </div>\r\n                                                <h5 class=\"class-name \">");
#nullable restore
#line 65 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                                                                   Write(Aclass.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n");
#nullable restore
#line 67 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                                                 if (Aclass.space > Aclass.spaceUsed)
                                                {
                                                    Aclass.Status = "Available";
                                                }
                                                else
                                                {
                                                    Aclass.Status = "Full";
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p class=\"class-status\">");
#nullable restore
#line 75 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                                                                   Write(Aclass.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                <div class=\"icon-container\">\r\n                                                    <i");
            BeginWriteAttribute("class", " class=\"", 3610, "\"", 3630, 1);
#nullable restore
#line 77 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
WriteAttributeValue("", 3618, Aclass.icon, 3618, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></i>
                                                </div>
                                            </div>

                                            <a href=""#!"" class=""js-change-trigger icon-plus"">

                                                <i class=""fas fa-plus""></i>
                                            </a>
                                            <div class=""actions js-actions hidden"">
                                                <p class=""class-description"">
                                                    ");
#nullable restore
#line 87 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                                               Write(Aclass.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </p>
                                                <a id=""modalButton"" class=""button js-book-class"">Book Now</a>

                                                <div id=""myModal"" class=""modal"">

                                                    <!-- Modal content -->
                                                    <div class=""modal-content"">
                                                        <span class=""close"">&times;</span>
                                                        <h2 class=""header"">Confirm</h2>
                                                        <p>Confirm joining this class?</p>
                                                        <div class=""modal-buttons"">
                                                            <a class=""button class-yes""");
            BeginWriteAttribute("href", " href=\"", 5062, "\"", 5140, 1);
#nullable restore
#line 99 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
WriteAttributeValue("", 5069, Url.Action("BookTheClass","MemberArea",new { ClassID=Aclass.ClassID }), 5069, 71, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Yes</a>
                                                            <a id=""blue"" class=""button"">No</a>
                                                        </div>
                                                    </div>

                                                </div>
                                                <div class=""spaces"">
                                                    Available spaces:
                                                    <span class=""available"">
                                                        ");
#nullable restore
#line 108 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                                                   Write(Aclass.spaceUsed);

#line default
#line hidden
#nullable disable
            WriteLiteral("/\r\n                                                    </span>\r\n                                                    <span class=\"total\">\r\n                                                        ");
#nullable restore
#line 111 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                                                   Write(Aclass.space);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </span>
                                                </div>
                                            </div>
                                            <div class=""message hidden"">

                                            </div>
                                        </div>
");
#nullable restore
#line 119 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </article>\r\n");
#nullable restore
#line 123 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\MemberArea\BookClass.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </section>\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41ffe7758e1606c7b91685b1b57bc0744a59fbf316863", async() => {
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
