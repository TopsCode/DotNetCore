#pragma checksum "D:\DotNet Core\PartialViewStronglyTypes\PartialViewStronglyTypes\Views\Default\_ShowData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "222bbc041abdbe5f6aac31ddbb062e7487c04454"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default__ShowData), @"mvc.1.0.view", @"/Views/Default/_ShowData.cshtml")]
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
#line 1 "D:\DotNet Core\PartialViewStronglyTypes\PartialViewStronglyTypes\Views\_ViewImports.cshtml"
using PartialViewStronglyTypes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DotNet Core\PartialViewStronglyTypes\PartialViewStronglyTypes\Views\_ViewImports.cshtml"
using PartialViewStronglyTypes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"222bbc041abdbe5f6aac31ddbb062e7487c04454", @"/Views/Default/_ShowData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be78b6d82dfee076e20512904db99b0d8b9770f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Default__ShowData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartialViewStronglyTypes.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 8 "D:\DotNet Core\PartialViewStronglyTypes\PartialViewStronglyTypes\Views\Default\_ShowData.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.empid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 11 "D:\DotNet Core\PartialViewStronglyTypes\PartialViewStronglyTypes\Views\Default\_ShowData.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.fname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 14 "D:\DotNet Core\PartialViewStronglyTypes\PartialViewStronglyTypes\Views\Default\_ShowData.cshtml"
   Write(Html.DisplayFor(modelItem => modelItem.salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 17 "D:\DotNet Core\PartialViewStronglyTypes\PartialViewStronglyTypes\Views\Default\_ShowData.cshtml"
   Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n        ");
#nullable restore
#line 18 "D:\DotNet Core\PartialViewStronglyTypes\PartialViewStronglyTypes\Views\Default\_ShowData.cshtml"
   Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n        ");
#nullable restore
#line 19 "D:\DotNet Core\PartialViewStronglyTypes\PartialViewStronglyTypes\Views\Default\_ShowData.cshtml"
   Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n</tr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartialViewStronglyTypes.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
