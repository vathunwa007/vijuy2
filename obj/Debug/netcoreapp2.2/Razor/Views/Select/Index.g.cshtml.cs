#pragma checksum "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Select\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dabdf598933fb8b1ceafeecea77dca0e09e443d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Select_Index), @"mvc.1.0.view", @"/Views/Select/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Select/Index.cshtml", typeof(AspNetCore.Views_Select_Index))]
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
#line 1 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\_ViewImports.cshtml"
using netcore;

#line default
#line hidden
#line 2 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\_ViewImports.cshtml"
using netcore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dabdf598933fb8b1ceafeecea77dca0e09e443d", @"/Views/Select/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91ceef2bbbea8f7e1eb485cc90e0c774edd14efc", @"/Views/_ViewImports.cshtml")]
    public class Views_Select_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Register>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Select\Index.cshtml"
  
    ViewData["Title"] = "เลือกเมนู";

#line default
#line hidden
            BeginContext(64, 1151, true);
            WriteLiteral(@"
<style>
    .card, .row {
        padding-top: 20px;
    }

    h3, p {
        text-align: center;
        border: 20px;
    }
</style>
<!--<h1 style=""text-align:center;"">เมนูเลือก</h1>-->


<div class=""row"">
    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3 class=""card-title"">กรอกบันทึกแบบฟอร์ม</h3>
                <p class=""card-text"">กรอกแบบฟอร์มCS1ก่อนทำการเลือกอาจารย์ที่ปรึกษา.</p>

            </div>
            <a href=""home/detail"" style=""height:5rem;text-align:center;padding:20px;font-size:2rem;"" class=""btn btn-primary btn-sm"">กรอกบันทึกแบบฟอร์ม</a>
        </div>
    </div>
    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-body"">
                <h3 class=""card-title"">เลือกอาจารย์ที่ปรึกษา</h3>
                <p class=""card-text"">เลือกอาจารย์ที่ปรึกษาและส่งแบบฟอร์มยืนเสนอหัวข้อ.</p>
            </div>
            <a href=""home/techer"" style=""height:5rem;text-align:center;pad");
            WriteLiteral("ding:20px;font-size:2rem;\" class=\"btn btn-danger btn-sm\">เลือกอาจารย์ที่ปรึกษา</a>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<p>");
            EndContext();
            BeginContext(1216, 12, false);
#line 43 "C:\Users\vathu\OneDrive\เอกสาร\netcore\Views\Select\Index.cshtml"
Write(ViewBag.show);

#line default
#line hidden
            EndContext();
            BeginContext(1228, 14, true);
            WriteLiteral("</p>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Register> Html { get; private set; }
    }
}
#pragma warning restore 1591
