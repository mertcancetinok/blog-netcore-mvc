#pragma checksum "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Admin\Blogger.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f76b303c637206c8858cbe80e0de78507adbd707"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Blogger), @"mvc.1.0.view", @"/Views/Admin/Blogger.cshtml")]
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
#line 1 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\_ViewImports.cshtml"
using blog.webui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\_ViewImports.cshtml"
using blog.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\_ViewImports.cshtml"
using blog.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f76b303c637206c8858cbe80e0de78507adbd707", @"/Views/Admin/Blogger.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f38946f1f225f4c7c89ab067bdda5198a4e46d36", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Blogger : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blogger>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success p-4 mr-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BloggerCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BloggerDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Admin\Blogger.cshtml"
  
    Layout = "_AdminLayout";
    ViewData["pageName"] = "Blogger";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"blog-button p-3\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f76b303c637206c8858cbe80e0de78507adbd7075734", async() => {
                WriteLiteral("Blogger Ekle");
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
                <h3 class=""title-5 m-b-35"">Bloggerlar</h3>
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
                                <th>Blogger Adı</th>
                                <th>Blogger Soyadı</th>
                                <th>Blogger İş Başlığı</th>
                          ");
            WriteLiteral("      <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Admin\Blogger.cshtml"
                             if (Model.Count > 0)
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Admin\Blogger.cshtml"
                                 foreach (var blogger in Model)
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
#line 55 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Admin\Blogger.cshtml"
                                       Write(blogger.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 56 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Admin\Blogger.cshtml"
                                       Write(blogger.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 57 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Admin\Blogger.cshtml"
                                       Write(blogger.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                                        <td>\r\n                                            <div class=\"table-data-feature\">\r\n\r\n\r\n\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2452, "\"", 2486, 2);
            WriteAttributeValue("", 2459, "/admin/bloggers/", 2459, 16, true);
#nullable restore
#line 65 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Admin\Blogger.cshtml"
WriteAttributeValue("", 2475, blogger.Id, 2475, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""item"" data-toggle=""tooltip"" data-placement=""top"" title=""Edit"">
                                                    <i class=""zmdi zmdi-edit"">
                                                    </i>
                                                </a>

                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f76b303c637206c8858cbe80e0de78507adbd70711232", async() => {
                WriteLiteral("\r\n                                                    <input type=\"hidden\" name=\"bloggerId\"");
                BeginWriteAttribute("value", " value=\"", 2961, "\"", 2980, 1);
#nullable restore
#line 71 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Admin\Blogger.cshtml"
WriteAttributeValue("", 2969, blogger.Id, 2969, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                                    <button class=""item blogger-delete"" type=""submit"" data-toggle=""tooltip"" data-placement=""top"" title=""Sil"">
                                                        <i class=""zmdi zmdi-delete"">
                                                        </i>
                                                    </button>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                                <button class=""item"" data-toggle=""tooltip"" data-placement=""top"" title=""More"">
                                                    <i class=""zmdi zmdi-more""></i>
                                                </button>
                                            </div>
                                        </td>
                                    </tr>
");
#nullable restore
#line 84 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Admin\Blogger.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Admin\Blogger.cshtml"
                                 

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"text-danger\">Kayıt bulunumadı</tr>\r\n");
#nullable restore
#line 90 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Admin\Blogger.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n                <!-- END DATA TABLE -->\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("CustomJS", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n        $(\'.blogger-delete\').click(function (e) {\r\n            if (confirm(\"Silmek istediğine eminmisin\")) {\r\n\r\n            }\r\n            else {\r\n                e.preventDefault();\r\n            }\r\n        });\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blogger>> Html { get; private set; }
    }
}
#pragma warning restore 1591
