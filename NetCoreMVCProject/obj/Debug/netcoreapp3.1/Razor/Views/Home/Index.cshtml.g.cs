#pragma checksum "C:\Users\kubra\source\repos\NetCoreMVCProject\NetCoreMVCProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4741ea213979e5285fe530d653a74129c74792dd"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4741ea213979e5285fe530d653a74129c74792dd", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NetCoreMVCProject.Entities.Urun>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 6 "C:\Users\kubra\source\repos\NetCoreMVCProject\NetCoreMVCProject\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3\">\r\n            <div class=\"card mr-1 mb-2\" >\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 209, "\"", 215, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"Resim Yok\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\kubra\source\repos\NetCoreMVCProject\NetCoreMVCProject\Views\Home\Index.cshtml"
                                      Write(item.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\kubra\source\repos\NetCoreMVCProject\NetCoreMVCProject\Views\Home\Index.cshtml"
                                    Write(item.Fiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a href=\"#\" class=\"btn btn-primary\">Detay</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\kubra\source\repos\NetCoreMVCProject\NetCoreMVCProject\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n");
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
