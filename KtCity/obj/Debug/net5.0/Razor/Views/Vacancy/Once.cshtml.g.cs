#pragma checksum "E:\projects\KtCity\KtCity\Views\Vacancy\Once.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4be14d31c1313db3bfb83ded18fe8c36190c0eb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vacancy_Once), @"mvc.1.0.view", @"/Views/Vacancy/Once.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be14d31c1313db3bfb83ded18fe8c36190c0eb9", @"/Views/Vacancy/Once.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a78b66430ca9d38f0cff1b2524223b1edb5595b", @"/Views/_ViewImports.cshtml")]
    public class Views_Vacancy_Once : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\projects\KtCity\KtCity\Views\Vacancy\Once.cshtml"
  
    
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\projects\KtCity\KtCity\Views\Vacancy\Once.cshtml"
Write(Html.Partial("_OnceView",Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsItem> Html { get; private set; }
    }
}
#pragma warning restore 1591