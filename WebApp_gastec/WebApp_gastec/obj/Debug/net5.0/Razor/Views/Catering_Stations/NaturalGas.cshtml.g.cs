#pragma checksum "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f324cf22e58c5ed666a4831a856dfe065c06fee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catering_Stations_NaturalGas), @"mvc.1.0.view", @"/Views/Catering_Stations/NaturalGas.cshtml")]
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
#nullable restore
#line 2 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
using WebApp_gastec.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f324cf22e58c5ed666a4831a856dfe065c06fee", @"/Views/Catering_Stations/NaturalGas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Catering_Stations_NaturalGas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 179px; width: 268px; margin: 0px 25px; float: left;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 110px; height: 201px; margin-left: 25px; margin-right: 25px; float: left;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 25px; margin-right: 25px; width: 400px; height: 234px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 566px; width: 400px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/Stations.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 13 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
         foreach (var entity in Model.Stations_Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 15 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 16 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 700, "\"", 734, 1);
#nullable restore
#line 25 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
WriteAttributeValue("", 707, Url.Action("Index","Home"), 707, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 26 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                 foreach (var entity in Model.Stations_Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 28 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 29 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
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
#line 45 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                 foreach (var mainSection in Model.Stations_Main)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                     foreach (var entity in mainSection.LstChildClassification)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                         if (entity.IsActive == true)
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"active\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 1973, "\"", 2096, 1);
#nullable restore
#line 53 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
WriteAttributeValue("", 1980, Url.Action(GetActionName.GetActionNameforCateringStationsSectionByID(entity.ClassificationID), "Catering_Stations"), 1980, 116, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 53 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                                                                                                                                                          Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 55 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2413, "\"", 2536, 1);
#nullable restore
#line 59 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
WriteAttributeValue("", 2420, Url.Action(GetActionName.GetActionNameforCateringStationsSectionByID(entity.ClassificationID), "Catering_Stations"), 2420, 116, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                                                                                                                                                          Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 61 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                     
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
#line 74 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                             foreach (var entity in Model.Stations_Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h2>");
#nullable restore
#line 76 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                               Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <div style=\"font-size:14px; position:relative\">\r\n                                    <p style=\"text-align: justify;\">\r\n");
#nullable restore
#line 79 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                         foreach (var webSection in entity.LstWebSections)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span style=\"color:#263a69;\">\r\n                                                <span style=\"font-size:18px;\">\r\n                                                    ");
#nullable restore
#line 83 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                               Write(Html.Raw(webSection.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </span>\r\n                                            </span>\r\n");
#nullable restore
#line 86 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                             foreach (var image in webSection.LstImages)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                                 if (webSection.WebSectionID == 79)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f324cf22e58c5ed666a4831a856dfe065c06fee15666", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4293, "~/Images/NaturalGas_Stations/", 4293, 29, true);
#nullable restore
#line 90 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
AddHtmlAttributeValue("", 4322, image.ImageGUID, 4322, 16, false);

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
#line 91 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 80)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f324cf22e58c5ed666a4831a856dfe065c06fee17705", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4663, "~/Images/NaturalGas_Stations/", 4663, 29, true);
#nullable restore
#line 94 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
AddHtmlAttributeValue("", 4692, image.ImageGUID, 4692, 16, false);

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
#line 95 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 81)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <table align=""center"" border=""1"" cellpadding=""1"" cellspacing=""1"">
                                                        <tbody>
                                                            <tr>
                                                                <td style=""text-align: justify;"">
                                                                    <span style=""color:#263a69;"">
                                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f324cf22e58c5ed666a4831a856dfe065c06fee20225", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5529, "~/Images/NaturalGas_Stations/", 5529, 29, true);
#nullable restore
#line 103 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
AddHtmlAttributeValue("", 5558, image.ImageGUID, 5558, 16, false);

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
            WriteLiteral(@"
                                                                    </span>
                                                                </td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
");
#nullable restore
#line 109 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 92)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a");
            BeginWriteAttribute("href", " href=\"", 6242, "\"", 6249, 0);
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f324cf22e58c5ed666a4831a856dfe065c06fee22912", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6335, "~/Images/NaturalGas_Stations/", 6335, 29, true);
#nullable restore
#line 113 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
AddHtmlAttributeValue("", 6364, image.ImageGUID, 6364, 16, false);

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
            WriteLiteral("\r\n                                                        &nbsp;\r\n                                                    </a>\r\n");
#nullable restore
#line 116 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f324cf22e58c5ed666a4831a856dfe065c06fee25044", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6761, "~/Images/NaturalGas_Stations/", 6761, 29, true);
#nullable restore
#line 119 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
AddHtmlAttributeValue("", 6790, image.ImageGUID, 6790, 16, false);

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
#line 120 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <hr />\r\n");
#nullable restore
#line 123 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </p>\r\n                                </div>\r\n");
#nullable restore
#line 126 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Catering_Stations\NaturalGas.cshtml"
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
