#pragma checksum "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5286cfa5661e23150c73277ce22cbf1bdb1feb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Conversion_CommonQuestions), @"mvc.1.0.view", @"/Views/Car_Conversion/CommonQuestions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5286cfa5661e23150c73277ce22cbf1bdb1feb0", @"/Views/Car_Conversion/CommonQuestions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Conversion_CommonQuestions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 900px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
 foreach (var entity in Model.Car_ConversionCategory)
{
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
   Write(Html.Raw(entity.Style));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                               
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/car_conv.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 16 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
         foreach (var entity in Model.Car_ConversionCategory)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 18 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 19 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 768, "\"", 802, 1);
#nullable restore
#line 28 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
WriteAttributeValue("", 775, Url.Action("Index","Home"), 775, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 29 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                 foreach (var entity in Model.Car_ConversionCategory)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 31 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 32 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
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
#line 49 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                 foreach (var mainSection in Model.Car_ConversionMain)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                     foreach (var entity in mainSection.LstChildClassification)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                         if (entity.ClassificationID == 19)
                                        {
                                            // Advantages

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2049, "\"", 2098, 1);
#nullable restore
#line 56 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
WriteAttributeValue("", 2056, Url.Action("Advantage", "Car_Conversion"), 2056, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 56 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                                                                                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 57 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                        }
                                        else if (entity.ClassificationID == 20)
                                        {
                                            //Conversion Proccess

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2421, "\"", 2480, 1);
#nullable restore
#line 61 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
WriteAttributeValue("", 2428, Url.Action("Conversion_Proccess", "Car_Conversion"), 2428, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                                                                                          Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 62 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                        }
                                        else if (entity.ClassificationID == 21)
                                        {
                                            //Conversion Cost

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2799, "\"", 2854, 1);
#nullable restore
#line 66 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
WriteAttributeValue("", 2806, Url.Action("Conversion_Cost", "Car_Conversion"), 2806, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                                                                                      Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 67 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                        }
                                        else if (entity.ClassificationID == 22)
                                        {
                                            //SafteyFactor

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3170, "\"", 3222, 1);
#nullable restore
#line 71 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
WriteAttributeValue("", 3177, Url.Action("SafteyFactor", "Car_Conversion"), 3177, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                                                                                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 72 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                        }
                                        else if (entity.ClassificationID == 23)
                                        {
                                            //Questions

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 3550, "\"", 3605, 1);
#nullable restore
#line 76 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
WriteAttributeValue("", 3557, Url.Action("CommonQuestions", "Car_Conversion"), 3557, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 76 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                                                                                                     Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 77 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                        }
                                        else if (entity.ClassificationID == 24)
                                        {
                                            //Conversion Centers

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 3927, "\"", 3985, 1);
#nullable restore
#line 81 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
WriteAttributeValue("", 3934, Url.Action("Conversion_Centers", "Car_Conversion"), 3934, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 81 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                                                                                         Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 82 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                        }
                                        else if (entity.ClassificationID == 25)
                                        {
                                            //Local Manuf

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a");
            BeginWriteAttribute("href", " href=\"", 4300, "\"", 4359, 1);
#nullable restore
#line 86 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
WriteAttributeValue("", 4307, Url.Action("local_manufacturing", "Car_Conversion"), 4307, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 86 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                                                                                          Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 87 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                     
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
#line 100 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                             foreach (var entity in Model.Car_ConversionCategory)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h2>");
#nullable restore
#line 102 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                               Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <div style=\"font-size:14px; position:relative\">\r\n\r\n");
#nullable restore
#line 105 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                     foreach (var image in entity.LstImages)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p style=\"text-align: justify;\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d5286cfa5661e23150c73277ce22cbf1bdb1feb019172", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5428, "~/Images/CommonQuestions/", 5428, 25, true);
#nullable restore
#line 108 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
AddHtmlAttributeValue("", 5453, image.ImageGUID, 5453, 16, false);

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
            WriteLiteral("\r\n                                    </p>\r\n");
#nullable restore
#line 110 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                               Write(Html.Raw(entity.Body));

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
                                                          
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 113 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Car_Conversion\CommonQuestions.cshtml"
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
