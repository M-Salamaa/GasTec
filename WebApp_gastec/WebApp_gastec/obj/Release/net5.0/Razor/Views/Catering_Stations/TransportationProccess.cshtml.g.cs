#pragma checksum "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc4fc7a0d07e26ac212551b330b6c4f42509d072"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catering_Stations_TransportationProccess), @"mvc.1.0.view", @"/Views/Catering_Stations/TransportationProccess.cshtml")]
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
#line 2 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
using WebApp_gastec.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc4fc7a0d07e26ac212551b330b6c4f42509d072", @"/Views/Catering_Stations/TransportationProccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Catering_Stations_TransportationProccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 230px; width: 400px; margin: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 117px; width: 250px; float: left;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float: left; height: 149px; width: 150px; margin: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 232px; width: 900px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 243px; width: 900px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 292px; width: 500px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/Stations.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 13 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
         foreach (var entity in Model.Stations_Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 15 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 16 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 700, "\"", 734, 1);
#nullable restore
#line 25 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
WriteAttributeValue("", 707, Url.Action("Index","Home"), 707, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 26 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                 foreach (var entity in Model.Stations_Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 28 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 29 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
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
#line 45 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                 foreach (var mainSection in Model.Stations_Main)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                     foreach (var entity in mainSection.LstChildClassification)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                         if (entity.IsActive == true)
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"active\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 1973, "\"", 2096, 1);
#nullable restore
#line 53 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
WriteAttributeValue("", 1980, Url.Action(GetActionName.GetActionNameforCateringStationsSectionByID(entity.ClassificationID), "Catering_Stations"), 1980, 116, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 53 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                                                                                                                                                          Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 55 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2413, "\"", 2536, 1);
#nullable restore
#line 59 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
WriteAttributeValue("", 2420, Url.Action(GetActionName.GetActionNameforCateringStationsSectionByID(entity.ClassificationID), "Catering_Stations"), 2420, 116, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                                                                                                                                                          Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 61 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                     
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
#line 74 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                             foreach (var entity in Model.Stations_Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h2>");
#nullable restore
#line 76 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                               Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <div style=\"font-size:14px; position:relative\">\r\n");
#nullable restore
#line 78 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                     foreach (var webSection in entity.LstWebSections)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>&nbsp;</p>\r\n                                        <p>\r\n                                            ");
#nullable restore
#line 82 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                       Write(Html.Raw(webSection.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 83 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                             foreach (var image in webSection.LstImages)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                                 if (webSection.WebSectionID == 104)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc4fc7a0d07e26ac212551b330b6c4f42509d07216052", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4043, "~/Images/Transportation_Proccess/", 4043, 33, true);
#nullable restore
#line 87 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
AddHtmlAttributeValue("", 4076, image.ImageGUID, 4076, 16, false);

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
#line 88 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 107)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc4fc7a0d07e26ac212551b330b6c4f42509d07218120", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4401, "~/Images/Transportation_Proccess/", 4401, 33, true);
#nullable restore
#line 91 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
AddHtmlAttributeValue("", 4434, image.ImageGUID, 4434, 16, false);

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
#line 92 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 109)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc4fc7a0d07e26ac212551b330b6c4f42509d07220188", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4758, "~/Images/Transportation_Proccess/", 4758, 33, true);
#nullable restore
#line 95 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
AddHtmlAttributeValue("", 4791, image.ImageGUID, 4791, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 96 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 111)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc4fc7a0d07e26ac212551b330b6c4f42509d07222256", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5129, "~/Images/Transportation_Proccess/", 5129, 33, true);
#nullable restore
#line 99 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
AddHtmlAttributeValue("", 5162, image.ImageGUID, 5162, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 100 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 112)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc4fc7a0d07e26ac212551b330b6c4f42509d07224325", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5473, "~/Images/Transportation_Proccess/", 5473, 33, true);
#nullable restore
#line 103 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
AddHtmlAttributeValue("", 5506, image.ImageGUID, 5506, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 104 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 114)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc4fc7a0d07e26ac212551b330b6c4f42509d07226395", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5817, "~/Images/Transportation_Proccess/", 5817, 33, true);
#nullable restore
#line 107 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
AddHtmlAttributeValue("", 5850, image.ImageGUID, 5850, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 108 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc4fc7a0d07e26ac212551b330b6c4f42509d07228429", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6125, "~/Images/Transportation_Proccess/", 6125, 33, true);
#nullable restore
#line 111 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
AddHtmlAttributeValue("", 6158, image.ImageGUID, 6158, 16, false);

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
#line 112 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </p>\r\n                                        <p>&nbsp;</p>\r\n                                        <hr />\r\n");
#nullable restore
#line 117 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 119 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\TransportationProccess.cshtml"
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