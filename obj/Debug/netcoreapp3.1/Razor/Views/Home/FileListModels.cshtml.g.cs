#pragma checksum "C:\Users\Md Oli\source\repos\WebApplication1\Views\Home\FileListModels.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d2e3cf4e9f21632cfd199ace948f98d26745a3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FileListModels), @"mvc.1.0.view", @"/Views/Home/FileListModels.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d2e3cf4e9f21632cfd199ace948f98d26745a3f", @"/Views/Home/FileListModels.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FileListModels : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.FileDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Home\FileListModels.cshtml"
  
    ViewData["Title"] = "FileListModels";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>File List Models</h1>
<h2>Data pass with Model</h2>

<div class=""row"">
    <div class=""col-md-12"">
        <table border=""1"">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Extension</th>
                    <th>Path</th>
");
            WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Home\FileListModels.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Home\FileListModels.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Home\FileListModels.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Home\FileListModels.cshtml"
                       Write(item.Extension);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                        <td>");
#nullable restore
#line 30 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Home\FileListModels.cshtml"
                       Write(item.Path);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Md Oli\source\repos\WebApplication1\Views\Home\FileListModels.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.FileDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
