#pragma checksum "D:\02-paoNetzao\formularioSimples\formularioSimples\Views\Viagem\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf1f03afff0278cdf9d9a14564904525c95e673a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Viagem_Listar), @"mvc.1.0.view", @"/Views/Viagem/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Viagem/Listar.cshtml", typeof(AspNetCore.Views_Viagem_Listar))]
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
#line 1 "D:\02-paoNetzao\formularioSimples\formularioSimples\Views\_ViewImports.cshtml"
using formularioSimples;

#line default
#line hidden
#line 2 "D:\02-paoNetzao\formularioSimples\formularioSimples\Views\_ViewImports.cshtml"
using formularioSimples.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf1f03afff0278cdf9d9a14564904525c95e673a", @"/Views/Viagem/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff43cf2de19e20bf9b8a7efb98cfdc165b3b413f", @"/Views/_ViewImports.cshtml")]
    public class Views_Viagem_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Viagem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "D:\02-paoNetzao\formularioSimples\formularioSimples\Views\Viagem\Listar.cshtml"
 if (TempData["msg"] != null) { 

#line default
#line hidden
            BeginContext(60, 42, true);
            WriteLiteral("<div class=\"alert alert-success\">\r\n    <p>");
            EndContext();
            BeginContext(103, 15, false);
#line 6 "D:\02-paoNetzao\formularioSimples\formularioSimples\Views\Viagem\Listar.cshtml"
  Write(TempData["msg"]);

#line default
#line hidden
            EndContext();
            BeginContext(118, 14, true);
            WriteLiteral("</p>\r\n</div>\r\n");
            EndContext();
#line 8 "D:\02-paoNetzao\formularioSimples\formularioSimples\Views\Viagem\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(139, 224, true);
            WriteLiteral("\r\n<h1>Listar viagens</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Destino</th>\r\n        <th>Valor</th>\r\n        <th>Data Saída</th>\r\n        <th>Internacional</th>\r\n        <th>Tipo</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 21 "D:\02-paoNetzao\formularioSimples\formularioSimples\Views\Viagem\Listar.cshtml"
     foreach (var p in Model)
    {

#line default
#line hidden
            BeginContext(401, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(432, 9, false);
#line 24 "D:\02-paoNetzao\formularioSimples\formularioSimples\Views\Viagem\Listar.cshtml"
           Write(p.Destino);

#line default
#line hidden
            EndContext();
            BeginContext(441, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(465, 7, false);
#line 25 "D:\02-paoNetzao\formularioSimples\formularioSimples\Views\Viagem\Listar.cshtml"
           Write(p.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(472, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(496, 31, false);
#line 26 "D:\02-paoNetzao\formularioSimples\formularioSimples\Views\Viagem\Listar.cshtml"
           Write(p.DataSaida.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(527, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(552, 31, false);
#line 27 "D:\02-paoNetzao\formularioSimples\formularioSimples\Views\Viagem\Listar.cshtml"
            Write(p.Internacional ? "Sim" : "Não");

#line default
#line hidden
            EndContext();
            BeginContext(584, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(608, 12, false);
#line 28 "D:\02-paoNetzao\formularioSimples\formularioSimples\Views\Viagem\Listar.cshtml"
           Write(p.TipoViagem);

#line default
#line hidden
            EndContext();
            BeginContext(620, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 30 "D:\02-paoNetzao\formularioSimples\formularioSimples\Views\Viagem\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(649, 14, true);
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Viagem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
