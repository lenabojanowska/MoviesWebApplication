#pragma checksum "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\Movies\ActionMovies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9133d1a9d3c5ed42c519e55ba0e031636ed42b9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_ActionMovies), @"mvc.1.0.view", @"/Views/Movies/ActionMovies.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9133d1a9d3c5ed42c519e55ba0e031636ed42b9e", @"/Views/Movies/ActionMovies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff5912c456796afa826218a695b32754050fd4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_ActionMovies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MoviesWebApplication.Data.MovieDBO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("integrity", new global::Microsoft.AspNetCore.Html.HtmlString("sha256-hwg4gsxgFZhOsEEamdOYGBf13FyQuiTwlAQgxVSNgt4="), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\Movies\ActionMovies.cshtml"
   ViewBag.Title = "ActionMovies"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9133d1a9d3c5ed42c519e55ba0e031636ed42b9e5962", async() => {
                WriteLiteral(@"

    <style>
        .posters {
            width: 200px;
            height: 300px;
            margin: 35px;
        }

        .errorPosters {
            width: 200px;
            height: 300px;
            margin: 35px;
        }

        #myInput {
            background-image: url('/Images/zoom.png');
            background-size: 20px;
            background-position: 10px 12px;
            background-repeat: no-repeat;
            width: 100%;
            font-size: 16px;
            padding: 12px 20px 12px 40px;
            border: 1px solid #ddd;
            margin-bottom: 12px;
        }
    </style>

    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9133d1a9d3c5ed42c519e55ba0e031636ed42b9e6870", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9133d1a9d3c5ed42c519e55ba0e031636ed42b9e8230", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9133d1a9d3c5ed42c519e55ba0e031636ed42b9e10211", async() => {
                WriteLiteral("\r\n    <h1>Action Movies</h1>\r\n    <input type=\"text\" id=\"myInput\" name=\"search\" placeholder=\"Search for movies..\">\r\n    <div id=\"article_table\"></div>\r\n\r\n");
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
            WriteLiteral(@"
</html>

<script>
    $(""#myInput"").keyup(function () {
        var val = $.trim(this.value);
        if (val === """") {
            $('.text').show();
            $('img').show();
        } else {
            $('img').hide();
            $('.text').hide();
            val = val.split("" "").join(""\\ "");
            $(""img[alt*="" + val + "" i]"").show();
            $("".text[alt*="" + val + "" i]"").show();
        }
    });
</script>
");
#nullable restore
#line 61 "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\Movies\ActionMovies.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"wrapper row\">\r\n");
#nullable restore
#line 64 "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\Movies\ActionMovies.cshtml"
         foreach (var movie in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"item m-4\">\r\n                <script>\r\n\r\n                    $(document).ready(function () {\r\n                        $.getJSON(\'https://www.omdbapi.com/?apikey=\' + \'4713f8\' + \'&i=tt\' + ");
#nullable restore
#line 70 "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\Movies\ActionMovies.cshtml"
                                                                                       Write(movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" , function (data) {
                            //a0b6e7bc
                            //74e33cd2
                            console.log(data.Title);
                            var string = data.Genre;
                            if (string.includes(""Action"")) {

                            var title = data.Title;
                            var article_data = '';
                            if (data.Poster == ""N/A"" || data.Poster == null) {
                                article_data += '<div class=""box""><img src=""/Images/black.jpg"" alt="" ' + data.Title + ' ""  id=""' + data.Title + '"" class=""posters"" /><div alt="" ' + data.Title + ' ""  id=""' + data.Title + '"" class=""text""><h6>' + title + '</h6></div></div>';
                            } else {
                                article_data += '<img src="" ' + data.Poster + ' "" alt="" ' + data.Title + ' ""  id=""' + data.Title + '"" class=""posters""/>';
                            }
                            var images = document.getElementsByTagNa");
            WriteLiteral(@"me(""img"");
                            for (var i = 0; i < images.length; i++) {
                                var image = images[i];
                                image.onclick = function (event) {


                                    window.location.href = 'https://bestmoviesinclela.azurewebsites.net/Movies/Details/' + this.id;
                                  //window.location.href = 'https://localhost:44329/Movies/Details/' + this.id;




                                };
                            }


                                 
                            $('#article_table').append(article_data);
                        }
                        });
                    });
                </script>

            </div>
");
#nullable restore
#line 108 "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\Movies\ActionMovies.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 110 "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\Movies\ActionMovies.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>No Movies Available Right Now</h4>\r\n");
#nullable restore
#line 114 "C:\Users\PC\source\repos\MoviesWebApplication\MoviesWebApplication\Views\Movies\ActionMovies.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MoviesWebApplication.Data.MovieDBO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
