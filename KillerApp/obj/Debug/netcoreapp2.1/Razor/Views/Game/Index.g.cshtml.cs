#pragma checksum "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31bd8a2bd694f7e5c6152f6574949b1286ba310c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Index), @"mvc.1.0.view", @"/Views/Game/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Game/Index.cshtml", typeof(AspNetCore.Views_Game_Index))]
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
#line 2 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
using KillerApp.Objects;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31bd8a2bd694f7e5c6152f6574949b1286ba310c", @"/Views/Game/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb7dff1f122510935cd3a16f7b84d2cb7d151d", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KillerApp.Models.GameViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
  
    ViewData["Title"] = "Game";

#line default
#line hidden
            BeginContext(105, 17, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04e708a770444ceda64b45513fe40af0", async() => {
                BeginContext(111, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(122, 153, true);
            WriteLiteral("\r\n<div>\r\n    <div style=\"float:left\">\r\n        <h2>Game</h2>\r\n    </div>\r\n    \r\n    <div id=\"new-game\" style=\"float:right\">\r\n        <br />\r\n            ");
            EndContext();
            BeginContext(276, 37, false);
#line 16 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
       Write(Html.ActionLink("Add Game","AddGame"));

#line default
#line hidden
            EndContext();
            BeginContext(313, 259, true);
            WriteLiteral(@"    
    </div>
</div>

<div>
    <table class=""table"">
        <thead>
            <tr>
                <th>Game ID</th>
                <th>Game Name</th>
                <th>Description</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 30 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
             foreach (var item in Model.Game)
            {

#line default
#line hidden
            BeginContext(634, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(681, 33, false);
#line 33 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
                   Write(Html.DisplayFor(Model => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(714, 33, true);
            WriteLiteral("</td>\r\n                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 747, "\"", 772, 2);
            WriteAttributeValue("", 754, "Game/Game/", 754, 10, true);
#line 34 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
WriteAttributeValue("", 764, item.ID, 764, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(773, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(775, 35, false);
#line 34 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
                                                Write(Html.DisplayFor(Model => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(810, 35, true);
            WriteLiteral("</a></td>\r\n                    <td>");
            EndContext();
            BeginContext(846, 42, false);
#line 35 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
                   Write(Html.DisplayFor(Model => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(888, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 37 "C:\Users\lucvd\Desktop\ICT\Semester 2\Indivueel\Program\Speedrun\KillerApp\Views\Game\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(933, 44, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KillerApp.Models.GameViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
