#pragma checksum "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcd64d8fed725895ae93b318e28d1cb52b2e67e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cylindar_Test_Index), @"mvc.1.0.view", @"/Views/Cylindar_Test/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcd64d8fed725895ae93b318e28d1cb52b2e67e4", @"/Views/Cylindar_Test/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cylindar_Test_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 331px; width: 200px; margin: 10px; float: left;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float: left; height: 311px; width: 200px; margin: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 500px; height: 262px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 25px; margin-right: 25px; width: 400px; height: 266px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/cyl_test.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 13 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
         foreach (var entity in Model.Sub_Section)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 15 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 16 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 665, "\"", 699, 1);
#nullable restore
#line 25 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
WriteAttributeValue("", 672, Url.Action("Index","Home"), 672, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 26 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                 foreach (var entity in Model.Sub_Section)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 28 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 29 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
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
#line 45 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                 foreach (var mainSection in Model.Main_Section)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                     foreach (var entity in mainSection.LstChildClassification)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                         if (entity.IsActive == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"active\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 1927, "\"", 2019, 1);
#nullable restore
#line 52 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
WriteAttributeValue("", 1934, Url.Action("Index", "Cylindar_Test",new { ID_ = entity.ClassificationID.ToString()}), 1934, 85, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 52 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                                                                                                           Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 54 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                        }
                                        else
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2338, "\"", 2430, 1);
#nullable restore
#line 59 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
WriteAttributeValue("", 2345, Url.Action("Index", "Cylindar_Test",new { ID_ = entity.ClassificationID.ToString()}), 2345, 85, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 59 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                                                                                                           Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 61 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                         

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                     
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
#line 75 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                             foreach (var entity in Model.Sub_Section)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h2>");
#nullable restore
#line 77 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                               Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <div style=\"font-size:14px; position:relative\">\r\n");
#nullable restore
#line 79 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                     foreach (var webSection in entity.LstWebSections)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                   Write(Html.Raw(webSection.Body));

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                         if (entity.ClassificationID == 39)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a");
            BeginWriteAttribute("href", " href=\"", 3657, "\"", 3685, 1);
#nullable restore
#line 84 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
WriteAttributeValue("", 3664, webSection.ActionURL, 3664, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 84 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                                       Write(webSection.ActionURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            <hr />\r\n");
#nullable restore
#line 86 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                             foreach (var image in webSection.LstImages)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                 if (webSection.WebSectionID == 154)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bcd64d8fed725895ae93b318e28d1cb52b2e67e415644", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4234, "~/Images/Cylinder_Testing/", 4234, 26, true);
#nullable restore
#line 93 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
AddHtmlAttributeValue("", 4260, image.ImageGUID, 4260, 16, false);

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
#line 94 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 155)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bcd64d8fed725895ae93b318e28d1cb52b2e67e417663", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4598, "~/Images/Cylinder_Testing/", 4598, 26, true);
#nullable restore
#line 97 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
AddHtmlAttributeValue("", 4624, image.ImageGUID, 4624, 16, false);

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
#line 98 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 158)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bcd64d8fed725895ae93b318e28d1cb52b2e67e419682", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4962, "~/Images/Cylinder_Testing/", 4962, 26, true);
#nullable restore
#line 101 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
AddHtmlAttributeValue("", 4988, image.ImageGUID, 4988, 16, false);

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
#line 102 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 159)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bcd64d8fed725895ae93b318e28d1cb52b2e67e421620", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5262, "~/Images/Cylinder_Testing/", 5262, 26, true);
#nullable restore
#line 105 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
AddHtmlAttributeValue("", 5288, image.ImageGUID, 5288, 16, false);

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
#line 106 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 160)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bcd64d8fed725895ae93b318e28d1cb52b2e67e423641", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5599, "~/Images/Cylinder_Testing/", 5599, 26, true);
#nullable restore
#line 109 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
AddHtmlAttributeValue("", 5625, image.ImageGUID, 5625, 16, false);

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
#line 110 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 115 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
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
