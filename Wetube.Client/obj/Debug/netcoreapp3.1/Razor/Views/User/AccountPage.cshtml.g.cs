#pragma checksum "C:\Users\tdgso\Documents\revature\revature_projects\project_2\WeTube\Wetube.Client\Views\User\AccountPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69fa58df61f5154fc5a4d12df962de38e2d78fb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_AccountPage), @"mvc.1.0.view", @"/Views/User/AccountPage.cshtml")]
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
#line 1 "C:\Users\tdgso\Documents\revature\revature_projects\project_2\WeTube\Wetube.Client\Views\_ViewImports.cshtml"
using Wetube.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tdgso\Documents\revature\revature_projects\project_2\WeTube\Wetube.Client\Views\_ViewImports.cshtml"
using Wetube.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69fa58df61f5154fc5a4d12df962de38e2d78fb4", @"/Views/User/AccountPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc2c2f5e5dfb05c03bfa7e0da9dd6dad56de352a", @"/Views/_ViewImports.cshtml")]
    public class Views_User_AccountPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tdgso\Documents\revature\revature_projects\project_2\WeTube\Wetube.Client\Views\User\AccountPage.cshtml"
  
    ViewData["Title"] = "Account";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    <div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\">\n        <div class=\"carousel-inner\">\n            <div class=\"carousel-item active\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69fa58df61f5154fc5a4d12df962de38e2d78fb44572", async() => {
                WriteLiteral("<img src=\"http://sartorialgeek.com/wp-content/uploads/2019/03/Good-Place-The-Netflix-1-810x456.jpg\" class=\"d-block w-100\" alt=\"The Good Place\">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n            <div class=\"carousel-item\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69fa58df61f5154fc5a4d12df962de38e2d78fb46236", async() => {
                WriteLiteral("<img src=\"https://upload.wikimedia.org/wikipedia/en/e/e0/Gotham_Logo.jpg\" class=\"d-block w-100\" alt=\"Gotham\">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n            <div class=\"carousel-item\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69fa58df61f5154fc5a4d12df962de38e2d78fb47866", async() => {
                WriteLiteral("<img src=\"https://calendarmedia.blob.core.windows.net/assets/e5c06077-827c-4ebb-8bda-1323a4aec8e4.jpg\" class=\"d-block w-100\" alt=\"Animaniacs: Live\">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>

    <main class=""row"" style=""height: 30vw"">
        <section class=""col-md-12 h-100 overflow-auto"">
            <div class=""row mb-2"">
                <div class=""col-sm-4"">
                    <img class=""w-100"" src=""http://www.ece.iastate.edu/~alexs/classes/2018_Spring_575/HW/HW2/output/Part_1/placeholder.jpg"" alt=""..."" />
                </div>
                <div class=""col-sm-8 p-4"">
                    <h4>Title</h4>
                    <p>This is the description of the c");
            WriteLiteral(@"ontent of this media.</p>
                </div>
            </div>
            <div class=""row mb-2"">
                <div class=""col-sm-4"">
                    <img class=""w-100"" src=""http://www.ece.iastate.edu/~alexs/classes/2018_Spring_575/HW/HW2/output/Part_1/placeholder.jpg"" alt=""..."" />
                </div>
                <div class=""col-sm-8 p-4"">
                    <h4>Title</h4>
                    <p>This is the description of the content of this media.</p>
                </div>
            </div>
            <div class=""row mb-2"">
                <div class=""col-sm-4"">
                    <img class=""w-100"" src=""http://www.ece.iastate.edu/~alexs/classes/2018_Spring_575/HW/HW2/output/Part_1/placeholder.jpg"" alt=""..."" />
                </div>
                <div class=""col-sm-8 p-4"">
                    <h4>Title</h4>
                    <p>This is the description of the content of this media.</p>
                </div>
            </div>
            <div class=""row mb-2"">
                <di");
            WriteLiteral(@"v class=""col-sm-4"">
                    <img class=""w-100"" src=""http://www.ece.iastate.edu/~alexs/classes/2018_Spring_575/HW/HW2/output/Part_1/placeholder.jpg"" alt=""..."" />
                </div>
                <div class=""col-sm-8 p-4"">
                    <h4>Title</h4>
                    <p>This is the description of the content of this media.</p>
                </div>
            </div>
            <div class=""row mb-2"">
                <div class=""col-sm-4"">
                    <img class=""w-100"" src=""http://www.ece.iastate.edu/~alexs/classes/2018_Spring_575/HW/HW2/output/Part_1/placeholder.jpg"" alt=""..."" />
                </div>
                <div class=""col-sm-8 p-4"">
                    <h4>Title</h4>
                    <p>This is the description of the content of this media.</p>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-sm-4"">
                    <img class=""w-100"" src=""http://www.ece.iastate.edu/~alexs/classes/2018_Spring_575/HW/HW");
            WriteLiteral(@"2/output/Part_1/placeholder.jpg"" alt=""..."" />
                </div>
                <div class=""col-sm-8 p-4"">
                    <h4>Title</h4>
                    <p>This is the description of the content of this media.</p>
                </div>
            </div>
        </section>
        
    </main>

    <div class=""row"">

    </div>

    <div class=""row"">

    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591