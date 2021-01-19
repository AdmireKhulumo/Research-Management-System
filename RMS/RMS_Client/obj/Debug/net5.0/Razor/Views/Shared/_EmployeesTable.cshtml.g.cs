#pragma checksum "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EmployeesTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca93a071d582389ee73298175fd8731530b3e00c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__EmployeesTable), @"mvc.1.0.view", @"/Views/Shared/_EmployeesTable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca93a071d582389ee73298175fd8731530b3e00c", @"/Views/Shared/_EmployeesTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68fa66e8d1b0bb69689da6e773b4dc63b0aca432", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__EmployeesTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EmployeesTable.cshtml"
  
    //get data from the viewdata component
    List<Employee> employees = (List<Employee>)this.ViewData["employees"];


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-hover table-dark table-bordered table-responsive"" id=""employees_table"">
    <thead class=""thead-light"">
        <tr>
            <th scope=""col"">First Name</th>
            <th scope=""col"">Last Name</th>
            <th scope=""col"">ID</th>
            <th scope=""col"">Department</th>
            <th scope=""col"">Position</th>
            <th scope=""col"">Qualification</th>
            <th scope=""col"">Research Interests</th>
            <th scope=""col"">Phone</th>
            <th scope=""col"">Email</th>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 24 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EmployeesTable.cshtml"
          
            foreach (Employee emp in employees)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n");
            WriteLiteral("                    <td>");
#nullable restore
#line 29 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EmployeesTable.cshtml"
                   Write(emp.Fname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 30 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EmployeesTable.cshtml"
                   Write(emp.Sname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td><strong>");
#nullable restore
#line 31 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EmployeesTable.cshtml"
                           Write(emp.EmpId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\n                    <td>");
#nullable restore
#line 32 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EmployeesTable.cshtml"
                   Write(emp.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 33 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EmployeesTable.cshtml"
                   Write(emp.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 34 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EmployeesTable.cshtml"
                   Write(emp.Qualification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 35 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EmployeesTable.cshtml"
                   Write(emp.Interests);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 36 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EmployeesTable.cshtml"
                   Write(emp.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 37 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EmployeesTable.cshtml"
                   Write(emp.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 39 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EmployeesTable.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>\n\n");
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
