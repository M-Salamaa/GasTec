#pragma checksum "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7552bdfc68cf481ed606ce929e2b389ab66fde05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Oil_Commercial), @"mvc.1.0.view", @"/Views/Oil/Commercial.cshtml")]
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
#line 2 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
using WebApp_gastec.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7552bdfc68cf481ed606ce929e2b389ab66fde05", @"/Views/Oil/Commercial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Oil_Commercial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
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
#line 4 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
 foreach (var entity in Model.Oil_Categories)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
     foreach (var Websection in entity.LstWebSections)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
   Write(Html.Raw(Websection.Style));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                   
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/eni-header.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 21 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
         foreach (var entity in Model.Oil_Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 23 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 24 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 859, "\"", 893, 1);
#nullable restore
#line 33 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
WriteAttributeValue("", 866, Url.Action("Index","Home"), 866, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 34 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                 foreach (var entity in Model.Oil_Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 36 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 37 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
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
#line 53 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                 foreach (var mainSection in Model.Oil_Main)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                     foreach (var entity in mainSection.LstChildClassification)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1983, "\"", 2080, 1);
#nullable restore
#line 58 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
WriteAttributeValue("", 1990, Url.Action(GetActionName.GetActionNameforOilsSectionByID(entity.ClassificationID), "Oil"), 1990, 90, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 58 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                                                                                                                            Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </li>\r\n");
#nullable restore
#line 60 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                     
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
            <div class=""services-single"" dir=""rtl"">

                <div class=""inner-box"">

                    <div id=""cmspage1""></div>

                </div>
            </div>
");
#nullable restore
#line 76 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
              
                var Counter = 0;
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""content-side pull-left col-lg-9 col-md-8 col-sm-12 col-xs-12"">
                <div class=""services-single"" dir=""rtl"">

                    <div class=""inner-box"">

                        <div id=""cmspage1""></div>

                    </div>
                </div>
                <div class=""team-column col-md-12 col-sm-12 col-xs-12"" style=""margin-top: 30px"">
                    <div class=""inner-column"">
                        <div class=""row clearfix"">
                            <div id=""teambox"">
");
#nullable restore
#line 92 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                 foreach (var entity in Model.Oil_Categories)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                     foreach (var webSection in entity.LstWebSections)
                                    {
                                        Counter = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"team-block col-md-3 col-sm-6 col-xs-12 pull-right\">\r\n                                            <div class=\"inner-box\">\r\n");
#nullable restore
#line 99 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                                 foreach (var image in webSection.LstImages)
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                                     if (Counter == 1)
                                                        break;
                                                    else
                                                    {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                                         for (int i = 0; i < 1; i++)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"image\">\r\n                                                                <a");
            BeginWriteAttribute("href", " href=\"", 4365, "\"", 4388, 1);
#nullable restore
#line 108 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
WriteAttributeValue("", 4372, image.ImageLink, 4372, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7552bdfc68cf481ed606ce929e2b389ab66fde0513267", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4470, "~/Images/Commerical_Oil/", 4470, 24, true);
#nullable restore
#line 109 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
AddHtmlAttributeValue("", 4494, image.ImageGUID, 4494, 16, false);

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
            WriteLiteral(@"
                                                                </a>
                                                            </div>
                                                            <div class=""lower-box"">
                                                                <h3>
                                                                    <a href=""#"">
                                                                        ");
#nullable restore
#line 115 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                                                   Write(Html.Raw(webSection.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                    </a>\r\n                                                                </h3>\r\n                                                            </div>\r\n");
#nullable restore
#line 119 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                                         
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                                     
                                                    Counter++;
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n                                        </div>\r\n");
#nullable restore
#line 125 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Oil\Commercial.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
