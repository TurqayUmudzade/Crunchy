#pragma checksum "C:\Users\Turqay\Desktop\Crunch\Views\PartialViews\PromoStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb68680760c3210b489bc31598911a72dc45906c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PartialViews_PromoStatus), @"mvc.1.0.view", @"/Views/PartialViews/PromoStatus.cshtml")]
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
#line 1 "C:\Users\Turqay\Desktop\Crunch\Views\_ViewImports.cshtml"
using Crunch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Turqay\Desktop\Crunch\Views\_ViewImports.cshtml"
using Crunch.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Turqay\Desktop\Crunch\Views\_ViewImports.cshtml"
using Crunch.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb68680760c3210b489bc31598911a72dc45906c", @"/Views/PartialViews/PromoStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a13b96ed4794bec2fae1a69c0ba5e842643c7752", @"/Views/_ViewImports.cshtml")]
    public class Views_PartialViews_PromoStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Promocode>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Turqay\Desktop\Crunch\Views\PartialViews\PromoStatus.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"error\">This promocode does not exist or has expired</div>\r\n");
#nullable restore
#line 7 "C:\Users\Turqay\Desktop\Crunch\Views\PartialViews\PromoStatus.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"accepted\">");
#nullable restore
#line 10 "C:\Users\Turqay\Desktop\Crunch\Views\PartialViews\PromoStatus.cshtml"
                     Write(Model.discountPercent);

#line default
#line hidden
#nullable disable
            WriteLiteral("% discount will be applied on checkout </div>\r\n");
#nullable restore
#line 11 "C:\Users\Turqay\Desktop\Crunch\Views\PartialViews\PromoStatus.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Promocode> Html { get; private set; }
    }
}
#pragma warning restore 1591
