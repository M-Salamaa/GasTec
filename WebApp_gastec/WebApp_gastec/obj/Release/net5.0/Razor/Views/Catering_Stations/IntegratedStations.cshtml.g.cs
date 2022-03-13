#pragma checksum "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84fbe61e44a573b92fbeef868488bba11d9f4f9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catering_Stations_IntegratedStations), @"mvc.1.0.view", @"/Views/Catering_Stations/IntegratedStations.cshtml")]
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
#line 2 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
using WebApp_gastec.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84fbe61e44a573b92fbeef868488bba11d9f4f9f", @"/Views/Catering_Stations/IntegratedStations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Catering_Stations_IntegratedStations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 315px; width: 900px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/Stations.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 13 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
         foreach (var entity in Model.Stations_Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 15 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 16 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 700, "\"", 734, 1);
#nullable restore
#line 25 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
WriteAttributeValue("", 707, Url.Action("Index","Home"), 707, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 26 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                 foreach (var entity in Model.Stations_Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 28 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 29 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
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
#line 45 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                 foreach (var mainSection in Model.Stations_Main)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                     foreach (var entity in mainSection.LstChildClassification)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                         if (entity.IsActive == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"active\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 1971, "\"", 2094, 1);
#nullable restore
#line 52 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
WriteAttributeValue("", 1978, Url.Action(GetActionName.GetActionNameforCateringStationsSectionByID(entity.ClassificationID), "Catering_Stations"), 1978, 116, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 52 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                                                                                                                                                          Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 54 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                        }
                                        else
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2413, "\"", 2536, 1);
#nullable restore
#line 59 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
WriteAttributeValue("", 2420, Url.Action(GetActionName.GetActionNameforCateringStationsSectionByID(entity.ClassificationID), "Catering_Stations"), 2420, 116, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                                                                                                                                                          Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 61 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                     
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
                <div class=""services-single"" dir=""rtl"">
                    <div class=""inner-box"">
                        <div id=""cmspage1"">
                            <div style=""font-size:14px; position:relative"">
                                <h3 dir=""rtl"" style=""text-align: justify;"">
                                    <span style=""color:#263a69;"">
                                        <span style=""font-size:18px;"">- محطات تموين نموذجية متكاملة الخدمات بالوقود السائل والغاز الطبيعي والشحن الكهربائي</span>
                                    </span>
                                </h3>
");
#nullable restore
#line 80 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                 foreach (var Lstchild in Model.Stations_Categories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <table border=\"1\" cellpadding=\"1\" cellspacing=\"1\" dir=\"rtl\" style=\"width:100%;\">\r\n                                        <tbody>\r\n                                            <tr>\r\n");
#nullable restore
#line 85 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                                 foreach (var child in Lstchild.LstChildClassification)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <td>\r\n                                                        <a");
            BeginWriteAttribute("href", " href=\"", 4225, "\"", 4322, 1);
#nullable restore
#line 88 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
WriteAttributeValue("", 4232, Url.Action("Stations","Catering_Stations",new { Id_ = child.ClassificationID.ToString()}), 4232, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            ");
#nullable restore
#line 89 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                                       Write(child.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </a>\r\n                                                    </td>\r\n");
#nullable restore
#line 92 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tr>
                                        </tbody>
                                    </table>
                                    <p dir=""rtl"" style=""text-align: justify;"">&nbsp;</p>
                                    <p dir=""rtl"" style=""text-align: justify;"">
                                        <span style=""color:#263a69;"">
                                            <span style=""font-size:18px;"">
                                                ");
#nullable restore
#line 100 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                           Write(Html.Raw(Lstchild.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </span>
                                        </span>
                                    </p>
                                    <p dir=""rtl"" style=""text-align: justify;"">&nbsp;</p>
                                    <h3 dir=""rtl"" style=""text-align: justify;"">
                                        <span style=""color:#263a69;"">
");
#nullable restore
#line 107 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                             foreach (var image in Lstchild.LstImages)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "84fbe61e44a573b92fbeef868488bba11d9f4f9f16110", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5702, "~/Images/Integrated_Stations/", 5702, 29, true);
#nullable restore
#line 109 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
AddHtmlAttributeValue("", 5731, image.ImageGUID, 5731, 16, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 110 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </span>\r\n                                    </h3>\r\n");
#nullable restore
#line 113 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\IntegratedStations.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
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
