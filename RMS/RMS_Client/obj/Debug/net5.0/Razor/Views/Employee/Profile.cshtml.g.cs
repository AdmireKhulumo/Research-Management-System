#pragma checksum "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2fbf7c9d610c5fef4f508bb42089e20dcfac207"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Profile), @"mvc.1.0.view", @"/Views/Employee/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2fbf7c9d610c5fef4f508bb42089e20dcfac207", @"/Views/Employee/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68fa66e8d1b0bb69689da6e773b4dc63b0aca432", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/Profile.cshtml"
  
    ViewData["Title"] = "My Profile";

    Employee emp = Employee.user;

    //get photo url
    string userUrl = emp.Photo;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">My Profile</h1>\n    <div class=\"container row\">\n\n");
            WriteLiteral("        <div class=\"col-md-4\">\n            <div class=\"card bg-light text-center \">\n                <img");
            BeginWriteAttribute("src", " src=\"", 363, "\"", 377, 1);
#nullable restore
#line 17 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/Profile.cshtml"
WriteAttributeValue("", 369, userUrl, 369, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top rounded-circle img-fluid\" alt=\"user image\" width=\"300\" height=\"300\">\n                <div class=\"card-body column\">\n\n                    <div>\n                        <a class=\"btn badge-warning col-md-8\"");
            BeginWriteAttribute("href", " href=\"", 603, "\"", 850, 1);
#nullable restore
#line 21 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/Profile.cshtml"
WriteAttributeValue("", 610, Url.Action("EditEmployee", "Employee", new { fname=emp.Fname, sname=emp.Sname, department=emp.Department, position=emp.Position, qualification=emp.Qualification, interests=emp.Interests, phone=emp.Phone, email=emp.Email, empId=emp.EmpId }), 610, 240, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <img src=""/images/edit.svg"" width=""16"" height=""16"" alt=""profile image"" style=""color:white"">
                            EDIT
                        </a>
                        <br />
                    </div>

                    <div class=""row"">
                        <h6 class=""col-md-5"">First Name: </h6>
                        <h5 class=""col-md-7"">");
#nullable restore
#line 30 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/Profile.cshtml"
                                        Write(emp.Fname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    </div>\n                    <br />\n                    <div class=\"row\">\n                        <h6 class=\"col-md-5\">Surname: </h6>\n                        <h5 class=\"col-md-7\">");
#nullable restore
#line 35 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/Profile.cshtml"
                                        Write(emp.Sname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    </div>\n                    <br />\n\n                    <div class=\"row\">\n                        <h6 class=\"col-md-5\">ID: </h6>\n                        <h5 class=\"col-md-7\">");
#nullable restore
#line 41 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/Profile.cshtml"
                                        Write(emp.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    </div>\n                    <br />\n\n                </div>\n            </div>\n        </div>\n\n");
            WriteLiteral(@"        <div class=""col-md-8"">
            <div class=""card bg-light "">
                <div class=""card-body column"">

                    <h4><strong>Institutional Details</strong></h4>
                    <br />
                    <div class=""row"">
                        <h5 class=""col-md-5"">Department: </h5>
                        <h5 class=""col-md-7"">");
#nullable restore
#line 58 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/Profile.cshtml"
                                        Write(emp.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    </div>\n                    <br />\n                    <div class=\"row\">\n                        <h5 class=\"col-md-5\">Position: </h5>\n                        <h5 class=\"col-md-7\">");
#nullable restore
#line 63 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/Profile.cshtml"
                                        Write(emp.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                    </div>
                    <br />
                    <br />
                    <hr />

                    <h4><strong>Academics</strong></h4>
                    <br />
                    <div class=""row"">
                        <h5 class=""col-md-5"">Qualification:</h5>
                        <h5 class=""col-md-7"">");
#nullable restore
#line 73 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/Profile.cshtml"
                                        Write(emp.Qualification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    </div>\n                    <br />\n                    <div class=\"row\">\n                        <h5 class=\"col-md-5\">Research Interests:</h5>\n                        <h5 class=\"col-md-7\">");
#nullable restore
#line 78 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/Profile.cshtml"
                                        Write(emp.Interests);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                    </div>
                    <br />
                    <br />
                    <hr />

                    <h4><strong>Contact Details</strong></h4>
                    <br />
                    <div class=""row"">
                        <h5 class=""col-md-5"">Email: </h5>
                        <h5 class=""col-md-7"">");
#nullable restore
#line 88 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/Profile.cshtml"
                                        Write(emp.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    </div>\n                    <br />\n                    <div class=\"row\">\n                        <h5 class=\"col-md-5\">Phone: </h5>\n                        <h5 class=\"col-md-7\">");
#nullable restore
#line 93 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Employee/Profile.cshtml"
                                        Write(emp.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    </div>\n\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
