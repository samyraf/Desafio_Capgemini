#pragma checksum "C:\Users\samy_\OneDrive\Área de Trabalho\desafio-capgemini\CadastroAnuncio\CadastroAnuncio\Views\Home\Anuncio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "705a89aef7753d6916fe7a62a956a74e70cb2b74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Anuncio), @"mvc.1.0.view", @"/Views/Home/Anuncio.cshtml")]
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
#line 1 "C:\Users\samy_\OneDrive\Área de Trabalho\desafio-capgemini\CadastroAnuncio\CadastroAnuncio\Views\_ViewImports.cshtml"
using CadastroAnuncio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samy_\OneDrive\Área de Trabalho\desafio-capgemini\CadastroAnuncio\CadastroAnuncio\Views\_ViewImports.cshtml"
using Entities.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"705a89aef7753d6916fe7a62a956a74e70cb2b74", @"/Views/Home/Anuncio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"079c44e7b02f6b53e53e3a391a88af461b87e7d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Anuncio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/anuncio.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\n    ");
            WriteLiteral(@"@import url('https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap');

    * {
        margin: 0;
        border: 0;
        padding: 0;
        box-sizing: border-box;
        font-family: 'Poppins', sans-serif;
    }

    #header {
        height: 100vh;
        background-image: url(../Images/background2.png);
        background-repeat: no-repeat;
        background-position: center;
        background-size: cover;
    }

    .content-container {
        min-width: 100vw;
        min-height: 100vh;
        display: flex;
        align-items: center;
        justify-content: center;
    }

    .form {
        background: white;
        max-width: 550px;
        min-height: 60vh;
        padding: 3rem;
        box-shadow: 5px 5px 15px rgba(0, 0, 0, 0.3);
        border-radius: 30px;
        border: 1px #8e2de2 solid;
    }

    .logo {
        width: 100px;
        margin-left: 165px;");
            WriteLiteral(@"
    }

    h2 {
        font-size: 30px;
        font-weight: 700;
        margin-bottom: 2rem;
        position: relative;
        text-align: center;
    }

        h2::before {
            content: '';
            position: absolute;
            height: 8px;
            width: 60px;
            bottom: 1px;
            left: 92px;
            border-radius: 8px;
            background: linear-gradient(45deg, #9B72AA, #8e54e9);
        }

    .box {
        padding: 20px;
        margin: 5px;
        height: 30px;
        width: 260px;
        border-radius: 50px;
        border: 1px solid #8e2de2;
    }

    .btn {
        width: 200px;
        height: 50px;
        background: linear-gradient(to left, #9B72AA, #8e54e9);
        cursor: pointer;
        border-radius: 50px;
        margin-left: 120px;
        margin-top: 2rem;
        font-size: 1.3rem;
        transition: all 0.3s ease;
        color: white;
    }

        .btn:hover {
            letter-spacing: 3px;
            transition: all 0.8s eas");
            WriteLiteral(@"e;
            background: linear-gradient(to right, #9B72AA, #8e54e9);
        }

    a {
        text-decoration: none;
        color: #fff;
    }    
</style>

<section id=""header"">
    <main class=""content-container"">
        <div class=""form"">
            <img src=""../Images/logo.png"" class=""logo"">
            <h2>Cadastramento</h2>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "705a89aef7753d6916fe7a62a956a74e70cb2b746361", async() => {
                WriteLiteral(@"
                <div class=""input-field"">
                    <span class=""details"">Cliente</span>
                    <input id=""cliente"" class=""box"" type=""text"" placeholder=""Insira seu nome completo"" required>
                </div>
                <div class=""input-field"">
                    <span class=""details"">Anúncio</span>
                    <input id=""nomeAnuncio"" class=""box"" type=""text"" placeholder=""Insira o nome do anúncio"" required>
                </div>
                <div class=""input-field"">
                    <span class=""details"">Data de início</span>
                    <input id=""dataInicio"" class=""box"" type=""date"" required>
                </div>
                <div class=""input-field"">
                    <span class=""details"">Data de término</span>
                    <input id=""dataTermino"" class=""box"" type=""date"" required>
                </div>
                <div class=""input-field"">
                    <span class=""details"">Investimento diário</span>
                    <inp");
                WriteLiteral(@"ut id=""investimentoPorDia"" class=""box"" type=""number"" placeholder=""Insira o valor em R$"" required>
                </div>
                <div class=""button"">
                    <button class=""btn"" type=""submit"" onclick=""inserir()"">Cadastrar</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n    </main>\n</section>\n\n<img src=\"../Images/menu.png\" id=\"menuBtn\" style=\"border-radius: 10px;\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "705a89aef7753d6916fe7a62a956a74e70cb2b749122", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
