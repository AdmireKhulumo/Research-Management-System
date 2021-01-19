#pragma checksum "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EditorialsTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8284fd6bbbbff667d7e8f21c475a1a838408ce28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__EditorialsTable), @"mvc.1.0.view", @"/Views/Shared/_EditorialsTable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8284fd6bbbbff667d7e8f21c475a1a838408ce28", @"/Views/Shared/_EditorialsTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68fa66e8d1b0bb69689da6e773b4dc63b0aca432", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__EditorialsTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EditorialsTable.cshtml"
  
    //get data from the viewdata component
    List<Editorial> editorials = (List<Editorial>)this.ViewData["editorials"];


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-hover table-dark table-bordered table-responsive"">
    <thead class=""thead-light"">
        <tr>
            <th scope=""col"">Employee(s)</th>
            <th scope=""col"">Activity Description</th>
            <th scope=""col"">Publication</th>
            <th scope=""col"">Url</th>
            <th scope=""col"">Date</th>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 20 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EditorialsTable.cshtml"
          
            foreach (Editorial ed in editorials)
            {
                string doers = "";
                foreach (Employee doer in ed.Doers)
                {
                    doers += $"{doer.Fname} {doer.Sname}, ";
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n");
            WriteLiteral("                    <td><strong>");
#nullable restore
#line 30 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EditorialsTable.cshtml"
                           Write(doers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\n                    <td>");
#nullable restore
#line 31 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EditorialsTable.cshtml"
                   Write(ed.Activity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 32 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EditorialsTable.cshtml"
                   Write(ed.Publication);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 33 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EditorialsTable.cshtml"
                   Write(ed.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 34 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EditorialsTable.cshtml"
                   Write(ed.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 36 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_EditorialsTable.cshtml"
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