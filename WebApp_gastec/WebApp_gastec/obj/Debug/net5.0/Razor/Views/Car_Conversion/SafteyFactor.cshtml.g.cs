#pragma checksum "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0acb010790aec080d9d91b0d35a6033892571f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Conversion_SafteyFactor), @"mvc.1.0.view", @"/Views/Car_Conversion/SafteyFactor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0acb010790aec080d9d91b0d35a6033892571f8", @"/Views/Car_Conversion/SafteyFactor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Conversion_SafteyFactor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 418px; width: 900px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
 foreach (var entity in Model.Car_ConversionCategory)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
     foreach (var Websection in entity.LstWebSections)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
   Write(Html.Raw(Websection.Style));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                   
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/car_conv.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 20 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
         foreach (var entity in Model.Car_ConversionCategory)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 22 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 23 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 844, "\"", 878, 1);
#nullable restore
#line 32 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
WriteAttributeValue("", 851, Url.Action("Index","Home"), 851, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 33 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                 foreach (var entity in Model.Car_ConversionCategory)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 35 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 36 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
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
#line 52 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                 foreach (var mainSection in Model.Car_ConversionMain)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                     foreach (var entity in mainSection.LstChildClassification)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                         if (entity.ClassificationID == 19)
                                        {
                                            // Advantages

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2123, "\"", 2172, 1);
#nullable restore
#line 59 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
WriteAttributeValue("", 2130, Url.Action("Advantage", "Car_Conversion"), 2130, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                                                                                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 60 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                        }
                                        else if (entity.ClassificationID == 20)
                                        {
                                            //Conversion Proccess

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2495, "\"", 2554, 1);
#nullable restore
#line 64 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
WriteAttributeValue("", 2502, Url.Action("Conversion_Proccess", "Car_Conversion"), 2502, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                                                                                          Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 65 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                        }
                                        else if (entity.ClassificationID == 21)
                                        {
                                            //Conversion Cost

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2873, "\"", 2928, 1);
#nullable restore
#line 69 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
WriteAttributeValue("", 2880, Url.Action("Conversion_Cost", "Car_Conversion"), 2880, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 69 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                                                                                      Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 70 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                        }
                                        else if (entity.ClassificationID == 22)
                                        {
                                            //Saftey Factor

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 3260, "\"", 3312, 1);
#nullable restore
#line 74 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
WriteAttributeValue("", 3267, Url.Action("SafteyFactor", "Car_Conversion"), 3267, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 74 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                                                                                                  Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 75 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                        }
                                        else if (entity.ClassificationID == 23)
                                        {
                                            //Questions

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3625, "\"", 3680, 1);
#nullable restore
#line 79 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
WriteAttributeValue("", 3632, Url.Action("CommonQuestions", "Car_Conversion"), 3632, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 79 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                                                                                      Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 80 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                        }
                                        else if (entity.ClassificationID == 24)
                                        {
                                            //Conversion Centers

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 4002, "\"", 4060, 1);
#nullable restore
#line 84 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
WriteAttributeValue("", 4009, Url.Action("Conversion_Centers", "Car_Conversion"), 4009, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 84 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                                                                                         Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 85 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                        }
                                        else if (entity.ClassificationID == 25)
                                        {
                                            //Local Manuf

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 4375, "\"", 4434, 1);
#nullable restore
#line 89 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
WriteAttributeValue("", 4382, Url.Action("local_manufacturing", "Car_Conversion"), 4382, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 89 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                                                                                          Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 90 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                     
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
#line 103 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                             foreach (var entity in Model.Car_ConversionCategory)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h2>");
#nullable restore
#line 105 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                               Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <div>\r\n");
#nullable restore
#line 107 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                     foreach (var webSection in entity.LstWebSections)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <!-- Rendreing Body with HTML Link-->\r\n");
#nullable restore
#line 111 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                   Write(Html.Raw(webSection.Body));

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                         foreach (var image in webSection.LstImages)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <!--//end backend to retrieve variables  -->\r\n                                            <!--//Start backend to retrieve variables  -->\r\n");
#nullable restore
#line 116 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                             if (webSection.WebSectionID == 63)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p style=\"text-align: justify;\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b0acb010790aec080d9d91b0d35a6033892571f820626", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6080, "~/Images/SafteyFactor/", 6080, 22, true);
#nullable restore
#line 119 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
AddHtmlAttributeValue("", 6102, image.ImageGUID, 6102, 16, false);

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
            WriteLiteral("\r\n                                                </p>\r\n");
#nullable restore
#line 121 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p style=\"text-align: justify;\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b0acb010790aec080d9d91b0d35a6033892571f822753", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6501, "~/Images/SafteyFactor/", 6501, 22, true);
#nullable restore
#line 125 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
AddHtmlAttributeValue("", 6523, image.ImageGUID, 6523, 16, false);

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
            WriteLiteral("\r\n                                                </p>\r\n");
#nullable restore
#line 127 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                             

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <hr />\r\n");
#nullable restore
#line 132 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 134 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\SafteyFactor.cshtml"

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
