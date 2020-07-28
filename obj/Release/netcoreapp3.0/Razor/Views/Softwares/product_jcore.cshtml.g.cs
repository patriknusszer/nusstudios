#pragma checksum "/Users/patrik.nusszer/Desktop/Nusstudios/Views/Softwares/product_jcore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "826b7b38fc8b0a64a839204eba935ff2daa28e37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Softwares_product_jcore), @"mvc.1.0.view", @"/Views/Softwares/product_jcore.cshtml")]
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
#line 1 "/Users/patrik.nusszer/Desktop/Nusstudios/Views/_ViewImports.cshtml"
using Nusstudios;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"826b7b38fc8b0a64a839204eba935ff2daa28e37", @"/Views/Softwares/product_jcore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2753723ec3b7f1744cac33670045c6f2e6d4ce3", @"/Views/_ViewImports.cshtml")]
    public class Views_Softwares_product_jcore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/patrik.nusszer/Desktop/Nusstudios/Views/Softwares/product_jcore.cshtml"
  
    ViewData["Title"] = "JCore Library";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("keywords", async() => {
                WriteLiteral("\r\n    <meta name=\"keywords\" content=\"Java class library\" />\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("topheading", async() => {
                WriteLiteral("\r\n    JCore library\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("subheading", async() => {
                WriteLiteral("\r\n    A library of Java utilities\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("description", async() => {
                WriteLiteral(@"
    This library contains the most common functions I use while programming Java.
    It contains a downloader class. It can send GET requests in one single static function
    in which you can specify the most important aspects of the connection. It has a complex
    callback system communicating with JSON objects.<br>
    It contains an IO library. It contsains read/write functions to make certain tasks easy.
    There is for example a function that will walk through a directory system while
    reporting every node (files and directories).<br>
    It contains StringMath, a very basic math library for string variables.<br>
    It has a base converter that converts a fraction from a base into another (up to base 16).<br>
    There is a byte array to integer/double and integer/double to byte array converter class that you can
    configure with endianness. It can read variable encoded unsigned integers as well.<br>
    And finally there is a bit handling utility which you can use to quickly acces");
                WriteLiteral(@"s certain bits
    in a byte. A function will return a sequence of bits from a byte array given a byte position,
    bit position (little endian-like), requested number of bits, and whether you are reading towards
    the most or the least singificant bit. There is a write function with similar parameters to insert a sequence
    of bits into a byte array.
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("source", async() => {
                WriteLiteral("\r\n    href=\"https://mega.nz/#!mNgXUCAR!3iVlW3K2ClPfQE1UPnZTeWXmfAHWmEZ-5dyoTrg14us\" target=\"_blank\"\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("release", async() => {
                WriteLiteral("\r\n    href=\"https://mega.nz/#!vdxTHAZS!l8cyXvZuK17-DreitIg7rS6q41YNfAYIHfwYBizQqqk\" target=\"_blank\"\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("projectspecs", async() => {
                WriteLiteral("\r\n    Java library compiled with JDK 10.0.2. Version 1.1.\r\n");
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
