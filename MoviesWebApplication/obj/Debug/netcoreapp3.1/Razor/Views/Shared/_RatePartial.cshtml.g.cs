#pragma checksum "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\Shared\_RatePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1feb0b4ed77d40f0cf01d8a79594ad5e7712f3cf"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1feb0b4ed77d40f0cf01d8a79594ad5e7712f3cf", @"/Views/Shared/_RatePartial.cshtml")]
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
            WriteLiteral("    <div>\r\n        <dd>\r\n            <div>\r\n");
#nullable restore
#line 9 "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\Shared\_RatePartial.cshtml"
                 using (Html.BeginForm("Add", "Star", FormMethod.Post, new { onsubmit = "return SubmitRating()" }))
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
                            <div class=""row"">
                                <div style=""float: left;"">
                                    <div onmouseout=""Select()"">
                                        <span class=""starFade"" id=""Rate1"" onclick=""Rate(1)"" onmouseover=""Over(1)"" onmouseout=""Out(1)""></span>
                                        <span class=""starFade"" id=""Rate2"" onclick=""Rate(2)"" onmouseover=""Over(2)"" onmouseout=""Out(2)""></span>
                                        <span class=""starFade"" id=""Rate3"" onclick=""Rate(3)"" onmouseover=""Over(3)"" onmouseout=""Out(3)""></span>
                                        <span class=""starFade"" id=""Rate4"" onclick=""Rate(4)"" onmouseover=""Over(4)"" onmouseout=""Out(4)""></span>
                                        <span class=""starFade"" id=""Rate5"" onclick=""Rate(5)"" onmouseover=""Over(5)"" onmouseout=""Out(5)""></span>
                                    ");
            WriteLiteral(@"    <span class=""starFade"" id=""Rate6"" onclick=""Rate(6)"" onmouseover=""Over(6)"" onmouseout=""Out(6)""></span>
                                        <span class=""starFade"" id=""Rate7"" onclick=""Rate(7)"" onmouseover=""Over(7)"" onmouseout=""Out(7)""></span>
                                        <span class=""starFade"" id=""Rate8"" onclick=""Rate(8)"" onmouseover=""Over(8)"" onmouseout=""Out(8)""></span>
                                        <span class=""starFade"" id=""Rate9"" onclick=""Rate(9)"" onmouseover=""Over(9)"" onmouseout=""Out(9)""></span>
                                        <span class=""starFade"" id=""Rate10"" onclick=""Rate(10)"" onmouseover=""Over(10)"" onmouseout=""Out(10)""></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-md-12"">
                                <input type=""hidden"" name=""MovieId""");
            BeginWriteAttribute("value", " value=\"", 2338, "\"", 2355, 1);
#nullable restore
#line 33 "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\Shared\_RatePartial.cshtml"
WriteAttributeValue("", 2346, Model.Id, 2346, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                <input type=""hidden"" name=""Rating"" id=""Rating"" value=""0"" />
                                <input type=""submit"" id=""btnRegister"" name=""btnRegister"" value=""Rate this movie!"" class=""btn btn-dark"" />
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 39 "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\Shared\_RatePartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </dd>\r\n\r\n    </div>\r\n");
#nullable restore
#line 44 "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\Shared\_RatePartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h7>Please sign in to rate this movie!</h7>\r\n    </div>\r\n");
#nullable restore
#line 50 "C:\Users\karla\source\repos\lenabojanowska\MoviesWebApplication\MoviesWebApplication\Views\Shared\_RatePartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<script>
    function SubmitComment() {
        if ($(""#Rating"").val() == ""0"") {
            alert(""Please select your rate."");
            return false;
        }
        else {
            return true;
        }
    }

    function Rate(r) {
        $(""#Rating"").val(r);
        for (var i = 1; i <= r; i++) {
            $(""#Rate"" + i).attr('class', 'starGlow');
        }
        for (var i = r + 1; i <= 10; i++) {
            $(""#Rate"" + i).attr('class', 'starFade');
        }
    }

    function Over(r) {
        for (var i = 1; i <= r; i++) {
            $(""#Rate"" + i).attr('class', 'starGlow');
        }
    }

    function Out(r) {
        for (var i = 1; i <= r; i++) {
            $(""#Rate"" + i).attr('class', 'starFade');
        }
    }

    function Select() {
        var setRating = $(""#Rating"").val();
        for (var i = 1; i <= setRating; i++) {
            $(""#Rate"" + i).attr('class', 'starGlow');
        }
    }
</script>");
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
