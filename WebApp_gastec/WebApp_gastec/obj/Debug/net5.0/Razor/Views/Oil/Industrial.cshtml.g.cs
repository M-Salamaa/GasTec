#pragma checksum "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bce7f24ceaa55735a7c727c2c5fb132304d6fdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Oil_Industrial), @"mvc.1.0.view", @"/Views/Oil/Industrial.cshtml")]
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
#line 2 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
using WebApp_gastec.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bce7f24ceaa55735a7c727c2c5fb132304d6fdb", @"/Views/Oil/Industrial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Oil_Industrial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/eni-header.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 14 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
         foreach (var entity in Model.Oil_Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 16 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 17 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 699, "\"", 733, 1);
#nullable restore
#line 26 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
WriteAttributeValue("", 706, Url.Action("Index","Home"), 706, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 27 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                 foreach (var entity in Model.Oil_Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 29 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 30 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
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
#line 46 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                                 foreach (var mainSection in Model.Oil_Main)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                                     foreach (var entity in mainSection.LstChildClassification)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                                         if (entity.IsActive == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"active\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 1960, "\"", 2057, 1);
#nullable restore
#line 53 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
WriteAttributeValue("", 1967, Url.Action(GetActionName.GetActionNameforOilsSectionByID(entity.ClassificationID), "Oil"), 1967, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 53 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                                                                                                                                                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 55 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2374, "\"", 2471, 1);
#nullable restore
#line 59 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
WriteAttributeValue("", 2381, Url.Action(GetActionName.GetActionNameforOilsSectionByID(entity.ClassificationID), "Oil"), 2381, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                                                                                                                                                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 61 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                                     
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
                        <div id=""cmspage1""></div>
                    </div>
                </div>

");
#nullable restore
#line 77 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                 foreach (var oilCategory in Model.Oil_Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""team-column col-md-12 col-sm-12 col-xs-12"" style=""margin-top: 30px"">
                        <div class=""inner-column"">
                            <div class=""row clearfix"">
                                <div id=""teambox"">
");
#nullable restore
#line 83 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                                     foreach (var entity in oilCategory.LstChildClassification)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""team-block col-md-3 col-sm-6 col-xs-12 pull-left"">
                                            <div class=""inner-box"">
                                                <div class=""image"">
                                                    <a");
            BeginWriteAttribute("href", " href=\"", 3923, "\"", 4017, 1);
#nullable restore
#line 88 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
WriteAttributeValue("", 3930, Url.Action("SubIndustrial", "Oil", new { oilID_ = entity.ClassificationID.ToString()}), 3930, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7bce7f24ceaa55735a7c727c2c5fb132304d6fdb12811", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4087, "~/Images/Industrial_Oil/", 4087, 24, true);
#nullable restore
#line 89 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
AddHtmlAttributeValue("", 4111, entity.LstImages.Select(x=>x.ImageGUID).FirstOrDefault().ToString(), 4111, 68, false);

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
            WriteLiteral(@"
                                                    </a>
                                                </div>
                                                <div class=""lower-box"">
                                                    <h3>
                                                        <a");
            BeginWriteAttribute("href", " href=\"", 4495, "\"", 4589, 1);
#nullable restore
#line 94 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
WriteAttributeValue("", 4502, Url.Action("SubIndustrial", "Oil", new { oilID_ = entity.ClassificationID.ToString()}), 4502, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            ");
#nullable restore
#line 95 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                                                       Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                        </a>
                                                    </h3>
                                                </div>
                                            </div>
                                        </div>
");
#nullable restore
#line 101 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 106 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Industrial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
