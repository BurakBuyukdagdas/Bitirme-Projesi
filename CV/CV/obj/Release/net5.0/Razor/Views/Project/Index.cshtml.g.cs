#pragma checksum "C:\Users\izbur\Desktop\CV\CV\Views\Project\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c95c3674860eab4d044bd0e622f3f769589107b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Index), @"mvc.1.0.view", @"/Views/Project/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\izbur\Desktop\CV\CV\Views\Project\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c95c3674860eab4d044bd0e622f3f769589107b1", @"/Views/Project/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"347884a291c693055c42ebac550b30b84eb01c32", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Project_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Project>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\izbur\Desktop\CV\CV\Views\Project\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col"">
        <div class=""card bg-default shadow"">
            <div class=""card-header bg-transparent border-0"">
            </div>
            <div class=""table-responsive"">
                <table class=""table align-items-center table-dark table-flush"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"">Başlık</th>
                            <th scope=""col"">Açıklama</th>
                            <th scope=""col"">Resim</th>
                            <th scope=""col"">Sil</th>
                            <th scope=""col"">Düzenle</th>
                        </tr>
                    </thead>
                    <tbody class=""list"">
");
#nullable restore
#line 27 "C:\Users\izbur\Desktop\CV\CV\Views\Project\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <tr>
                                <th scope=""row"">
                                    <div class=""media align-items-center"">
                                        <div class=""media-body"">
                                            <span class=""name mb-0 text-sm"">");
#nullable restore
#line 33 "C:\Users\izbur\Desktop\CV\CV\Views\Project\Index.cshtml"
                                                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </th>\r\n                                <td class=\"budget\">\r\n");
#nullable restore
#line 38 "C:\Users\izbur\Desktop\CV\CV\Views\Project\Index.cshtml"
                                      
                                        string description = item.Description;
                                        if (description != null)
                                        {
                                            description = description.Length <= 20 ? description : description.Substring(0, 20);
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
#nullable restore
#line 45 "C:\Users\izbur\Desktop\CV\CV\Views\Project\Index.cshtml"
                               Write(description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ...
                                </td>
                                <td>
                                    <div class=""avatar-group"">
                                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Ryan Tompson"">
                                            <img alt=""Image placeholder""");
            BeginWriteAttribute("src", " src=\"", 2360, "\"", 2377, 1);
#nullable restore
#line 50 "C:\Users\izbur\Desktop\CV\CV\Views\Project\Index.cshtml"
WriteAttributeValue("", 2366, item.Image, 2366, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </a>\r\n                                    </div>\r\n                                </td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 2548, "\"", 2593, 2);
            WriteAttributeValue("", 2555, "/Project/DeleteProject/", 2555, 23, true);
#nullable restore
#line 54 "C:\Users\izbur\Desktop\CV\CV\Views\Project\Index.cshtml"
WriteAttributeValue("", 2578, item.ProjectID, 2578, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 2678, "\"", 2721, 2);
            WriteAttributeValue("", 2685, "/Project/EditProject/", 2685, 21, true);
#nullable restore
#line 55 "C:\Users\izbur\Desktop\CV\CV\Views\Project\Index.cshtml"
WriteAttributeValue("", 2706, item.ProjectID, 2706, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\">Düzenle</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\izbur\Desktop\CV\CV\Views\Project\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<br />\r\n<a href=\"/Project/AddProject/\" class=\"btn btn-primary\">Proje Ekle</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Project>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
