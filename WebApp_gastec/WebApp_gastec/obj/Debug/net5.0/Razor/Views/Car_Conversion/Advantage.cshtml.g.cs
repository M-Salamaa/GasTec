#pragma checksum "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46dc7545629f953c12f1c9c1f2aa4773403c1e3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Conversion_Advantage), @"mvc.1.0.view", @"/Views/Car_Conversion/Advantage.cshtml")]
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
#line 2 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
using WebApp_gastec.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46dc7545629f953c12f1c9c1f2aa4773403c1e3e", @"/Views/Car_Conversion/Advantage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Conversion_Advantage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 346px; width: 900px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 193px; width: 400px; float: left; margin: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 400px; float: left; margin: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 533px; width: 900px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
 foreach (var entity in Model.Car_ConversionCategory)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
     foreach (var Websection in entity.LstWebSections)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
   Write(Html.Raw(Websection.Style));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                   
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/car_conv.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 20 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
         foreach (var entity in Model.Car_ConversionCategory)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 22 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 23 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 871, "\"", 905, 1);
#nullable restore
#line 32 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
WriteAttributeValue("", 878, Url.Action("Index","Home"), 878, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 33 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                 foreach (var entity in Model.Car_ConversionCategory)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 35 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 36 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
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
#line 53 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                 foreach (var mainSection in Model.Car_ConversionMain)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                     foreach (var entity in mainSection.LstChildClassification)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                         if (entity.IsActive == true)
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"active\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2154, "\"", 2271, 1);
#nullable restore
#line 61 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
WriteAttributeValue("", 2161, Url.Action(GetActionName.GetActionNameforCarConversionSectionByID(entity.ClassificationID), "Car_Conversion"), 2161, 110, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                                                                                                                                                    Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 63 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2588, "\"", 2705, 1);
#nullable restore
#line 67 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
WriteAttributeValue("", 2595, Url.Action(GetActionName.GetActionNameforCarConversionSectionByID(entity.ClassificationID), "Car_Conversion"), 2595, 110, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 67 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                                                                                                                                                    Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 69 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                     
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
#line 82 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                             foreach (var entity in Model.Car_ConversionCategory)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h2>");
#nullable restore
#line 84 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                               Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <div>\r\n");
#nullable restore
#line 86 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                     foreach (var webSection in entity.LstWebSections)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <!-- Rendreing Body with HTML Link-->\r\n");
#nullable restore
#line 89 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                   Write(Html.Raw(webSection.Body));

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                         foreach (var image in webSection.LstImages)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <!--//end backend to retrieve variables  -->\r\n                                            <!--//Start backend to retrieve variables  -->\r\n                                            <p>\r\n");
#nullable restore
#line 96 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                                 if (webSection.WebSectionID == 25)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span style=\"color:#273461;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "46dc7545629f953c12f1c9c1f2aa4773403c1e3e15967", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4401, "~/Images/CarConversion_Advantage/", 4401, 33, true);
#nullable restore
#line 98 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
AddHtmlAttributeValue("", 4434, image.ImageGUID, 4434, 16, false);

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
            WriteLiteral("</span>\r\n");
#nullable restore
#line 99 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 30)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "46dc7545629f953c12f1c9c1f2aa4773403c1e3e18009", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4751, "~/Images/CarConversion_Advantage/", 4751, 33, true);
#nullable restore
#line 102 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
AddHtmlAttributeValue("", 4784, image.ImageGUID, 4784, 16, false);

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
#line 103 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 32)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "46dc7545629f953c12f1c9c1f2aa4773403c1e3e20046", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5121, "~/Images/CarConversion_Advantage/", 5121, 33, true);
#nullable restore
#line 106 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
AddHtmlAttributeValue("", 5154, image.ImageGUID, 5154, 16, false);

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
#line 107 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 33)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span style=\"color:#273461;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "46dc7545629f953c12f1c9c1f2aa4773403c1e3e22114", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5505, "~/Images/CarConversion_Advantage/", 5505, 33, true);
#nullable restore
#line 110 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
AddHtmlAttributeValue("", 5538, image.ImageGUID, 5538, 16, false);

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
            WriteLiteral("</span>\r\n");
#nullable restore
#line 111 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </p>\r\n                                            <hr />\r\n");
#nullable restore
#line 114 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 117 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\Advantage.cshtml"
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
