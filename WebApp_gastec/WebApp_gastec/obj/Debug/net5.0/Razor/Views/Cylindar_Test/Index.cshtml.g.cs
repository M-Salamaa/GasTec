#pragma checksum "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1e3bb7c67bc5d34240114661af5b54d21c288dd"
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
#nullable restore
#line 3 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
using WebApp_gastec.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1e3bb7c67bc5d34240114661af5b54d21c288dd", @"/Views/Cylindar_Test/Index.cshtml")]
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
#line 5 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
 foreach (var entity in Model.Sub_Section)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
     foreach (var Websection in entity.LstWebSections)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
   Write(Html.Raw(Websection.Style));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                   
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/cyl_test.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 21 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
         foreach (var entity in Model.Sub_Section)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- <h1>");
#nullable restore
#line 23 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h1>-->\r\n");
#nullable restore
#line 24 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!-- End Page Title-->\r\n<!-- Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 851, "\"", 885, 1);
#nullable restore
#line 33 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
WriteAttributeValue("", 858, Url.Action("Index","Home"), 858, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 34 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                 foreach (var entity in Model.Sub_Section)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 36 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 37 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
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
#line 53 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                 foreach (var mainSection in Model.Main_Section)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                     foreach (var entity in mainSection.LstChildClassification)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                         if (entity.IsActive == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"active\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2113, "\"", 2205, 1);
#nullable restore
#line 60 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
WriteAttributeValue("", 2120, Url.Action("Index", "Cylindar_Test",new { ID_ = entity.ClassificationID.ToString()}), 2120, 85, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 60 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                                                                                                           Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 62 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                        }
                                        else
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2524, "\"", 2616, 1);
#nullable restore
#line 67 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
WriteAttributeValue("", 2531, Url.Action("Index", "Cylindar_Test",new { ID_ = entity.ClassificationID.ToString()}), 2531, 85, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 67 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                                                                                                           Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 69 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                         

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                     
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
#line 83 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                             foreach (var entity in Model.Sub_Section)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h2>");
#nullable restore
#line 85 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                               Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <div style=\"font-size:14px; position:relative\">\r\n");
#nullable restore
#line 87 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                     foreach (var webSection in entity.LstWebSections)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                   Write(Html.Raw(webSection.Body));

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                         if (entity.ClassificationID == 39)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a");
            BeginWriteAttribute("href", " href=\"", 3843, "\"", 3871, 1);
#nullable restore
#line 92 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
WriteAttributeValue("", 3850, webSection.ActionURL, 3850, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 92 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                                       Write(webSection.ActionURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            <hr />\r\n");
#nullable restore
#line 94 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                             foreach (var image in webSection.LstImages)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                 if (webSection.WebSectionID == 154)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c1e3bb7c67bc5d34240114661af5b54d21c288dd16876", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4420, "~/Images/Cylinder_Testing/", 4420, 26, true);
#nullable restore
#line 101 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
AddHtmlAttributeValue("", 4446, image.ImageGUID, 4446, 16, false);

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
#line 102 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 155)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c1e3bb7c67bc5d34240114661af5b54d21c288dd18897", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4784, "~/Images/Cylinder_Testing/", 4784, 26, true);
#nullable restore
#line 105 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
AddHtmlAttributeValue("", 4810, image.ImageGUID, 4810, 16, false);

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
#line 106 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 158)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c1e3bb7c67bc5d34240114661af5b54d21c288dd20918", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5148, "~/Images/Cylinder_Testing/", 5148, 26, true);
#nullable restore
#line 109 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
AddHtmlAttributeValue("", 5174, image.ImageGUID, 5174, 16, false);

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
#line 110 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 159)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c1e3bb7c67bc5d34240114661af5b54d21c288dd22856", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5448, "~/Images/Cylinder_Testing/", 5448, 26, true);
#nullable restore
#line 113 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
AddHtmlAttributeValue("", 5474, image.ImageGUID, 5474, 16, false);

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
#line 114 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                }
                                                else if (webSection.WebSectionID == 160)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c1e3bb7c67bc5d34240114661af5b54d21c288dd24877", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5785, "~/Images/Cylinder_Testing/", 5785, 26, true);
#nullable restore
#line 117 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
AddHtmlAttributeValue("", 5811, image.ImageGUID, 5811, 16, false);

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
#line 118 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 123 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\Cylindar_Test\Index.cshtml"
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
