#pragma checksum "E:\exam\gdcp-frontend\gdcp.App\gdcp.App\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed5d6979829567dfc2b52f282919d029fa32a777"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "E:\exam\gdcp-frontend\gdcp.App\gdcp.App\Views\_ViewImports.cshtml"
using gdcp.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\exam\gdcp-frontend\gdcp.App\gdcp.App\Views\_ViewImports.cshtml"
using gdcp.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed5d6979829567dfc2b52f282919d029fa32a777", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"216f6758fbfbdbea67ee40a7b3aa2c1bc6f4a714", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/c3.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/d3.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/c3.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ed5d6979829567dfc2b52f282919d029fa32a7774434", async() => {
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
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""panel panel-headline"" style=""        border-top: 0px solid #3A9259;"">

                <div class=""panel-heading"">
                    <h3 class=""panel-title"" style=""flex: 4;"">Welcome to GDCP Dashboard</h3>

                </div>

            </div>
        </div>
    </div>

    <div class=""row"">

        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""panel panel-headline"" style=""border-top: 5px solid #3A9259;height:423px;padding-top: 42px;"">

                        <div class=""panel-body"">
                            <div class=""row"">
                                <div id=""summaryChart"" style=""height:438px; width:99%;"">
                                    <div id=""donut""></div>
                                </div>
                            </div>

                        </div>

");
            WriteLiteral(@"                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""panel panel-headline"" style=""padding-top: 25px;border-top: 5px solid #e55353; height: 423px;"">

                        <div class=""panel-body"">
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""metric"" style=""        background: #39f;
        color: #fff;"">
                                        <span class=""icon""><i class=""fa fa-bookmark""></i></span>
                                        <p>
                                            <span class=""number"" id=""actsDom"">19</span>
                                            <span class=""title"" style=""text-decoration: none;"">Approved of Schools</span>
                                        </p>
                                    </div>
                                </div>
                                <div class=""col-md");
            WriteLiteral(@"-6"">
                                    <div class=""metric"" style=""        background: #e55353;
        color: #fff;"">
                                        <span class=""icon""><i class=""fa fa-h-square""></i></span>
                                        <p>
                                            <span class=""number"" id=""deathsDom"">183</span>
                                            <span class=""title"" style=""text-decoration: none;"">Submitted Schools</span>
                                        </p>
                                    </div>
                                </div>

                            </div>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""metric"" style=""        background: #f9b115;
        color: #fff;"">
                                        <span class=""icon""><i class=""fa fa-eraser""></i></span>
                                        <p>
                ");
            WriteLiteral(@"                            <span class=""number"" id=""injuriesDom"">1</span>
                                            <span class=""title"" style=""text-decoration: none;"">Number Errors</span>
                                        </p>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""metric"" style=""        background: #321fdb;
        color: #fff;"">
                                        <span class=""icon""><i class=""fa fa-male""></i></span>
                                        <p>
                                            <span class=""number"" id=""perpetratorsDom"">20</span>
                                            <span class=""title"" style=""text-decoration: none;"">Number of Countries</span>
                                        </p>
                                    </div>
                                </div>
                            </div>
   ");
            WriteLiteral(@"                         <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""metric"" style=""        background: #39f;
        color: #fff;"">
                                        <span class=""icon""><i class=""fa fa-bookmark""></i></span>
                                        <p>
                                            <span class=""number"" id=""actsDom"">19</span>
                                            <span class=""title"" style=""text-decoration: none;"">Total Regions</span>
                                        </p>
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""metric"" style=""        background: #e55353;
        color: #fff;"">
                                        <span class=""icon""><i class=""fa fa-h-square""></i></span>
                                        <p>
               ");
            WriteLiteral(@"                             <span class=""number"" id=""deathsDom"">183</span>
                                            <span class=""title"" style=""text-decoration: none;"">System Performance</span>
                                        </p>
                                    </div>
                                </div>

                            </div>

                        </div>
                    </div>
                </div>
            </div>

        </div>


    </div>
    <div class=""row"">
        <div class=""container-fluid"">
            <div class=""panel panel-headline"" style=""        border-top: 5px solid #39f;"">

                <div class=""panel-body"">
                    <div class=""row"">
                        <div id=""line"" style=""height:400px;padding-top:20px""></div>

                    </div>

                </div>

            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""container-fluid"">
            <div class=""pan");
            WriteLiteral(@"el panel-headline"" style=""        border-top: 5px solid #e55353;"">

                <div class=""panel-body"">
                    <div class=""row"">
                        <div id=""bar"" style=""height:400px; padding-top:20px;""></div>

                    </div>

                </div>

            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""container-fluid"">
            <div class=""panel panel-headline"" style=""        border-top: 5px solid #f9b115;"">

                <div class=""panel-body"">
                    <div class=""row"">
                        <div id=""area"" style=""height:400px; padding-top:20px;""></div>
                    </div>

                </div>

            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""container-fluid"">
            <div class=""panel panel-headline"" style=""        border-top: 5px solid #f9b115;"">

                <div class=""panel-body"">
                    <div class=""row"">
          ");
            WriteLiteral("              <div id=\"multi\" style=\"height:400px; padding-top:20px;\"></div>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed5d6979829567dfc2b52f282919d029fa32a77713376", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed5d6979829567dfc2b52f282919d029fa32a77714416", async() => {
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
            WriteLiteral(@"
<script>
    var chart = c3.generate({
        bindto: ""#donut"",
        data: {
            columns: [
                ['data1', 30],
                ['data2', 120],
            ],
            type: 'donut',
            onclick: function (d, i) { console.log(""onclick"", d, i); },
            onmouseover: function (d, i) { console.log(""onmouseover"", d, i); },
            onmouseout: function (d, i) { console.log(""onmouseout"", d, i); }
        },
        donut: {
            title: ""School Information""
        }
    });

    setTimeout(function () {
        chart.load({
            columns: [
                [""setosa"", 0.2, 0.2, 0.2, 0.2, 0.2, 0.4, 0.3, 0.2, 0.2, 0.1, 0.2, 0.2, 0.1, 0.1, 0.2, 0.4, 0.4, 0.3, 0.3, 0.3, 0.2, 0.4, 0.2, 0.5, 0.2, 0.2, 0.4, 0.2, 0.2, 0.2, 0.2, 0.4, 0.1, 0.2, 0.2, 0.2, 0.2, 0.1, 0.2, 0.2, 0.3, 0.3, 0.2, 0.6, 0.4, 0.3, 0.2, 0.2, 0.2, 0.2],
                [""versicolor"", 1.4, 1.5, 1.5, 1.3, 1.5, 1.3, 1.6, 1.0, 1.3, 1.4, 1.0, 1.5, 1.0, 1.4, 1.3, 1.4, 1.5, 1.0, 1.5, 1.1, 1.8, 1.3, 1.5,");
            WriteLiteral(@" 1.2, 1.3, 1.4, 1.4, 1.7, 1.5, 1.0, 1.1, 1.0, 1.2, 1.6, 1.5, 1.6, 1.5, 1.3, 1.3, 1.3, 1.2, 1.4, 1.2, 1.0, 1.3, 1.2, 1.3, 1.3, 1.1, 1.3],
                [""virginica"", 2.5, 1.9, 2.1, 1.8, 2.2, 2.1, 1.7, 1.8, 1.8, 2.5, 2.0, 1.9, 2.1, 2.0, 2.4, 2.3, 1.8, 2.2, 2.3, 1.5, 2.3, 2.0, 2.0, 1.8, 2.1, 1.8, 1.8, 1.8, 2.1, 1.6, 1.9, 2.0, 2.2, 1.5, 1.4, 2.3, 2.4, 1.8, 1.8, 2.1, 2.4, 2.3, 1.9, 2.3, 2.5, 2.3, 1.9, 2.0, 2.3, 1.8],
            ]
        });
    }, 1500);

    setTimeout(function () {
        chart.unload({
            ids: 'data1'
        });
        chart.unload({
            ids: 'data2'
        });
    }, 2500);


    var chart = c3.generate({
        bindto: '#bar',
        data: {
            columns: [
                ['data1', -30, 200, 200, 400, -150, 250],
                ['data2', 130, 100, -100, 200, -150, 50],
                ['data3', -230, 200, 200, -300, 250, 250]
            ],
            type: 'bar',
            groups: [
                ['data1', 'data2']
            ]
        },
        gri");
            WriteLiteral(@"d: {
            y: {
                lines: [{ value: 0 }]
            }
        }
    });



    var chart = c3.generate({
        bindto: '#line', 
        data: {
            columns: [
                ['data1', 30, 200, 100, 400, 150, 250],
                ['data2', 50, 20, 10, 40, 15, 25]
            ]
        }
    });

    setTimeout(function () {
        chart.load({
            columns: [
                ['data1', 230, 190, 300, 500, 300, 400]
            ]
        });
    }, 1000);



    var chart = c3.generate({
        bindto: '#area', 
        data: {
            columns: [
                ['data1', 300, 350, 300, 0, 0, 120],
                ['data2', 130, 100, 140, 200, 150, 50]
            ],
            types: {
                data1: 'area-spline',
                data2: 'area-spline'
                // 'line', 'spline', 'step', 'area', 'area-step' are also available to stack
            },
            groups: [['data1', 'data2']]
        }
    });

    var chart = c3.generate({
        bin");
            WriteLiteral(@"dto:'#multi',
        data: {
            xs: {
                setosa: 'setosa_x',
                versicolor: 'versicolor_x',
            },
            // iris data from R
            columns: [
                [""setosa_x"", 3.5, 3.0, 3.2, 3.1, 3.6, 3.9, 3.4, 3.4, 2.9, 3.1, 3.7, 3.4, 3.0, 3.0, 4.0, 4.4, 3.9, 3.5, 3.8, 3.8, 3.4, 3.7, 3.6, 3.3, 3.4, 3.0, 3.4, 3.5, 3.4, 3.2, 3.1, 3.4, 4.1, 4.2, 3.1, 3.2, 3.5, 3.6, 3.0, 3.4, 3.5, 2.3, 3.2, 3.5, 3.8, 3.0, 3.8, 3.2, 3.7, 3.3],
                [""versicolor_x"", 3.2, 3.2, 3.1, 2.3, 2.8, 2.8, 3.3, 2.4, 2.9, 2.7, 2.0, 3.0, 2.2, 2.9, 2.9, 3.1, 3.0, 2.7, 2.2, 2.5, 3.2, 2.8, 2.5, 2.8, 2.9, 3.0, 2.8, 3.0, 2.9, 2.6, 2.4, 2.4, 2.7, 2.7, 3.0, 3.4, 3.1, 2.3, 3.0, 2.5, 2.6, 3.0, 2.6, 2.3, 2.7, 3.0, 2.9, 2.9, 2.5, 2.8],
                [""setosa"", 0.2, 0.2, 0.2, 0.2, 0.2, 0.4, 0.3, 0.2, 0.2, 0.1, 0.2, 0.2, 0.1, 0.1, 0.2, 0.4, 0.4, 0.3, 0.3, 0.3, 0.2, 0.4, 0.2, 0.5, 0.2, 0.2, 0.4, 0.2, 0.2, 0.2, 0.2, 0.4, 0.1, 0.2, 0.2, 0.2, 0.2, 0.1, 0.2, 0.2, 0.3, 0.3, 0.2, 0.6, 0.4, 0.3, 0.2, ");
            WriteLiteral(@"0.2, 0.2, 0.2],
                [""versicolor"", 1.4, 1.5, 1.5, 1.3, 1.5, 1.3, 1.6, 1.0, 1.3, 1.4, 1.0, 1.5, 1.0, 1.4, 1.3, 1.4, 1.5, 1.0, 1.5, 1.1, 1.8, 1.3, 1.5, 1.2, 1.3, 1.4, 1.4, 1.7, 1.5, 1.0, 1.1, 1.0, 1.2, 1.6, 1.5, 1.6, 1.5, 1.3, 1.3, 1.3, 1.2, 1.4, 1.2, 1.0, 1.3, 1.2, 1.3, 1.3, 1.1, 1.3],
            ],
            type: 'scatter'
        },
        axis: {
            x: {
                label: 'Sepal.Width',
                tick: {
                    fit: false
                }
            },
            y: {
                label: 'Petal.Width'
            }
        }
    });

    setTimeout(function () {
        chart.load({
            xs: {
                virginica: 'virginica_x'
            },
            columns: [
                [""virginica_x"", 3.3, 2.7, 3.0, 2.9, 3.0, 3.0, 2.5, 2.9, 2.5, 3.6, 3.2, 2.7, 3.0, 2.5, 2.8, 3.2, 3.0, 3.8, 2.6, 2.2, 3.2, 2.8, 2.8, 2.7, 3.3, 3.2, 2.8, 3.0, 2.8, 3.0, 2.8, 3.8, 2.8, 2.8, 2.6, 3.0, 3.4, 3.1, 3.0, 3.1, 3.1, 3.1, 2.7, 3.2, 3.3, 3.0, 2.5, 3.0, 3.4, 3.");
            WriteLiteral(@"0],
                [""virginica"", 2.5, 1.9, 2.1, 1.8, 2.2, 2.1, 1.7, 1.8, 1.8, 2.5, 2.0, 1.9, 2.1, 2.0, 2.4, 2.3, 1.8, 2.2, 2.3, 1.5, 2.3, 2.0, 2.0, 1.8, 2.1, 1.8, 1.8, 1.8, 2.1, 1.6, 1.9, 2.0, 2.2, 1.5, 1.4, 2.3, 2.4, 1.8, 1.8, 2.1, 2.4, 2.3, 1.9, 2.3, 2.5, 2.3, 1.9, 2.0, 2.3, 1.8],
            ]
        });
    }, 1000);

    setTimeout(function () {
        chart.unload({
            ids: 'setosa'
        });
    }, 2000);

    setTimeout(function () {
        chart.load({
            columns: [
                [""virginica"", 0.2, 0.2, 0.2, 0.2, 0.2, 0.4, 0.3, 0.2, 0.2, 0.1, 0.2, 0.2, 0.1, 0.1, 0.2, 0.4, 0.4, 0.3, 0.3, 0.3, 0.2, 0.4, 0.2, 0.5, 0.2, 0.2, 0.4, 0.2, 0.2, 0.2, 0.2, 0.4, 0.1, 0.2, 0.2, 0.2, 0.2, 0.1, 0.2, 0.2, 0.3, 0.3, 0.2, 0.6, 0.4, 0.3, 0.2, 0.2, 0.2, 0.2],
            ]
        });
    }, 3000);




</script>");
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
