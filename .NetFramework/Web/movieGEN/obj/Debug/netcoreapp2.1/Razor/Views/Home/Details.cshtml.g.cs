#pragma checksum "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\Home\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9a7306adeb84921ff831f84e7f554aa314ccbed1c96276abcdc24b5daf95015b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\_ViewImports.cshtml"
using movieGEN;

#line default
#line hidden
#line 2 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\_ViewImports.cshtml"
using movieGEN.Models;

#line default
#line hidden
#line 3 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 4 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 5 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\_ViewImports.cshtml"
using movieGEN.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9a7306adeb84921ff831f84e7f554aa314ccbed1c96276abcdc24b5daf95015b", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"65cfe831ce58b855cfe4a0e0a6341739c434b510429cafba6a44d6c3552b4b5c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<movieGEN.Models.ImdbEntity>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListEbay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";
    string targetLanguage = Environment.GetEnvironmentVariable("TARGET_LANGUAGE");
    string sourceLanguage = null; // automatically detected
    //var client = Google.Cloud.Translation.V2.TranslationClient.Create();

#line default
#line hidden
            BeginContext(348, 28, true);
            WriteLiteral("<script>\r\n    var imgUrl = \'");
            EndContext();
            BeginContext(377, 12, false);
#line 11 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\Home\Details.cshtml"
             Write(Model.Poster);

#line default
#line hidden
            EndContext();
            BeginContext(389, 71, true);
            WriteLiteral("\';\r\n</script>\r\n<div class=\"w-100 p-3\" style=\"height : 200px\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 460, "\"", 505, 1);
#line 14 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\Home\Details.cshtml"
WriteAttributeValue("", 466, Html.DisplayFor(model => model.Poster), 466, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(506, 398, true);
            WriteLiteral(@" style=""width : 120% ; height : 100%; object-fit : cover ; margin-left : -10%; margin-top : -2%"" onerror=""this.onerror=null;this.src='https://us.123rf.com/450wm/pavelstasevich/pavelstasevich1811/pavelstasevich181101065/112815953-stock-vector-no-image-available-icon-flat-vector.jpg?ver=6';""/>
</div>
<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-3"">
            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 904, "\"", 949, 1);
#line 19 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\Home\Details.cshtml"
WriteAttributeValue("", 910, Html.DisplayFor(model => model.Poster), 910, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(950, 287, true);
            WriteLiteral(@" class=""img-thumbnail"" onerror=""this.onerror=null;this.src='https://us.123rf.com/450wm/pavelstasevich/pavelstasevich1811/pavelstasevich181101065/112815953-stock-vector-no-image-available-icon-flat-vector.jpg?ver=6';""/>
        </div>
        <div class=""col-sm-9"">
            <h2><b>");
            EndContext();
            BeginContext(1299, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1301, 11, false);
#line 22 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\Home\Details.cshtml"
                                                                             Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1367, 61, true);
            WriteLiteral("</b></h2>\r\n            <p><i class=\"fas fa-star\"></i>&nbsp;  ");
            EndContext();
            BeginContext(1429, 42, false);
#line 23 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\Home\Details.cshtml"
                                             Write(Html.DisplayFor(model => model.imdbRating));

#line default
#line hidden
            EndContext();
            BeginContext(1471, 62, true);
            WriteLiteral("</p>\r\n            <button type=\"button\" class=\"btn btn-light\">");
            EndContext();
            BeginContext(1533, 221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a7306adeb84921ff831f84e7f554aa314ccbed1c96276abcdc24b5daf95015b9156", async() => {
                BeginContext(1607, 3, true);
                WriteLiteral("<b>");
                EndContext();
                BeginContext(1673, 16, true);
                WriteLiteral("ACHETER SUR EBAY");
                EndContext();
                BeginContext(1745, 5, true);
                WriteLiteral("</b> ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Title", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\Home\Details.cshtml"
                                                                                                         WriteLiteral(Model.Title);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1754, 136, true);
            WriteLiteral("<i class=\"fab fa-ebay\"></i></button>\r\n            &nbsp;\r\n            <button type=\"button\" class=\"btn btn-light\"><a style=\"color:black\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1890, "\"", 1920, 1);
#line 26 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\Home\Details.cshtml"
WriteAttributeValue("", 1897, ViewData["URLYoutube"], 1897, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1921, 20, true);
            WriteLiteral(" target=\"_blank\"><b>");
            EndContext();
            BeginContext(2004, 21, true);
            WriteLiteral("VOIR LA BANDE ANNONCE");
            EndContext();
            BeginContext(2087, 186, true);
            WriteLiteral("</b></a> <i class=\"fab fa-youtube\"></i></button>\r\n        </div>\r\n    </div>\r\n    <br>\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n            <h2 style=\"text-align : left\">");
            EndContext();
            BeginContext(2336, 6, true);
            WriteLiteral("Résumé");
            EndContext();
            BeginContext(2398, 22, true);
            WriteLiteral("</h2>\r\n            <p>");
            EndContext();
            BeginContext(2482, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2484, 10, false);
#line 33 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\Home\Details.cshtml"
                                                                         Write(Model.Plot);

#line default
#line hidden
            EndContext();
            BeginContext(2549, 160, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-6\">\r\n            <h2 style=\"text-align : left\">Casting</h2>\r\n            <p>");
            EndContext();
            BeginContext(2771, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2773, 12, false);
#line 39 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\Home\Details.cshtml"
                                                                         Write(Model.Actors);

#line default
#line hidden
            EndContext();
            BeginContext(2840, 96, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-sm-6\">\r\n            <h2 style=\"text-align : left\">");
            EndContext();
            BeginContext(2999, 6, true);
            WriteLiteral("Équipe");
            EndContext();
            BeginContext(3061, 22, true);
            WriteLiteral("</h2>\r\n            <p>");
            EndContext();
            BeginContext(3145, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3147, 12, false);
#line 43 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\Home\Details.cshtml"
                                                                         Write(Model.Writer);

#line default
#line hidden
            EndContext();
            BeginContext(3214, 21, true);
            WriteLiteral("</p>\r\n            <p>");
            EndContext();
            BeginContext(3297, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3299, 14, false);
#line 44 "D:\école\session7\Developpement_Distribuer\TP1Distribution(SamuelDextraze_ET_FelixNoiseux)\TP1Distribution\movieGEN\movieGEN\Views\Home\Details.cshtml"
                                                                         Write(Model.Director);

#line default
#line hidden
            EndContext();
            BeginContext(3368, 55, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3423, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a7306adeb84921ff831f84e7f554aa314ccbed1c96276abcdc24b5daf95015b16148", async() => {
                BeginContext(3508, 6, true);
                WriteLiteral("Retour");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3574, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<movieGEN.Models.ImdbEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591
