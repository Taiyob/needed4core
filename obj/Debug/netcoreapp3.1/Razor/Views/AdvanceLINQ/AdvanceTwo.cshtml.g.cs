#pragma checksum "C:\Users\Md Oli\source\repos\WebApplication1\Views\AdvanceLINQ\AdvanceTwo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e470f5f6db31bd3a599245c1f45e66c935724059"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdvanceLINQ_AdvanceTwo), @"mvc.1.0.view", @"/Views/AdvanceLINQ/AdvanceTwo.cshtml")]
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
#line 1 "C:\Users\Md Oli\source\repos\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Md Oli\source\repos\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e470f5f6db31bd3a599245c1f45e66c935724059", @"/Views/AdvanceLINQ/AdvanceTwo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_AdvanceLINQ_AdvanceTwo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Md Oli\source\repos\WebApplication1\Views\AdvanceLINQ\AdvanceTwo.cshtml"
  
    ViewData["Title"] = "AdvanceTwo";
    Layout = "_LinqAdvance";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Advance Two</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Md Oli\source\repos\WebApplication1\Views\AdvanceLINQ\AdvanceTwo.cshtml"
 if (ViewBag.data != null)
{
    foreach (var item in ViewBag.data)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"alert alert-info\"> ");
#nullable restore
#line 13 "C:\Users\Md Oli\source\repos\WebApplication1\Views\AdvanceLINQ\AdvanceTwo.cshtml"
                                 Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 14 "C:\Users\Md Oli\source\repos\WebApplication1\Views\AdvanceLINQ\AdvanceTwo.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
