#pragma checksum "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d830c5d4dc36b469cbd066a04fbacb8bb92f7d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Profile.cshtml", typeof(AspNetCore.Views_Account_Profile))]
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
#line 1 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\_ViewImports.cshtml"
using KillerApp;

#line default
#line hidden
#line 2 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\_ViewImports.cshtml"
using KillerApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d830c5d4dc36b469cbd066a04fbacb8bb92f7d7", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb7dff1f122510935cd3a16f7b84d2cb7d151d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KillerApp.Models.AccountViewModels.ProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Profile.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("/images/NoIMG.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/NoIMG.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img img-responsive profile-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(69, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ecd12a132e1349ae9cd1f6ebd690ea76", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(119, 104, true);
            WriteLiteral("\r\n\r\n<div id=\"ProfileInfo\" class=\"col-md-3 profile-box\">\r\n    <div class=\"profile-box-content\">\r\n        ");
            EndContext();
            BeginContext(223, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3b1367f287ff45f69ff7a8285bb83951", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(318, 39, true);
            WriteLiteral("\r\n        <h2 class=\"no-margin-bottom\">");
            EndContext();
            BeginContext(358, 19, false);
#line 10 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Account\Profile.cshtml"
                                Write(Model.user.Username);

#line default
#line hidden
            EndContext();
            BeginContext(377, 21, true);
            WriteLiteral("</h2>\r\n        <p><b>");
            EndContext();
            BeginContext(399, 19, false);
#line 11 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Account\Profile.cshtml"
         Write(Model.user.Username);

#line default
#line hidden
            EndContext();
            BeginContext(418, 152, true);
            WriteLiteral("</b></p>\r\n        <hr />\r\n        <ul class=\"container details no-padding\">\r\n            <li><p><span class=\"glyphicon glyphicon-map-marker one\"></span>");
            EndContext();
            BeginContext(571, 18, false);
#line 14 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Account\Profile.cshtml"
                                                                      Write(Model.user.Country);

#line default
#line hidden
            EndContext();
            BeginContext(589, 84, true);
            WriteLiteral("</p></li>\r\n            <li><p><span class=\"glyphicon glyphicon-calendar one\"></span>");
            EndContext();
            BeginContext(674, 35, false);
#line 15 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Account\Profile.cshtml"
                                                                    Write(Model.user.date.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(709, 84, true);
            WriteLiteral("</p></li>\r\n            <li><p><span class=\"glyphicon glyphicon-envelope one\"></span>");
            EndContext();
            BeginContext(794, 16, false);
#line 16 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Account\Profile.cshtml"
                                                                    Write(Model.user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(810, 1077, true);
            WriteLiteral(@"</p></li>
        </ul>
    </div>
    
</div>
<div class=""container"" id=""Container""> 
    <text id=""Description"">
        Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
    </text>
    </div>
<div class=""profile-box-content"">
    <table id=""TableHeader"" class=""table table-striped table-bordered"">
        <thead>
            <tr>
                <td>Game</td>
                <td>Time</td>
                <td>Placement</td>
                <td  width=""40px"">Settings</td>
   ");
            WriteLiteral("         </tr>\r\n        </thead>\r\n        <tbody>\r\n\r\n");
            EndContext();
#line 38 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Account\Profile.cshtml"
             foreach (var item in Model.Speedruns)
                {

#line default
#line hidden
            BeginContext(1958, 91, true);
            WriteLiteral("                <tr class=\"\">\r\n                    <td>#Game</td>\r\n                    <td>");
            EndContext();
            BeginContext(2050, 14, false);
#line 42 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Account\Profile.cshtml"
                   Write(item.GetTime());

#line default
#line hidden
            EndContext();
            BeginContext(2064, 147, true);
            WriteLiteral("</td>\r\n                    <td>#Placement</td>\r\n                    <td><a href=\"#\">edit</a> - <a href=\"#\">delete</a></td>\r\n                </tr>\r\n");
            EndContext();
#line 46 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Account\Profile.cshtml"
              }

#line default
#line hidden
            BeginContext(2228, 63, true);
            WriteLiteral("               \r\n            </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KillerApp.Models.AccountViewModels.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
