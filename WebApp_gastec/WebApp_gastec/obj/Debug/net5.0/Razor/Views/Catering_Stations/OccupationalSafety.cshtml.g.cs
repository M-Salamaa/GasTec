#pragma checksum "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f63a71fa4af466ddbe3181336b3062630350a8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catering_Stations_OccupationalSafety), @"mvc.1.0.view", @"/Views/Catering_Stations/OccupationalSafety.cshtml")]
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
#line 2 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
using WebApp_gastec.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f63a71fa4af466ddbe3181336b3062630350a8f", @"/Views/Catering_Stations/OccupationalSafety.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Catering_Stations_OccupationalSafety : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 309px; width: 400px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 541px; width: 700px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
 foreach (var entity in Model.Stations_Categories)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
     foreach (var Websection in entity.LstWebSections)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
   Write(Html.Raw(Websection.Style));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                   
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/Stations.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 21 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
         foreach (var entity in Model.Stations_Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 23 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 24 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 867, "\"", 901, 1);
#nullable restore
#line 33 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
WriteAttributeValue("", 874, Url.Action("Index","Home"), 874, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 34 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                 foreach (var entity in Model.Stations_Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 36 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 37 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
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
#line 53 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                 foreach (var mainSection in Model.Stations_Main)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                     foreach (var entity in mainSection.LstChildClassification)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                         if (entity.IsActive == true)
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"active\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2140, "\"", 2263, 1);
#nullable restore
#line 61 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
WriteAttributeValue("", 2147, Url.Action(GetActionName.GetActionNameforCateringStationsSectionByID(entity.ClassificationID), "Catering_Stations"), 2147, 116, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                                                                                                                                                          Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 63 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2580, "\"", 2703, 1);
#nullable restore
#line 67 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
WriteAttributeValue("", 2587, Url.Action(GetActionName.GetActionNameforCateringStationsSectionByID(entity.ClassificationID), "Catering_Stations"), 2587, 116, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 67 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                                                                                                                                                          Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 69 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                     
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
");
#nullable restore
#line 82 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                             foreach (var entity in Model.Stations_Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h2>");
#nullable restore
#line 84 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                               Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <div style=\"font-size:14px; position:relative\">\r\n");
#nullable restore
#line 86 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                     foreach (var webSection in entity.LstWebSections)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>&nbsp;</p>\r\n                                        <p>\r\n                                            ");
#nullable restore
#line 90 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                       Write(Html.Raw(webSection.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 91 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                             foreach (var image in webSection.LstImages)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                                 if (webSection.WebSectionID == 100)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9f63a71fa4af466ddbe3181336b3062630350a8f15544", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4210, "~/Images/Occupational_Safety/", 4210, 29, true);
#nullable restore
#line 95 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
AddHtmlAttributeValue("", 4239, image.ImageGUID, 4239, 16, false);

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
#line 96 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 101)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9f63a71fa4af466ddbe3181336b3062630350a8f17600", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4550, "~/Images/Occupational_Safety/", 4550, 29, true);
#nullable restore
#line 99 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
AddHtmlAttributeValue("", 4579, image.ImageGUID, 4579, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 100 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"

                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9f63a71fa4af466ddbe3181336b3062630350a8f19540", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4819, "~/Images/Occupational_Safety/", 4819, 29, true);
#nullable restore
#line 104 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
AddHtmlAttributeValue("", 4848, image.ImageGUID, 4848, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 105 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </p>\r\n                                        <p>&nbsp;</p>\r\n                                        <hr />\r\n");
#nullable restore
#line 110 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 112 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\OccupationalSafety.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
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
