#pragma checksum "C:\Csharp_Nelio\Aplicacao\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a43fcd5d3ae95fca5386c9d0fdf3a73ae187f451"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Csharp_Nelio\Aplicacao\Views\_ViewImports.cshtml"
using Aplicacao;

#line default
#line hidden
#line 2 "C:\Csharp_Nelio\Aplicacao\Views\_ViewImports.cshtml"
using Aplicacao.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a43fcd5d3ae95fca5386c9d0fdf3a73ae187f451", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79324916cd296a0c3dbdbf7040eea0f65351f369", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Csharp_Nelio\Aplicacao\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(46, 17, false);
#line 4 "C:\Csharp_Nelio\Aplicacao\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(63, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(75, 19, false);
#line 5 "C:\Csharp_Nelio\Aplicacao\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(94, 32, true);
            WriteLiteral("</h3>\r\n\r\n<p>Site construído por ");
            EndContext();
            BeginContext(127, 20, false);
#line 7 "C:\Csharp_Nelio\Aplicacao\Views\Home\About.cshtml"
                  Write(ViewData["vinicius"]);

#line default
#line hidden
            EndContext();
            BeginContext(147, 22, true);
            WriteLiteral(".</p>\r\n<p>Meu e-mail: ");
            EndContext();
            BeginContext(170, 17, false);
#line 8 "C:\Csharp_Nelio\Aplicacao\Views\Home\About.cshtml"
          Write(ViewData["email"]);

#line default
#line hidden
            EndContext();
            BeginContext(187, 114, true);
            WriteLiteral("</p>\r\n<p>\r\n    <a href=\"https://www.linkedin.com/in/vinicius-do-nascimento-b98289189/\"> Meu LinkedIn. </a>\r\n</p>\r\n");
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
