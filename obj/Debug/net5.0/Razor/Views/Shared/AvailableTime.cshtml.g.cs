#pragma checksum "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09d803300d555fa0d30b4d073cdca4c170945a63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AvailableTime), @"mvc.1.0.view", @"/Views/Shared/AvailableTime.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09d803300d555fa0d30b4d073cdca4c170945a63", @"/Views/Shared/AvailableTime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50e937b79e78d914c754e3a1d797613611528950", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AvailableTime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"schedule-cont\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n");
            WriteLiteral("            <div class=\"time-slot\">\r\n                <ul class=\"clearfix\">\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"
                    <li>
                        <a class=""timing"" href=""#"" id=""A9"" onclick=""setTime('09:00:00')"">
                            <span>9:00</span> <span>AM</span>
                        </a>
                        <a class=""timing"" href=""#"" id=""A1045"" onclick=""setTime('10:45:00')"">
                            <span>10:45</span> <span>AM</span>
                        </a>
                        <a class=""timing"" href=""#"" id=""A1230"" onclick=""setTime('12:30:00')"">
                            <span>12:30</span> <span>PM</span>
                        </a>
                    </li>
                    <li>
                        <a class=""timing"" href=""#"" id=""A915""onclick=""setTime('09:15:00')"">
                            <span>9:15</span> <span>AM</span>
                        </a>
                        <a class=""timing"" href=""#"" id=""A11""onclick=""setTime('11:00:00')"">
                            <span>11:00</span> <span>AM</span>
                        </a>
             ");
            WriteLiteral(@"           <a class=""timing"" href=""#"" id=""A1245""onclick=""setTime('12:45:00')"">
                            <span>12:45</span> <span>PM</span>
                        </a>
                    </li>
                    <li>
                        <a class=""timing"" href=""#"" id=""A930""onclick=""setTime('09:30:00')"">
                            <span>9:30</span> <span>AM</span>
                        </a>
                        <a class=""timing"" href=""#"" id=""A1115"" onclick=""setTime('11:15:00')"">
                            <span>11:15</span> <span>AM</span>
                        </a>
                        <a class=""timing"" href=""#"" id=""A1""onclick=""setTime('13:00:00')"">
                            <span>1:00</span> <span>PM</span>
                        </a>
                    </li>
                    <li>
                        <a class=""timing"" href=""#"" id=""A945""onclick=""setTime('09:45:00')"">
                            <span>9:45</span> <span>AM</span>
                        </a>
   ");
            WriteLiteral(@"                     <a class=""timing"" href=""#"" id=""A1130""onclick=""setTime('11:30:00')"">
                            <span>11:30</span> <span>AM</span>
                        </a>
                        <a class=""timing"" href=""#"" id=""A115""onclick=""setTime('13:15:00')"">
                            <span>1:15</span> <span>PM</span>
                        </a>
                    </li>
                    <li>

                        <a class=""timing"" id=""A10""onclick=""setTime('10:00:00')"">
                            <span>10:00</span> <span>AM</span>
                        </a>
                        <a class=""timing"" href=""#"" id=""11451""onclick=""setTime('11:45:00')"">
                            <span>11:45</span> <span>AM</span>
                        </a>
                        <a class=""timing"" href=""#"" id=""A1330""onclick=""setTime('13:30:00')"">
                            <span>1:30</span> <span>PM</span>
                        </a>
                    </li>
                    <li>");
            WriteLiteral(@"
                        <a class=""timing"" href=""#"" id=""A1015""onclick=""setTime('10:15:00')"">
                            <span>10:15</span> <span>AM</span>
                        </a>
                        <a class=""timing"" href=""#"" id=""A12""onclick=""setTime('12:00:00')"">
                            <span>12:00</span> <span>PM</span>
                        </a>
                        <a class=""timing"" href=""#"" id=""A145""onclick=""setTime('13:45:00')"">
                            <span>1:45</span> <span>PM</span>
                        </a>
                    </li>
                    <li>
                        <a class=""timing"" href=""#"" id=""A10301""onclick=""setTime('10:30:00')"">
                            <span>10:30</span> <span>AM</span>
                        </a>
                        <a class=""timing"" href=""#"" id=""A1215""onclick=""setTime('12:15:00')"">
                            <span>12:15</span> <span>PM</span>
                        </a>
                        <a class=""tim");
            WriteLiteral("ing\" href=\"#\" id=\"A2\"onclick=\"setTime(\'14:00:00\')\">\r\n                            <span>2:00</span> <span>PM</span>\r\n                        </a>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 102 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
 foreach (var item in Model)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "09:00:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A9\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 110 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "10:45:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A1045\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 118 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "12:30:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A1230\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 126 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 130 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "09:15:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A915\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 135 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "11:00:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A11\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 143 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "12:45:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A1245\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 151 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "09:30:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A930\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 160 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "11:15:00" )
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A1115\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 168 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 171 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "13:00:00" )
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A1\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 176 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 178 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "09:45:00" )
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A945\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 183 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 186 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "11:30:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A1130\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 191 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 194 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "13:15:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A115\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 199 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 202 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "10:00:00")
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A10\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 208 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 211 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "11:45:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'11451\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 216 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 219 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "13:30:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A1330\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 224 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 228 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "10:15:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A1015\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 233 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 237 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "12:00:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A12\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 242 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 245 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "13:45:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A145\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 250 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 254 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "10:30:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A10301\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 259 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 263 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "12:15:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A1215\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 268 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 270 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     if (item.TimeOfDay.ToString() == "14:00:00")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <script>\r\n            document.getElementById(\'A2\').classList.add(\'selected\');\r\n        </script>\r\n");
#nullable restore
#line 275 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 276 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Shared\AvailableTime.cshtml"
     


}

#line default
#line hidden
#nullable disable
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
