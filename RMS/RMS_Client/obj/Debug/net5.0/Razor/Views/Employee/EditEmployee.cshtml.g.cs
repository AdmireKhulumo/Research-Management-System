#pragma checksum "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9909d711c3c940b7b1af7cef06c5a28af8e03e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EditEmployee), @"mvc.1.0.view", @"/Views/Employee/EditEmployee.cshtml")]
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
#line 1 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/_ViewImports.cshtml"
using RMS_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/_ViewImports.cshtml"
using RMS_Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9909d711c3c940b7b1af7cef06c5a28af8e03e0", @"/Views/Employee/EditEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68fa66e8d1b0bb69689da6e773b4dc63b0aca432", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_EditEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
  
    ViewData["Title"] = "Edit Employee";

    Employee e = ViewBag.Message;

    //create and add departments
    List<string> depts = new List<string>();
    depts.Add("Computer Science and Information Systems");
    depts.Add("Forensic Science");
    depts.Add("Mechanical Engineering");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Edit Employee Details</h1>\n\n");
#nullable restore
#line 16 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
     using (Html.BeginForm("EditEmployee", "Employee", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-8 col-lg-8 container\">\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9909d711c3c940b7b1af7cef06c5a28af8e03e04520", async() => {
                WriteLiteral("\n\n");
                WriteLiteral(@"                <div class=""row"">
                    <div class=""form-group col-md-6"">
                        <div class=""column"">
                            <label>First Name</label>
                            <input type=""text"" class=""form-control"" name=""fname"" id=""fname""");
                BeginWriteAttribute("value", " value=\"", 830, "\"", 846, 1);
#nullable restore
#line 27 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
WriteAttributeValue("", 838, e.Fname, 838, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                        </div>\n                    </div>\n\n                    <div class=\"column col-md-6\">\n                        <label>Last Name</label>\n                        <input type=\"text\" class=\"form-control\" name=\"sname\" id=\"sname\"");
                BeginWriteAttribute("value", " value=\"", 1096, "\"", 1112, 1);
#nullable restore
#line 33 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
WriteAttributeValue("", 1104, e.Sname, 1104, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                    </div>\n                </div>\n\n\n");
                WriteLiteral("                <div class=\"form-group\">\n                    <label>Position</label>\n                    <input type=\"text\" class=\"form-control\" name=\"position\" id=\"position\"");
                BeginWriteAttribute("value", " value=\"", 1382, "\"", 1401, 1);
#nullable restore
#line 41 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
WriteAttributeValue("", 1390, e.Position, 1390, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                </div>\n\n                <div class=\"form-group\">\n                    <label>Department</label>\n                    <select class=\"form-control\" name=\"department\" id=\"department\">\n");
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9909d711c3c940b7b1af7cef06c5a28af8e03e07213", async() => {
#nullable restore
#line 48 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
                                                 Write(e.Department);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
                           WriteLiteral(e.Department);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n");
                WriteLiteral("                        ");
#nullable restore
#line 51 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
                   Write(depts.RemoveAll(dept => dept == e.Department));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n\n");
#nullable restore
#line 54 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
                         foreach (string dept in depts)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9909d711c3c940b7b1af7cef06c5a28af8e03e09958", async() => {
#nullable restore
#line 56 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
                                             Write(dept);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
                               WriteLiteral(dept);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 57 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\n                </div>\n\n");
                WriteLiteral("                <div class=\"form-group\">\n                    <label>Highest Qualificaton</label>\n                    <input type=\"text\" class=\"form-control\" name=\"qualification\" id=\"qualification\"");
                BeginWriteAttribute("value", " value=\"", 2432, "\"", 2456, 1);
#nullable restore
#line 64 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
WriteAttributeValue("", 2440, e.Qualification, 2440, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                </div>\n\n                <div class=\"form-group\">\n                    <label>Research Interests</label>\n                    <textarea class=\"form-control\" name=\"interests\" id=\"interests\">");
#nullable restore
#line 69 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
                                                                              Write(e.Interests);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\n                </div>\n\n\n");
                WriteLiteral(@"                <div class=""row"">
                    <div class=""form-group col-md-6"">
                        <div class=""column"">
                            <label>Email Address</label>
                            <input type=""text"" class=""form-control"" name=""email"" id=""email""");
                BeginWriteAttribute("value", " value=\"", 3026, "\"", 3042, 1);
#nullable restore
#line 78 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
WriteAttributeValue("", 3034, e.Email, 3034, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>

                    <div class=""form-group column col-md-6"">
                        <label>Phone Number</label>
                        <input type=""text"" class=""form-control"" name=""phone"" id=""phone""");
                BeginWriteAttribute("value", " value=\"", 3306, "\"", 3322, 1);
#nullable restore
#line 84 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
WriteAttributeValue("", 3314, e.Phone, 3314, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                    </div>\n                </div>\n\n                <input type=\"hidden\" class=\"form-control\" name=\"save\" id=\"save\" value=\"true\" />\n                <input type=\"hidden\" class=\"form-control\" name=\"empId\" id=\"empId\"");
                BeginWriteAttribute("value", " value=\"", 3555, "\"", 3571, 1);
#nullable restore
#line 89 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
WriteAttributeValue("", 3563, e.EmpId, 3563, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n\n\n");
                WriteLiteral(@"                <!-- Button trigger modal -->
            <div>

                <button type=""button"" class=""btn btn-primary btn-block"" data-toggle=""modal"" data-target=""#confirm"">
                    <span class=""far fa-save""></span>
                    SAVE CHANGES
                </button>

                <!-- Modal -->
                <div class=""modal fade"" id=""confirm"" tabindex=""-1"" aria-labelledby=""confirm"" aria-hidden=""true"">
                    <div class=""modal-dialog"">
                        <div class=""modal-content"">

                            <div class=""modal-header"">
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>

                            <div class=""modal-body"">
                                <h5>Are you sure you want to edit ");
#nullable restore
#line 113 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
                                                             Write(e.Fname);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 113 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
                                                                      Write(e.Sname);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'s details?</h5>
                            </div>

                            <div class=""modal-footer"">
                                <div class=""form-group"">
                                    <button type=""button"" class=""btn btn badge-pill badge-light"" data-dismiss=""modal"">CANCEL</button>
                                    <button type=""submit"" value=""Submit"" class=""btn badge-pill badge-warning"">CONFIRM</button>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>

            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n");
#nullable restore
#line 130 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/EditEmployee.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n");
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