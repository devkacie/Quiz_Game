#pragma checksum "C:\Users\16182\OneDrive\Purdue\Purdue\Quiz_Game\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c6e8460eb4992b066ca0bcf983bf0e48148994e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\16182\OneDrive\Purdue\Purdue\Quiz_Game\Views\_ViewImports.cshtml"
using Quiz_Game;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\16182\OneDrive\Purdue\Purdue\Quiz_Game\Views\_ViewImports.cshtml"
using Quiz_Game.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c6e8460eb4992b066ca0bcf983bf0e48148994e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e21a67abc3b2f6705291e02a2b22e9faa931962", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<QuizQuestionModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Home/SubmitAnswers"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<header>\r\n");
#nullable restore
#line 2 "C:\Users\16182\OneDrive\Purdue\Purdue\Quiz_Game\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("</header>\r\n");
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <div class=\"card\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c6e8460eb4992b066ca0bcf983bf0e48148994e4370", async() => {
                WriteLiteral("\r\n                <div class=\"card-header\">\r\n                    <h3>Quiz</h3>\r\n                    <hr />\r\n                </div>\r\n                \r\n                <div class=\"card-body\">\r\n");
#nullable restore
#line 21 "C:\Users\16182\OneDrive\Purdue\Purdue\Quiz_Game\Views\Home\Index.cshtml"
                     for (int i = 0; i < Model.Count; i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div>\r\n                            ");
#nullable restore
#line 24 "C:\Users\16182\OneDrive\Purdue\Purdue\Quiz_Game\Views\Home\Index.cshtml"
                       Write(Model[i].QuestionText);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\16182\OneDrive\Purdue\Purdue\Quiz_Game\Views\Home\Index.cshtml"
                             for (int k = 0; k < Model[i].PossibleAnswers.Count; k++)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p class=\"clearfix\">\r\n                                <label>\r\n                                    <input type=\"radio\" required");
                BeginWriteAttribute("name", " name=\"", 942, "\"", 964, 3);
                WriteAttributeValue("", 949, "UserAnswers[", 949, 12, true);
#nullable restore
#line 29 "C:\Users\16182\OneDrive\Purdue\Purdue\Quiz_Game\Views\Home\Index.cshtml"
WriteAttributeValue("", 961, i, 961, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 963, "]", 963, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 965, "\"", 975, 1);
#nullable restore
#line 29 "C:\Users\16182\OneDrive\Purdue\Purdue\Quiz_Game\Views\Home\Index.cshtml"
WriteAttributeValue("", 973, k, 973, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    ");
#nullable restore
#line 30 "C:\Users\16182\OneDrive\Purdue\Purdue\Quiz_Game\Views\Home\Index.cshtml"
                               Write(Model[i].PossibleAnswers[k]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </label>\r\n                                </p>\r\n");
#nullable restore
#line 33 "C:\Users\16182\OneDrive\Purdue\Purdue\Quiz_Game\Views\Home\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n");
#nullable restore
#line 36 "C:\Users\16182\OneDrive\Purdue\Purdue\Quiz_Game\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <div class=\"card-footer\">\r\n                    <button type=\"submit\">Submit Answers</button>\r\n                    <button type=\"reset\">Reset</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<QuizQuestionModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
