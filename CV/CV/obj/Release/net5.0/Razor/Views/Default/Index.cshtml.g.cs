#pragma checksum "C:\Users\izbur\Desktop\CV\CV\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f40d501dc00942bb040cfd4e0df66289e9e3830"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f40d501dc00942bb040cfd4e0df66289e9e3830", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"347884a291c693055c42ebac550b30b84eb01c32", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\izbur\Desktop\CV\CV\Views\Default\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
#nullable restore
#line 8 "C:\Users\izbur\Desktop\CV\CV\Views\Default\Index.cshtml"
Write(await Html.PartialAsync("HeaderPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f40d501dc00942bb040cfd4e0df66289e9e38303453", async() => {
                WriteLiteral(@"

    <div class=""sequence"">

        <div class=""seq-preloader"">
            <svg width=""39"" height=""16"" viewBox=""0 0 39 16"" xmlns=""http://www.w3.org/2000/svg"" class=""seq-preload-indicator""><g fill=""#F96D38""><path class=""seq-preload-circle seq-preload-circle-1"" d=""M3.999 12.012c2.209 0 3.999-1.791 3.999-3.999s-1.79-3.999-3.999-3.999-3.999 1.791-3.999 3.999 1.79 3.999 3.999 3.999z"" /><path class=""seq-preload-circle seq-preload-circle-2"" d=""M15.996 13.468c3.018 0 5.465-2.447 5.465-5.466 0-3.018-2.447-5.465-5.465-5.465-3.019 0-5.466 2.447-5.466 5.465 0 3.019 2.447 5.466 5.466 5.466z"" /><path class=""seq-preload-circle seq-preload-circle-3"" d=""M31.322 15.334c4.049 0 7.332-3.282 7.332-7.332 0-4.049-3.282-7.332-7.332-7.332s-7.332 3.283-7.332 7.332c0 4.05 3.283 7.332 7.332 7.332z"" /></g></svg>
        </div>

    </div>

    ");
#nullable restore
#line 19 "C:\Users\izbur\Desktop\CV\CV\Views\Default\Index.cshtml"
Write(await Html.PartialAsync("NavbarPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n    <div class=\"slides\">\r\n\r\n        ");
#nullable restore
#line 25 "C:\Users\izbur\Desktop\CV\CV\Views\Default\Index.cshtml"
   Write(await Component.InvokeAsync("FeatureList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n        ");
#nullable restore
#line 28 "C:\Users\izbur\Desktop\CV\CV\Views\Default\Index.cshtml"
   Write(await Component.InvokeAsync("AboutList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n        ");
#nullable restore
#line 32 "C:\Users\izbur\Desktop\CV\CV\Views\Default\Index.cshtml"
   Write(await Component.InvokeAsync("ProjecktList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n\r\n        ");
#nullable restore
#line 36 "C:\Users\izbur\Desktop\CV\CV\Views\Default\Index.cshtml"
   Write(await Component.InvokeAsync("CertificateList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    </div>\r\n\r\n    <div class=\"footer\">\r\n        <div class=\"content\">\r\n            <p>Copyright &copy; ");
#nullable restore
#line 43 "C:\Users\izbur\Desktop\CV\CV\Views\Default\Index.cshtml"
                           Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" Burak Büyükdağdaş. <a href=""https://wa.me/905345811690"">Whatsapp</a> | <a href=""https://github.com/BurakBuyukdagdas"">GitHub</a> | <a href=""https://www.linkedin.com/in/burakbuyukdagdas"" target=""_parent"">Linkedln</a></p>
        </div>
    </div>


    <script src=""//ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js""></script>
    <script>window.jQuery || document.write('<script src=""/moonlight-master/js/vendor/jquery-1.11.2.min.js""><\/script>')</script>

    <script src=""/moonlight-master/js/vendor/bootstrap.min.js""></script>

    <script src=""/moonlight-master/js/datepicker.js""></script>
    <script src=""/moonlight-master/js/plugins.js""></script>
    <script src=""/moonlight-master/js/main.js""></script>

    <script src=""http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"" type=""text/javascript""></script>
    <script type=""text/javascript"">
        $(document).ready(function () {



            // navigation click actions
            $('.scroll-link').on('click', func");
                WriteLiteral(@"tion (event) {
                event.preventDefault();
                var sectionID = $(this).attr(""data-id"");
                scrollToID('#' + sectionID, 750);
            });
            // scroll to top action
            $('.scroll-top').on('click', function (event) {
                event.preventDefault();
                $('html, body').animate({ scrollTop: 0 }, 'slow');
            });
            // mobile nav toggle
            $('#nav-toggle').on('click', function (event) {
                event.preventDefault();
                $('#main-nav').toggleClass(""open"");
            });
        });
        // scroll function
        function scrollToID(id, speed) {
            var offSet = 0;
            var targetOffset = $(id).offset().top - offSet;
            var mainNav = $('#main-nav');
            $('html,body').animate({ scrollTop: targetOffset }, speed);
            if (mainNav.hasClass(""open"")) {
                mainNav.css(""height"", ""1px"").removeClass(""in"").addClass(""coll");
                WriteLiteral("apse\");\r\n                mainNav.removeClass(\"open\");\r\n            }\r\n        }\r\n        if (typeof console === \"undefined\") {\r\n            console = {\r\n                log: function () { }\r\n            };\r\n        }\r\n    </script>\r\n");
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
