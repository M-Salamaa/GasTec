#pragma checksum "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5822f3993d04c9dab8f0950f329ce9f39b02412"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Contributors), @"mvc.1.0.view", @"/Views/About/Contributors.cshtml")]
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
#line 2 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
using WebApp_gastec.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5822f3993d04c9dab8f0950f329ce9f39b02412", @"/Views/About/Contributors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c714fee471500ac0555f931cba968b228d83c63c", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Contributors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 832px; width: 900px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
  
    ViewData["Title"] = "GASTEC";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!--Page Title-->\r\n<section class=\"page-title\" style=\"background-image:url(\'../../wwwroot/public/assets/softextwo/images/background/4.jpg\');\">\r\n    <div class=\"auto-container\">\r\n");
#nullable restore
#line 12 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
         foreach (var entity in Model.AboutUsSection)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!--<h1>");
#nullable restore
#line 14 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
               Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>-->\r\n");
#nullable restore
#line 15 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n<!--End Page Title-->\r\n<!--Page Info-->\r\n<div class=\"page-info\">\r\n    <div class=\"auto-container\">\r\n        <div class=\"inner-container clearfix\">\r\n            <ul class=\"bread-crumb pull-right\">\r\n                <li><a");
            BeginWriteAttribute("href", " href=\"", 680, "\"", 715, 1);
#nullable restore
#line 24 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
WriteAttributeValue("", 687, Url.Action("Index", "Home"), 687, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">الرئيسية</a></li>\r\n");
#nullable restore
#line 25 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
                 foreach (var entity in Model.AboutUsSection)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
#nullable restore
#line 27 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
                   Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 28 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
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
#line 44 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
                             foreach (var mainSection in Model.AboutUs)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
                                 foreach (var entity in mainSection.LstChildClassification)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1717, "\"", 1820, 1);
#nullable restore
#line 48 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
WriteAttributeValue("", 1724, Url.Action(GetActionName.GetActionNameByClassificationTreeID(entity.ClassificationID), "About"), 1724, 96, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 48 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
                                                                                                                                              Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 49 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"

                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
                                 
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
                        <div id=""cmspage1"">
                            <!--//end backend to retrieve variables  -->
                            <!--//Start backend to retrieve variables  -->
");
#nullable restore
#line 63 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
                             foreach (var entity in Model.AboutUsSection)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h2>");
#nullable restore
#line 65 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
                               Write(entity.ClassificationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <link");
            BeginWriteAttribute("href", " href=\"", 2662, "\"", 2669, 0);
            EndWriteAttribute();
            WriteLiteral(" rel=\"stylesheet\" type=\"text/css\">\r\n                                <div style=\"font-size:14px; position:relative\">\r\n");
#nullable restore
#line 68 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
                                     foreach (var image in entity.LstImages)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f5822f3993d04c9dab8f0950f329ce9f39b0241210554", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3003, "~/Images/Contributors/", 3003, 22, true);
#nullable restore
#line 71 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
AddHtmlAttributeValue("", 3025, image.ImageGUID, 3025, 16, false);

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
            WriteLiteral("\r\n                                        </p>\r\n");
#nullable restore
#line 73 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n");
#nullable restore
#line 75 "E:\GitHub\GasTec\WebApp_gastec\WebApp_gastec\Views\About\Contributors.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
