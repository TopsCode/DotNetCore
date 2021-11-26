#pragma checksum "D:\DotNet Core\09.ValidationDemo\ValidationDemo\Views\Default\JsValidation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e133ce6c3584644ea285f59eb5ff60f47047be05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_JsValidation), @"mvc.1.0.view", @"/Views/Default/JsValidation.cshtml")]
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
#line 1 "D:\DotNet Core\09.ValidationDemo\ValidationDemo\Views\_ViewImports.cshtml"
using ValidationDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DotNet Core\09.ValidationDemo\ValidationDemo\Views\_ViewImports.cshtml"
using ValidationDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e133ce6c3584644ea285f59eb5ff60f47047be05", @"/Views/Default/JsValidation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b500944a255bcd1148806f225ba21ceb0abcc4a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_JsValidation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\DotNet Core\09.ValidationDemo\ValidationDemo\Views\Default\JsValidation.cshtml"
  
    ViewData["Title"] = "JsValidation";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    function formValidation() {
        var fname = document.getElementById(""txtfn"").value;
        if (fname == """") {
            alert(""Fname is Required..!!"");
            return false;
        }
        var expr = /^[a-zA-Z]+$/;
        if (expr.test(fname) == false) {
            alert(""Alphabets only.."");
            return false;
        }

        var mobile = document.getElementById(""txtmob"").value;
        if (mobile == """") {
            alert(""Mobile no is Required..!!"");
            return false;
        }
        var expr = /^[9876]\d{9}$/;
        if (expr.test(mobile) == false) {
            alert(""invalid mobile no..!!"");
            return false;
        }

        var email = document.getElementById(""txtemail"").value;
        if (email == """") {
            alert(""email is Required..!!"");
            return false;
        }
        var expr = /^[_a-z0-9-]+(\.[_a-z0-9-]+)*");
            WriteLiteral(@"@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$/;
        if (expr.test(email) == false) {
            alert(""invalid email..!!"");
            return false;
        }

        var age = document.getElementById(""txtage"").value;
        if (age < 25) {
            alert(""Under age..!!"");
            return false;
        }

        var pass = document.getElementById(""txtpass"").value;
        if (pass == """") {
            alert(""Password is Required..!!"");
            return false;
        }
        var expr = /^(?=.*[a-zA-Z])(?=.*\d)(?=.*[!");
            WriteLiteral("@#$%^&*()_+])[A-Za-z\\d][A-Za-z\\d!");
            WriteLiteral(@"@#$%^&*()_+]{7,19}$/;
        if (expr.test(pass) == false) {
            alert(""Password is weak..!!"");
            return false;
        }

        var cnfpass = document.getElementById(""txtcnf"").value;
        if (cnfpass != pass) {
            alert(""Passwords Mismatch..!!"");
            return false;
        }

        return true;
    }
</script>

<h1>JavaScript Validations</h1>
<br />
");
#nullable restore
#line 70 "D:\DotNet Core\09.ValidationDemo\ValidationDemo\Views\Default\JsValidation.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"form-group\">\r\n            <label>First Name</label>\r\n            <input id=\"txtfn\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2168, "\"", 2176, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Mobile</label>\r\n            <input id=\"txtmob\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2330, "\"", 2338, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Email</label>\r\n            <input id=\"txtemail\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2493, "\"", 2501, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Age</label>\r\n            <input id=\"txtage\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2652, "\"", 2660, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Password</label>\r\n            <input id=\"txtpass\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2817, "\"", 2825, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Cnf Password</label>\r\n            <input id=\"txtcnf\" type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 2985, "\"", 2993, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label> </label>\r\n            <input type=\"submit\" value=\"Submit\" onclick=\"return formValidation();\" class=\"btn btn-success\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 102 "D:\DotNet Core\09.ValidationDemo\ValidationDemo\Views\Default\JsValidation.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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