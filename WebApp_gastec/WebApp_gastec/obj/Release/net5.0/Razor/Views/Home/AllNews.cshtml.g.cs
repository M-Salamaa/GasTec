#pragma checksum "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "355eb186ea1bde53eb3cd7179532f13a2a299dcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllNews), @"mvc.1.0.view", @"/Views/Home/AllNews.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"355eb186ea1bde53eb3cd7179532f13a2a299dcb", @"/Views/Home/AllNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
  
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
#line 23 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
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
            <!--Content Side-->
            <div class=""content-side col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <div class=""services-single"" dir=""rtl"">
                    <div class=""inner-box"">
                        <div id=""events1"">
                            <ul class=""nav nav-tabs"" dir=""rtl"">
");
#nullable restore
#line 41 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
                                 foreach (var year in Model.News_Group)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
                                     if (year.GroupID == 3 || year.GroupID == 4)
                                    {
                                        continue;
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li id=\"active-tab\">\r\n                                            <a data-toggle=\"tab\"");
            BeginWriteAttribute("href", " href=\"", 1748, "\"", 1769, 2);
            WriteAttributeValue("", 1755, "#", 1755, 1, true);
#nullable restore
#line 50 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
WriteAttributeValue("", 1756, year.GroupID, 1756, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-expanded=\"true\">");
#nullable restore
#line 50 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
                                                                                                       Write(year.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </li>\r\n");
#nullable restore
#line 52 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                            <div class=\"tab-content text-right\" style=\"padding-top: 20px\">\r\n");
#nullable restore
#line 56 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
                                 foreach (var year in Model.News_Group)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div");
            BeginWriteAttribute("id", " id=\"", 2209, "\"", 2227, 1);
#nullable restore
#line 58 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
WriteAttributeValue("", 2214, year.GroupID, 2214, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""tab-pane fade in"">
                                        <div class=""clearfix""></div>
                                        <div class=""page-info"" style=""margin-bottom: 10px;"">
                                            <div class=""auto-container"">
                                                <div class=""inner-container clearfix text-right"">
                                                    <h4>
                                                        أهم أخبار ");
#nullable restore
#line 64 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
                                                             Write(year.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </h4>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""row"">
                                            <!--//Start backend to retrieve variables  -->
                                            <!--//End backend to retrieve variables  -->
                                            <!--News Block-->
");
#nullable restore
#line 73 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
                                             foreach (var topic in Model.NewsTopics.LstNews.Where(x => x.GroupID == year.GroupID).ToList())
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <div class=""news-block col-md-3 col-sm-6 col-xs-12 wow fadeIn pull-right"" style=""max-height:400px; overflow:hidden; margin-top:20px"">
                                                    <div class=""inner-box"">
                                                        <div class=""image"">
                                                            <a");
            BeginWriteAttribute("href", " href=\"", 3840, "\"", 3912, 1);
#nullable restore
#line 78 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
WriteAttributeValue("", 3847, Url.Action("NewsDetails", "Home", new { serial_ = topic.Serial}), 3847, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "355eb186ea1bde53eb3cd7179532f13a2a299dcb11044", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3990, "~/Images/MediaCenter_NewsSection/", 3990, 33, true);
#nullable restore
#line 79 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
AddHtmlAttributeValue("", 4023, topic.ImageGUID, 4023, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                            </a>
                                                        </div>
                                                        <div class=""lower-box"" style=""min-height:200px"">
                                                            <div class=""post-info"">
                                                                ");
#nullable restore
#line 84 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
                                                           Write(topic.TopicDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </div>\r\n                                                            <h3>\r\n                                                                <a");
            BeginWriteAttribute("href", " href=\"", 4694, "\"", 4766, 1);
#nullable restore
#line 87 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
WriteAttributeValue("", 4701, Url.Action("NewsDetails", "Home", new { serial_ = topic.Serial}), 4701, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"theme-btn read-more\" style=\"margin-top: 10px;\">\r\n                                                                    ");
#nullable restore
#line 88 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
                                                               Write(topic.NewsTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                </a>\r\n                                                            </h3>\r\n                                                            <a");
            BeginWriteAttribute("href", " href=\"", 5109, "\"", 5181, 1);
#nullable restore
#line 91 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
WriteAttributeValue("", 5116, Url.Action("NewsDetails", "Home", new { serial_ = topic.Serial}), 5116, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""theme-btn read-more"" style=""margin-top: 10px; font-size: 14px;"">
                                                                إقرأ المزيد
                                                                <span class=""icon flaticon-left-arrow"" style=""margin-right: 10px;font-size: 20px;vertical-align: sub;""></span>
                                                            </a>
                                                        </div>
                                                    </div>
                                                </div>
");
#nullable restore
#line 98 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 101 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    $(document).ready(function () {
        $(""#active-tab"").addClass(""active"");
        $(""#1"").addClass(""active"");
    });
</script>
");
#nullable restore
#line 117 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
 foreach (var entity in Model.News_Group)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n            $(\"#active-tab\").click(function () {\r\n                $(\"#");
#nullable restore
#line 121 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
               Write(entity.GroupID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\").addClass(\"active\");\r\n            });\r\n    </script>\r\n");
#nullable restore
#line 124 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Home\AllNews.cshtml"
}

#line default
#line hidden
#nullable disable
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
