#pragma checksum "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Home\BlogDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fd7997d76f1f21d64a13add3ffcd69d0cfcda52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BlogDetails), @"mvc.1.0.view", @"/Views/Home/BlogDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fd7997d76f1f21d64a13add3ffcd69d0cfcda52", @"/Views/Home/BlogDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f38946f1f225f4c7c89ab067bdda5198a4e46d36", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BlogDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n");
#nullable restore
#line 3 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Home\BlogDetails.cshtml"
     if (Model != null)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-muted font-weight-normal mt-5\">Anasayfa>Uzay>");
#nullable restore
#line 6 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Home\BlogDetails.cshtml"
                                                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"text-muted\">");
#nullable restore
#line 7 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Home\BlogDetails.cshtml"
                         Write(Model.ReadTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" dakika okuma süresi</p>\r\n        <p class=\"text-right\">");
#nullable restore
#line 8 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Home\BlogDetails.cshtml"
                         Write(Model.AddedTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 9 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Home\BlogDetails.cshtml"
         foreach (var item in Model.BlogCategories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"text-right\">");
#nullable restore
#line 11 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Home\BlogDetails.cshtml"
                         Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> \r\n");
#nullable restore
#line 12 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Home\BlogDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row my-3\">\r\n            <div class=\"col-md-8\">\r\n                ");
#nullable restore
#line 15 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Home\BlogDetails.cshtml"
           Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""col-md-4"">
                <h2 class=""h4 read-popular-news"">Popüler Haberler</h2>
                <ul class=""list-group"">
                    <li class=""list-group-item"">Cras justo odio</li>
                    <li class=""list-group-item"">Dapibus ac facilisis in</li>
                    <li class=""list-group-item"">Morbi leo risus</li>
                    <li class=""list-group-item"">Porta ac consectetur ac</li>
                    <li class=""list-group-item"">Vestibulum at eros</li>
                </ul>
            </div>

            <div class=""comments col-md-12 my-5"">
                <h2>YORUMLAR</h2>
                <div class=""new-comment my-5"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fd7997d76f1f21d64a13add3ffcd69d0cfcda526936", async() => {
                WriteLiteral(@"
                        <textarea cols=""10"" class=""form-control"" rows=""5"" style=""width: 100%;""></textarea>
                        <p>240</p>
                        <input class=""form-control w-25 mt-2"" type=""text"" placeholder=""Kullanıcı Adınız"">
                        <input type=""submit"" value=""Gönder"" class=""btn btn-outline-success float-right"">
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""comment mt-5 p-5 text-white"" style=""background-color: #1E1A17;"">

                    <p class=""d-inline-block"">Mertcan</p>
                    <p class=""float-right d-inline-block"">01.02.2015</p>
                    <hr>
                    <p class=""comment-long"">
                        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Adipisci accusantium quasi a ratione doloremque ipsum, necessitatibus modi dignissimos nesciunt eos?
                    </p>
                </div>
                <div class=""comment mt-5 p-5 text-white"" style=""background-color: #1E1A17;"">

                    <p class=""d-inline-block"">Mertcan</p>
                    <p class=""float-right d-inline-block"">01.02.2015</p>
                    <hr>
                    <p class=""comment-long"">
                        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Adipisci accusantium quasi a ratione doloremque ipsum, necessitatibus modi digni");
            WriteLiteral(@"ssimos nesciunt eos?
                    </p>
                </div>
                <div class=""comment mt-5 p-5 text-white"" style=""background-color: #1E1A17;"">

                    <p class=""d-inline-block"">Mertcan</p>
                    <p class=""float-right d-inline-block"">01.02.2015</p>
                    <hr>
                    <p class=""comment-long"">
                        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Adipisci accusantium quasi a ratione doloremque ipsum, necessitatibus modi dignissimos nesciunt eos?
                    </p>
                </div>
            </div>
        </div>
");
#nullable restore
#line 67 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Home\BlogDetails.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning\">\r\n            Boş veri geldi\r\n        </div>\r\n");
#nullable restore
#line 73 "C:\Users\mertc\Desktop\blog-net\blog.webui\Views\Home\BlogDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
