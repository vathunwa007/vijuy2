#pragma checksum "/Users/runkanchano/Desktop/Vitcome/Views/Checkstatus/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d91ebd0ffaaebef6f8ef2daba8b3fb38e6e1d27e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkstatus_index), @"mvc.1.0.view", @"/Views/Checkstatus/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Checkstatus/index.cshtml", typeof(AspNetCore.Views_Checkstatus_index))]
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
#line 1 "/Users/runkanchano/Desktop/Vitcome/Views/_ViewImports.cshtml"
using netcore;

#line default
#line hidden
#line 2 "/Users/runkanchano/Desktop/Vitcome/Views/_ViewImports.cshtml"
using netcore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d91ebd0ffaaebef6f8ef2daba8b3fb38e6e1d27e", @"/Views/Checkstatus/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a42f8c1e7f84b2085c62db58c14ae0e4f8b26c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkstatus_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "https://pickaface.net/assets/images/slides/slide2.png", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/runkanchano/Desktop/Vitcome/Views/Checkstatus/index.cshtml"
  
    ViewData["Title"] = "index";
    

#line default
#line hidden
            BeginContext(44, 392, true);
            WriteLiteral(@"    <style>
        body {
        background-image: linear-gradient(to top, #a8edea 0%, #fed6e3 100%);
        }
    </style>
<h2 style=""text-align:center; color:white;"">เช็คสถานะการรับของอาจารย์ที่ปรึกษา</h2>
<div class=""row""style=""padding-top:50px;"">

    <div class=""card mb-3"" style=""width: 100%;"">
        <div class=""row no-gutters"">
            <div class=""col-md-4"">
                ");
            EndContext();
            BeginContext(436, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d91ebd0ffaaebef6f8ef2daba8b3fb38e6e1d27e4770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 17 "/Users/runkanchano/Desktop/Vitcome/Views/Checkstatus/index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(553, 204, true);
            WriteLiteral("\n            </div>\n            <div class=\"col-md-8\">\n                <div class=\"card-body\" style=\" position:absolute;bottom:70px;left:50px;\">\r\n                    \r\n                    <p>ชื่ออาจารย์ :");
            EndContext();
            BeginContext(758, 17, false);
#line 22 "/Users/runkanchano/Desktop/Vitcome/Views/Checkstatus/index.cshtml"
                               Write(ViewBag.idteacher);

#line default
#line hidden
            EndContext();
            BeginContext(775, 45, true);
            WriteLiteral("</p>\r\n                    <p>ความถนัดพิเศษ : ");
            EndContext();
            BeginContext(821, 13, false);
#line 23 "/Users/runkanchano/Desktop/Vitcome/Views/Checkstatus/index.cshtml"
                                  Write(ViewBag.skill);

#line default
#line hidden
            EndContext();
            BeginContext(834, 46, true);
            WriteLiteral(" </p>\n                    <p>สถานะการตอบรับ : ");
            EndContext();
#line 24 "/Users/runkanchano/Desktop/Vitcome/Views/Checkstatus/index.cshtml"
                                         if(@ViewBag.status >0)
                    {

#line default
#line hidden
            BeginContext(925, 14, true);
            WriteLiteral(" <p>Pass</p>  ");
            EndContext();
#line 25 "/Users/runkanchano/Desktop/Vitcome/Views/Checkstatus/index.cshtml"
                                   }
                    else
                    {

#line default
#line hidden
            BeginContext(987, 13, true);
            WriteLiteral("<p>Fail</p>  ");
            EndContext();
#line 27 "/Users/runkanchano/Desktop/Vitcome/Views/Checkstatus/index.cshtml"
                                  }

#line default
#line hidden
            BeginContext(1003, 32, true);
            WriteLiteral("                    <p>Comment: ");
            EndContext();
            BeginContext(1036, 15, false);
#line 28 "/Users/runkanchano/Desktop/Vitcome/Views/Checkstatus/index.cshtml"
                           Write(ViewBag.comment);

#line default
#line hidden
            EndContext();
            BeginContext(1051, 206, true);
            WriteLiteral("\n                    </p>\r\n                    <p class=\"card-text\"><small class=\"text-muted\">Last updated 3 mins ago</small></p>\r\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
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
