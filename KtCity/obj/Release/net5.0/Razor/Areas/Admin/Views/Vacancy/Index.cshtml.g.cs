#pragma checksum "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e414117eddd3c6d40daf9d055d08c8216d7f3fba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Vacancy_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Vacancy/Index.cshtml")]
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
#line 1 "E:\projects\KtCity\KtCity\Areas\Admin\Views\_ViewImports.cshtml"
using KtCity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\projects\KtCity\KtCity\Areas\Admin\Views\_ViewImports.cshtml"
using KtCity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\projects\KtCity\KtCity\Areas\Admin\Views\_ViewImports.cshtml"
using KtCity.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e414117eddd3c6d40daf9d055d08c8216d7f3fba", @"/Areas/Admin/Views/Vacancy/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de70b408ff42be7a2db1c8c07c73c02f1b85d99a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Vacancy_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Vacancy>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <h2>სიახლეების ცხრილი</h2>
</div>
<table class=""mainContainer_content-table"">
    <thead class=""thead"">
        <tr class=""thead-tr"">
            <td class=""thead-tr-td"">
                სურათი
            </td>
            <td class=""thead-tr-td"">
                სათაური
            </td>
            <td class=""thead-tr-td"">
                რედაქტირება
            </td>
            <td class=""thead-tr-td"">
                წაშლა
            </td>
        </tr>
    </thead>
    <tbody class=""tbody"">
");
#nullable restore
#line 27 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
         if (Model.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"tbody-tr\">\r\n                    <td class=\"tbody-tr-td\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 869, "\"", 914, 2);
            WriteAttributeValue("", 875, "/img/", 875, 5, true);
#nullable restore
#line 33 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
WriteAttributeValue("", 880, item.Image??ConfigClass.NoImage, 880, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 915, "\"", 921, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </td>\r\n                    <td class=\"tbody-tr-td\">\r\n                        ");
#nullable restore
#line 36 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"tbody-tr-td\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e414117eddd3c6d40daf9d055d08c8216d7f3fba5971", async() => {
                WriteLiteral("\r\n                            <i class=\"far _coursor  fa-edit\" data-id=\"1\"></i>\r\n                        ");
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
#line 41 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
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
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"tbody-tr-td \">\r\n                        <a class=\"dltnews\" data-id=\"");
#nullable restore
#line 46 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
                                               Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <i class=\"far _coursor fa-trash-alt\" data-id=\"1\"></i>\r\n                        </a>\r\n\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 52 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
             

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td></td>\r\n                <td>\r\n                    ბაზები ცარიელია\r\n                </td>\r\n                <td></td>\r\n            </tr>\r\n");
#nullable restore
#line 64 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("paging", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e414117eddd3c6d40daf9d055d08c8216d7f3fba9558", async() => {
                WriteLiteral("\r\n");
            }
            );
            __LazZiya_TagHelpers_PagingTagHelper = CreateTagHelper<global::LazZiya.TagHelpers.PagingTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_TagHelpers_PagingTagHelper);
#nullable restore
#line 67 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.TotalRecords = 5;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("total-records", __LazZiya_TagHelpers_PagingTagHelper.TotalRecords, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 68 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.PageNo = 1;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-no", __LazZiya_TagHelpers_PagingTagHelper.PageNo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 69 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.PageSize = 2;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __LazZiya_TagHelpers_PagingTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 70 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowTotalPages = false;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-total-pages", __LazZiya_TagHelpers_PagingTagHelper.ShowTotalPages, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 71 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowFirstLast = false;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-first-last", __LazZiya_TagHelpers_PagingTagHelper.ShowFirstLast, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 72 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowTotalRecords = false;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-total-records", __LazZiya_TagHelpers_PagingTagHelper.ShowTotalRecords, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 73 "E:\projects\KtCity\KtCity\Areas\Admin\Views\Vacancy\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowPageSizeNav = false;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-page-size-nav", __LazZiya_TagHelpers_PagingTagHelper.ShowPageSizeNav, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function (){
            let btns = $("".dltnews"");
            btns.each((i, el) => {
                $(el).click(e => {
                    e.preventDefault();
                    if (confirm(""ნამდვილად გსურთ წაშლა?"")) {
                        let id = $(el).data(""id"");
                        $.ajax({
                            url: ""/api/vacancy/delete"",
                            method: ""DELETE"",
                            dataType: ""json"",
                            data: { id: id },
                            success: function (data) {
                                location.reload();
                            },
                            error: function (data) {
                                alert(`${data.status} => ${data.statusText}`)
                            }
                        })
                    }


                })
            })
        })
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Vacancy>> Html { get; private set; }
    }
}
#pragma warning restore 1591
