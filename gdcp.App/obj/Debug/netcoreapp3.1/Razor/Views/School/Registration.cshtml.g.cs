#pragma checksum "E:\exam\gdcp-frontend\gdcp.App\gdcp.App\Views\School\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e513fb2b882c88bfdb9efe40a223e3e5dde49e23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_School_Registration), @"mvc.1.0.view", @"/Views/School/Registration.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e513fb2b882c88bfdb9efe40a223e3e5dde49e23", @"/Views/School/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"216f6758fbfbdbea67ee40a7b3aa2c1bc6f4a714", @"/Views/_ViewImports.cshtml")]
    public class Views_School_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bd-wizard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.steps.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bd-wizard.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://cdn.materialdesignicons.com/4.8.95/css/materialdesignicons.min.css\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e513fb2b882c88bfdb9efe40a223e3e5dde49e234626", async() => {
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

<link rel=""stylesheet"" href=""assets/css/bd-wizard.css"">
<div class=""container-fluid"" style=""width:90%;"">
    <div id=""wizard"">
        <h3>
            <div class=""media"">
                <div class=""bd-wizard-step-icon""><i class=""mdi mdi-account-outline""></i></div>
                <div class=""media-body"">
                    <div class=""bd-wizard-step-title"">School Information</div>
                    <div class=""bd-wizard-step-subtitle"">Step 1</div>
                </div>
            </div>
        </h3>
        <section>
            <div class=""content-wrapper"">
                <h4 class=""section-heading"">Enter your School details </h4>
                <div class=""row"">
                    <div class=""form-group col-md-12"">
                        <h5 class=""section-heading mb-5"">School Name</h5>
                        <input type=""text"" name=""firstName"" id=""firstName"" class=""form-control"" placeholder=""School Name"">
                    </div>

                </div>
            ");
            WriteLiteral(@"    <div class=""row"">
                    <div class=""form-group col-md-12"">
                        <h5 class=""section-heading mb-5"">Are you at the school right now?</h5>
                        <input type=""radio"" id=""yes"" name=""school"" value=""yes"">
                        <label for=""yes"">Yes</label><br>
                        <input type=""radio"" id=""no"" name=""school"" value=""no"">
                        <label for=""no"">No</label><br>

                    </div>
                </div>
            </div>
        </section>
        <h3>
            <div class=""media"">
                <div class=""bd-wizard-step-icon""><i class=""mdi mdi-bank""></i></div>
                <div class=""media-body"">

                    <div class=""bd-wizard-step-title"">Internet Details</div>
                    <div class=""bd-wizard-step-subtitle"">Step 2</div>
                </div>
            </div>
        </h3>
        <section>
            <div class=""content-wrapper"">
                <h4 class=""section-");
            WriteLiteral(@"heading"">Internet Usage details </h4>
                <div class=""row"">
                    <div class=""form-group col-md-12"">
                        <h5 class=""section-heading mb-5"">Are you at using the school internet now?</h5>

                        <input type=""radio"" id=""yes"" name=""internet"" value=""YesConnection"">
                        <label for=""yes"">Yes</label><br>
                        <input type=""radio"" id=""no"" name=""internet"" value=""NoConnection"">
                        <label for=""no"">No</label><br>

                    </div>
                </div>
            </div>
        </section>

        <h3>
            <div class=""media"">
                <div class=""bd-wizard-step-icon""><i class=""mdi mdi-bank""></i></div>
                <div class=""media-body"">
                    <div class=""bd-wizard-step-title"">Connectivity Details</div>
                    <div class=""bd-wizard-step-subtitle"">Step 3</div>
                </div>
            </div>
        </h3>
       ");
            WriteLiteral(@" <section>
            <div class=""content-wrapper automatic"" style=""display:none"">
                <h4 class=""section-heading"">Connectivity/location details </h4>
                <div class=""row"">
                    <div class=""form-group col-md-12"">
                        <h5 class=""section-heading mb-5"">Automatically retrive location and Internet Information </h5>
                        <label for=""lastName"" class=""sr-only""></label>
                        <a class=""btn btn-primary btn-lg"" id=""location"">Retrive Internet Information</a>

                    </div>
                </div>
                <div class=""row location-detail"" style=""display:none;"">
                    <h4 class=""section-heading mb-5"">Your connectivity and location Details</h4>
                    <h6 class=""font-weight-bold"">Location Details</h6>
                    <p class=""mb-4"">

                        Latitude: <span id=""enteredPhoneNumber"">40.7128?? N</span> <br>
                        Longitude: <span id");
            WriteLiteral(@"=""enteredEmailAddress"">74.0060?? W</span>
                    </p>
                    <h6 class=""font-weight-bold"">Connectivity Details</h6>
                    <p class=""mb-0"">

                        Connectivity Type: <span id=""enteredEmployeeNumber"">Broadband Internet Network</span> <br>
                        Connectivity Speed: <span id=""enteredWorkEmailAddress"">5G</span>
                    </p>
                </div>
            </div>

            <div class=""content-wrapper manual"" style=""display:none"">
                <h4 class=""section-heading"">Connectivity/location details </h4>
                <div class=""row"">
                    <div class=""form-group col-md-12"">
                        <h5 class=""section-heading mb-5"">Automatically retrive location and Internet Information </h5>
                        <label for=""lastName"" class=""sr-only""></label>
                        <div class=""form-group col-md-12"">
                            <h5 class=""section-heading mb-5"">Connec");
            WriteLiteral(@"tivity Type</h5>
                            <input type=""text"" name=""firstName"" id=""firstName"" class=""form-control"" placeholder=""Connectivity Type"">
                        </div>
                        <div class=""form-group col-md-12"">
                            <h5 class=""section-heading mb-5"">Connectivity Speed</h5>
                            <input type=""text"" name=""firstName"" id=""firstName"" class=""form-control"" placeholder=""Connectivity Speed"">
                        </div>

                    </div>
                </div>
                
            </div>


        </section>


        <h3>
            <div class=""media"">
                <div class=""bd-wizard-step-icon""><i class=""mdi mdi-account-check-outline""></i></div>
                <div class=""media-body"">
                    <div class=""bd-wizard-step-title"">Review </div>
                    <div class=""bd-wizard-step-subtitle"">Step 4</div>
                </div>
            </div>
        </h3>
        <section>");
            WriteLiteral(@"
            <div class=""content-wrapper"">
                <h4 class=""section-heading mb-5"">Review your Details</h4>
                <h6 class=""font-weight-bold"">School Details</h6>
                <p class=""mb-4"">

                    School name: <span id=""enteredPhoneNumber""><u>St John Catholic Primary School</u></span> <br>
                    Are you at school now: <span id=""enteredEmailAddress""><u>Yes</u></span><br />
                    Are using school internet connection: <span id=""enteredEmailAddress""><u>Yes</u></span>
                </p>
                <h6 class=""font-weight-bold"">Location Details</h6>
                <p class=""mb-0"">
                    Latitude: <span id=""enteredPhoneNumber""><u>40.7128?? N</u></span> <br>
                    Longitude: <span id=""enteredEmailAddress""><u>74.0060?? W</u></span>
                </p>
                <h6 class=""font-weight-bold"">Connectivity Details</h6>
                <p class=""mb-0"">
                    Connectivity Type: <span id=""");
            WriteLiteral(@"enteredEmployeeNumber""><u>Broadband Internet Network</u></span> <br>
                    Connectivity Speed: <span id=""enteredWorkEmailAddress""><u>5G</u></span>
                </p>
            </div>
        </section>
        <h3>
            <div class=""media"">
                <div class=""bd-wizard-step-icon""><i class=""mdi mdi-emoticon-outline""></i></div>
                <div class=""media-body"">
                    <div class=""bd-wizard-step-title"">Submit</div>
                    <div class=""bd-wizard-step-subtitle"">Step 5</div>
                </div>
            </div>
        </h3>
        <section>
            <div class=""content-wrapper"">
                <h4 class=""section-heading mb-5"">Accept agreement and Submit</h4>
                <div class=""form-check"">
                    <label class=""form-check-label"">
                        <input type=""checkbox"" class=""form-check-input""");
            BeginWriteAttribute("name", " name=\"", 8252, "\"", 8259, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 8260, "\"", 8265, 0);
            EndWriteAttribute();
            WriteLiteral(@" value=""checkedValue"" checked>
                        I hereby declare that I had read all the <a href=""#!"">terms and conditions</a>  and all the details provided my me in this form are true.
                    </label>
                </div>
            </div>
        </section>
    </div>
</div>

<script src=""https://code.jquery.com/jquery-3.4.1.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js""></script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e513fb2b882c88bfdb9efe40a223e3e5dde49e2315054", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e513fb2b882c88bfdb9efe40a223e3e5dde49e2316094", async() => {
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


    $('input[type=""radio""]').click(function () {
        if ($(this).attr(""value"") == ""NoConnection"") {
            $("".automatic"").hide('slow');
            $("".manual"").show('slow');
        }
        if ($(this).attr(""value"") == ""YesConnection"") {
            $("".automatic"").show('slow');
            $("".manual"").hide('slow');

        }
    });
    $('input[type=""radio""]').trigger('click');



    $(""#location"").click(function () {
        $("".location-detail"").show();
    });

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
