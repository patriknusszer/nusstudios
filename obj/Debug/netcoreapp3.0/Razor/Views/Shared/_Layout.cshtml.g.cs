#pragma checksum "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dbcd9623bc1db644a803baab40e85e597df86d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dbcd9623bc1db644a803baab40e85e597df86d6", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2753723ec3b7f1744cac33670045c6f2e6d4ce3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Softwares", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NussAPI", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reference", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dbcd9623bc1db644a803baab40e85e597df86d65495", async() => {
                WriteLiteral("\r\n        <meta name=\"format-detection\" content=\"telephone=no\">\r\n        <meta charset=\"utf-8\" />\r\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n        ");
#nullable restore
#line 6 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
   Write(RenderSection("meta", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <title>");
#nullable restore
#line 7 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
          Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Nusstudios</title>\r\n        ");
#nullable restore
#line 8 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
   Write(RenderSection("styles", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 9 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
   Write(RenderSection("scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <script>(function (i, s, o, g, r, a, m) {
                i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                    (i[r].q = i[r].q || []).push(arguments)
                }, i[r].l = 1 * new Date(); a = s.createElement(o),
                    m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
            })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

            ga('create', 'UA-70457939-1', 'auto');
            ga('send', 'pageview');</script>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dbcd9623bc1db644a803baab40e85e597df86d68156", async() => {
                WriteLiteral("\r\n        <div id=\"background\"></div>\r\n        <div id=\"navbar\" align=\"center\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dbcd9623bc1db644a803baab40e85e597df86d68513", async() => {
                    WriteLiteral(@"
                <div id=""navbar_logo"">
                    <svg width=""100%"" height=""100%"" viewBox=""0 0 118 116"" version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" xml:space=""preserve"" style=""fill-rule:evenodd;clip-rule:evenodd;stroke-linejoin:round;stroke-miterlimit:1.41421;"">
                    <g transform=""matrix(1,0,0,1,-627.592,-249.486)"">
                    <g transform=""matrix(1,0,0,1,-600.157,-1353.94)"">
                    <g transform=""matrix(1,0,0,1,600.157,1353.94)"">
                    <path id=""nuss"" d=""M640.953,358.732C639.776,359.017 638.356,359.434 636.819,360.043C633.457,361.376 629.439,363.663 628.073,364.46L627.711,364.823L627.691,364.831C627.691,364.831 627.738,364.752 627.824,364.607C627.673,364.695 627.592,364.744 627.592,364.744L627.6,364.725L627.975,364.349C628.772,362.984 631.059,358.966 632.392,355.603C633.114,353.779 633.568,352.119 633.849,350.836C624.28,334.108 632.585,305.465 654.46,282.048C654.617,278.833 655.711,275.901 658.11");
                    WriteLiteral(@"4,273.499C672.435,259.178 698.086,261.576 715.362,278.852C732.637,296.127 735.035,321.779 720.715,336.099C718.073,338.741 714.886,339.895 711.444,340.019C687.05,362.529 657.156,370.372 640.953,358.732ZM719.388,275.041C719.388,275.041 737.307,263.1 743.705,256.701C745.355,255.052 745.355,252.373 743.705,250.723C742.055,249.073 739.377,249.073 737.727,250.723C731.328,257.122 719.388,275.041 719.388,275.041Z"" fill=""#FFFFFF"" />

                                </g>
                            </g>
                        </g>
                    </svg>
                </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gb", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
                                                           WriteLiteral(Model.GB ? "true" : "false");

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gb"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gb", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gb"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dbcd9623bc1db644a803baab40e85e597df86d612657", async() => {
                    WriteLiteral("\r\n                <div");
                    BeginWriteAttribute("title", " title=\"", 2932, "\"", 2979, 1);
#nullable restore
#line 38 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 2940, Model.GB ? "Softwares" : "Projektek", 2940, 39, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    BeginWriteAttribute("class", " class=\"", 2980, "\"", 3041, 2);
#nullable restore
#line 38 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 2988, Model.SoftwaresSelected ? "selected" : "", 2988, 44, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue(" ", 3032, "menuitem", 3033, 9, true);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                    ");
#nullable restore
#line 39 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
                Write(Model.GB ? "Softwares" : "Projektek");

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                </div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gb", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
                                                               WriteLiteral(Model.GB ? "true" : "false");

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gb"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gb", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gb"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dbcd9623bc1db644a803baab40e85e597df86d616257", async() => {
                    WriteLiteral("\r\n                <div title=\"Blog\"");
                    BeginWriteAttribute("class", " class=\"", 3284, "\"", 3348, 2);
#nullable restore
#line 43 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 3292, Model.BlogSelected ? "selected" : "menuitem", 3292, 47, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue(" ", 3339, "menuitem", 3340, 9, true);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                    Blog\r\n                </div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gb", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
                                                          WriteLiteral(Model.GB ? "true" : "false");

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gb"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gb", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gb"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dbcd9623bc1db644a803baab40e85e597df86d619292", async() => {
                    WriteLiteral("\r\n                <div title=\"NussAPI\"");
                    BeginWriteAttribute("class", " class=\"", 3562, "\"", 3629, 2);
#nullable restore
#line 48 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 3570, Model.NussAPISelected ? "selected" : "menuitem", 3570, 50, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue(" ", 3620, "menuitem", 3621, 9, true);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                    NussAPI\r\n                </div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gb", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
                                                             WriteLiteral(Model.GB ? "true" : "false");

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gb"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gb", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gb"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dbcd9623bc1db644a803baab40e85e597df86d622339", async() => {
                    WriteLiteral("\r\n                <div");
                    BeginWriteAttribute("title", " title=\"", 3826, "\"", 3875, 1);
#nullable restore
#line 53 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 3834, Model.GB ? "Tutoring" : "Magántanítás", 3834, 41, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    BeginWriteAttribute("class", " class=\"", 3876, "\"", 3939, 2);
#nullable restore
#line 53 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 3884, Model.EduSelected ? "selected" : "menuitem", 3884, 46, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue(" ", 3930, "menuitem", 3931, 9, true);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                    ");
#nullable restore
#line 54 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
                Write(Model.GB ? "Tutoring" : "Magántanítás");

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                </div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gb", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
                                                         WriteLiteral(Model.GB ? "true" : "false");

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gb"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gb", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gb"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dbcd9623bc1db644a803baab40e85e597df86d625939", async() => {
                    WriteLiteral("\r\n                <div");
                    BeginWriteAttribute("title", " title=\"", 4176, "\"", 4226, 1);
#nullable restore
#line 58 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 4184, Model.GB ? "Reference" : "Referenciáim", 4184, 42, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    BeginWriteAttribute("class", " class=\"", 4227, "\"", 4296, 2);
#nullable restore
#line 58 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 4235, Model.ReferenceSelected ? "selected" : "menuitem", 4235, 52, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue(" ", 4287, "menuitem", 4288, 9, true);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                    ");
#nullable restore
#line 59 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
                Write(Model.GB ? "Reference" : "Referenciáim");

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                </div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gb", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
                                                               WriteLiteral(Model.GB ? "true" : "false");

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gb"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gb", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gb"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dbcd9623bc1db644a803baab40e85e597df86d629553", async() => {
                    WriteLiteral("\r\n                <div");
                    BeginWriteAttribute("title", " title=\"", 4532, "\"", 4577, 1);
#nullable restore
#line 63 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 4540, Model.GB ? "Contact" : "Kapcsolat", 4540, 37, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    BeginWriteAttribute("class", " class=\"", 4578, "\"", 4645, 2);
#nullable restore
#line 63 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 4586, Model.ContactSelected ? "selected" : "menuitem", 4586, 50, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue(" ", 4636, "menuitem", 4637, 9, true);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                    ");
#nullable restore
#line 64 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
                Write(Model.GB ? "Contact" : "Kapcsolat");

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                </div>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gb", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
                                                             WriteLiteral(Model.GB ? "true" : "false");

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gb"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gb", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gb"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div id=\"flags\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 4798, "\"", 4831, 1);
#nullable restore
#line 68 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 4805, Model.BaseURL + "/true", 4805, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""flag"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 60 30"" width=""100%"" height=""100%"">
                            <clipPath id=""s"">
                                <path d=""M0,0 v30 h60 v-30 z"" />
                            </clipPath>
                            <clipPath id=""t"">
                                <path d=""M30,15 h30 v15 z v15 h-30 z h-30 v-15 z v-15 h30 z"" />
                            </clipPath>
                            <g clip-path=""url(#s)"">
                                <path d=""M0,0 v30 h60 v-30 z"" fill=""#012169"" />
                                <path d=""M0,0 L60,30 M60,0 L0,30"" stroke=""#fff"" stroke-width=""6"" />
                                <path d=""M0,0 L60,30 M60,0 L0,30"" clip-path=""url(#t)"" stroke=""#C8102E"" stroke-width=""4"" />
                                <path d=""M30,0 v30 M0,15 h60"" stroke=""#fff"" stroke-width=""10"" />
                                <path d=""M30,0 v30 M0,15 h60"" stroke=""#C");
                WriteLiteral("8102E\" stroke-width=\"6\" />\r\n                            </g>\r\n                        </svg>\r\n                    </div>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 6018, "\"", 6052, 1);
#nullable restore
#line 87 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
WriteAttributeValue("", 6025, Model.BaseURL + "/false", 6025, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""flag"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""100%"" height=""100%"" viewBox=""0 0 6 3"">
                            <rect fill=""#436F4D"" width=""6"" height=""3"" />
                            <rect fill=""#FFF"" width=""6"" height=""2"" />
                            <rect fill=""#CD2A3E"" width=""6"" height=""1"" />
                        </svg>
                    </div>
                </a>
            </div>
        </div>
        <div id=""panel"">
            ");
#nullable restore
#line 99 "/Users/patrik.nusszer/nusstudios/Views/Shared/_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
