#pragma checksum "C:\Users\sam79\Desktop\GIT\TP1ApplicationDistribuer\TP1Distribution\movieGEN\movieGEN\Views\Home\ListEbay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba04823fae54394867ec030dadc872f83929f5bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListEbay), @"mvc.1.0.view", @"/Views/Home/ListEbay.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListEbay.cshtml", typeof(AspNetCore.Views_Home_ListEbay))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba04823fae54394867ec030dadc872f83929f5bb", @"/Views/Home/ListEbay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96f350a43f5359ed488453bfb61ddc222e4fabfb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListEbay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\sam79\Desktop\GIT\TP1ApplicationDistribuer\TP1Distribution\movieGEN\movieGEN\Views\Home\ListEbay.cshtml"
  
    ViewData["Title"] = "ListEbay";
    Layout = "~/Views/Shared/_Layout.cshtml";
    string targetLanguage = "fr";
    string sourceLanguage = null; // automatically detected
    var client = Google.Cloud.Translation.V2.TranslationClient.Create();

#line default
#line hidden
            BeginContext(263, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(270, 121, false);
#line 10 "C:\Users\sam79\Desktop\GIT\TP1ApplicationDistribuer\TP1Distribution\movieGEN\movieGEN\Views\Home\ListEbay.cshtml"
Write(System.Web.HttpUtility.HtmlDecode(client.TranslateHtml("Article de Ebay", targetLanguage, sourceLanguage).TranslatedText));

#line default
#line hidden
            EndContext();
            BeginContext(391, 3339, true);
            WriteLiteral(@"</h2>
<div id=""results""></div>

<script>
    // Parse the response and build an HTML table to display search results
    function _cb_findItemsByKeywords(root) {
        var items = root.findItemsByKeywordsResponse[0].searchResult[0].item || [];
        var html = [];
        html.push('<table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""3""><tbody>');
        for (var i = 0; i < items.length; ++i) {
            var item = items[i];
            var title = item.title;
            var pic = item.galleryURL;
            var viewitem = item.viewItemURL;
            if (null != title && null != viewitem) {
                html.push('<tr><td>' + '<img src=""' + pic + '"" border=""0"">' + '</td>' +
                    '<td><a href=""' + viewitem + '"" target=""_blank"">' + title + '</a></td></tr>');
            }
        }
        html.push('</tbody></table>');
        document.getElementById(""results"").innerHTML = html.join("""");
    }  // End _cb_findItemsByKeywords() function

    // Create ");
            WriteLiteral(@"a JavaScript array of the item filters you want to use in your request
    var filterarray = [
        {
            ""name"": ""MaxPrice"",
            ""value"": ""25"",
            ""paramName"": ""Currency"",
            ""paramValue"": ""USD""
        },
        {
            ""name"": ""FreeShippingOnly"",
            ""value"": ""true"",
            ""paramName"": """",
            ""paramValue"": """"
        },
        {
            ""name"": ""ListingType"",
            ""value"": [""AuctionWithBIN"", ""FixedPrice""],
            ""paramName"": """",
            ""paramValue"": """"
        },
    ];
    // Define global variable for the URL filter
    var urlfilter = """";
        // Generates an indexed URL snippet from the array of item filters
    function buildURLArray() {
        // Iterate through each filter in the array
        for (var i = 0; i < filterarray.length; i++) {
            //Index each item filter in filterarray
            var itemfilter = filterarray[i];
            // Iterate through each paramete");
            WriteLiteral(@"r in each item filter
            for (var index in itemfilter) {
                // Check to see if the paramter has a value (some don't)
                if (itemfilter[index] !== """") {
                    if (itemfilter[index] instanceof Array) {
                        for (var r = 0; r < itemfilter[index].length; r++) {
                            var value = itemfilter[index][r];
                            urlfilter += ""&itemFilter\("" + i + ""\)."" + index + ""\("" + r + ""\)="" + value;
                        }
                    }
                    else {
                        urlfilter += ""&itemFilter\("" + i + ""\)."" + index + ""="" + itemfilter[index];
                    }
                }
            }
        }
    }  // End buildURLArray() function

    // Execute the function to build the URL filter
    buildURLArray(filterarray);

    var url = ""https://svcs.ebay.com/services/search/FindingService/v1"";
    url += ""?OPERATION-NAME=findItemsByKeywords"";
    url += ""&SERVICE-");
            WriteLiteral(@"VERSION=1.0.0"";
    url += ""&SECURITY-APPNAME=SamuelDe-movieGEN-PRD-9dfe51816-c0152236"";
    url += ""&GLOBAL-ID=EBAY-US"";
    url += ""&RESPONSE-DATA-FORMAT=JSON"";
    url += ""&callback=_cb_findItemsByKeywords"";
    url += ""&REST-PAYLOAD"";
    url += ""&keywords=");
            EndContext();
            BeginContext(3731, 16, false);
#line 91 "C:\Users\sam79\Desktop\GIT\TP1ApplicationDistribuer\TP1Distribution\movieGEN\movieGEN\Views\Home\ListEbay.cshtml"
                 Write(ViewData["Film"]);

#line default
#line hidden
            EndContext();
            BeginContext(3747, 247, true);
            WriteLiteral("\";\r\n    url += \"&paginationInput.entriesPerPage=3\";\r\n\r\n    url += urlfilter;\r\n    \r\n    // Submit the request\r\n    s = document.createElement(\'script\'); // create script element\r\n    s.src = url;\r\n    document.body.appendChild(s);\r\n\r\n</script>\r\n\r\n");
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
