#pragma checksum "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\Shared\_RatePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "902b1d650b23a0db418ea7218cc49dd882e4669d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__RatePartial), @"mvc.1.0.view", @"/Views/Shared/_RatePartial.cshtml")]
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
#line 1 "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\_ViewImports.cshtml"
using MoviesWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\_ViewImports.cshtml"
using MoviesWebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\Shared\_RatePartial.cshtml"
using System.Security.Principal;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"902b1d650b23a0db418ea7218cc49dd882e4669d", @"/Views/Shared/_RatePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bff5912c456796afa826218a695b32754050fd4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__RatePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 4 "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\Shared\_RatePartial.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <dd>\r\n            <div class=\"commentBox\">\r\n");
#nullable restore
#line 9 "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\Shared\_RatePartial.cshtml"
                 using (Html.BeginForm("Add", "ArticlesComments", FormMethod.Post, new { onsubmit = "return SubmitComment()" }))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\Shared\_RatePartial.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""form-horizontal"">
                        <div class=""form-group"">
                            <label class=""col-md-4 control-label"">
                                Your rating <span style=""font-weight:normal;"">(1 start is bad, 5 star is good)</span>
                            </label>
                            <div class=""col-md-7"">
                                <div onmouseout=""CRateSelected()"">
                                    <span class=""starFade"" id=""Rate1"" onclick=""CRate(1)"" onmouseover=""CRateOver(1)"" onmouseout=""CRateOut(1)""></span><span class=""starFade"" id=""Rate2"" onclick=""CRate(2)"" onmouseover=""CRateOver(2)"" onmouseout=""CRateOut(2)""></span><span class=""starFade"" id=""Rate3"" onclick=""CRate(3)"" onmouseover=""CRateOver(3)"" onmouseout=""CRateOut(3)""></span><span class=""starFade"" id=""Rate4"" onclick=""CRate(4)"" onmouseover=""CRateOver(4)"" onmouseout=""CRateOut(4)""></span><span class=""starFade"" id=""Rate5"" onclick=""CRate(5)"" onmouseover=""CRateOver(5)"" onmouseout=""CR");
            WriteLiteral(@"ateOut(5)""></span>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-md-12"">
                                <textarea name=""Comment"" id=""Comment"" required rows=""5"" style=""width:100%;"" class=""form-control""></textarea>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-md-12"">
                                <input type=""hidden"" name=""MovieId""");
            BeginWriteAttribute("value", " value=\"", 1976, "\"", 2000, 1);
#nullable restore
#line 30 "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\Shared\_RatePartial.cshtml"
WriteAttributeValue("", 1984, ViewBag.MovieId, 1984, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                <input type=""hidden"" name=""Rating"" id=""Rating"" value=""0"" />
                                <input type=""submit"" id=""btnRegister"" name=""btnRegister"" value=""Submit Comment"" class=""btn btn-warning"" />
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 36 "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\Shared\_RatePartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </dd>\r\n\r\n    </div>\r\n");
#nullable restore
#line 41 "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\Shared\_RatePartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h7>Please sign in to rate this movie!</h7>\r\n    </div>\r\n");
#nullable restore
#line 47 "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\Shared\_RatePartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<script>
    function SubmitComment() {
        if ($(""#Rating"").val() == ""0"") {
            alert(""Please rate this service provider."");
            return false;
        }
        else {
            return true;
        }
    }

    function CRate(r) {
        $(""#Rating"").val(r);
        for (var i = 1; i <= r; i++) {
            $(""#Rate"" + i).attr('class', 'starGlow');
        }
        // unselect remaining
        for (var i = r + 1; i <= 5; i++) {
            $(""#Rate"" + i).attr('class', 'starFade');
        }
    }

    function CRateOver(r) {
        for (var i = 1; i <= r; i++) {
            $(""#Rate"" + i).attr('class', 'starGlow');
        }
    }

    function CRateOut(r) {
        for (var i = 1; i <= r; i++) {
            $(""#Rate"" + i).attr('class', 'starFade');
        }
    }

    function CRateSelected() {
        var setRating = $(""#Rating"").val();
        for (var i = 1; i <= setRating; i++) {
            $(""#Rate"" + i).attr('class', 'starGlo");
            WriteLiteral("w\');\r\n        }\r\n    }\r\n</script>");
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
