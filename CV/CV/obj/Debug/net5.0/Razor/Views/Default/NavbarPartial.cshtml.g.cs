#pragma checksum "C:\Users\izbur\Desktop\CV\CV\Views\Default\NavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99ebe793abd6cd1f18babec86346f6793e4edb8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_NavbarPartial), @"mvc.1.0.view", @"/Views/Default/NavbarPartial.cshtml")]
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
#line 1 "C:\Users\izbur\Desktop\CV\CV\Views\_ViewImports.cshtml"
using CV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\izbur\Desktop\CV\CV\Views\_ViewImports.cshtml"
using CV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99ebe793abd6cd1f18babec86346f6793e4edb8c", @"/Views/Default/NavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"347884a291c693055c42ebac550b30b84eb01c32", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Default_NavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<nav>\r\n    <div class=\"logo\">\r\n        <img src=\"/moonlight-master/img/Software2.png\"");
            BeginWriteAttribute("alt", " alt=\"", 85, "\"", 91, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"mini-logo\">\r\n        <img src=\"/moonlight-master/img/mini_logo.png\"");
            BeginWriteAttribute("alt", " alt=\"", 190, "\"", 196, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    </div>
    <ul>
        <li><a href=""#1""><i class=""fa fa-home""></i> <em>Anasayfa</em></a></li>
        <li><a href=""#2""><i class=""fa fa-user""></i> <em>Hakkımda</em></a></li>
        <li><a href=""#3""><i class=""fa fa-pencil""></i> <em>Projeler</em></a></li>
        <li><a href=""#4""><i class=""fa fa-image""></i> <em>Sertifikalar</em></a></li>
");
            WriteLiteral("    </ul>\r\n</nav>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
