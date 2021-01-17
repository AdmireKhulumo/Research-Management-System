#pragma checksum "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cb61354fd7037a0afec54075b27bec4fbe4f2de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Editorial_MyEditorials), @"mvc.1.0.view", @"/Views/Editorial/MyEditorials.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cb61354fd7037a0afec54075b27bec4fbe4f2de", @"/Views/Editorial/MyEditorials.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68fa66e8d1b0bb69689da6e773b4dc63b0aca432", @"/Views/_ViewImports.cshtml")]
    public class Views_Editorial_MyEditorials : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
  
    ViewData["Title"] = "My Editorials";
    List<Editorial> editorials = ViewBag.Message;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">My Editorials</h1>\n\n");
#nullable restore
#line 9 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
      
        if (editorials.Count == 0)
        {
            //there are no editorials done by this user

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>No Editorials Yet.</h3>\n");
#nullable restore
#line 14 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\n");
#nullable restore
#line 19 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
     foreach (Editorial ed in editorials)
    {
        //create dynamic modal name
        string mId = $"del_{ed.Activity}_{ed.Publication}";
        mId = mId.Replace(" ", string.Empty);
        mId = mId.Replace(".", string.Empty);


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6\">\n\n\n            <div class=\"card text-center\">\n                <div class=\"card-header\">\n\n                    <h4 class=\"col-md-12\">");
#nullable restore
#line 32 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
                                     Write(ed.Publication);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n                    <a class=\"badge badge-pill badge-warning text-white\"");
            BeginWriteAttribute("href", " href=\"", 908, "\"", 1041, 1);
#nullable restore
#line 34 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
WriteAttributeValue("", 915, Url.Action("EditEditorial", "Editorial", new { activity=ed.Activity, publication=ed.Publication, url=ed.Url, date=ed.Date } ), 915, 126, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-pencil text-white"" viewBox=""0 0 16 16"">
                            <path d=""M12.146.146a.5.5 0 0 1 .708 0l3 3a.5.5 0 0 1 0 .708l-10 10a.5.5 0 0 1-.168.11l-5 2a.5.5 0 0 1-.65-.65l2-5a.5.5 0 0 1 .11-.168l10-10zM11.207 2.5L13.5 4.793 14.793 3.5 12.5 1.207 11.207 2.5zm1.586 3L10.5 3.207 4 9.707V10h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.293l6.5-6.5zm-9.761 5.175l-.106.106-1.528 3.821 3.821-1.528.106-.106A.5.5 0 0 1 5 12.5V12h-.5a.5.5 0 0 1-.5-.5V11h-.5a.5.5 0 0 1-.468-.325z"" />
                        </svg>
                        EDIT
                    </a>


                    <a class=""badge badge-pill badge-danger text-white""");
            BeginWriteAttribute("href", " href=\"", 1807, "\"", 1819, 2);
            WriteAttributeValue("", 1814, "#", 1814, 1, true);
#nullable restore
#line 42 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
WriteAttributeValue("", 1815, mId, 1815, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-toggle=""modal"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-trash text-white"" viewBox=""0 0 16 16"">
                            <path d=""M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"" />
                            <path fill-rule=""evenodd"" d=""M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4L4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z"" />
                        </svg>
                        DELETE
                    </a>

                    
                </div>

                <div class=""card-body"">
                    <h5><u>Description</u></h5>
                    <h6>");
#nullable restore
#line 55 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
                   Write(ed.Activity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                    <br />\n                    <h5><u>Organisation\'s URL</u></h5>\n                    <h6>");
#nullable restore
#line 58 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
                   Write(ed.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                    <br />\n                    <h5><u>Date</u></h5>\n                    <h6>");
#nullable restore
#line 61 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
                   Write(ed.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                    <br />\n\n\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 3061, "\"", 3075, 1);
#nullable restore
#line 65 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
WriteAttributeValue("", 3068, ed.Url, 3068, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" target=""_blank"">
                        View Website
                        <span class=""fa fa-chevron-right""></span>
                        <span class=""fa fa-chevron-right""></span>
                    </a>

                </div>
            </div>
        </div>
");
            WriteLiteral("        <!-- Button trigger modal -->\n");
            WriteLiteral("            <!-- Modal -->\n            <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 3484, "\"", 3493, 1);
#nullable restore
#line 79 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
WriteAttributeValue("", 3489, mId, 3489, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 3508, "\"", 3530, 1);
#nullable restore
#line 79 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
WriteAttributeValue("", 3526, mId, 3526, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-hidden=""true"">
                <div class=""modal-dialog"">
                    <div class=""modal-content"">

                        <div class=""modal-header"">
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>

                        <div class=""modal-body"">
                            <h5>Are you sure you want to delete the editorial ""<em>");
#nullable restore
#line 90 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
                                                                              Write(ed.Activity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</em>"" ?</h5>
                        </div>

                        <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn badge-pill badge-light"" data-dismiss=""modal"">CANCEL</button>
                            <button type=""button"" value=""Submit"" class=""btn badge-pill badge-warning""");
            BeginWriteAttribute("onclick", " onclick=\"", 4410, "\"", 4527, 3);
            WriteAttributeValue("", 4420, "location.href=\'", 4420, 15, true);
#nullable restore
#line 95 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
WriteAttributeValue("", 4435, Url.Action("Delete", "Editorial", new { activity=ed.Activity, publication=ed.Publication}), 4435, 91, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4526, "\'", 4526, 1, true);
            EndWriteAttribute();
            WriteLiteral(">DELETE</button>\n                        </div>\n\n                        \n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 102 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 105 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <button type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4761, "\"", 4827, 3);
            WriteAttributeValue("", 4771, "location.href=\'", 4771, 15, true);
#nullable restore
#line 108 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Editorial/MyEditorials.cshtml"
WriteAttributeValue("", 4786, Url.Action("AddEditorial", "Editorial"), 4786, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4826, "\'", 4826, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n        <span class=\"fa fa-plus\"></span>\n        Add Editorial\n    </button>\n\n\n</div>\n\n\n");
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
