#pragma checksum "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c149ebda92a96562d79db4538f46768a5e734fd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewsDetails), @"mvc.1.0.view", @"/Views/Home/NewsDetails.cshtml")]
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
#line 1 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\_ViewImports.cshtml"
using WebApp_gastec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\_ViewImports.cshtml"
using WebApp_gastec.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c149ebda92a96562d79db4538f46768a5e734fd8", @"/Views/Home/NewsDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NewsDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Page Title-->
<section class=""page-title"" style=""background-image:url('../../wwwroot/public/assets/softextwo/images/background/news.jpg');"">
    <div class=""auto-container"">

        <!-- <h1>أحدث الأخبار</h1>-->
    </div>
</section>

<!-- End Page Title-->
<!-- Page Info-->
<div class=""page-info"">
    <div class=""auto-container"">
        <div class=""inner-container clearfix"">
            <ul class=""bread-crumb pull-right"">
                <li><a");
            BeginWriteAttribute("href", " href=\"", 569, "\"", 604, 1);
#nullable restore
#line 23 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
WriteAttributeValue("", 576, Url.Action("Index", "Home"), 576, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">الرئيسية</a></li>
                <li>
                    أخبار وفاعليات غازتك
                </li>
            </ul>
        </div>
    </div>
</div>
<!-- End Page Info-->
<div class=""sidebar-page-container"">
    <div class=""auto-container"">
        <div class=""row clearfix"">
            <div class=""sidebar-side col-lg-3 col-md-4 col-sm-12 col-xs-12"">
                <aside class=""sidebar"">
                    <div id=""sideevents"">
                        <!-- Popular Posts -->
                        <div class=""sidebar-widget popular-posts"">
                            <div class=""sidebar-title""><h2>آخر الأخبار</h2></div>
");
#nullable restore
#line 41 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                             foreach (var topic in Model.NewsTopics.LstNews.Take(11))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <!--//Start backend to retrieve variables  -->\r\n                                <article class=\"post\">\r\n                                    <figure class=\"post-thumb\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1620, "\"", 1691, 1);
#nullable restore
#line 46 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
WriteAttributeValue("", 1627, Url.Action("NewsDetails", "Home", new { srial_ = topic.Serial}), 1627, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c149ebda92a96562d79db4538f46768a5e734fd86241", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1749, "~/Images/MediaCenter_NewsSection/", 1749, 33, true);
#nullable restore
#line 47 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
AddHtmlAttributeValue("", 1782, topic.ImageGUID, 1782, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </a>\r\n                                    </figure>\r\n                                    <div class=\"text\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2000, "\"", 2071, 1);
#nullable restore
#line 51 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
WriteAttributeValue("", 2007, Url.Action("NewsDetails", "Home", new { srial_ = topic.Serial}), 2007, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            ");
#nullable restore
#line 52 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                       Write(topic.NewsTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </div>\r\n                                    <div class=\"post-info\">");
#nullable restore
#line 55 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                                      Write(topic.TopicDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </article>\r\n");
#nullable restore
#line 57 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </aside>
            </div>
            <!--Content Side-->
            <div class=""content-side col-lg-9 col-md-8 col-sm-12 col-xs-12 pull-right"">
                <div class=""services-single"" dir=""rtl"">
                    <div class=""inner-box"">
                        <div id=""events1"">
                            <div class=""blog-classic padding-right"" style=""padding-right:0;"">
                                <!--Large Image Posts-->
                                <div class=""large-image-posts"">
                                    <!--News Block Three-->
                                    <div class=""news-block-three"">
                                        <div class=""inner-box"">
");
#nullable restore
#line 73 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                             foreach (var entity in Model.News_Details)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"single-item-carousel owl-carousel owl-theme\">\r\n");
#nullable restore
#line 76 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                                     foreach (var img in entity.LstImages)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <div class=""testimonial-block"">
                                                            <div class=""inner-box"">
                                                                <div class=""upper-box"">
                                                                    <div class=""image"">
                                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c149ebda92a96562d79db4538f46768a5e734fd811465", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4015, "~/Images/News/", 4015, 14, true);
#nullable restore
#line 82 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
AddHtmlAttributeValue("", 4029, img.ImageGUID, 4029, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                                                            </div>
                                                        </div>
");
#nullable restore
#line 87 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </div>
                                                <div class=""lower-content"">
                                                    <div class=""lower-box"">
                                                        <p style=""color: #999"">
                                                            <i class=""fa fa-calendar""></i> ");
#nullable restore
#line 92 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                                                                      Write(entity.TopicDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                        </p>
                                                        <h3>
                                                            <a href=""#"">
                                                                ");
#nullable restore
#line 96 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                                           Write(entity.NewsTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </a>\r\n                                                        </h3>\r\n\r\n                                                        ");
#nullable restore
#line 100 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                                   Write(Html.Raw(entity.body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                        <a");
            BeginWriteAttribute("href", " href=\"", 5364, "\"", 5400, 1);
#nullable restore
#line 102 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
WriteAttributeValue("", 5371, Url.Action("AllNews","Home"), 5371, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""theme-btn read-more"" style=""float: left;direction: rtl;font-size: 18px;"">
                                                            عرض جميع الأخبار<span class=""icon flaticon-left-arrow"" style=""margin-right: 10px;font-size: 20px;vertical-align: sub;"">
                                                            </span>
                                                        </a>

                                                    </div>
                                                </div>
");
#nullable restore
#line 109 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\NewsDetails.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomePageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
