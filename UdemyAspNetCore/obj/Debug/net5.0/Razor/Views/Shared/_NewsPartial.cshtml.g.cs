#pragma checksum "C:\Users\yskah\source\repos\UdemyAspNetCore\UdemyAspNetCore\Views\Shared\_NewsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fbae8087d2cb226dff680602fa62ce6f6aab614"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NewsPartial), @"mvc.1.0.view", @"/Views/Shared/_NewsPartial.cshtml")]
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
#line 3 "C:\Users\yskah\source\repos\UdemyAspNetCore\UdemyAspNetCore\Views\_ViewImports.cshtml"
using UdemyAspNetCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\yskah\source\repos\UdemyAspNetCore\UdemyAspNetCore\Views\_ViewImports.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fbae8087d2cb226dff680602fa62ce6f6aab614", @"/Views/Shared/_NewsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c01fec558b5eb2bbba6cd20f6a56ba95edc056c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__NewsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"list-group\">\r\n\r\n");
#nullable restore
#line 5 "C:\Users\yskah\source\repos\UdemyAspNetCore\UdemyAspNetCore\Views\Shared\_NewsPartial.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item \" aria-current=\"true\">");
#nullable restore
#line 7 "C:\Users\yskah\source\repos\UdemyAspNetCore\UdemyAspNetCore\Views\Shared\_NewsPartial.cshtml"
                                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 8 "C:\Users\yskah\source\repos\UdemyAspNetCore\UdemyAspNetCore\Views\Shared\_NewsPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   \r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
