#pragma checksum "C:\Users\Md Oli\source\repos\WebApplication1\Views\Linq\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9335f0696e7a7cf81dede6ed180b831ab5dce551"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Linq_Index), @"mvc.1.0.view", @"/Views/Linq/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9335f0696e7a7cf81dede6ed180b831ab5dce551", @"/Views/Linq/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Linq_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Linq\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_Linq";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>LINQ Index</h1>
<div class=""row"">
    <div class=""col-md-4"">
        <a href=""/LINQ/Example"">Example</a><br />
        <a href=""/LINQ/ExampleOne"">ExampleOne</a><br />
        <a href=""/LINQ/ExampleTwo"">ExampleTwo</a><br />
        <a href=""/LINQ/ExampleThree"">ExampleThree</a><br />
        <a href=""/LINQ/ExampleFour"">ExampleFour</a>
    </div>
</div>

");
#nullable restore
#line 18 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Linq\Index.cshtml"
 if(ViewBag.number != null)
{
    foreach (var item in ViewBag.number)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"alert alert-info\">");
#nullable restore
#line 22 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Linq\Index.cshtml"
                                Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 23 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Linq\Index.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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