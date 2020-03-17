#pragma checksum "C:\Users\Turqay\source\repos\Crunch\Views\MemberArea\Trainers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed46be7b9c83f5aef9377d79d4c6188bbbb49751"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MemberArea_Trainers), @"mvc.1.0.view", @"/Views/MemberArea/Trainers.cshtml")]
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
#line 1 "C:\Users\Turqay\source\repos\Crunch\Views\_ViewImports.cshtml"
using Crunch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Turqay\source\repos\Crunch\Views\_ViewImports.cshtml"
using Crunch.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed46be7b9c83f5aef9377d79d4c6188bbbb49751", @"/Views/MemberArea/Trainers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b420a4532370448e633cf30dee0c22889d4e17", @"/Views/_ViewImports.cshtml")]
    public class Views_MemberArea_Trainers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Trainer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Turqay\source\repos\Crunch\Views\MemberArea\Trainers.cshtml"
  
    ViewData["Title"] = "Trainers";
    Layout = "~/Views/Shared/Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""content "">
    <div class=""container80"">
        <div class=""header"">
            <h2>Personal Trainers</h2>
        </div>
        <div class=""body trainer-body"">
            <p id=""top-p"">Meet the personal trainers team below who will help you achieve the results and goals you are looking for! To contact the personal trainer of your choice, simply click on the email address or give them a call. </p>
            <p id=""bottom-p"">We look forward to meeting you soon!</p>
            <div class=""trainers"">
");
#nullable restore
#line 17 "C:\Users\Turqay\source\repos\Crunch\Views\MemberArea\Trainers.cshtml"
                 foreach (Trainer t in Model)
                {
                    String[] specialities = t.Speciality.Split('|');

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"trainer\">\r\n                        <div class=\"top\">\r\n                            <div class=\"circle\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ed46be7b9c83f5aef9377d79d4c6188bbbb497514760", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 963, "~/image/", 963, 8, true);
#nullable restore
#line 23 "C:\Users\Turqay\source\repos\Crunch\Views\MemberArea\Trainers.cshtml"
AddHtmlAttributeValue("", 971, t.image, 971, 8, false);

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
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"bottom\">\r\n                            <div class=\"about\">\r\n                                <h3 class=\"name\">");
#nullable restore
#line 28 "C:\Users\Turqay\source\repos\Crunch\Views\MemberArea\Trainers.cshtml"
                                            Write(t.fullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p class=\"specialities\">Speciality Areas:</p>\r\n");
#nullable restore
#line 30 "C:\Users\Turqay\source\repos\Crunch\Views\MemberArea\Trainers.cshtml"
                                 foreach (String s in specialities) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <p>");
#nullable restore
#line 31 "C:\Users\Turqay\source\repos\Crunch\Views\MemberArea\Trainers.cshtml"
                               Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 32 "C:\Users\Turqay\source\repos\Crunch\Views\MemberArea\Trainers.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <div class=\"foot\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1567, "\"", 1640, 1);
#nullable restore
#line 35 "C:\Users\Turqay\source\repos\Crunch\Views\MemberArea\Trainers.cshtml"
WriteAttributeValue("", 1574, Url.ActionLink("AboutTrainer","MemberArea",new{ trainerID=t.ID }), 1574, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"trainer-info-a\">More info<i class=\"fas fa-chevron-right\"></i></a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 39 "C:\Users\Turqay\source\repos\Crunch\Views\MemberArea\Trainers.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Trainer>> Html { get; private set; }
    }
}
#pragma warning restore 1591