#pragma checksum "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a1c344e303fed6e650821b2fc2cc3eb2b44abaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Oil_SubIndustrial), @"mvc.1.0.view", @"/Views/Oil/SubIndustrial.cshtml")]
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
#line 2 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
using WebApp_gastec.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a1c344e303fed6e650821b2fc2cc3eb2b44abaf", @"/Views/Oil/SubIndustrial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Oil_SubIndustrial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:262px; width:175px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/4.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 13 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
         foreach (var entity in Model.Oil_Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 15 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 16 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 688, "\"", 722, 1);
#nullable restore
#line 25 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
WriteAttributeValue("", 695, Url.Action("Index","Home"), 695, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 26 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                 foreach (var entity in Model.Oil_Main)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 28 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 29 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </ul>
        </div>
    </div>
</div>
<!--End Page Info-->
<!--Sidebar Page Container-->

<div class=""sidebar-page-container"">
    <div class=""auto-container"">
        <div class=""row clearfix"">
            <!--Content Side-->
            <div id=""imgfull"">
");
#nullable restore
#line 42 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                 foreach (var entity in Model.Oil_Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"sidebar-side col-lg-5 col-md-5 col-sm-12 col-xs-12 pull-right text-right\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6a1c344e303fed6e650821b2fc2cc3eb2b44abaf7283", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1402, "~/Images/Industrial_Oil/", 1402, 24, true);
#nullable restore
#line 45 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
AddHtmlAttributeValue("", 1426, entity.LstImages.Select(x=>x.ImageGUID).FirstOrDefault().ToString(), 1426, 68, false);

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
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 47 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                     if (entity.LstChildClassification.Count == 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                         foreach (var image in entity.LstImages.Skip(1))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"content-side col-lg-7 col-md-7 col-sm-12 col-xs-12\">\r\n                                <div class=\"services-single\" dir=\"rtl\">\r\n                                    <div class=\"sidebar-title\"><h2>");
#nullable restore
#line 53 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                                              Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n                                    <div class=\"inner-box\">\r\n                                        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6a1c344e303fed6e650821b2fc2cc3eb2b44abaf10162", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2112, "~/Images/Industrial_Oil/", 2112, 24, true);
#nullable restore
#line 55 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
AddHtmlAttributeValue("", 2136, image.ImageGUID, 2136, 16, false);

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
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 59 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                         
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                         if (entity.LstChildClassification.Select(x=>x.LstFiles).FirstOrDefault().Count() == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"content-side col-lg-7 col-md-7 col-sm-12 col-xs-12\">\r\n                                <div class=\"services-single\" dir=\"rtl\">\r\n                                    <div class=\"sidebar-title\"><h2>");
#nullable restore
#line 67 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                                              Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2></div>
                                    <div class=""inner-box"">
                                        <table border=""1"" cellpadding=""1"" cellspacing=""1"" style=""width:100%"">
                                            <tbody>
                                                <tr>
");
#nullable restore
#line 72 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                                     foreach (var child in entity.LstChildClassification)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td style=\"text-align:center; padding-left:20px\">\r\n                                                            <a");
            BeginWriteAttribute("href", " href=\"", 3402, "\"", 3495, 1);
#nullable restore
#line 75 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
WriteAttributeValue("", 3409, Url.Action("SubIndustrial", "Oil", new { oilID_ = child.ClassificationID.ToString()}), 3409, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6a1c344e303fed6e650821b2fc2cc3eb2b44abaf14443", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3580, "~/Images/Industrial_Oil/", 3580, 24, true);
#nullable restore
#line 76 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
AddHtmlAttributeValue("", 3604, child.LstImages.Select(x=>x.ImageGUID).FirstOrDefault().ToString(), 3604, 67, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 3671, "", 3672, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                            </a>\r\n                                                            <div>\r\n                                                                <a");
            BeginWriteAttribute("href", " href=\"", 3909, "\"", 4002, 1);
#nullable restore
#line 79 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
WriteAttributeValue("", 3916, Url.Action("SubIndustrial", "Oil", new { oilID_ = child.ClassificationID.ToString()}), 3916, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                    ");
#nullable restore
#line 80 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                                               Write(child.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                </a>\r\n                                                            </div>\r\n                                                        </td>\r\n");
#nullable restore
#line 84 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 91 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"content-side col-lg-7 col-md-7 col-sm-12 col-xs-12\">\r\n                                <div class=\"services-single\" dir=\"rtl\">\r\n                                    <div class=\"sidebar-title\"><h2>");
#nullable restore
#line 96 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                                              Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n                                    <div class=\"inner-box\">\r\n");
#nullable restore
#line 98 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                         foreach (var child in entity.LstChildClassification)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h3> ");
#nullable restore
#line 100 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                            Write(child.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 101 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                             foreach (var file in child.LstFiles)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 5510, "\"", 5531, 1);
#nullable restore
#line 104 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
WriteAttributeValue("", 5517, file.FileLink, 5517, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                                                        ");
#nullable restore
#line 105 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                                   Write(file.FileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </a>\r\n                                                </p>\r\n");
#nullable restore
#line 108 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 113 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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