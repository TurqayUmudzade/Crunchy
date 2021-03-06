#pragma checksum "C:\Users\Turqay\Desktop\Crunch\Views\MyGym\AverageUsage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0b63c509b35f4daca61b50278eb78e008312abe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyGym_AverageUsage), @"mvc.1.0.view", @"/Views/MyGym/AverageUsage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0b63c509b35f4daca61b50278eb78e008312abe", @"/Views/MyGym/AverageUsage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a13b96ed4794bec2fae1a69c0ba5e842643c7752", @"/Views/_ViewImports.cshtml")]
    public class Views_MyGym_AverageUsage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Turqay\Desktop\Crunch\Views\MyGym\AverageUsage.cshtml"
  
    ViewData["Title"] = "Average Usage";

    Layout = "~/Views/Shared/_LayoutUser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""content "">
    <div class=""container80"">
        <div class=""header"">
            <h2>Average Usage</h2>
        </div>
        <div class=""body"">
            <h3 class=""sub-heading busy-message"">Your home gym is busiest between <span>5-6pm</span></h3>
            <canvas id=""myChart"" width=""400"" height=""400""></canvas>
            <script>
                Chart.defaults.global.legend.display = false;
                var ctx = document.getElementById('myChart').getContext('2d');
                var myChart = new Chart(ctx, {
                    type: 'line',
                    data: {
                        labels: ['2am', '4am', '6am', '8am', '10am', '12am', '2pm', '4pm', '6pm', '8pm', '10pm', '12pm'],
                        datasets: [{

                            data: [25, 13, 7, 5, 8, 15, 20, 26, 31, 25, 12, 8],
                            fill: false,
                            backgroundColor: [
                                'rgba(0, 159, 223, 1)'
                ");
            WriteLiteral(@"            ],
                            borderColor: [
                                'rgba(0, 159, 223, 1)'
                            ],
                            borderWidth: 1
                        }]
                    },
                    options: {
                        scales: {
                            yAxes: [{
                                ticks: {
                                    beginAtZero: true
                                }
                            }]
                        }
                    },
                    options: {
                        elements: {
                            line: {
                                tension: 0
                            }
                        }
                    },
                    options: {
                        scales: {
                            yAxes: [{
                                ticks: {
                                    max: 50,
                                 ");
            WriteLiteral(@"   min: 0,
                                    stepSize: 10
                                }
                            }]
                        }
                    }
                });
            </script>
            <div class=""my-gym"">
                <span class=""tick-c""></span>
                <span class=""gym-name"">");
#nullable restore
#line 68 "C:\Users\Turqay\Desktop\Crunch\Views\MyGym\AverageUsage.cshtml"
                                  Write(Model.gym.gymLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
