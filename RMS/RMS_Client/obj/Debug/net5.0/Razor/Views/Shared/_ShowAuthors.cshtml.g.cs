#pragma checksum "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_ShowAuthors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c1286b14056c6a2dd8d76a15478054c0d234229"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ShowAuthors), @"mvc.1.0.view", @"/Views/Shared/_ShowAuthors.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c1286b14056c6a2dd8d76a15478054c0d234229", @"/Views/Shared/_ShowAuthors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68fa66e8d1b0bb69689da6e773b4dc63b0aca432", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ShowAuthors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 5 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_ShowAuthors.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\n");
#nullable restore
#line 9 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_ShowAuthors.cshtml"
          int i = 1;
            foreach (Employee auth in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"col-md-6\">");
#nullable restore
#line 12 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_ShowAuthors.cshtml"
                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 12 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_ShowAuthors.cshtml"
                                   Write(auth.Fname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_ShowAuthors.cshtml"
                                               Write(auth.Sname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 13 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_ShowAuthors.cshtml"
                i = i + 1;
            }

        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
#nullable restore
#line 18 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_ShowAuthors.cshtml"
}
else
{
    //no authors, show message

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No Authors added yet.</p>\n");
#nullable restore
#line 23 "/Users/admirekhulumo/OneDrive - biust.ac.bw/BIUST/Class/Y3S1/COMP 342 Internet Programming/Project/RMS/RMS_Client/Views/Shared/_ShowAuthors.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
