#pragma checksum "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0799acbcbfc13c9b0b627e40f98ff7d59305c195"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_organizational), @"mvc.1.0.view", @"/Views/About/organizational.cshtml")]
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
#nullable restore
#line 2 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
using WebApp_gastec.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0799acbcbfc13c9b0b627e40f98ff7d59305c195", @"/Views/About/organizational.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_About_organizational : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!--Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/hr.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 13 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
         foreach (var section in Model.AboutUsSection)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
             foreach (var entity in section.LstChildClassification)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!--<h1> ");
#nullable restore
#line 17 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
                    Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>-->\r\n");
#nullable restore
#line 18 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!--End Page Title-->\r\n<!--Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n");
#nullable restore
#line 27 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
             if (Gastech_Vault.TranslationLanguageID == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul class=\"bread-crumb pull-right\">\r\n                    <li>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 897, "\"", 931, 1);
#nullable restore
#line 31 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
WriteAttributeValue("", 904, Url.Action("Index","Home"), 904, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            الرئيسية\r\n                        </a>\r\n                    </li>\r\n                    <li>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1082, "\"", 1123, 1);
#nullable restore
#line 36 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
WriteAttributeValue("", 1089, Url.Action("LegalEntity","About"), 1089, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            عن غازتك\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 40 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
                     foreach (var entity in Model.AboutUsSection)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>");
#nullable restore
#line 42 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
                       Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 43 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n");
#nullable restore
#line 45 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>
<!--End Page Info-->
<!--Sidebar Page Container-->
<div class=""sidebar-page-container"">
    <div class=""auto-container"">
        <div class=""row clearfix"">
            <!--Sidebar Side-->
            <div class=""sidebar-side col-lg-3 col-md-4 col-sm-12 col-xs-12 pull-right"">
                <aside class=""sidebar"">
                    <div id=""sidenavelist""></div>
                    <div class=""sidebar-widget sidebar-blog-category"">
                        <ul class=""blog-cat"">
");
#nullable restore
#line 60 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
                             foreach (var mainSection in Model.HR)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
                                 foreach (var entity in mainSection.LstChildClassification)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2233, "\"", 2330, 1);
#nullable restore
#line 64 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
WriteAttributeValue("", 2240, Url.Action(GetActionName.GetActionNameforHRSectionByID(entity.ClassificationID), "About"), 2240, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
                                                                                                                                        Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 65 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\organizational.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                </aside>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<!-- Content Side -->\r\n\r\n\r\n<!-- End Content Side -->\r\n");
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
