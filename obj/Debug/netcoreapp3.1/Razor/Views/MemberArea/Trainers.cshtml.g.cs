#pragma checksum "C:\Users\Turqay\Desktop\Crunch\Views\MemberArea\Trainers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23e2f6a6dd705f9b4beacf3d13e4b5bb1f314059"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23e2f6a6dd705f9b4beacf3d13e4b5bb1f314059", @"/Views/MemberArea/Trainers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a13b96ed4794bec2fae1a69c0ba5e842643c7752", @"/Views/_ViewImports.cshtml")]
    public class Views_MemberArea_Trainers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrainerViewModel>
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
#line 2 "C:\Users\Turqay\Desktop\Crunch\Views\MemberArea\Trainers.cshtml"
  
    ViewData["Title"] = "Trainers";
    Layout = "~/Views/Shared/ViewModelLayout.cshtml";

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
#line 17 "C:\Users\Turqay\Desktop\Crunch\Views\MemberArea\Trainers.cshtml"
                 foreach (Trainer t in Model.trainers)
                {
                    String[] specialities = t.Speciality.Split('|');

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"trainer\">\r\n                        <div class=\"top\">\r\n                            <div class=\"circle\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23e2f6a6dd705f9b4beacf3d13e4b5bb1f3140594918", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 982, "~/image/Trainers/", 982, 17, true);
#nullable restore
#line 23 "C:\Users\Turqay\Desktop\Crunch\Views\MemberArea\Trainers.cshtml"
AddHtmlAttributeValue("", 999, t.image, 999, 8, false);

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
#line 28 "C:\Users\Turqay\Desktop\Crunch\Views\MemberArea\Trainers.cshtml"
                                            Write(t.fullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p class=\"specialities\">Speciality Areas:</p>\r\n");
#nullable restore
#line 30 "C:\Users\Turqay\Desktop\Crunch\Views\MemberArea\Trainers.cshtml"
                                 foreach (String s in specialities)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>");
#nullable restore
#line 32 "C:\Users\Turqay\Desktop\Crunch\Views\MemberArea\Trainers.cshtml"
                                  Write(s);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 33 "C:\Users\Turqay\Desktop\Crunch\Views\MemberArea\Trainers.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <div class=\"foot\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1631, "\"", 1704, 1);
#nullable restore
#line 36 "C:\Users\Turqay\Desktop\Crunch\Views\MemberArea\Trainers.cshtml"
WriteAttributeValue("", 1638, Url.ActionLink("AboutTrainer","MemberArea",new{ trainerID=t.ID }), 1638, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"trainer-info-a\">More info<i class=\"fas fa-chevron-right\"></i></a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 40 "C:\Users\Turqay\Desktop\Crunch\Views\MemberArea\Trainers.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrainerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
