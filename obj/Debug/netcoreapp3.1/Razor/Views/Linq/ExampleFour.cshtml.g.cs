#pragma checksum "C:\Users\Md Oli\source\repos\WebApplication1\Views\Linq\ExampleFour.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9acd5576a34bcdcd257806132f9044b2d92d162"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Linq_ExampleFour), @"mvc.1.0.view", @"/Views/Linq/ExampleFour.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9acd5576a34bcdcd257806132f9044b2d92d162", @"/Views/Linq/ExampleFour.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Linq_ExampleFour : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Linq\ExampleFour.cshtml"
  
    ViewData["Title"] = "ExampleFour";
    Layout = "_Linq";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Example Four</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Linq\ExampleFour.cshtml"
 if (ViewBag.data != null)
{
    foreach (var item in ViewBag.data)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3 class=\"alert alert-info\">");
#nullable restore
#line 13 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Linq\ExampleFour.cshtml"
                                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Linq\ExampleFour.cshtml"
                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Linq\ExampleFour.cshtml"
                                                    Write(item.Depertment);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Linq\ExampleFour.cshtml"
                                                                     Write(item.AcademicSession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 14 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Linq\ExampleFour.cshtml"
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
