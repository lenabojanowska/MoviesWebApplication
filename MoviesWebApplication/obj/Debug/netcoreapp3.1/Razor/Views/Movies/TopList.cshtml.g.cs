#pragma checksum "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\Movies\TopList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6965fc4c213c824859be2d54ff047a8a84c1f3eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_TopList), @"mvc.1.0.view", @"/Views/Movies/TopList.cshtml")]
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
#line 1 "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\_ViewImports.cshtml"
using MoviesWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\_ViewImports.cshtml"
using MoviesWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6965fc4c213c824859be2d54ff047a8a84c1f3eb", @"/Views/Movies/TopList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff5912c456796afa826218a695b32754050fd4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_TopList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("integrity", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("crossorigin", new global::Microsoft.AspNetCore.Html.HtmlString("anonymous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/scripts/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("runat", new global::Microsoft.AspNetCore.Html.HtmlString("server"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\Movies\TopList.cshtml"
  
    ViewData["Title"] = "TopList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6965fc4c213c824859be2d54ff047a8a84c1f3eb5848", async() => {
                WriteLiteral(@"

    <style>
        .posters {
            width: 150px;
            height: 200px;
        }

        #text {
            font-size: 18px;
        }

        table tr {
            border: solid 1px;
            border-color: lightgrey;
        }
    </style>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6965fc4c213c824859be2d54ff047a8a84c1f3eb6389", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6965fc4c213c824859be2d54ff047a8a84c1f3eb7749", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6965fc4c213c824859be2d54ff047a8a84c1f3eb9730", async() => {
                WriteLiteral("\r\n    <h2>Top Rated</h2>\r\n    <br />\r\n    <div id=\"cardContainer\">\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
#nullable restore
#line 39 "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\Movies\TopList.cshtml"
 if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"wrapper row\">\r\n");
#nullable restore
#line 42 "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\Movies\TopList.cshtml"
             foreach (var movie in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"item m-4\">\r\n                    <script>\r\n\r\n                    $(document).ready(function () {\r\n                        $.getJSON(\'https://www.omdbapi.com/?apikey=\' + \'4713f8\' + \'&i=tt\' + ");
#nullable restore
#line 48 "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\Movies\TopList.cshtml"
                                                                                       Write(movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" , function (data) {
                            var contentString = '';
                            var title = data.Title;
                            var article_data = '';
                            if (data.Poster == ""N/A"" || data.Poster == null) {
                                contentString = '<table>' +
                                    '<tbody>' +
                                    '<tr>' +
                                    '<th style=""width: 210px;"">' +
                                    '<img class =""posters""  src=' + links + ' />' +
                                    '</th>' +
                                    '<th style=""width: 590px;"" id=""text"">' +
                                    data.results[i].title +
                                    '</th>' +
                                    '<th style=""width: 200px;"">' +
                                    '<img style=""width: 18px; height: 20px;"" src=""/Images/Star.png"" />' + ' ' + data.results[i].vote_average + ' (' + data");
            WriteLiteral(@".results[i].vote_count + ' votes)' +
                                    '</th>' +
                                    '</tr>' +
                                    '</tbody>' +
                                    '</table></br>'       
                                article_data += '<div class=""box""><img src=""/Images/black.jpg"" alt="" ' + data.Title + ' ""  id=""' + data.Title + '"" class=""posters"" /><div alt="" ' + data.Title + ' ""  id=""' + data.Title +'"" class=""text""><h6>'+title+'</h6></div></div>';
                            } else {
                                contentString[i] = '<table>' +
                                    '<tbody>' +
                                    '<tr>' +
                                    '<th style=""width: 210px;"">' +
                                    '<img class =""posters""  src=' + links + ' />' +
                                    '</th>' +
                                    '<th style=""width: 590px;"" id=""text"">' +
                                    dat");
            WriteLiteral(@"a.results[i].title +
                                    '</th>' +
                                    '<th style=""width: 200px;"">' +
                                    '<img style=""width: 18px; height: 20px;"" src=""/Images/Star.png"" />' + ' ' + data.results[i].vote_average + ' (' + data.results[i].vote_count + ' votes)' +
                                    '</th>' +
                                    '</tr>' +
                                    '</tbody>' +
                                    '</table></br>'         
                                article_data += '<div><img  src="" ' + data.Poster + ' "" alt="" ' + data.Title + ' ""  id=""' + data.Title + '"" class=""posters"" /></div>';
                            }
                            var images = document.getElementsByTagName(""img"");
                            for (var i = 0; i < images.length; i++) {
                                var image = images[i];
                                image.onclick = function (event) {

             ");
            WriteLiteral(@"                       window.location.href = 'https://localhost:44329/Movies/Details/' + this.id;
                                };
                            }
                            $('#article_table').append(content);

                        });
                    });
</script>

                </div>
");
#nullable restore
#line 102 "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\Movies\TopList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 104 "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\Movies\TopList.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>No Movies Available Right Now</h4>\r\n");
#nullable restore
#line 108 "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\Movies\TopList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
