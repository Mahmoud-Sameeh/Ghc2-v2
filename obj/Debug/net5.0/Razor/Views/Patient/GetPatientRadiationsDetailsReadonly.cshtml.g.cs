#pragma checksum "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75a04aa436abd7c06eb2d62c906f4c7d05f08efc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_GetPatientRadiationsDetailsReadonly), @"mvc.1.0.view", @"/Views/Patient/GetPatientRadiationsDetailsReadonly.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75a04aa436abd7c06eb2d62c906f4c7d05f08efc", @"/Views/Patient/GetPatientRadiationsDetailsReadonly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50e937b79e78d914c754e3a1d797613611528950", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_GetPatientRadiationsDetailsReadonly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Radiation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml"
  
    ViewData["Title"] = "GetPatientProfileReadonly";
    Layout = "~/Views/Shared/_Patient.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mt-2"">


    <div class=""col-md-12"">
    </div>
</div>
<div class=""container bcontent"">
    <h5 style="" color:gray"">&nbsp;&nbsp;  Add Diagnose </h5>
    <div class=""card"" style=""width: 100%;margin:auto ;border-top:2px solid green"">
        <div class=""row no-gutters"">
            <div class=""col-md-2"">
                <img class=""card-img  rounded-circle CardPhotoPatients"" style=""margin-left:30%""");
            BeginWriteAttribute("src", " src=\"", 555, "\"", 597, 1);
#nullable restore
#line 18 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml"
WriteAttributeValue("", 561, Url.Content(Model.Patient.ImageUrl), 561, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Suresh Dasari Card"">
            </div>
            <div class="" col-md-9 ml-4"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group mb-2"">
                                <label for=""name"">Name:</label>&nbsp;&nbsp;
                                <input type=""text"" class=""form-control"" placeholder=""Patient Name""");
            BeginWriteAttribute("value", " value=\"", 1050, "\"", 1077, 1);
#nullable restore
#line 26 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml"
WriteAttributeValue("", 1058, Model.Patient.Name, 1058, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Name"" readonly>
                            </div>
                            <div class=""form-group mb-2"">
                                <label for=""age"">Birthdate:</label>&nbsp;&nbsp;
                                <input type=""text"" class=""form-control"" placeholder=""Birthdate""");
            BeginWriteAttribute("value", " value=\"", 1379, "\"", 1416, 1);
#nullable restore
#line 30 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml"
WriteAttributeValue("", 1387, Model.Patient.BitrhDate.Date, 1387, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Age"" readonly>
                            </div>
                            <div class=""form-group mb-2"">
                                <label for=""Address"">Address:</label>&nbsp;&nbsp;
                                <input type=""text"" class=""form-control"" placeholder=""Address""");
            BeginWriteAttribute("value", " value=\"", 1717, "\"", 1747, 1);
#nullable restore
#line 34 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml"
WriteAttributeValue("", 1725, Model.Patient.Address, 1725, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Address"" readonly>
                            </div>
                            <div class=""form-group mb-2"">

                                <div class=""form-check"">
                                    <label for=""Gender"" class=""mr-5"">Gender:</label>
");
#nullable restore
#line 40 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml"
                                       if (Model.Patient.Gender.ToLower() == "male")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<input class=""form-check-input"" type=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault1"" checked readonly>
                                            <label class=""form-check-label"" for=""flexRadioDefault1"">
                                                Male
                                            </label>
");
#nullable restore
#line 45 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml"
                                        }
                                        else
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <input class=""form-check-input ml-2"" type=""radio"" name=""flexRadioDefault"" id=""flexRadioDefault1"" checked readonly>
                                            <label class=""form-check-label ml-4"" for=""flexRadioDefault1"">
                                                Female
                                            </label>
");
#nullable restore
#line 53 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>


                            </div>
                        </div>
                        <div class="" col-md-6"">
                            <div class=""form-group mb-2"">
                                <label for=""Phone"">Phone:</label>&nbsp;&nbsp;
                                <input type=""text"" class=""form-control"" placeholder=""Phone""");
            BeginWriteAttribute("value", " value=\"", 3455, "\"", 3483, 1);
#nullable restore
#line 64 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml"
WriteAttributeValue("", 3463, Model.Patient.Phone, 3463, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Phone"" readonly>
                            </div>
                            <div class=""form-group mb-2"">
                                <label for=""Bloodgroup"">BloodGroup:</label>&nbsp;&nbsp;
                                <input type=""text"" class=""form-control"" placeholder=""BloodGroup"" aria-label=""BloodGroup"" readonly>
                            </div>
                            <div class=""form-group mb-2"">
                                <label for=""email"">Email:</label>&nbsp;&nbsp;
                                <input type=""text"" class=""form-control"" placeholder=""Email""");
            BeginWriteAttribute("value", " value=\"", 4096, "\"", 4124, 1);
#nullable restore
#line 72 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml"
WriteAttributeValue("", 4104, Model.Patient.Email, 4104, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Email"" readonly>
                            </div>


                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<br />
<div class=""container bcontent"">
    <h5 style="" color:gray"">&nbsp;&nbsp;   Radiation Type</h5>
    <div class=""card"" style=""width: 100%;margin:auto;border-top:2px solid green"">
        <div class=""row mb-3 mt-2"">
            <div class=""form-group"" style=""width:95%;margin:auto"">

                <textarea class=""form-control"" placeholder=""Write Analyses Report"" id=""floatingTextarea2"" style=""height: 50px"">");
#nullable restore
#line 91 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml"
                                                                                                                          Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>

            </div>
        </div>
    </div>
</div>
<div class=""container bcontent"">
    <h5 style="" color:gray"">&nbsp;&nbsp;   Radiation Report </h5>
    <div class=""card"" style=""width: 100%;margin:auto;border-top:2px solid green"">
        <div class=""row mb-3 mt-2"">
            <div class=""form-group"" style=""width:95%;margin:auto"">

                <textarea class=""form-control"" placeholder=""Write Analyses Report"" id=""floatingTextarea2"" style=""height: 100px"">");
#nullable restore
#line 103 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml"
                                                                                                                           Write(Model.Report);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>

            </div>
        </div>
    </div>
</div>
<br />
<div class=""container bcontent"">
    <h5 style="" color:gray"">&nbsp;&nbsp;   Note </h5>
    <div class=""card"" style=""width: 100%;margin:auto;border-top:2px solid green"">
        <div class=""row mb-3 mt-2"">



            <div class=""form-group"" style=""width:95%;margin:auto"">

                <textarea class=""form-control"" placeholder=""Write Notes"" id=""floatingTextarea2"" style=""height: 100px"">");
#nullable restore
#line 119 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml"
                                                                                                                 Write(Model.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</textarea>

            </div>
        </div>
    </div>
</div>
<br />

<div class=""container bcontent"">
    <h5 style="" color:gray"" "">&nbsp;&nbsp;   Attached File </h5>
    <div class=""card"" style=""width: 100%;margin:auto;border-top:2px solid green"">
        <div class=""row no-gutters"">
            <div class=""row"" style=""width:100%;margin-top:20px"">
                <div class=""col-md-4 offset-1"" style=""margin-top:7px"">
                    <div class=""form-group mb-2 "">
                        <label for=""date"">Date:</label>&nbsp;&nbsp;
                        <input asp-for=""");
#nullable restore
#line 135 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml"
                                   Write(Model.DateAndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" type=\"text\" class=\"btn small\" id=\"button\" data-date-format=\"yyyy-mm-dd\" data-date=\"2012-02-20\" value=\"");
#nullable restore
#line 135 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml"
                                                                                                                                                             Write(Model.DateAndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" />

                    </div>
                </div>
                <div class=""offset-1 col-md-4 mr-2 mb-3 "" style=""margin-top:7px;"">
                    <label class=""form-label"" for=""customFile""> Attached file</label>
                    <a class=""btn btn-outline-primary"" id=""customFile"" href=""");
#nullable restore
#line 141 "C:\Users\Lenovo\Downloads\GHC2-main29-4 V1 (1)\GHC2-main\GHC2\Views\Patient\GetPatientRadiationsDetailsReadonly.cshtml"
                                                                        Write(Url.Content(Model.AttachUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" target=\"_blank\">Read File</a>\r\n\r\n\r\n                </div>\r\n\r\n\r\n");
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Radiation> Html { get; private set; }
    }
}
#pragma warning restore 1591