#pragma checksum "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Home\Indexx.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "378fdaf908543e26fa75eb214984f9632a895c97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Indexx), @"mvc.1.0.view", @"/Views/Home/Indexx.cshtml")]
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
#line 1 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\_ViewImports.cshtml"
using GHC2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\_ViewImports.cshtml"
using GHC2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\_ViewImports.cshtml"
using GHC2.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\_ViewImports.cshtml"
using GHC2.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\_ViewImports.cshtml"
using GHC2.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"378fdaf908543e26fa75eb214984f9632a895c97", @"/Views/Home/Indexx.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50e937b79e78d914c754e3a1d797613611528950", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Indexx : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Chat>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Home\Indexx.cshtml"
  
   Layout = "~/Views/Shared/_ChatLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"chat-body\">\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Home\Indexx.cshtml"
     if (Model != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Home\Indexx.cshtml"
           
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 18 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Home\Indexx.cshtml"
  
    ViewData["Title"] = "Home Page";

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Chat>> Html { get; private set; }
    }
}
#pragma warning restore 1591