#pragma checksum "D:\Practice\VCdemo\VCdemo\Views\Shared\Components\EmployeeSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e1dd18f863b79b93d772006e83e4a017bac0919"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_EmployeeSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/EmployeeSummary/Default.cshtml")]
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
#line 1 "D:\Practice\VCdemo\VCdemo\Views\_ViewImports.cshtml"
using VCdemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Practice\VCdemo\VCdemo\Views\_ViewImports.cshtml"
using VCdemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e1dd18f863b79b93d772006e83e4a017bac0919", @"/Views/Shared/Components/EmployeeSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efa9f65f4d067d3d4d13f69443843ff9b4f37899", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_EmployeeSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VCdemo.Models.EmployeeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Practice\VCdemo\VCdemo\Views\Shared\Components\EmployeeSummary\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Default</h1>\r\n\r\n<div>\r\n    <h4>EmployeeViewModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\Practice\VCdemo\VCdemo\Views\Shared\Components\EmployeeSummary\Default.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\Practice\VCdemo\VCdemo\Views\Shared\Components\EmployeeSummary\Default.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\Practice\VCdemo\VCdemo\Views\Shared\Components\EmployeeSummary\Default.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\Practice\VCdemo\VCdemo\Views\Shared\Components\EmployeeSummary\Default.cshtml"
       Write(Html.DisplayFor(model => model.TotalSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VCdemo.Models.EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
