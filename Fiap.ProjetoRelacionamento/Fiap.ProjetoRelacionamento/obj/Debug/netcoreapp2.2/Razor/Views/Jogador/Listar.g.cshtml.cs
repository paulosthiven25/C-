#pragma checksum "C:\Users\logonrmlocal\Desktop\C-\Fiap.ProjetoRelacionamento\Fiap.ProjetoRelacionamento\Views\Jogador\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0367c2a98dcc9ec8a3f81e07f1dee632883de9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jogador_Listar), @"mvc.1.0.view", @"/Views/Jogador/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Jogador/Listar.cshtml", typeof(AspNetCore.Views_Jogador_Listar))]
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
#line 1 "C:\Users\logonrmlocal\Desktop\C-\Fiap.ProjetoRelacionamento\Fiap.ProjetoRelacionamento\Views\_ViewImports.cshtml"
using Fiap.ProjetoRelacionamento;

#line default
#line hidden
#line 2 "C:\Users\logonrmlocal\Desktop\C-\Fiap.ProjetoRelacionamento\Fiap.ProjetoRelacionamento\Views\_ViewImports.cshtml"
using Fiap.ProjetoRelacionamento.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0367c2a98dcc9ec8a3f81e07f1dee632883de9e", @"/Views/Jogador/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17b3ef2c32b02486c5bbcf602b03453373f40b36", @"/Views/_ViewImports.cshtml")]
    public class Views_Jogador_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Jogador>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Time", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "timeBusca", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "jogador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "listar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Fiap.ProjetoRelacionamento.TagHelpers.MensagemTagHelper __Fiap_ProjetoRelacionamento_TagHelpers_MensagemTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(25, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("Mensagem", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0367c2a98dcc9ec8a3f81e07f1dee632883de9e6528", async() => {
            }
            );
            __Fiap_ProjetoRelacionamento_TagHelpers_MensagemTagHelper = CreateTagHelper<global::Fiap.ProjetoRelacionamento.TagHelpers.MensagemTagHelper>();
            __tagHelperExecutionContext.Add(__Fiap_ProjetoRelacionamento_TagHelpers_MensagemTagHelper);
            BeginWriteTagHelperAttribute();
#line 3 "C:\Users\logonrmlocal\Desktop\C-\Fiap.ProjetoRelacionamento\Fiap.ProjetoRelacionamento\Views\Jogador\Listar.cshtml"
   WriteLiteral(TempData["msg"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Fiap_ProjetoRelacionamento_TagHelpers_MensagemTagHelper.Msg = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("msg", __Fiap_ProjetoRelacionamento_TagHelpers_MensagemTagHelper.Msg, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(69, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(75, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0367c2a98dcc9ec8a3f81e07f1dee632883de9e8239", async() => {
                BeginContext(144, 9, true);
                WriteLiteral("Cadastrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(157, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(159, 336, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0367c2a98dcc9ec8a3f81e07f1dee632883de9e9901", async() => {
                BeginContext(223, 40, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(263, 132, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0367c2a98dcc9ec8a3f81e07f1dee632883de9e10326", async() => {
                    BeginContext(336, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(350, 26, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0367c2a98dcc9ec8a3f81e07f1dee632883de9e10743", async() => {
                        BeginContext(358, 9, true);
                        WriteLiteral("Selecione");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(376, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 9 "C:\Users\logonrmlocal\Desktop\C-\Fiap.ProjetoRelacionamento\Fiap.ProjetoRelacionamento\Views\Jogador\Listar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.times;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(395, 93, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Buscar\" class=\"btn btn-success ml-2\" />\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(495, 237, true);
            WriteLiteral("\r\n\r\n<div>\r\n    <table class=\"table table table-bordered table-striped\">\r\n        <tr>\r\n            <th>Nome</th>\r\n            <th>DataNascimento</th>\r\n            <th>Altura</th>\r\n            <th>Time</th>\r\n           \r\n        </tr>\r\n\r\n");
            EndContext();
#line 27 "C:\Users\logonrmlocal\Desktop\C-\Fiap.ProjetoRelacionamento\Fiap.ProjetoRelacionamento\Views\Jogador\Listar.cshtml"
         foreach (var jogador in Model)
        {

#line default
#line hidden
            BeginContext(784, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(823, 12, false);
#line 30 "C:\Users\logonrmlocal\Desktop\C-\Fiap.ProjetoRelacionamento\Fiap.ProjetoRelacionamento\Views\Jogador\Listar.cshtml"
               Write(jogador.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(835, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(864, 22, false);
#line 31 "C:\Users\logonrmlocal\Desktop\C-\Fiap.ProjetoRelacionamento\Fiap.ProjetoRelacionamento\Views\Jogador\Listar.cshtml"
                Write(jogador.DataNascimento);

#line default
#line hidden
            EndContext();
            BeginContext(887, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(915, 14, false);
#line 32 "C:\Users\logonrmlocal\Desktop\C-\Fiap.ProjetoRelacionamento\Fiap.ProjetoRelacionamento\Views\Jogador\Listar.cshtml"
               Write(jogador.Altura);

#line default
#line hidden
            EndContext();
            BeginContext(929, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(957, 17, false);
#line 33 "C:\Users\logonrmlocal\Desktop\C-\Fiap.ProjetoRelacionamento\Fiap.ProjetoRelacionamento\Views\Jogador\Listar.cshtml"
               Write(jogador.Time.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(974, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 35 "C:\Users\logonrmlocal\Desktop\C-\Fiap.ProjetoRelacionamento\Fiap.ProjetoRelacionamento\Views\Jogador\Listar.cshtml"
        }

#line default
#line hidden
            BeginContext(1011, 24, true);
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Jogador>> Html { get; private set; }
    }
}
#pragma warning restore 1591
