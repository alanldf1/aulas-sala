#pragma checksum "C:\xampp\htdocs\Alan_Sou\aulas-sala\projeto-csharp\mvcproject\mvcproject\Views\Signup\Signup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc5e4e8faa2d848e1201f31062099ade61429f5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Signup_Signup), @"mvc.1.0.view", @"/Views/Signup/Signup.cshtml")]
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
#line 1 "C:\xampp\htdocs\Alan_Sou\aulas-sala\projeto-csharp\mvcproject\mvcproject\Views\_ViewImports.cshtml"
using mvcproject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\xampp\htdocs\Alan_Sou\aulas-sala\projeto-csharp\mvcproject\mvcproject\Views\_ViewImports.cshtml"
using mvcproject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc5e4e8faa2d848e1201f31062099ade61429f5c", @"/Views/Signup/Signup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"899233e96cc852233039d0981f740e8b0d2d7dc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Signup_Signup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("formContact text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\xampp\htdocs\Alan_Sou\aulas-sala\projeto-csharp\mvcproject\mvcproject\Views\Signup\Signup.cshtml"
  
    ViewData["Title"] = "Cadastro";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"" id=""banner"">
    <h1 class=""col-12 m-4 text-center"">Faça seu cadastro para ter mais recursos no nosso site</h1>
</div>

<div class=""contact"" id=""content-contact"">

    <section>

        <div class=""container"">

            <h2 class=""text-center m-5"" style=""text-decoration: underline;"">Preencha o formulário para enviar a mensagem!</h2><br>


            <div class=""row"">

                <!-- Formulário -->
                <div class=""text-center col-6"">

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc5e4e8faa2d848e1201f31062099ade61429f5c4405", async() => {
                WriteLiteral(@"

                        <div class=""form-group"">
                            <label>Nome</label><br>
                            <input class=""form-control"" type=""text"" name=""name"" placeholder=""Digite seu nome completo."">
                        </div>

                        <div class=""form-group"">
                            <label>E-mail</label><br>
                            <input class=""form-control"" type=""email"" name=""email"" placeholder=""Digite seu E-mail."">
                        </div>

                        <div class=""form-group"">
                            <label>Telefone</label><br>
                            <input class=""form-control"" type=""text"" name=""phone"" placeholder=""Digite seu número de telefone."">
                        </div>

                        <div class=""form-group mb-5"">
                            <label>Mensagem</label><br>
                            <textarea class=""form-control"" name=""message"" placeholder=""Deixe o seu motivo para contato""></te");
                WriteLiteral("xtarea>\r\n                        </div>\r\n\r\n                        <div class=\"form-group\">\r\n                            <div class=\"btn btn-secondary\" id=\"btnSubmitContact\">Enviar</div>\r\n                        </div>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n                \r\n            </div>\r\n\r\n        </div>\r\n\r\n    </section>\r\n\r\n</div>\r\n");
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
