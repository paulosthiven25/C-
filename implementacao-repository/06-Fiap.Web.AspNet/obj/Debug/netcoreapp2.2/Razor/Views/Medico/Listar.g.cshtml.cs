#pragma checksum "C:\Users\logonrmlocal\Desktop\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Medico\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bdcd409ba8f80742769df3d3bffb0ea0fc464b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medico_Listar), @"mvc.1.0.view", @"/Views/Medico/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Medico/Listar.cshtml", typeof(AspNetCore.Views_Medico_Listar))]
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
#line 1 "C:\Users\logonrmlocal\Desktop\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _06_Fiap.Web.AspNet;

#line default
#line hidden
#line 2 "C:\Users\logonrmlocal\Desktop\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _06_Fiap.Web.AspNet.Models;

#line default
#line hidden
#line 3 "C:\Users\logonrmlocal\Desktop\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _06_Fiap.Web.AspNet.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bdcd409ba8f80742769df3d3bffb0ea0fc464b1", @"/Views/Medico/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea5ec748c0a27873567765ff021adea2c43c769", @"/Views/_ViewImports.cshtml")]
    public class Views_Medico_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Medico>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "consulta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\logonrmlocal\Desktop\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Medico\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(65, 162, true);
            WriteLiteral("\r\n<h1>Médicos</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>CRM</th>\r\n        <th>Nome</th>\r\n        <th>Especialidade</th>\r\n        <th></th>\r\n    </tr>\r\n");
            EndContext();
#line 15 "C:\Users\logonrmlocal\Desktop\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Medico\Listar.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(268, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(299, 8, false);
#line 18 "C:\Users\logonrmlocal\Desktop\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Medico\Listar.cshtml"
           Write(item.Crm);

#line default
#line hidden
            EndContext();
            BeginContext(307, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(331, 9, false);
#line 19 "C:\Users\logonrmlocal\Desktop\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Medico\Listar.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(340, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(364, 18, false);
#line 20 "C:\Users\logonrmlocal\Desktop\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Medico\Listar.cshtml"
           Write(item.Especialidade);

#line default
#line hidden
            EndContext();
            BeginContext(382, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(423, 225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bdcd409ba8f80742769df3d3bffb0ea0fc464b16195", async() => {
                BeginContext(588, 56, true);
                WriteLiteral("\r\n                    Agendar Consulta\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-medico", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\logonrmlocal\Desktop\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Medico\Listar.cshtml"
                         WriteLiteral(item.MedicoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["medico"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-medico", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["medico"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(648, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 29 "C:\Users\logonrmlocal\Desktop\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Medico\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(691, 14, true);
            WriteLiteral("</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Medico>> Html { get; private set; }
    }
}
#pragma warning restore 1591
