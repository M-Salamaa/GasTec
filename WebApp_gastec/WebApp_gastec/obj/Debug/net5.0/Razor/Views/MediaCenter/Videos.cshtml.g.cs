#pragma checksum "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ed6fa617ed90616e36fa38b94286074ca7811d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MediaCenter_Videos), @"mvc.1.0.view", @"/Views/MediaCenter/Videos.cshtml")]
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
#line 1 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\_ViewImports.cshtml"
using WebApp_gastec;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\_ViewImports.cshtml"
using WebApp_gastec.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ed6fa617ed90616e36fa38b94286074ca7811d2", @"/Views/MediaCenter/Videos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_MediaCenter_Videos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/4.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 12 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
         foreach (var entity in Model.Sub_Section)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 14 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 15 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 656, "\"", 690, 1);
#nullable restore
#line 24 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
WriteAttributeValue("", 663, Url.Action("Index","Home"), 663, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 25 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
                 foreach (var entity in Model.Sub_Section)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 27 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 28 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
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
#line 44 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
                                 foreach (var mainSection in Model.Main_Section)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
                                     foreach (var entity in mainSection.LstChildClassification)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
                                         if (entity.ClassificationID == 48)
                                        {
                                            // Photo Center

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li ><a");
            BeginWriteAttribute("href", " href=\"", 1921, "\"", 1969, 1);
#nullable restore
#line 51 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
WriteAttributeValue("", 1928, Url.Action("PhotoCenter", "MediaCenter"), 1928, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
                                                                                                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 52 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
                                        }
                                        else if (entity.ClassificationID == 49)
                                        {
                                            //Videos

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 2294, "\"", 2337, 1);
#nullable restore
#line 56 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
WriteAttributeValue("", 2301, Url.Action("Videos", "MediaCenter"), 2301, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 56 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
                                                                                                         Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 57 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
                                        }
                                        else if (entity.ClassificationID == 50)
                                        {
                                            //Activites Photo

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2656, "\"", 2708, 1);
#nullable restore
#line 61 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
WriteAttributeValue("", 2663, Url.Action("ActivitiesPhoto", "MediaCenter"), 2663, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
                                                                                                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 62 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
                                        }
                                        else if (entity.ClassificationID == 51)
                                        {
                                            //Reports

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3019, "\"", 3063, 1);
#nullable restore
#line 66 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
WriteAttributeValue("", 3026, Url.Action("Reports", "MediaCenter"), 3026, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
                                                                                           Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 67 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\MediaCenter\Videos.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </ul>
                        </div>
                    </div>
                </aside>
            </div>
            <!--Content Side-->
            <div class=""content-side pull-left col-lg-9 col-md-8 col-sm-12 col-xs-12"">
                <div class=""auto-container"">
                    <div id=""galrow"">
                        <!-- Tabs Side-->

                    </div>
                </div>
                <div class=""team-column col-md-12 col-sm-12 col-xs-12"" style=""margin-top: 30px"">
                    <div class=""inner-column"">
                        <div class=""row clearfix"">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
