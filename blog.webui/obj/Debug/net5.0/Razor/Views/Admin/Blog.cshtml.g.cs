#pragma checksum "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f761554e90a145d67019954da55705556a27c37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Blog), @"mvc.1.0.view", @"/Views/Admin/Blog.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\_ViewImports.cshtml"
using blog.webui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\_ViewImports.cshtml"
using blog.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\_ViewImports.cshtml"
using blog.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\_ViewImports.cshtml"
using blog.webui.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\_ViewImports.cshtml"
using blog.webui.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f761554e90a145d67019954da55705556a27c37", @"/Views/Admin/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0622d730720bf29bf42dbce41351033c2f6de620", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataPagingModel<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success p-4 mr-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
  

    Layout = "_AdminLayout";
    ViewData["pageName"] = "Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"blog-button p-3\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f761554e90a145d67019954da55705556a27c378011", async() => {
                WriteLiteral("Blog Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


        </div>
    </div>
</section>

<section class=""blog-tables p-3 my-5"">
    <div class=""container"">

        <div class=""row"">
            <div class=""col-md-12"">
                <!-- DATA TABLE -->
                <h3 class=""title-5 m-b-35"">Bloglar</h3>
                <hr>

                <div class=""table-responsive table-responsive-data2"">
                    <table class=""table table-data2"">
                        <thead>
                            <tr>
                                <th>
                                    <label class=""au-checkbox"">
                                        <input type=""checkbox"">
                                        <span class=""au-checkmark""></span>
                                    </label>
                                </th>
                                <th>Blog Adı</th>
                                <th>Blog İçeriği</th>
                                <th>Url</th>
                                <th>Okuma Süresi<");
            WriteLiteral("/th>\r\n                                <th>Eklenme Tarihi</th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
                             if (Model.Data.Count > 0)
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
                                 foreach (var blog in Model.Data)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <tr class=""tr-shadow"">
                                        <td>
                                            <label class=""au-checkbox"">
                                                <input type=""checkbox"">
                                                <span class=""au-checkmark""></span>
                                            </label>
                                        </td>
                                        <td>");
#nullable restore
#line 59 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
                                       Write(blog.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 61 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
                                       Write(Html.Raw(blog.Content.Length > 50 ? blog.Content.Substring(0, 50).ToString() : blog.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 63 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
                                       Write(blog.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 64 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
                                       Write(blog.ReadTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td class=\"desc\">");
#nullable restore
#line 65 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
                                                    Write(blog.AddedTime.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                        <td>\r\n                                            <div class=\"table-data-feature\">\r\n\r\n\r\n\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f761554e90a145d67019954da55705556a27c3713628", async() => {
                WriteLiteral("\r\n                                                    <i class=\"zmdi zmdi-edit\">\r\n                                                    </i>\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
                                                                                                  WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f761554e90a145d67019954da55705556a27c3716606", async() => {
                WriteLiteral("\r\n                                                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3381, "\"", 3397, 1);
#nullable restore
#line 78 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
WriteAttributeValue("", 3389, blog.Id, 3389, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""blogId"" />
                                                    <button class=""item blog-delete"" type=""submit"" data-toggle=""tooltip"" data-placement=""top"" title=""Sil"">
                                                        <i class=""zmdi zmdi-delete""></i>
                                                    </button>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                                            </div>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 88 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
                                 

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"text-danger\">Kayıt bulunumadı</tr>\r\n");
#nullable restore
#line 94 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n                <!-- END DATA TABLE -->\r\n                <nav aria-label=\"Page navigation example\">\r\n                    <ul class=\"pagination mt-2\">\r\n");
#nullable restore
#line 101 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
                         for (int i = 0; i < Model.PageModel.TotalPage; i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li");
            BeginWriteAttribute("class", " class=\"", 4547, "\"", 4614, 2);
            WriteAttributeValue("", 4555, "page-item", 4555, 9, true);
#nullable restore
#line 103 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
WriteAttributeValue(" ", 4564, Model.PageModel.CurrentPage==i+1 ? "active":"", 4565, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4670, "\"", 4700, 2);
            WriteAttributeValue("", 4677, "/admin/blog?page=", 4677, 17, true);
#nullable restore
#line 104 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
WriteAttributeValue("", 4694, i+1, 4694, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 104 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
                                                                                Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </li>\r\n");
#nullable restore
#line 106 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Blog.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </ul>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("CustomJS", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n        $(\'.blog-delete\').click(function (e) {\r\n            if (confirm(\"Silmek istediğine eminmisin\")) {\r\n\r\n            }\r\n            else {\r\n                e.preventDefault();\r\n            }\r\n        });\r\n    </script>\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataPagingModel<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
