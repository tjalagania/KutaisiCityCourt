#pragma checksum "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d21a5ae6c29abca53401c6b63ddfc22593876a0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ParitalNews), @"mvc.1.0.view", @"/Views/Shared/_ParitalNews.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d21a5ae6c29abca53401c6b63ddfc22593876a0c", @"/Views/Shared/_ParitalNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a78b66430ca9d38f0cff1b2524223b1edb5595b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ParitalNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewsItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "once", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", "row", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class-active-page", "active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::LazZiya.TagHelpers.PagingTagHelper __LazZiya_TagHelpers_PagingTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
  

    int lines;
    if ((Model.Count / ConfigClass.NewsInLine) == 0)
    {
        lines = 1;
    }
    else if ((Model.Count % ConfigClass.NewsInLine) > 0)
    {
        lines = Model.Count / ConfigClass.NewsInLine + 1;
    }
    else
        lines = Model.Count / ConfigClass.NewsInLine;

    int startK = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
 for (int i = 0; i < lines; i++)
{
    startK = i * (ConfigClass.NewsInLine);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mainContainer shadows\">\r\n        <div class=\"container\">\r\n            <div class=\"grid_container\">\r\n\r\n");
#nullable restore
#line 26 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
                 foreach (var item in Model.Skip(startK).Take(ConfigClass.NewsInLine))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"grid_container-item\">\r\n                        <h3 class=\"grid_container-item-title\">\r\n                            ");
#nullable restore
#line 30 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h3>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 882, "\"", 927, 2);
            WriteAttributeValue("", 888, "/img/", 888, 5, true);
#nullable restore
#line 32 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
WriteAttributeValue("", 893, item.Image??ConfigClass.NoImage, 893, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 928, "\"", 934, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <p class=\"grid_container-item-description\">\r\n                            ");
#nullable restore
#line 34 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d21a5ae6c29abca53401c6b63ddfc22593876a0c6667", async() => {
                WriteLiteral("??????????????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
                                               WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 39 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 45 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("paging", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d21a5ae6c29abca53401c6b63ddfc22593876a0c9273", async() => {
                WriteLiteral("\r\n");
            }
            );
            __LazZiya_TagHelpers_PagingTagHelper = CreateTagHelper<global::LazZiya.TagHelpers.PagingTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_TagHelpers_PagingTagHelper);
#nullable restore
#line 51 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.PageNo = 0;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-no", __LazZiya_TagHelpers_PagingTagHelper.PageNo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 52 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.TotalRecords = (ViewBag.AllCount);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("total-records", __LazZiya_TagHelpers_PagingTagHelper.TotalRecords, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 53 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.PageSize = ConfigClass.PageSize;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __LazZiya_TagHelpers_PagingTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 54 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowTotalPages = false;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-total-pages", __LazZiya_TagHelpers_PagingTagHelper.ShowTotalPages, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 55 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowFirstLast = false;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-first-last", __LazZiya_TagHelpers_PagingTagHelper.ShowFirstLast, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 56 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowTotalRecords = false;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-total-records", __LazZiya_TagHelpers_PagingTagHelper.ShowTotalRecords, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 57 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowPageSizeNav = false;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-page-size-nav", __LazZiya_TagHelpers_PagingTagHelper.ShowPageSizeNav, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 58 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowPrevNext = false;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-prev-next", __LazZiya_TagHelpers_PagingTagHelper.ShowPrevNext, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowGap = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-gap", __LazZiya_TagHelpers_PagingTagHelper.ShowGap, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __LazZiya_TagHelpers_PagingTagHelper.Class = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __LazZiya_TagHelpers_PagingTagHelper.ClassActivePage = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 62 "E:\projects\KtCity\KtCity\Views\Shared\_ParitalNews.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.MaxDisplayedPages = 10;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("max-displayed-pages", __LazZiya_TagHelpers_PagingTagHelper.MaxDisplayedPages, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NewsItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
