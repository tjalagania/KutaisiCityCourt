#pragma checksum "E:\projects\KtCity\KtCity\Views\Galery\Once.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1d8463d6990ed63020cf877f4f6a2eed2021b9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Galery_Once), @"mvc.1.0.view", @"/Views/Galery/Once.cshtml")]
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
#line 1 "E:\projects\KtCity\KtCity\Views\_ViewImports.cshtml"
using KtCity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\projects\KtCity\KtCity\Views\_ViewImports.cshtml"
using KtCity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\projects\KtCity\KtCity\Views\_ViewImports.cshtml"
using KtCity.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1d8463d6990ed63020cf877f4f6a2eed2021b9e", @"/Views/Galery/Once.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a78b66430ca9d38f0cff1b2524223b1edb5595b", @"/Views/_ViewImports.cshtml")]
    public class Views_Galery_Once : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GaleryImgs>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\projects\KtCity\KtCity\Views\Galery\Once.cshtml"
  
    
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"mainContainer shadows\">\r\n    <div class=\"container\">\r\n        <div class=\"container-images\">\r\n            \r\n");
#nullable restore
#line 11 "E:\projects\KtCity\KtCity\Views\Galery\Once.cshtml"
                 foreach (GaleryImgs g in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 298, "\"", 323, 2);
            WriteAttributeValue("", 305, "/Galery/", 305, 8, true);
#nullable restore
#line 13 "E:\projects\KtCity\KtCity\Views\Galery\Once.cshtml"
WriteAttributeValue("", 313, g.ImgName, 313, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                       data-fancybox=\"gallery\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 403, "\"", 427, 2);
            WriteAttributeValue("", 409, "/Galery/", 409, 8, true);
#nullable restore
#line 15 "E:\projects\KtCity\KtCity\Views\Galery\Once.cshtml"
WriteAttributeValue("", 417, g.ImgName, 417, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 428, "\"", 434, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </a>\r\n");
#nullable restore
#line 17 "E:\projects\KtCity\KtCity\Views\Galery\Once.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("           \r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GaleryImgs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
