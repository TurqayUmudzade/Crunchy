#pragma checksum "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f3c30d78844123f75de25ee78eb2a52d3d405c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ClassInfo), @"mvc.1.0.view", @"/Views/Shared/ClassInfo.cshtml")]
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
#line 1 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
using Crunch.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f3c30d78844123f75de25ee78eb2a52d3d405c0", @"/Views/Shared/ClassInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a13b96ed4794bec2fae1a69c0ba5e842643c7752", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ClassInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookClassViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"calendar\">\r\n        <div class=\"tab-nav\">\r\n            <ul>\r\n");
#nullable restore
#line 6 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
                 for (int i = 0; i < 7; i++)
                {
                    String d = String.Concat("d", i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <a href=\"#!\"");
            BeginWriteAttribute("id", " id=\"", 317, "\"", 324, 1);
#nullable restore
#line 10 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
WriteAttributeValue("", 322, d, 322, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"js-toggle-day \">\r\n                            <span class=\"day\">");
#nullable restore
#line 11 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
                                         Write(DateTime.Today.AddDays(i).ToString("ddd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span class=\"date\">");
#nullable restore
#line 12 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
                                          Write(DateTime.Today.AddDays(i).Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 15 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <section>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
             for (int i = 0; i < 7; i++)
            {
                String a = String.Concat("a", i + 1);

                List<Class> classes = Model.classes.ElementAt(i);




#line default
#line hidden
#nullable disable
            WriteLiteral("                <article");
            BeginWriteAttribute("id", " id=\"", 877, "\"", 884, 1);
#nullable restore
#line 28 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
WriteAttributeValue("", 882, a, 882, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"active hidden\">\r\n                    <div class=\"class-container\">\r\n");
#nullable restore
#line 30 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
                         foreach (Class Aclass in classes)
                        {
                            String Status;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div");
            BeginWriteAttribute("class", " class=\"", 1124, "\"", 1151, 3);
            WriteAttributeValue("", 1132, "class", 1132, 5, true);
#nullable restore
#line 33 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
WriteAttributeValue(" ", 1137, Aclass.type, 1138, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1150, "", 1151, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"details\">\r\n                                    <div class=\"time-duration\">\r\n                                        <div class=\"time\">");
#nullable restore
#line 36 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
                                                     Write(Aclass.dateTime.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        <div class=\"duration\">");
#nullable restore
#line 37 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
                                                         Write(Aclass.duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" mins</div>\r\n                                    </div>\r\n                                    <h5 class=\"class-name \">");
#nullable restore
#line 39 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
                                                       Write(Aclass.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n");
#nullable restore
#line 41 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
                                     if (Aclass.space > Aclass.spaceUsed)
                                    {
                                        Status = "Available";
                                    }
                                    else
                                    {
                                        Status = "Full";
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p class=\"class-status\">");
#nullable restore
#line 49 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
                                                       Write(Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <div class=\"icon-container\">\r\n                                        <i");
            BeginWriteAttribute("class", " class=\"", 2169, "\"", 2189, 1);
#nullable restore
#line 51 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
WriteAttributeValue("", 2177, Aclass.icon, 2177, 12, false);

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
#line 61 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
                                   Write(Aclass.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                    <button class=\"button js-book-class\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2786, "\"", 2871, 1);
#nullable restore
#line 63 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
WriteAttributeValue("", 2796, Url.Action("BookTheClass", "MemberArea", new { ClassID = Aclass.ClassID }), 2796, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Book Now</button>\r\n\r\n                                    <div class=\"spaces\">\r\n                                        Available spaces:\r\n                                        <span class=\"available\">\r\n                                            ");
#nullable restore
#line 68 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
                                       Write(Aclass.spaceUsed);

#line default
#line hidden
#nullable disable
            WriteLiteral("/\r\n                                        </span>\r\n                                        <span class=\"total\">\r\n                                            ");
#nullable restore
#line 71 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
                                       Write(Aclass.space);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </span>
                                    </div>
                                </div>
                                <div class=""message hidden"">
                                    <span>Great, you are booked into this class.</span>
                                    <div class=""confirm-action arrow"">
                                        <input class=""check"" id=""booked-2"" type=""checkbox"">
                                        <label class=""action"" for=""booked-2"">Cancel booking</label>
                                        <span class=""confirm"" href=""#!"">Cancel booking</span>
                                        <a class=""yes js-cancel"" href=""#!"">YES</a>
                                        <label class=""no"" for=""booked-2"">NO</label>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 86 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </article>\r\n");
#nullable restore
#line 90 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\Shared\ClassInfo.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </section>\r\n    </div>");
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
