#pragma checksum "C:\Users\Md Oli\source\repos\WebApplication1\Views\Home\SinglePerson.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "867deda81aaef452b0dc9b5827d7d089a72325de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SinglePerson), @"mvc.1.0.view", @"/Views/Home/SinglePerson.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867deda81aaef452b0dc9b5827d7d089a72325de", @"/Views/Home/SinglePerson.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SinglePerson : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Home\SinglePerson.cshtml"
  
    ViewData["Title"] = "SinglePerson";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Single Person</h1>\r\n<h2>Data pass with Model</h2>\r\n\r\n<h3 class=\"text-info\">");
#nullable restore
#line 9 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Home\SinglePerson.cshtml"
                 Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3 class=\"text-info\">");
#nullable restore
#line 10 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Home\SinglePerson.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3 class=\"text-info\">");
#nullable restore
#line 11 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Home\SinglePerson.cshtml"
                 Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3 class=\"text-info\">");
#nullable restore
#line 12 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Home\SinglePerson.cshtml"
                 Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3 class=\"text-info\">");
#nullable restore
#line 13 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Home\SinglePerson.cshtml"
                 Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
