#pragma checksum "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22cf19b824d12365da562b22ef23b6661a10b698"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cylindar_Test_Testing_Proccess), @"mvc.1.0.view", @"/Views/Cylindar_Test/Testing_Proccess.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22cf19b824d12365da562b22ef23b6661a10b698", @"/Views/Cylindar_Test/Testing_Proccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cylindar_Test_Testing_Proccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 331px; width: 200px; margin: 10px; float: left;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float: left; height: 311px; width: 200px; margin: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
 foreach (var entity in Model.Cylindar_Test_Categories)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
     foreach (var Websection in entity.LstWebSections)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
   Write(Html.Raw(Websection.Style));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                   
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/cyl_test.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 19 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
         foreach (var entity in Model.Cylindar_Test_Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 21 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 22 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 846, "\"", 880, 1);
#nullable restore
#line 31 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
WriteAttributeValue("", 853, Url.Action("Index","Home"), 853, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 32 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                 foreach (var entity in Model.Cylindar_Test_Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 34 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 35 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
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
#line 52 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                 foreach (var mainSection in Model.Cylindar_Test_Main)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                     foreach (var entity in mainSection.LstChildClassification)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                         if (entity.ClassificationID == 37)
                                        {
                                            // Testing Proccess

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"active\"><a");
            BeginWriteAttribute("href", " href=\"", 2150, "\"", 2205, 1);
#nullable restore
#line 59 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
WriteAttributeValue("", 2157, Url.Action("Testing_Proccess", "Cylindar_Test"), 2157, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                                                                                                     Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 60 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                        }
                                        else if (entity.ClassificationID == 38)
                                        {
                                            //Testing Centers

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a href=\"#\">");
#nullable restore
#line 64 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                                       Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 65 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                        }
                                        else if (entity.ClassificationID == 39)
                                        {
                                            //Videos

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><a href=\"#\">");
#nullable restore
#line 69 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                                       Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 70 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                     
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
#line 83 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                             foreach (var entity in Model.Cylindar_Test_Categories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h2>");
#nullable restore
#line 85 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                               Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <div style=\"font-size:14px; position:relative\">\r\n");
#nullable restore
#line 87 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                     foreach (var webSection in entity.LstWebSections)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                   Write(Html.Raw(webSection.Body));

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                         foreach (var image in webSection.LstImages)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                             if (webSection.WebSectionID == 154)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "22cf19b824d12365da562b22ef23b6661a10b69815058", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4192, "~/Images/Testing_Proccess/", 4192, 26, true);
#nullable restore
#line 94 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
AddHtmlAttributeValue("", 4218, image.ImageGUID, 4218, 16, false);

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
#line 95 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                            }
                                            else if (webSection.WebSectionID == 155)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "22cf19b824d12365da562b22ef23b6661a10b69817083", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4540, "~/Images/Testing_Proccess/", 4540, 26, true);
#nullable restore
#line 98 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
AddHtmlAttributeValue("", 4566, image.ImageGUID, 4566, 16, false);

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
#line 99 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 104 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Testing_Proccess.cshtml"
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
