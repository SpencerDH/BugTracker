#pragma checksum "C:\Users\spenc\WebDev\BugTracker\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57f8d51f71093a287d39b6150eca1ef5e8c8bf23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
#line 1 "C:\Users\spenc\WebDev\BugTracker\Views\_ViewImports.cshtml"
using BugTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\spenc\WebDev\BugTracker\Views\_ViewImports.cshtml"
using BugTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57f8d51f71093a287d39b6150eca1ef5e8c8bf23", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"415cd50ac37814e1a4fb76bf7d07627084cdfa27", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\spenc\WebDev\BugTracker\Views\Account\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\spenc\WebDev\BugTracker\Views\Account\Register.cshtml"
   
    Layout = "_AuthLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\spenc\WebDev\BugTracker\Views\Account\Register.cshtml"
 using (Html.BeginForm("Register", "Account", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <tr>\r\n            <td>Enter First Name:</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\spenc\WebDev\BugTracker\Views\Account\Register.cshtml"
           Write(Html.TextBox("FirstName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Enter Last Name:</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\spenc\WebDev\BugTracker\Views\Account\Register.cshtml"
           Write(Html.TextBox("LastName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Enter Username:</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\spenc\WebDev\BugTracker\Views\Account\Register.cshtml"
           Write(Html.TextBox("Username"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Enter Password:</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\spenc\WebDev\BugTracker\Views\Account\Register.cshtml"
           Write(Html.TextBox("Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\"><input type=\"submit\" value=\"Submit\" /></td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 32 "C:\Users\spenc\WebDev\BugTracker\Views\Account\Register.cshtml"
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
