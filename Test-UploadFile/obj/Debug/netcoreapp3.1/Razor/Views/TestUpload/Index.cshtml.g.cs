#pragma checksum "E:\Projects_C-sharp\Test-UploadFile\Test-UploadFile\Views\TestUpload\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15a8ab76455d166219ad7490789ab83a0a1cc38c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestUpload_Index), @"mvc.1.0.view", @"/Views/TestUpload/Index.cshtml")]
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
#line 1 "E:\Projects_C-sharp\Test-UploadFile\Test-UploadFile\Views\_ViewImports.cshtml"
using Test_UploadFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects_C-sharp\Test-UploadFile\Test-UploadFile\Views\_ViewImports.cshtml"
using Test_UploadFile.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Projects_C-sharp\Test-UploadFile\Test-UploadFile\Views\TestUpload\Index.cshtml"
using Test_UploadFile.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15a8ab76455d166219ad7490789ab83a0a1cc38c", @"/Views/TestUpload/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dcf075a40e4df67c2a8328c5a97a3a2c0c4647a", @"/Views/_ViewImports.cshtml")]
    public class Views_TestUpload_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Emploes_out>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/TestUpload/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css\" rel=\"stylesheet\" type=\"text/css\" />\r\n<div class=\"container\">\r\n    <div class=\"mb-3 mt-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15a8ab76455d166219ad7490789ab83a0a1cc38c4670", async() => {
                WriteLiteral(@"
            <div class=""mb-3"">
                <label>Choos the file-List of employes</label>
                <input type=""file"" accept=""*.csv"" id=""file_input"" name=""file_input"" class=""form-control"" />
            </div>
            <div class=""mb-3"">
                <input type=""submit"" id=""btnUpload"" value=""Identifity employees"" class=""btn btn-primary"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"mb-3 mt-5\">\r\n");
#nullable restore
#line 20 "E:\Projects_C-sharp\Test-UploadFile\Test-UploadFile\Views\TestUpload\Index.cshtml"
      
        if (Model != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <h2>Table of employes</h2>
            <div class=""row"">
                <div class=""col-md-6"">
                    <table class=""table-striped"">
                        <tbody>
                            <tr>
                                <th>
                                    Emplouee ID-1
                                </th>
                                <th>
                                    Emplouee ID-2
                                </th>
                                <th>
                                    Project ID
                                </th>
                                <th>
                                    Days worked
                                </th>
                            </tr>
");
#nullable restore
#line 42 "E:\Projects_C-sharp\Test-UploadFile\Test-UploadFile\Views\TestUpload\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr><td>");
#nullable restore
#line 44 "E:\Projects_C-sharp\Test-UploadFile\Test-UploadFile\Views\TestUpload\Index.cshtml"
                                   Write(item.Employee_id_1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 44 "E:\Projects_C-sharp\Test-UploadFile\Test-UploadFile\Views\TestUpload\Index.cshtml"
                                                               Write(item.Employee_id_2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 44 "E:\Projects_C-sharp\Test-UploadFile\Test-UploadFile\Views\TestUpload\Index.cshtml"
                                                                                           Write(item.Priject_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 44 "E:\Projects_C-sharp\Test-UploadFile\Test-UploadFile\Views\TestUpload\Index.cshtml"
                                                                                                                    Write(item.Count_days_worked);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 45 "E:\Projects_C-sharp\Test-UploadFile\Test-UploadFile\Views\TestUpload\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 50 "E:\Projects_C-sharp\Test-UploadFile\Test-UploadFile\Views\TestUpload\Index.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Emploes_out>> Html { get; private set; }
    }
}
#pragma warning restore 1591
