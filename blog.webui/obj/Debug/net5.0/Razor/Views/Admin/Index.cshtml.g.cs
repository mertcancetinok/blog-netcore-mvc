#pragma checksum "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fb8b231a60b0eee50f78f99431c954039406b1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fb8b231a60b0eee50f78f99431c954039406b1a", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0622d730720bf29bf42dbce41351033c2f6de620", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Index.cshtml"
  
    Layout = "_AdminLayout";
    ViewData["pageName"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- STATISTIC-->
<section class=""statistic statistic2"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-lg-4"">
                <div class=""statistic__item statistic__item--green"">
                    <h2 class=""number"">8</h2>
                    <span class=""desc"">aktif Ziyaretçi</span>
                    <div class=""icon"">
                        <i class=""zmdi zmdi-account-o""></i>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-4 m-auto"">
                <div class=""statistic__item statistic__item--orange"">
                    <h2 class=""number"">");
#nullable restore
#line 23 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Index.cshtml"
                                  Write(ViewBag.NotApprovedCommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <span class=""desc"">onaylanmamış yorum</span>
                    <div class=""icon"">
                        <i class=""zmdi zmdi-shopping-cart""></i>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-4"">
                <div class=""statistic__item statistic__item--blue"">
                    <h2 class=""number"">");
#nullable restore
#line 32 "C:\Users\Berkcan\Desktop\blog-net\blog.webui\Views\Admin\Index.cshtml"
                                  Write(ViewBag.BlogsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <span class=""desc"">toplam yazı</span>
                    <div class=""icon"">
                        <i class=""zmdi zmdi-calendar-note""></i>
                    </div>
                </div>
            </div>

        </div>
    </div>
</section>
<!-- END STATISTIC-->
<!-- STATISTIC CHART-->
<section class=""statistic-chart"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h3 class=""title-5 m-b-35"">statistics</h3>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 col-lg-6"">
                <div class=""au-card m-b-30"">
                    <div class=""au-card-inner"">
                        <h3 class=""title-2 m-b-40"">Aylık Ziyaretçi</h3>
                        <canvas id=""visiter-monthly""></canvas>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-6"">
                <!-- TOP CAMPAIGN-->
        ");
            WriteLiteral(@"        <div class=""top-campaign"">
                    <h3 class=""title-3 m-b-30"">En aktif ülkerler</h3>
                    <div class=""table-responsive"">
                        <table class=""table table-top-campaign"">
                            <tbody>
                                <tr>
                                    <td>1. Australia</td>
                                    <td></td>

                                </tr>
                                <tr>
                                    <td>2. United Kingdom</td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>3. Turkey</td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td>4. Germany</td>
                                    <td></td>
                                </tr>
                            ");
            WriteLiteral(@"    <tr>
                                    <td>5. France</td>
                                    <td></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <!-- END TOP CAMPAIGN-->
            </div>

        </div>
    </div>
</section>
<!-- END STATISTIC CHART-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
