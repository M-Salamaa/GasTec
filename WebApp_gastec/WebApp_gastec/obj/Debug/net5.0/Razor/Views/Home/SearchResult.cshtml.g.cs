#pragma checksum "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aae53755ebf589510fe71b166f5414686ce35905"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchResult), @"mvc.1.0.view", @"/Views/Home/SearchResult.cshtml")]
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
#line 1 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\_ViewImports.cshtml"
using WebApp_gastec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\_ViewImports.cshtml"
using WebApp_gastec.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aae53755ebf589510fe71b166f5414686ce35905", @"/Views/Home/SearchResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_SearchResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!--Page Title-->
<section class=""page-title"" style=""background-image:url(../../wwwroot/public/assets/softextwo/images/background/4.jpg);"">
    <div class=""auto-container"">
        <!--<h1>عن غازتك</h1>-->
    </div>
</section>
<!--End Page Title-->
<!--Page Info-->
<div class=""page-info"">
    <div class=""auto-container"">
        <div class=""inner-container clearfix"">
            <ul class=""bread-crumb pull-right"">
                <li><a");
            BeginWriteAttribute("href", " href=\"", 554, "\"", 589, 1);
#nullable restore
#line 22 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
WriteAttributeValue("", 561, Url.Action("Index", "Home"), 561, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">الرئيسية</a></li>
            </ul>
        </div>
    </div>
</div>
<!--End Page Info-->
<!--Sidebar Page Container-->
<div class=""sidebar-page-container"">
    <div class=""auto-container"">
        <div class=""row clearfix"">
            <!--Sidebar Side-->
            <!--Content Side-->
            <div class=""content-side col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <div class=""auto-container text-right"">
                    <h2>نتائج البحث</h2>
                    <hr>
                    <div id=""searchblocks""></div>

                    <div class=""row clearfix"">
");
#nullable restore
#line 41 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                         if (Model.searchResult.ListClassFicationTree != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""page-info"">
                                <div class=""auto-container"">
                                    <div class=""inner-container clearfix text-right"">
                                        <h4>صفحات</h4>
                                    </div>
                                </div>
                            </div>
                            <div class=""team-column col-md-12 col-sm-12 col-xs-12"" style=""margin-top: 30px"">
                                <div class=""inner-column"">
                                    <div class=""row clearfix"">
");
#nullable restore
#line 53 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                                         foreach (var classification in Model.searchResult.ListClassFicationTree)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div style=\"margin-bottom: 10px\" class=\"text-right\">\r\n                                                <a href=\"#\" target=\"blank\" data-caption=\"");
#nullable restore
#line 56 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                                                                                    Write(classification.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                                    ");
#nullable restore
#line 57 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                                               Write(classification.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </a>\r\n                                            </div>\r\n");
#nullable restore
#line 60 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 64 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                         if (Model.searchResult.ListNews != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""page-info"">
                                <div class=""auto-container"">
                                    <div class=""inner-container clearfix text-right"">
                                        <h4>أخبار</h4>
                                    </div>
                                </div>
                            </div>
                            <div class=""team-column col-md-12 col-sm-12 col-xs-12"" style=""margin-top: 30px"">
                                <div class=""inner-column"">
                                    <div class=""row clearfix"">
");
#nullable restore
#line 77 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                                         foreach (var classification in Model.searchResult.ListNews)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div style=\"margin-bottom: 10px\" class=\"text-right\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 3655, "\"", 3736, 1);
#nullable restore
#line 80 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
WriteAttributeValue("", 3662, Url.Action("NewsDetails", "Home", new { serial_ = classification.Serial}), 3662, 74, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"blank\" data-caption=\"");
#nullable restore
#line 80 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                                                                                                                                                             Write(classification.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                                    ");
#nullable restore
#line 81 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                                               Write(classification.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </a>\r\n                                            </div>\r\n");
#nullable restore
#line 84 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 88 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                         if (Model.searchResult.ListVideos != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""page-info"">

                                <div class=""auto-container"">
                                    <div class=""inner-container clearfix text-right"">
                                        <h4>فيديوهات</h4>
                                    </div>
                                </div>
                            </div>
                            <div class=""team-column col-md-12 col-sm-12 col-xs-12"" style=""margin-top: 30px"">
                                <div class=""inner-column"">
                                    <div class=""row clearfix"">
");
#nullable restore
#line 102 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                                         foreach (var classification in Model.searchResult.ListVideos)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div style=\"margin-bottom: 10px\" class=\"text-right\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 5169, "\"", 5195, 1);
#nullable restore
#line 105 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
WriteAttributeValue("", 5176, classification.URL, 5176, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"lightbox-image overlay-box\" data-caption=\"");
#nullable restore
#line 105 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                                                                                                                          Write(classification.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                                    ");
#nullable restore
#line 106 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                                               Write(classification.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </a>\r\n                                            </div>\r\n");
#nullable restore
#line 109 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 113 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\SearchResult.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>

        </div>

    </div>
</div>

<script>
    //LightBox / Fancybox
    if ($('.lightbox-image').length) {
        $('.lightbox-image').fancybox({
            openEffect: 'fade',
            closeEffect: 'fade',
            helpers: {
                media: {}
            }
        });
    }
</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomePageViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
