#pragma checksum "C:\Users\Turqay\source\repos\Crunch\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6218890784256a2669a8a6169d6a6ca78c6f1c3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6218890784256a2669a8a6169d6a6ca78c6f1c3d", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b420a4532370448e633cf30dee0c22889d4e17", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/navbar.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/login.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6218890784256a2669a8a6169d6a6ca78c6f1c3d4770", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <!-- MY CSS -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6218890784256a2669a8a6169d6a6ca78c6f1c3d5169", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <!-- FONT AWESOME -->
    <script src=""https://kit.fontawesome.com/e3658e79d2.js"" crossorigin=""anonymous""></script>
    <!-- GOOGLE FONTS -->
    <link href=""https://fonts.googleapis.com/css?family=Roboto+Mono&display=swap"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Roboto+Condensed&display=swap"" rel=""stylesheet"">
    <!-- JQUERY -->
    <script src=""https://code.jquery.com/jquery-3.4.1.min.js"" integrity=""sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo="" crossorigin=""anonymous""></script>
    <title>Document</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6218890784256a2669a8a6169d6a6ca78c6f1c3d7640", async() => {
                WriteLiteral("\r\n\r\n    <nav>\r\n        <div class=\"flex\">\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 862, "\"", 869, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"logo\">\r\n                <img class=\"menu-bar__logo\" alt=\"Crunch Logo\" src=\"https://d2l0v8ee8pblzo.cloudfront.net/assets/core/logo-f0321dadbee0b6b8ec6d98159305c76e56590ff97a88d28d4eb2400b3baafe49.svg\">\r\n            </a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1109, "\"", 1116, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"1\">LOCATIONS</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1154, "\"", 1161, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"2\">CLASSES</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1197, "\"", 1204, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"3\">HIITZONE</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1241, "\"", 1248, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"4\">TRANING</a>\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 1284, "\"", 1291, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""5"">ABOUT</a>
            <div class=""lang_picker flex"">
                <img class=""flag"" src=""https://dj7w0h47bhjwk.cloudfront.net/assets/core/flags/en-07772f1861e8e765c83be31bb1af70a23ecf038fc73041705d6f67f26ae4521a.png"" alt=""En"">
                <h2>EN</h2>
                <i class=""fas fa-sort-down""></i>
                <ul class=""chooser"">
                    <li class=""opened"">
                        <a>
                            <img class=""flag"" src=""https://dj7w0h47bhjwk.cloudfront.net/assets/core/flags/en-07772f1861e8e765c83be31bb1af70a23ecf038fc73041705d6f67f26ae4521a.png"" alt=""En"">
                            <p class=""lang_long_name"">United States</p>
                            <p class=""arrow""></p>
                        </a>
                        <ul class=""sub_chooser"">
                            <li>
                                <a href=""/about?locale=en"">
                                    <p class=""lang_long_name"">English</p>
                                ");
                WriteLiteral(@"</a>
                            </li>
                            <li>
                                <a href=""/about?locale=es"">
                                    <p class=""lang_long_name"">Spanish</p>
                                </a>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <a href=""https://www.crunch.com.au/"" target=""_blank"">
                            <img class=""flag"" src=""https://dj7w0h47bhjwk.cloudfront.net/assets/core/flags/en-AU-11a08e93915063e28b9bf32ea439cce104d97c8b5c809f012656950d750b2337.png"" alt=""En au"">
                            <p class=""lang_long_name"">Australia</p>
                        </a>
                    </li>
                    <li>
                        <a href=""https://www.crunchfitness.ca"" target=""_blank"">
                            <img class=""flag"" src=""https://dj7w0h47bhjwk.cloudfront.net/assets/core/flags/en-CA-a47ac4281a264334d74288c85c70de4bb1f7");
                WriteLiteral(@"cb6439f5b2156bcde5e365b44fd7.png"" alt=""En ca"">
                            <p class=""lang_long_name"">Canada</p>
                        </a>
                    </li>
                    <li>
                        <a>
                            <img class=""flag"" src=""https://dj7w0h47bhjwk.cloudfront.net/assets/core/flags/es-cr-ba792778a97c8236d38a8d164c5bee2c10e439c12b0a977ce454f56896e3ab02.png"" alt=""Es cr"">
                            <p class=""lang_long_name"">Costa Rica</p>
                            <p class=""arrow""></p>
                        </a>
                        <ul class=""sub_chooser"">
                            <li>
                                <a href=""/about?locale=es-cr"">
                                    <p class=""lang_long_name"">Spanish</p>
                                </a>
                            </li>
                        </ul>
                    </li>
                    <li>
                        <a href=""https://cr7crunch.fitness/es"" target=""");
                WriteLiteral(@"_blank"">
                            <img class=""flag"" src=""https://dj7w0h47bhjwk.cloudfront.net/assets/core/flags/es-8b91bd57e960c9078897020e6e0b09db748c562f96849a91e29d079f95143e49.png"" alt=""Es"">
                            <p class=""lang_long_name"">Spain</p>
                        </a>
                    </li>
                </ul>
            </div>
            <a id=""free-trial""");
                BeginWriteAttribute("href", " href=\"", 4759, "\"", 4803, 1);
#nullable restore
#line 89 "C:\Users\Turqay\source\repos\Crunch\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4766, Url.ActionLink("Register","Account"), 4766, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">FREE TRIAL</a>\r\n            <a id=\"join\"");
                BeginWriteAttribute("href", "  href=\"", 4845, "\"", 4887, 1);
#nullable restore
#line 90 "C:\Users\Turqay\source\repos\Crunch\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4853, Url.ActionLink("Login","Account"), 4853, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">JOIN</a>\r\n        </div>\r\n    </nav>\r\n\r\n    \r\n\r\n   \r\n\r\n    ");
#nullable restore
#line 98 "C:\Users\Turqay\source\repos\Crunch\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <footer>
        <div class=""footer-wrapper flex"">
            <div class=""left"">
                <div class=""icons"">
                    <i class=""fab fa-facebook-f""></i>
                    <i class=""fab fa-instagram""></i>
                    <i class=""fab fa-twitter""></i>
                    <i class=""fab fa-youtube""></i>
                </div>
                <p>© CRUNCH FITNESS</p>
                <p id=""grey"">ALL RIGHTS RESERVED</p>
            </div>
            <div class=""right"">
                <p>FREE TRIAL</p>
                <p id=""grey"">
                    OWN A CRUNCH • CONTACT • FAQ • CORPORATE MEMBERSHIPS • CAREERS • TERMS OF USE • PRIVACY • POLICY
                </p>
            </div>

        </div>
    </footer>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6218890784256a2669a8a6169d6a6ca78c6f1c3d14837", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6218890784256a2669a8a6169d6a6ca78c6f1c3d15937", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n</html>");
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
