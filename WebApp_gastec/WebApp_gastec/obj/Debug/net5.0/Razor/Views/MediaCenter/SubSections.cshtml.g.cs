#pragma checksum "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90ab205964d1b949d0adae89b6b502daa1e5191a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MediaCenter_SubSections), @"mvc.1.0.view", @"/Views/MediaCenter/SubSections.cshtml")]
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
#nullable restore
#line 2 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
using WebApp_gastec.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ab205964d1b949d0adae89b6b502daa1e5191a", @"/Views/MediaCenter/SubSections.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_MediaCenter_SubSections : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
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
#line 4 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/4.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 13 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
         foreach (var entity in Model.Sub_Section)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 15 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 16 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 685, "\"", 719, 1);
#nullable restore
#line 25 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
WriteAttributeValue("", 692, Url.Action("Index","Home"), 692, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 26 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                 foreach (var entity in Model.Sub_Section)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 28 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 29 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </ul>
        </div>
    </div>
</div>
<!-- End Page Info-->
<div class=""sidebar-page-container"">
    <div class=""auto-container"">
        <div class=""row clearfix"">
            <!--Sidebar Side-->
            <div class=""sidebar-side col-lg-3 col-md-4 col-sm-12 col-xs-12 pull-right"">
                <aside class=""sidebar"">
                    <!--Blog Category Widget-->
                    <div id=""sidenavelist"">
                        <div class=""sidebar-widget sidebar-blog-category"">
                            <ul class=""blog-cat"">
");
#nullable restore
#line 45 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                 foreach (var mainSection in Model.Main_Section)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                     if (Model.IsActive == true)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"active\">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1794, "\"", 1835, 1);
#nullable restore
#line 50 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
WriteAttributeValue("", 1801, Url.Action("News", "MediaCenter"), 1801, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">أحدث الأخبار</a>\r\n                                        </li>\r\n");
#nullable restore
#line 52 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2114, "\"", 2155, 1);
#nullable restore
#line 56 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
WriteAttributeValue("", 2121, Url.Action("News", "MediaCenter"), 2121, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">أحدث الأخبار</a>\r\n                                        </li>\r\n");
#nullable restore
#line 58 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                     foreach (var entity in mainSection.LstChildClassification)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                         if (entity.IsActive == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"active\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2626, "\"", 2717, 1);
#nullable restore
#line 64 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
WriteAttributeValue("", 2633, Url.Action("SubSections", "MediaCenter", new { GroupId_ = entity.ClassificationID}), 2633, 84, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                                                                                                                          Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 66 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 3034, "\"", 3125, 1);
#nullable restore
#line 70 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
WriteAttributeValue("", 3041, Url.Action("SubSections", "MediaCenter", new { GroupId_ = entity.ClassificationID}), 3041, 84, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 70 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                                                                                                                          Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 72 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </aside>\r\n            </div>\r\n            <!--Content Side-->\r\n");
#nullable restore
#line 81 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
             foreach (var entity in Model.Sub_Section)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                 if (entity.ClassificationID == 49)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""content-side pull-left col-lg-9 col-md-8 col-sm-12 col-xs-12"">
                        <div class=""auto-container"">
                            <div id=""galrow"">
                                <!-- Tabs Side-->
                                <div class=""content-side pull-left col-lg-9 col-md-8 col-sm-12 col-xs-12"">
                                    <div class=""services-single"" dir=""rtl"">
                                        <div class=""inner-box"">
                                            <div id=""videoholder"">
                                                <div class=""large-image-posts"">
                                                    <!--News Block Three-->
");
#nullable restore
#line 95 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                                     foreach (var webSection in entity.LstWebSections)
                                                    {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                                         foreach (var image in webSection.LstImages)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            <div class=""news-block-three col-md-6 col-sm-12 col-xs-12 pull-right"">
                                                                <div class=""inner-box"">
                                                                    <div class=""video-box"">
                                                                        <div class=""image"">
                                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "90ab205964d1b949d0adae89b6b502daa1e5191a15464", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5181, "~/Images/MediaCenter/", 5181, 21, true);
#nullable restore
#line 103 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
AddHtmlAttributeValue("", 5202, image.ImageGUID, 5202, 16, false);

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
            WriteLiteral("\r\n                                                                            <a");
            BeginWriteAttribute("href", " href=\"", 5307, "\"", 5335, 1);
#nullable restore
#line 104 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
WriteAttributeValue("", 5314, webSection.ActionURL, 5314, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""lightbox-image overlay-box"">
                                                                                <span class=""flaticon-play-button-2""></span>
                                                                            </a>
                                                                        </div>
                                                                    </div>
                                                                    <div class=""lower-content"">
                                                                        <div class=""lower-box"" style=""height: 40px;"">
                                                                            <h3>");
#nullable restore
#line 111 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                                                           Write(webSection.ToolTip);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
");
#nullable restore
#line 116 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                                         
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 126 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                }
                else if (entity.ClassificationID == 51)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""content-side pull-left col-lg-9 col-md-8 col-sm-12 col-xs-12"">
                        <div class=""services-single"" dir=""rtl"">
                            <div class=""inner-box"">
                                <div id=""filesholder"">
                                    <ul class=""nav nav-tabs"" dir=""rtl"">
");
#nullable restore
#line 134 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                         foreach (var child in entity.LstChildClassification)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li id=\"active-tab\">\r\n                                                <a data-toggle=\"tab\"");
            BeginWriteAttribute("href", " href=\"", 7516, "\"", 7547, 2);
            WriteAttributeValue("", 7523, "#", 7523, 1, true);
#nullable restore
#line 137 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
WriteAttributeValue("", 7524, child.ClassificationID, 7524, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-expanded=\"true\">\r\n                                                    ");
#nullable restore
#line 138 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                               Write(child.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </a>\r\n                                            </li>\r\n");
#nullable restore
#line 141 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                    <div class=\"tab-content text-right\" style=\"padding-top: 20px\">\r\n");
#nullable restore
#line 144 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                         foreach (var child in entity.LstChildClassification)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div");
            BeginWriteAttribute("id", " id=\"", 8128, "\"", 8157, 2);
            WriteAttributeValue("", 8133, "#", 8133, 1, true);
#nullable restore
#line 146 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
WriteAttributeValue("", 8134, child.ClassificationID, 8134, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n                                                <div class=\"clearfix\"></div>\r\n                                                <div>\r\n");
#nullable restore
#line 149 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                                     foreach (var file in child.LstFiles.Where(x => x.FileLinkedID == child.ClassificationID).ToList())
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <!--//Start backend to retrieve variables  -->
                                                        <!--//End backend to retrieve variables  -->
                                                        <!--News Block-->
                                                        <div>
                                                            <a");
            BeginWriteAttribute("href", " href=\"", 8909, "\"", 8930, 1);
#nullable restore
#line 155 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
WriteAttributeValue("", 8916, file.FileLink, 8916, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 14px;\" target=\"_blank\">\r\n                                                                <i class=\"fa fa-download\" style=\"margin-left: 10px;\"></i>\r\n                                                                ");
#nullable restore
#line 157 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                                           Write(file.FileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </a>\r\n                                                        </div>\r\n");
#nullable restore
#line 160 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 163 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 169 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 169 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\"#active-tab\").addClass(\"active\");\r\n    });\r\n</script>\r\n");
#nullable restore
#line 181 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
 foreach (var entity in Model.Sub_Section)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 183 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
     foreach (var child in entity.LstChildClassification)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n\r\n    $(\"active-tab\").click(function () {\r\n        $(#");
#nullable restore
#line 189 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
      Write(child.ClassificationID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(").addClass(\"tab-pane fade in active\");\r\n        console.log(\"ssssssss\");\r\n            });\r\n</script>\r\n");
#nullable restore
#line 193 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 193 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\SubSections.cshtml"
     
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
