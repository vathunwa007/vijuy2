#pragma checksum "/Users/runkanchano/Desktop/Vitcome/Views/Select/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a532c8b681ad388f064b7766ad1194a0609b0a1f"
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
#line 1 "/Users/runkanchano/Desktop/Vitcome/Views/_ViewImports.cshtml"
using netcore;

#line default
#line hidden
#line 2 "/Users/runkanchano/Desktop/Vitcome/Views/_ViewImports.cshtml"
using netcore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a532c8b681ad388f064b7766ad1194a0609b0a1f", @"/Views/Select/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a42f8c1e7f84b2085c62db58c14ae0e4f8b26c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Select_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/runkanchano/Desktop/Vitcome/Views/Select/Index.cshtml"
  
    ViewData["Title"] = "เลือกเมนู";

#line default
#line hidden
            BeginContext(64, 8, true);
            WriteLiteral("\n    <p>");
            EndContext();
            BeginContext(73, 15, false);
#line 7 "/Users/runkanchano/Desktop/Vitcome/Views/Select/Index.cshtml"
  Write(Model.Idstudent);

#line default
#line hidden
            EndContext();
            BeginContext(88, 21, true);
            WriteLiteral("</p>\n    <p>\n        ");
            EndContext();
            BeginContext(110, 14, false);
#line 9 "/Users/runkanchano/Desktop/Vitcome/Views/Select/Index.cshtml"
   Write(Model.Password);

#line default
#line hidden
            EndContext();
            BeginContext(124, 26, true);
            WriteLiteral("\n    </p>\n    <p>\n        ");
            EndContext();
            BeginContext(151, 10, false);
#line 12 "/Users/runkanchano/Desktop/Vitcome/Views/Select/Index.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(161, 26, true);
            WriteLiteral("\n    </p>\n    <p>\n        ");
            EndContext();
            BeginContext(188, 14, false);
#line 15 "/Users/runkanchano/Desktop/Vitcome/Views/Select/Index.cshtml"
   Write(Model.Lastname);

#line default
#line hidden
            EndContext();
            BeginContext(202, 26, true);
            WriteLiteral("\n    </p>\n    <p>\n        ");
            EndContext();
            BeginContext(229, 15, false);
#line 18 "/Users/runkanchano/Desktop/Vitcome/Views/Select/Index.cshtml"
   Write(Model.Telephone);

#line default
#line hidden
            EndContext();
            BeginContext(244, 26, true);
            WriteLiteral("\n    </p>\n    <p>\n        ");
            EndContext();
            BeginContext(271, 10, false);
#line 21 "/Users/runkanchano/Desktop/Vitcome/Views/Select/Index.cshtml"
   Write(Model.Year);

#line default
#line hidden
            EndContext();
            BeginContext(281, 328, true);
            WriteLiteral(@"
    </p>


<!--<h1 style=""text-align:center;"">เมนูเลือก</h1>-->



<button type=""button"" class=""btn btn-primary btn-lg btn-block"" style=""height:200px;font-size:50px;"">กรอกบันทึกแบบฟอร์มCS1</button>
<button type=""button"" class=""btn btn-danger btn-lg btn-block"" style=""height:200px;font-size:50px;"">เลือกอาจารย์ที่ปรึกษา</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
