#pragma checksum "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6d390e1f0ad22d5a3938ea174ce04ccb3621887"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JArticle_EditJArticle), @"mvc.1.0.view", @"/Views/JArticle/EditJArticle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6d390e1f0ad22d5a3938ea174ce04ccb3621887", @"/Views/JArticle/EditJArticle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68fa66e8d1b0bb69689da6e773b4dc63b0aca432", @"/Views/_ViewImports.cshtml")]
    public class Views_JArticle_EditJArticle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
  
    ViewData["Title"] = "Edit Journal Article";
    //get projects being done by the logged in employee
    List<Project> projects = await new APIRequest().getProjects(Employee.user.EmpId);
    JArticle ja = ViewBag.Message;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Edit Journal Article</h1>\n\n");
#nullable restore
#line 11 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
     using (Html.BeginForm("EditJArticle", "JArticle", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-8 col-lg-8 container\">\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6d390e1f0ad22d5a3938ea174ce04ccb36218874438", async() => {
                WriteLiteral("\n");
                WriteLiteral("\n        <input type=\"hidden\" class=\"form-control\" name=\"old_title\" id=\"old_title\"");
                BeginWriteAttribute("value", " value=\"", 633, "\"", 650, 1);
#nullable restore
#line 18 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
WriteAttributeValue("", 641, ja.Title, 641, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n        <input type=\"hidden\" class=\"form-control\" name=\"old_jname\" id=\"old_jname\"");
                BeginWriteAttribute("value", " value=\"", 736, "\"", 753, 1);
#nullable restore
#line 19 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
WriteAttributeValue("", 744, ja.Jname, 744, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n\n");
                WriteLiteral("        <div class=\"form-group\">\n            <label>Select Project</label>\n            <select class=\"form-control\" name=\"pId\" id=\"pId\">\n\n");
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6d390e1f0ad22d5a3938ea174ce04ccb36218876008", async() => {
#nullable restore
#line 27 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
                                 Write(projects.Find(p => p.PId == ja.PId).Title);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
                  WriteLiteral(ja.PId);

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
                WriteLiteral("                ");
#nullable restore
#line 29 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
           Write(projects.RemoveAll(p => p.PId == ja.PId));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\n\n");
#nullable restore
#line 32 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
                 foreach (Project p in projects)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6d390e1f0ad22d5a3938ea174ce04ccb36218878705", async() => {
#nullable restore
#line 34 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
                                    Write(p.Title);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
                      WriteLiteral(p.PId);

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
#line 35 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </select>\n        </div>\n\n");
                WriteLiteral("        <div class=\"form-group\">\n            <label>Article Title</label>\n            <input type=\"text\" class=\"form-control\" name=\"title\" id=\"title\"");
                BeginWriteAttribute("value", " value=\"", 1671, "\"", 1688, 1);
#nullable restore
#line 43 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
WriteAttributeValue("", 1679, ja.Title, 1679, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n        </div>\n\n");
                WriteLiteral("        <div class=\"form-group\">\n            <label>Journal Name</label>\n            <input type=\"text\" class=\"form-control\" name=\"jname\" id=\"jname\"");
                BeginWriteAttribute("value", " value=\"", 1875, "\"", 1892, 1);
#nullable restore
#line 49 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
WriteAttributeValue("", 1883, ja.Jname, 1883, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n        </div>\n\n        <div class=\"row\">\n\n");
                WriteLiteral("            <div class=\"form-group col-md-6\">\n                <label>Volume Number</label>\n                <input type=\"text\" class=\"form-control\" name=\"volume\" id=\"volume\"");
                BeginWriteAttribute("value", " value=\"", 2137, "\"", 2155, 1);
#nullable restore
#line 57 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
WriteAttributeValue("", 2145, ja.Volume, 2145, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n            </div>\n\n");
                WriteLiteral("            <div class=\"form-group col-md-6\">\n                <label>Issue Number</label>\n                <input type=\"text\" class=\"form-control\" name=\"issue\" id=\"issue\"");
                BeginWriteAttribute("value", " value=\"", 2373, "\"", 2390, 1);
#nullable restore
#line 63 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
WriteAttributeValue("", 2381, ja.Issue, 2381, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n            </div>\n\n");
                WriteLiteral("            <div class=\"form-group col-md-6\">\n                <label>Number of Pages</label>\n                <input type=\"text\" class=\"form-control\" name=\"pages\" id=\"pages\"");
                BeginWriteAttribute("value", " value=\"", 2611, "\"", 2628, 1);
#nullable restore
#line 69 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
WriteAttributeValue("", 2619, ja.Pages, 2619, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n            </div>\n\n");
                WriteLiteral("            <div class=\"form-group col-md-6\">\n                <label>Year of Publication</label>\n                <input type=\"text\" class=\"form-control\" name=\"year\" id=\"year\"");
                BeginWriteAttribute("value", " value=\"", 2850, "\"", 2866, 1);
#nullable restore
#line 75 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
WriteAttributeValue("", 2858, ja.Year, 2858, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n            </div>\n\n        </div>\n\n");
                WriteLiteral(@"        <!-- Button trigger modal -->
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
                            <h5>Are you sure you want to edit details of ""<em>");
#nullable restore
#line 101 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
                                                                         Write(ja.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</em>"" ?</h5>
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
            WriteLiteral("\n</div>\n");
#nullable restore
#line 118 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/JArticle/EditJArticle.cshtml"
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
