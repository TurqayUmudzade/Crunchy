#pragma checksum "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\PartialViews\CancelClass.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16c2083cb71bfb64f43c3e82f2b50d232f2f12cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PartialViews_CancelClass), @"mvc.1.0.view", @"/Views/PartialViews/CancelClass.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16c2083cb71bfb64f43c3e82f2b50d232f2f12cb", @"/Views/PartialViews/CancelClass.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a13b96ed4794bec2fae1a69c0ba5e842643c7752", @"/Views/_ViewImports.cshtml")]
    public class Views_PartialViews_CancelClass : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"modal-content\">\r\n    <span class=\"close\">&times;</span>\r\n    <h2 class=\"header\">Class Canceled!</h2>\r\n    <p>Your class was booking was succefully canceled.</p>\r\n    <div class=\"modal-buttons\">\r\n        <a class=\"button class-ok\"");
            BeginWriteAttribute("href", " href=", 241, "", 285, 1);
#nullable restore
#line 6 "C:\Users\Turqay\Desktop\Crunch\Backend\Crunch\Views\PartialViews\CancelClass.cshtml"
WriteAttributeValue("", 247, Url.Action("MyBookings","MemberArea"), 247, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Okay</a>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
