#pragma checksum "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f34e149f4eb74d3a25cfd56dfaa7f538be8c1400"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_VisionMision), @"mvc.1.0.view", @"/Views/About/VisionMision.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f34e149f4eb74d3a25cfd56dfaa7f538be8c1400", @"/Views/About/VisionMision.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_About_VisionMision : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 136px; width: 900px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/4.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 11 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
         foreach (var entity in Model.AboutUsSection)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!--<h1>");
#nullable restore
#line 13 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
               Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>-->\r\n");
#nullable restore
#line 14 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!--End Page Title-->\r\n<!--Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 651, "\"", 686, 1);
#nullable restore
#line 23 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
WriteAttributeValue("", 658, Url.Action("Index", "Home"), 658, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 24 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                 foreach (var entity in Model.AboutUsSection)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 26 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 27 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
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
            <!--Sidebar Side-->
            <div class=""sidebar-side col-lg-3 col-md-4 col-sm-12 col-xs-12 pull-right"">
                <aside class=""sidebar"">

                    <div id=""sidenavelist""></div>
                    <div class=""sidebar-widget sidebar-blog-category"">
                        <ul class=""blog-cat"">
");
#nullable restore
#line 45 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                             foreach (var mainSection in Model.AboutUs)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                 foreach (var entity in mainSection.LstChildClassification)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                     if (entity.ClassificationID == 124)
                                    {
                                        //Activities

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1863, "\"", 1904, 1);
#nullable restore
#line 52 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
WriteAttributeValue("", 1870, Url.Action("Activities", "About"), 1870, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 52 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                                                                    Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 53 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                    }
                                    else if (entity.ClassificationID == 9)
                                    {
                                        // Legal Entity

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li> <a");
            BeginWriteAttribute("href", " href=\"", 2201, "\"", 2243, 1);
#nullable restore
#line 57 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
WriteAttributeValue("", 2208, Url.Action("LegalEntity", "About"), 2208, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 57 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                                                                      Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 58 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                    }
                                    else if (entity.ClassificationID == 121)
                                    {
                                        //Vision and Mision

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"active\"> <a");
            BeginWriteAttribute("href", " href=\"", 2561, "\"", 2604, 1);
#nullable restore
#line 62 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
WriteAttributeValue("", 2568, Url.Action("VisionMision", "About"), 2568, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 62 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                                                                                      Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 63 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                    }
                                    else if (entity.ClassificationID == 120)
                                    {
                                        // Members

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li> <a");
            BeginWriteAttribute("href", " href=\"", 2898, "\"", 2936, 1);
#nullable restore
#line 67 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
WriteAttributeValue("", 2905, Url.Action("Members", "About"), 2905, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 67 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                                                                  Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 68 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                    }
                                    else if (entity.ClassificationID == 123)
                                    {
                                        //Human Resources

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li> <a");
            BeginWriteAttribute("href", " href=\"", 3237, "\"", 3270, 1);
#nullable restore
#line 72 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
WriteAttributeValue("", 3244, Url.Action("HR", "About"), 3244, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 72 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                                                             Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 73 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                    }
                                    else if (entity.ClassificationID == 122)
                                    {
                                        //Contributors

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li> <a");
            BeginWriteAttribute("href", " href=\"", 3568, "\"", 3611, 1);
#nullable restore
#line 77 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
WriteAttributeValue("", 3575, Url.Action("Contributors", "About"), 3575, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 77 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                                                                       Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 78 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                </aside>
            </div>
            <!--Content Side-->
            <div class=""content-side pull-left col-lg-9 col-md-8 col-sm-12 col-xs-12"">

                <div class=""services-single"" dir=""rtl"">
                    <div class=""inner-box"">
                        <div id=""cmspage1""></div>
                        <!--//end backend to retrieve variables  -->
");
#nullable restore
#line 92 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                         foreach (var entity in Model.AboutUsSection)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <!--//Start backend to retrieve variables  -->\r\n                            <h2>");
#nullable restore
#line 95 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                           Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 96 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"team-column col-md-12 col-sm-12 col-xs-12\" style=\"margin-top: 30px\">\r\n                            <div class=\"inner-column\">\r\n                                <div class=\"row clearfix\">\r\n");
#nullable restore
#line 100 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                     foreach (var entity in Model.AboutUsSection)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                         if (entity.LstImages.Count > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div id=\"teambox\"></div>\r\n");
#nullable restore
#line 105 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                             foreach (var image in entity.LstImages)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <!--//end backend to retrieve variables  -->
                                                <div style=""font-size:14px; position:relative"">
                                                    <h3 style=""text-align: justify;"">
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f34e149f4eb74d3a25cfd56dfaa7f538be8c140017779", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5480, "~/Images/VisionAndMision/", 5480, 25, true);
#nullable restore
#line 110 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
AddHtmlAttributeValue("", 5505, image.ImageGUID, 5505, 16, false);

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
                                                    </h3>
                                                    <h3 style=""text-align: justify;"">&nbsp;</h3>
                                                </div>
                                                <p dir=""rtl"" style=""text-align: justify;"">
                                                    ");
#nullable restore
#line 115 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                               Write(Html.Raw(entity.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </p>");
#nullable restore
#line 116 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                                     
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "D:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\VisionMision.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
