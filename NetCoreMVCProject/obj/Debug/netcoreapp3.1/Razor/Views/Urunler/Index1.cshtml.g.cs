#pragma checksum "C:\Users\kubra\source\repos\NetCoreMVCProject\NetCoreMVCProject\Views\Urunler\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fffe4fcc100d9b335525254456782a1425d7c4b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Urunler_Index1), @"mvc.1.0.view", @"/Views/Urunler/Index1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fffe4fcc100d9b335525254456782a1425d7c4b8", @"/Views/Urunler/Index1.cshtml")]
    public class Views_Urunler_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NetCoreMVCProject.Entities.Urun>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-sm table-bordered\">\r\n\r\n");
#nullable restore
#line 5 "C:\Users\kubra\source\repos\NetCoreMVCProject\NetCoreMVCProject\Views\Urunler\Index1.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 8 "C:\Users\kubra\source\repos\NetCoreMVCProject\NetCoreMVCProject\Views\Urunler\Index1.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 9 "C:\Users\kubra\source\repos\NetCoreMVCProject\NetCoreMVCProject\Views\Urunler\Index1.cshtml"
           Write(item.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 10 "C:\Users\kubra\source\repos\NetCoreMVCProject\NetCoreMVCProject\Views\Urunler\Index1.cshtml"
           Write(item.Fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 12 "C:\Users\kubra\source\repos\NetCoreMVCProject\NetCoreMVCProject\Views\Urunler\Index1.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NetCoreMVCProject.Entities.Urun>> Html { get; private set; }
    }
}
#pragma warning restore 1591
