#pragma checksum "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac4a4deb9dacc653282d779431b14093bb26930e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Tab), @"mvc.1.0.view", @"/Views/Home/Tab.cshtml")]
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
#line 1 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\_ViewImports.cshtml"
using WebApplicationMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\_ViewImports.cshtml"
using WebApplicationMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac4a4deb9dacc653282d779431b14093bb26930e", @"/Views/Home/Tab.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4113f9bd8ca5f5f187ae62cb42d7057125d4c09e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Tab : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ParserAnalyzing.Model.ViewTable>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <!--<th>country</th>\r\n        <th>domain</th>\r\n        <th>create_date</th>\r\n        <th>update_date</th>\r\n        <th>isDead</th>-->\r\n");
            WriteLiteral("    <!--</tr>-->\r\n");
#nullable restore
#line 31 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
     for (int i = 0; i < Model.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <th>country</th>\r\n        <td>");
#nullable restore
#line 35 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
       Write(Model[i].country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <th>domain</th>\r\n        <td>");
#nullable restore
#line 37 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
       Write(Model[i].domain);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <th>create_date</th>\r\n        <td>");
#nullable restore
#line 39 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
       Write(Model[i].create_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <th>update_date</th>\r\n        <td>");
#nullable restore
#line 41 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
       Write(Model[i].update_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <th>isDead</th>\r\n        <td>");
#nullable restore
#line 43 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
       Write(Model[i].isDead);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 45 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
         for (int k = 0; k < Model[i].NS?.Count; k++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>NS</th>\r\n            <td> ");
#nullable restore
#line 48 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
            Write(Model[i].NS[k]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 49 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
         for (int j = 0; j < Model[i].CNAME?.Count; j++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>CNAME</th>\r\n            <td> ");
#nullable restore
#line 53 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
            Write(Model[i].CNAME[j]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 54 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
         for (int n = 0; n < Model[i].A?.Count; n++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th> A</th>\r\n            <td> ");
#nullable restore
#line 58 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
            Write(Model[i].A[n]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 59 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
         for (int b = 0; b < Model[i].MX?.Count; b++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th> MX</th>\r\n            <td> ");
#nullable restore
#line 63 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
            Write(Model[i].MX[b].exchange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <th> MX</th>\r\n            <td> ");
#nullable restore
#line 65 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
            Write(Model[i].MX[b].priority);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 66 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tr>\r\n");
#nullable restore
#line 69 "C:\Users\User\source\repos\WebApplicationMvcRelease\WebApplicationMvc\Views\Home\Tab.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ParserAnalyzing.Model.ViewTable>> Html { get; private set; }
    }
}
#pragma warning restore 1591
