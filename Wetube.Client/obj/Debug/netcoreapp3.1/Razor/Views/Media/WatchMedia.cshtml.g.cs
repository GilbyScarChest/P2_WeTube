#pragma checksum "C:\Users\tdgso\Documents\revature\revature_projects\project_2\WeTube\Wetube.Client\Views\Media\WatchMedia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ab7cb82236e7cf9612638a4555fca2cee302c73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Media_WatchMedia), @"mvc.1.0.view", @"/Views/Media/WatchMedia.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ab7cb82236e7cf9612638a4555fca2cee302c73", @"/Views/Media/WatchMedia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc2c2f5e5dfb05c03bfa7e0da9dd6dad56de352a", @"/Views/_ViewImports.cshtml")]
    public class Views_Media_WatchMedia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wetube.Client.Models.CommentVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\tdgso\Documents\revature\revature_projects\project_2\WeTube\Wetube.Client\Views\Media\WatchMedia.cshtml"
  
    ViewData["Title"] = "Watch";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<br/>\n<div class=\"w-100\">\n");
#nullable restore
#line 10 "C:\Users\tdgso\Documents\revature\revature_projects\project_2\WeTube\Wetube.Client\Views\Media\WatchMedia.cshtml"
     using(Html.BeginForm("SendComment", "Media"))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tdgso\Documents\revature\revature_projects\project_2\WeTube\Wetube.Client\Views\Media\WatchMedia.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\tdgso\Documents\revature\revature_projects\project_2\WeTube\Wetube.Client\Views\Media\WatchMedia.cshtml"
       Write(Html.EditorFor(model => model.CommentText, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\n                <div class=\"justify-center\">\n                    <input type=\"submit\" value=\"Send\" class=\"btn btn-outline-light\" />\n                </div>\n            </div>\n");
#nullable restore
#line 19 "C:\Users\tdgso\Documents\revature\revature_projects\project_2\WeTube\Wetube.Client\Views\Media\WatchMedia.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wetube.Client.Models.CommentVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
