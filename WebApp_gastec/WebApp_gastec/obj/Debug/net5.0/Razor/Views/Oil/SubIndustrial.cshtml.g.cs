#pragma checksum "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4ab8676a75808e9027141a6ec6b8914e5df3fba"
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
#line 2 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
using WebApp_gastec.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4ab8676a75808e9027141a6ec6b8914e5df3fba", @"/Views/Oil/SubIndustrial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Oil_SubIndustrial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    #nullable disable
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
#line 4 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/4.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 13 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
         foreach (var entity in Model.Sub_Section)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 15 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 16 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 685, "\"", 719, 1);
#nullable restore
#line 25 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
WriteAttributeValue("", 692, Url.Action("Index","Home"), 692, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 26 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                 foreach (var entity in Model.Main_Section)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 28 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 29 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
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
#line 42 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                 foreach (var entity in Model.Sub_Section)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"sidebar-side col-lg-5 col-md-5 col-sm-12 col-xs-12 pull-right text-right\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f4ab8676a75808e9027141a6ec6b8914e5df3fba7327", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1400, "~/Images/Industrial_Oil/", 1400, 24, true);
#nullable restore
#line 45 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
AddHtmlAttributeValue("", 1424, entity.LstImages.Select(x=>x.ImageGUID).FirstOrDefault().ToString(), 1424, 68, false);

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
#line 47 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                     if (entity.LstChildClassification.Count == 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                         foreach (var image in entity.LstImages.Skip(1))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"content-side col-lg-7 col-md-7 col-sm-12 col-xs-12\">\r\n                                <div class=\"services-single\" dir=\"rtl\">\r\n                                    <div class=\"sidebar-title\"><h2>");
#nullable restore
#line 53 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                                              Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n                                    <div class=\"inner-box\">\r\n                                        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f4ab8676a75808e9027141a6ec6b8914e5df3fba10206", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2110, "~/Images/Industrial_Oil/", 2110, 24, true);
#nullable restore
#line 55 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
AddHtmlAttributeValue("", 2134, image.ImageGUID, 2134, 16, false);

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
#line 59 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                         
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                         if (entity.LstChildClassification.Select(x=>x.LstFiles).FirstOrDefault().Count() == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"content-side col-lg-7 col-md-7 col-sm-12 col-xs-12\">\r\n                                <div class=\"services-single\" dir=\"rtl\">\r\n                                    <div class=\"sidebar-title\"><h2>");
#nullable restore
#line 67 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
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
#line 72 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                                     foreach (var child in entity.LstChildClassification)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td style=\"text-align:center; padding-left:20px\">\r\n                                                            <a");
            BeginWriteAttribute("href", " href=\"", 3400, "\"", 3493, 1);
#nullable restore
#line 75 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
WriteAttributeValue("", 3407, Url.Action("SubIndustrial", "Oil", new { oilID_ = child.ClassificationID.ToString()}), 3407, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f4ab8676a75808e9027141a6ec6b8914e5df3fba14487", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3578, "~/Images/Industrial_Oil/", 3578, 24, true);
#nullable restore
#line 76 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
AddHtmlAttributeValue("", 3602, child.LstImages.Select(x=>x.ImageGUID).FirstOrDefault().ToString(), 3602, 67, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 3669, "", 3670, 1, true);
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
            BeginWriteAttribute("href", " href=\"", 3907, "\"", 4000, 1);
#nullable restore
#line 79 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
WriteAttributeValue("", 3914, Url.Action("SubIndustrial", "Oil", new { oilID_ = child.ClassificationID.ToString()}), 3914, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                    ");
#nullable restore
#line 80 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                                               Write(child.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                </a>\r\n                                                            </div>\r\n                                                        </td>\r\n");
#nullable restore
#line 84 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
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
#line 91 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"content-side col-lg-7 col-md-7 col-sm-12 col-xs-12\">\r\n                                <div class=\"services-single\" dir=\"rtl\">\r\n                                    <div class=\"sidebar-title\"><h2>");
#nullable restore
#line 96 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                                              Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></div>\r\n                                    <div class=\"inner-box\">\r\n");
#nullable restore
#line 98 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                         foreach (var child in entity.LstChildClassification)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h3> ");
#nullable restore
#line 100 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                            Write(child.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 101 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                             foreach (var file in child.LstFiles)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 5508, "\"", 5529, 1);
#nullable restore
#line 104 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
WriteAttributeValue("", 5515, file.FileLink, 5515, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">\r\n                                                        ");
#nullable restore
#line 105 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                                   Write(file.FileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </a>\r\n                                                </p>\r\n");
#nullable restore
#line 108 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 113 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "E:\Softex\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\SubIndustrial.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
