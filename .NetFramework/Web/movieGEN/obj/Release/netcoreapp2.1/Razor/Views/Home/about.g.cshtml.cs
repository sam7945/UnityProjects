#pragma checksum "C:\Users\sam79\Desktop\GIT\TP1ApplicationDistribuer\TP1Distribution\movieGEN\movieGEN\Views\Home\about.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30a98da3e5a7de637d767e0ea66e66fc01a7d4e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_about), @"mvc.1.0.view", @"/Views/Home/about.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/about.cshtml", typeof(AspNetCore.Views_Home_about))]
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
#line 1 "C:\Users\sam79\Desktop\GIT\TP1ApplicationDistribuer\TP1Distribution\movieGEN\movieGEN\Views\_ViewImports.cshtml"
using movieGEN;

#line default
#line hidden
#line 2 "C:\Users\sam79\Desktop\GIT\TP1ApplicationDistribuer\TP1Distribution\movieGEN\movieGEN\Views\_ViewImports.cshtml"
using movieGEN.Models;

#line default
#line hidden
#line 3 "C:\Users\sam79\Desktop\GIT\TP1ApplicationDistribuer\TP1Distribution\movieGEN\movieGEN\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 4 "C:\Users\sam79\Desktop\GIT\TP1ApplicationDistribuer\TP1Distribution\movieGEN\movieGEN\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30a98da3e5a7de637d767e0ea66e66fc01a7d4e9", @"/Views/Home/about.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96f350a43f5359ed488453bfb61ddc222e4fabfb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_about : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\sam79\Desktop\GIT\TP1ApplicationDistribuer\TP1Distribution\movieGEN\movieGEN\Views\Home\about.cshtml"
  
    ViewData["Title"] = "about";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 690, true);
            WriteLiteral(@"<style>
    #shadowBox {
    background-color: rgb(0, 0, 0);
    /* Fallback color */
    background-color: rgba(0, 0, 0, 0.2);
    /* Black w/opacity/see-through */
    border: 3px solid;
}

    .rainbow {
        text-align: center;
        text-decoration: underline;
        font-size: 32px;
        font-family: 'Lobster', cursive;
        letter-spacing: 5px;
    }
.rainbow_text_animated {
    background: linear-gradient(to right, #6666ff, #0099ff , #00ff00, #ff3399, #6666ff);
    -webkit-background-clip: text;
    background-clip: text;
    color: transparent;
    animation: rainbow_animation 6s ease-in-out infinite;
    background-size: 400% 100%;
}

");
            EndContext();
            BeginContext(781, 784, true);
            WriteLiteral(@"@keyframes rainbow_animation {
    0%,100% {
        background-position: 0 0;
    }

    50% {
        background-position: 100% 0;
    }
}
</style>
<div class=""container"">
    <br><br>
    <div class=""row"">
        <div class=""col-sm-12"" style=""text-align : center"">
           <u> <h1 class=""text-monospace"">À propos de nous</h1></u>
            <br>
            <h2 class=""text-monospace"">Felix Noiseux | Samuel Dextraze</h2>
            <h2 class=""text-monospace"">Septembre 2019</h2>
           <b><p class=""text-monospace"">Projet : </p></b>
        </div>
        <br><br>
        <div class=""col-sm-12"">
            <h1 style=""font-size : 400%;"" class=""rainbow rainbow_text_animated"">MovieGen</h1>

        </div>
        <br><br>
    </div>
</div>
");
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
