#pragma checksum "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_AddAuthor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "689544b51d17ac247daa5dd1862d6ce29b8420e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AddAuthor), @"mvc.1.0.view", @"/Views/Shared/_AddAuthor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"689544b51d17ac247daa5dd1862d6ce29b8420e4", @"/Views/Shared/_AddAuthor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68fa66e8d1b0bb69689da6e773b4dc63b0aca432", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AddAuthor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_AddAuthor.cshtml"
  
    //get data from the viewdata component
    List<Employee> employees =  (List<Employee>)this.ViewData["employees"];
    string id1 = (string)ViewData["id1"];
    string id2 = (string)ViewData["id2"];
    string type = (string)ViewData["type"];
    string str = id1 + id2 + type; ;
    string colId = String.Concat(str.Where(c => !Char.IsWhiteSpace(c)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n");
#nullable restore
#line 12 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_AddAuthor.cshtml"
     using (Html.BeginForm("AddAuthor", "Project", FormMethod.Post))
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "689544b51d17ac247daa5dd1862d6ce29b8420e44417", async() => {
                WriteLiteral("\n            <div class=\"row\">\n\n                <a class=\"col-md-12\" data-toggle=\"collapse\"");
                BeginWriteAttribute("href", "  href=\"", 550, "\"", 565, 2);
                WriteAttributeValue("", 558, "#", 558, 1, true);
#nullable restore
#line 18 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_AddAuthor.cshtml"
WriteAttributeValue("", 559, colId, 559, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"button\" aria-expanded=\"false\"");
                BeginWriteAttribute("aria-controls", " aria-controls=\"", 602, "\"", 624, 1);
#nullable restore
#line 18 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_AddAuthor.cshtml"
WriteAttributeValue("", 618, colId, 618, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    Add Author\n                </a>\n\n");
                WriteLiteral("                <div class=\"collapse row\"");
                BeginWriteAttribute("id", " id=\"", 832, "\"", 843, 1);
#nullable restore
#line 23 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_AddAuthor.cshtml"
WriteAttributeValue("", 837, colId, 837, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <div class=\"form-group col-md-10\">\n                        <select class=\"form-control\" name=\"empId\" id=\"empId\">\n");
#nullable restore
#line 26 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_AddAuthor.cshtml"
                             foreach (Employee emp in employees)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "689544b51d17ac247daa5dd1862d6ce29b8420e46809", async() => {
#nullable restore
#line 28 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_AddAuthor.cshtml"
                                                    Write(emp.Fname);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 28 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_AddAuthor.cshtml"
                                                               Write(emp.Sname);

#line default
#line hidden
#nullable disable
                    WriteLiteral(", ");
#nullable restore
#line 28 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_AddAuthor.cshtml"
                                                                           Write(emp.Department);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_AddAuthor.cshtml"
                                  WriteLiteral(emp.EmpId);

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
#line 29 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_AddAuthor.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </select>\n                    </div>\n\n");
                WriteLiteral("                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1390, "\"", 1402, 1);
#nullable restore
#line 34 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_AddAuthor.cshtml"
WriteAttributeValue("", 1398, id1, 1398, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id1\" id=\"id1\" />\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1467, "\"", 1479, 1);
#nullable restore
#line 35 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_AddAuthor.cshtml"
WriteAttributeValue("", 1475, id2, 1475, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id2\" id=\"id2\" />\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1544, "\"", 1557, 1);
#nullable restore
#line 36 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_AddAuthor.cshtml"
WriteAttributeValue("", 1552, type, 1552, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"type\" id=\"type\" />\n\n                    <div class=\"form-group col-md-2\">\n                        <button type=\"submit\" value=\"Submit\" class=\"btn btn-primary\">+</button>\n                    </div>\n                </div>\n            </div>\n        ");
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
            WriteLiteral("\n");
#nullable restore
#line 44 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_AddAuthor.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
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