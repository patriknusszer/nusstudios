#pragma checksum "/Users/patrik.nusszer/nusstudios/Views/Softwares/product_spltoemf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c3593c6eea6ed0629098118a9856bac12a83b3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Softwares_product_spltoemf), @"mvc.1.0.view", @"/Views/Softwares/product_spltoemf.cshtml")]
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
#line 1 "/Users/patrik.nusszer/nusstudios/Views/_ViewImports.cshtml"
using Nusstudios;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c3593c6eea6ed0629098118a9856bac12a83b3c", @"/Views/Softwares/product_spltoemf.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2753723ec3b7f1744cac33670045c6f2e6d4ce3", @"/Views/_ViewImports.cshtml")]
    public class Views_Softwares_product_spltoemf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/patrik.nusszer/nusstudios/Views/Softwares/product_spltoemf.cshtml"
  
    ViewData["Title"] = "SPL to EMF";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("keywords", async() => {
                WriteLiteral("\r\n    <meta name=\"keywords\" content=\"printing, SPL, EMF, MS-EMFSpool\" />\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("topheading", async() => {
                WriteLiteral("\r\n    SPL to EMF\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("subheading", async() => {
                WriteLiteral("\r\n    Splits MS-EMFSpool files into MS-EMF vector images\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("description", async() => {
                WriteLiteral(@"
    When printing a temporary SPL file is generated by Windows
    that contains all the pictures waiting to be processed by the
    printer. This application aims to extract the vector images in 
    their original format. This SPL file is deleted after printing
    unless a specific registry entry is modified. Google it.
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("source", async() => {
                WriteLiteral("\r\n    href=\"https://mega.nz/#!DNQ1HaZQ!q7SApE40tb97cVmIbO6sQLvsIuhEz1gWgHlMvG9hgv4\" target=\"_blank\"\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("release", async() => {
                WriteLiteral("\r\n    href=\"https://mega.nz/#!7UYHwKqQ!ISFQrUJcjj8eE59vkaAfyUQs1dBFDopYlg7HjvdOmqk\" target=\"_blank\"\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("projectspecs", async() => {
                WriteLiteral("\r\n    Windows console application. C#, .NET Framework 4.7.2. Version 4.2.0.0.\r\n");
            }
            );
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
