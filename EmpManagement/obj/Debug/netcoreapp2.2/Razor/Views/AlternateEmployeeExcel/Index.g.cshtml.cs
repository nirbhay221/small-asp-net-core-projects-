#pragma checksum "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e152a6e172f24a39a1c9902418baafb40661f70a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AlternateEmployeeExcel_Index), @"mvc.1.0.view", @"/Views/AlternateEmployeeExcel/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AlternateEmployeeExcel/Index.cshtml", typeof(AspNetCore.Views_AlternateEmployeeExcel_Index))]
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
#line 1 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\_ViewImports.cshtml"
using EmpManagement.Models;

#line default
#line hidden
#line 2 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\_ViewImports.cshtml"
using EmpManagement.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e152a6e172f24a39a1c9902418baafb40661f70a", @"/Views/AlternateEmployeeExcel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d6ec5c308294d61a3bbb40d8c9044fb01a3987", @"/Views/_ViewImports.cshtml")]
    public class Views_AlternateEmployeeExcel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "mainhome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "newindex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "alternateemployeeexcel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "importXML", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(8, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e152a6e172f24a39a1c9902418baafb40661f70a6103", async() => {
                BeginContext(14, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(108, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(110, 2069, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e152a6e172f24a39a1c9902418baafb40661f70a7378", async() => {
                BeginContext(116, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(123, 14, false);
#line 7 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
Write(ViewBag.result);

#line default
#line hidden
                EndContext();
                BeginContext(137, 18, true);
                WriteLiteral("\r\n    <br />\r\n    ");
                EndContext();
                BeginContext(155, 293, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e152a6e172f24a39a1c9902418baafb40661f70a8182", async() => {
                    BeginContext(268, 107, true);
                    WriteLiteral("\r\n        <input type=\"file\" name=\"xmlFile\" />\r\n        <input type=\"submit\" name=\"Import\" />\r\n\r\n\r\n        ");
                    EndContext();
                    BeginContext(375, 60, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e152a6e172f24a39a1c9902418baafb40661f70a8706", async() => {
                        BeginContext(426, 5, true);
                        WriteLiteral("Index");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(435, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(448, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 16 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
     if (ViewBag.AlternateEmployee != null)
    {


#line default
#line hidden
                BeginContext(504, 655, true);
                WriteLiteral(@"        <table border=""1"">
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Location</th>
                <th> Availability </th>
                <th>Role </th>
                <th>Status</th>
                <th> StartDate</th>
                <th> HomeAddress</th>

                <th>ReportsTo</th>
                <th>EmailAddress</th>
                <th> Dob </th>
                <th>  PassportDate</th>
                <th> SalaryDate </th>
                <th> MedicalInsuranceDate</th>
                <th>EidaDate </th>

                <th>Objective</th>

            </tr>
");
                EndContext();
#line 41 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
             foreach (var AlternateEmployee in ViewBag.AlternateEmployee)
            {

#line default
#line hidden
                BeginContext(1249, 30, true);
                WriteLiteral("        <tr>\r\n            <td>");
                EndContext();
                BeginContext(1280, 20, false);
#line 44 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
           Write(AlternateEmployee.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1300, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(1324, 22, false);
#line 45 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
           Write(AlternateEmployee.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1346, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(1370, 26, false);
#line 46 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
           Write(AlternateEmployee.Location);

#line default
#line hidden
                EndContext();
                BeginContext(1396, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(1420, 30, false);
#line 47 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
           Write(AlternateEmployee.Availability);

#line default
#line hidden
                EndContext();
                BeginContext(1450, 25, true);
                WriteLiteral("</td>\r\n\r\n            <td>");
                EndContext();
                BeginContext(1476, 22, false);
#line 49 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
           Write(AlternateEmployee.Role);

#line default
#line hidden
                EndContext();
                BeginContext(1498, 25, true);
                WriteLiteral("</td>\r\n\r\n            <td>");
                EndContext();
                BeginContext(1524, 24, false);
#line 51 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
           Write(AlternateEmployee.Status);

#line default
#line hidden
                EndContext();
                BeginContext(1548, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(1572, 27, false);
#line 52 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
           Write(AlternateEmployee.StartDate);

#line default
#line hidden
                EndContext();
                BeginContext(1599, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(1623, 29, false);
#line 53 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
           Write(AlternateEmployee.HomeAddress);

#line default
#line hidden
                EndContext();
                BeginContext(1652, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(1676, 27, false);
#line 54 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
           Write(AlternateEmployee.ReportsTo);

#line default
#line hidden
                EndContext();
                BeginContext(1703, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(1727, 30, false);
#line 55 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
           Write(AlternateEmployee.EmailAddress);

#line default
#line hidden
                EndContext();
                BeginContext(1757, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(1781, 21, false);
#line 56 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
           Write(AlternateEmployee.Dob);

#line default
#line hidden
                EndContext();
                BeginContext(1802, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(1826, 30, false);
#line 57 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
           Write(AlternateEmployee.PassportDate);

#line default
#line hidden
                EndContext();
                BeginContext(1856, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(1880, 28, false);
#line 58 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
           Write(AlternateEmployee.SalaryDate);

#line default
#line hidden
                EndContext();
                BeginContext(1908, 24, true);
                WriteLiteral(" </td>\r\n            <td>");
                EndContext();
                BeginContext(1933, 38, false);
#line 59 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
           Write(AlternateEmployee.MedicalInsuranceDate);

#line default
#line hidden
                EndContext();
                BeginContext(1971, 23, true);
                WriteLiteral("</td>\r\n            <td>");
                EndContext();
                BeginContext(1995, 26, false);
#line 60 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
           Write(AlternateEmployee.EidaDate);

#line default
#line hidden
                EndContext();
                BeginContext(2021, 25, true);
                WriteLiteral("</td>\r\n\r\n            <td>");
                EndContext();
                BeginContext(2047, 27, false);
#line 62 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
           Write(AlternateEmployee.Objective);

#line default
#line hidden
                EndContext();
                BeginContext(2074, 22, true);
                WriteLiteral("</td>\r\n        </tr>\r\n");
                EndContext();
#line 64 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(2111, 18, true);
                WriteLiteral("        </table>\r\n");
                EndContext();
#line 66 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\AlternateEmployeeExcel\Index.cshtml"

    }

#line default
#line hidden
                BeginContext(2138, 34, true);
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2179, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
