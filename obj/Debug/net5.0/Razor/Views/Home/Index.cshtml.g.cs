#pragma checksum "C:\Users\spenc\WebDev\BugTracker\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfb0283b56e765276cb6cf866e5b5f33691274ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfb0283b56e765276cb6cf866e5b5f33691274ad", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"415cd50ac37814e1a4fb76bf7d07627084cdfa27", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BugTracker.ViewModels.DashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Issues", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\spenc\WebDev\BugTracker\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<nav aria-label=""breadcrumb"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item active"" aria-current=""page"">Home</li>
    </ol>
</nav>

<!-- Cards section -->

<div class=""updates-cards row my-4"">
    <div class=""col-12 col-md-6 col-lg-3 mb-4 mb-lg-0"">
        <div class=""card"">
            <h5 class=""card-header"">Scrum Update</h5>
            <div class=""card-body"">
                <p class=""card-text"">Sprint #4 completed; customer review in progress.</p>
                <p class=""card-text text-success"">December 8th, 2021</p>
            </div>
        </div>
    </div>

    <div class=""col-12 col-md-6 col-lg-3 mb-4 mb-lg-0"">
        <div class=""card"">
            <h5 class=""card-header"">Scrum Update</h5>
            <div class=""card-body"">
                <p class=""card-text"">Sprint #5 begun; tasks assigned.</p>
                <p class=""card-text text-success"">January 8th, 2022</p>
            </div>
        </div>
    </div>

    <div class=""col-12 col-md-6 col");
            WriteLiteral(@"-lg-3 mb-4 mb-lg-0"">
        <div class=""card"">
            <h5 class=""card-header"">Scrum Update</h5>
            <div class=""card-body"">
                <p class=""card-text"">Sprint #5 midway point.</p>
                <p class=""card-text text-success"">January 19th, 2022</p>
            </div>
        </div>
    </div>

    <div class=""col-12 col-md-6 col-lg-3 mb-4 mb-lg-0"">
        <div class=""card text-white bg-primary"">
            <h5 class=""card-header bg-primary"">Scrum Update</h5>
            <div class=""card-body"">
                <p class=""card-text"">Sprint #5 extension approved.</p>
                <p class=""card-text text-success"">January 25th, 2022</p>
            </div>
        </div>
    </div>
</div>

<!-- Chart and Table Section -->
<div class=""container"">
    <div class=""row"">
        <!-- Column for table -->
        <div class=""col-6"">
            <h4 style=""text-align: center;"">Recently Viewed Tickets</h4>
            <table id=""dummyTable"">
                <thea");
            WriteLiteral("d>\r\n                    <tr>\r\n                        <th>Ticket</th>\r\n                        <th>Viewed</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 71 "C:\Users\spenc\WebDev\BugTracker\Views\Home\Index.cshtml"
                     if (Model.RecentlyViewedIssues == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td></td>\r\n                            <td></td>\r\n                        </tr>\r\n");
#nullable restore
#line 77 "C:\Users\spenc\WebDev\BugTracker\Views\Home\Index.cshtml"
                    }
                    else
                    {
                        foreach (var item in Model.RecentlyViewedIssues)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfb0283b56e765276cb6cf866e5b5f33691274ad7047", async() => {
#nullable restore
#line 83 "C:\Users\spenc\WebDev\BugTracker\Views\Home\Index.cshtml"
                                                                                                             Write(item.Issue.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\spenc\WebDev\BugTracker\Views\Home\Index.cshtml"
                                                                                      WriteLiteral(item.Issue.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 84 "C:\Users\spenc\WebDev\BugTracker\Views\Home\Index.cshtml"
                               Write(item.TimeViewed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 86 "C:\Users\spenc\WebDev\BugTracker\Views\Home\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <!-- Column for chart -->\r\n        <div class=\"col-6\">\r\n            <canvas height=\"300\" width=\"240\" id=\"dummyChart\"></canvas>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""#dummyTable"").DataTable({
                order: [[1, ""asc""]],
                lengthMenu: [5, 10, 15]
            });
        })
    </script>

    <script>
        // Setting up the chart data
        const labels = [
            'January',
            'February',
            'March',
            'April',
            'May',
            'June',
        ];
        const data = {
            labels: labels,
            datasets: [{
                label: '% Sales By Quarter',
                backgroundColor: 'rgb(255, 99, 132)',
                borderColor: 'rgb(255, 99, 132)',
                data: [0, 10, 5, 2, 20, 30, 45],
            }]
        };

        // Defining the chart
        const config = {
            type: 'line',
            data: data,
            options: {}
        };

        // Displaying the chart
        var dummyChart = new Chart(
            $(""#dummyChart""),
            conf");
                WriteLiteral("ig\r\n        )\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BugTracker.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
