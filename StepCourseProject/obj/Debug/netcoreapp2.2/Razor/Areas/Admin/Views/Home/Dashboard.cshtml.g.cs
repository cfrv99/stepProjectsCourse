#pragma checksum "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43d31660e0bb4e18b33497a5194bdc8c07a206d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Dashboard), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Areas_Admin_Views_Home_Dashboard))]
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
#line 1 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\_ViewImports.cshtml"
using StepCourseProject;

#line default
#line hidden
#line 2 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\_ViewImports.cshtml"
using StepCourseProject.Models;

#line default
#line hidden
#line 3 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\_ViewImports.cshtml"
using StepCourseProject.Areas.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d31660e0bb4e18b33497a5194bdc8c07a206d2", @"/Areas/Admin/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa7dc05c9f76f4f0fbfc7d980a9babac4c353162", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(65, 950, true);
            WriteLiteral(@"
<div class=""container-fluid"">

    <!-- Page Heading -->
    <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
        <h1 class=""h3 mb-0 text-gray-800"">Dashboard</h1>
        <a href=""#"" class=""d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm""><i class=""fas fa-download fa-sm text-white-50""></i> Generate Report</a>
    </div>

    <!-- Content Row -->
    <div class=""row"">

        <!-- Earnings (Monthly) Card Example -->
        <div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-primary shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">Client Users Count</div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
            EndContext();
            BeginContext(1016, 29, false);
#line 24 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\Home\Dashboard.cshtml"
                                                                           Write(Model.ClientsCount.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1045, 823, true);
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-calendar fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Earnings (Monthly) Card Example -->
        <div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-success shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">Freelance Users Count</div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
            EndContext();
            BeginContext(1869, 20, false);
#line 41 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\Home\Dashboard.cshtml"
                                                                           Write(Model.FreelanceCount);

#line default
#line hidden
            EndContext();
            BeginContext(1889, 950, true);
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-dollar-sign fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Earnings (Monthly) Card Example -->
        <div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-info shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">Tasks</div>
                            <div class=""row no-gutters align-items-center"">
                                <div class=""col-auto"">
                                    <div class=""h5 mb-0 mr-3 font-weight-bold text-gray-800"">");
            EndContext();
            BeginContext(2840, 18, false);
#line 60 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\Home\Dashboard.cshtml"
                                                                                        Write(Model.ProjectCount);

#line default
#line hidden
            EndContext();
            BeginContext(2858, 268, true);
            WriteLiteral(@"</div>
                                </div>
                                <div class=""col"">
                                    <div class=""progress progress-sm mr-2"">
                                        <div class=""progress-bar bg-info"" role=""progressbar""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3126, "\"", 3168, 4);
            WriteAttributeValue("", 3134, "width:", 3134, 6, true);
            WriteAttributeValue(" ", 3140, "((", 3141, 3, true);
#line 64 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 3143, Model.UserCount, 3143, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 3159, "/2)*100)%", 3159, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 3169, "\"", 3209, 3);
            WriteAttributeValue("", 3185, "(", 3185, 1, true);
#line 64 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 3186, Model.UserCount, 3186, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 3202, "/2)*100", 3202, 7, true);
            EndWriteAttribute();
            BeginContext(3210, 2443, true);
            WriteLiteral(@" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-auto"">
                            <i class=""fas fa-clipboard-list fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Pending Requests Card Example -->
        <div class=""col-xl-3 col-md-6 mb-4"">
            <div class=""card border-left-warning shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">Pending Requests</div>
                            <div class=""h5 mb-0 font-weight-bold text-gray-800"">18</div>
                        </div>
 ");
            WriteLiteral(@"                       <div class=""col-auto"">
                            <i class=""fas fa-comments fa-2x text-gray-300""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">All users list</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Rating Vote</th>
                            <th>City</th>
                            <th>Age</th>
                            <th>Experience</th>
                            <th>Email</th>
                        </tr>
                    </thead>
                    <tfoo");
            WriteLiteral(@"t>
                        <tr>
                            <th>Name</th>
                            <th>Rating Vote</th>
                            <th>City</th>
                            <th>Age</th>
                            <th>Experience</th>
                            <th>Email</th>
                        </tr>
                    </tfoot>
                    <tbody>
");
            EndContext();
#line 123 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\Home\Dashboard.cshtml"
                         foreach (var user in Model.Users)
                        {


#line default
#line hidden
            BeginContext(5742, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(5813, 13, false);
#line 127 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\Home\Dashboard.cshtml"
                               Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(5826, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(5871, 61, false);
#line 128 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\Home\Dashboard.cshtml"
                                Write(user.Rating == 0 ? "Not rating vote" : user.Rating.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(5933, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(5978, 59, false);
#line 129 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\Home\Dashboard.cshtml"
                                Write(user.City ==null ? "No entered city" : user.City.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(6038, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(6082, 8, false);
#line 130 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\Home\Dashboard.cshtml"
                               Write(user.Age);

#line default
#line hidden
            EndContext();
            BeginContext(6090, 53, true);
            WriteLiteral(" years old</td>\r\n                                <td>");
            EndContext();
            BeginContext(6144, 15, false);
#line 131 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\Home\Dashboard.cshtml"
                               Write(user.Experience);

#line default
#line hidden
            EndContext();
            BeginContext(6159, 48, true);
            WriteLiteral(" year</td>\r\n                                <td>");
            EndContext();
            BeginContext(6208, 10, false);
#line 132 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\Home\Dashboard.cshtml"
                               Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(6218, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 134 "C:\Users\Murad\source\repos\StepCourseProject\StepCourseProject\Areas\Admin\Views\Home\Dashboard.cshtml"
                        }

#line default
#line hidden
            BeginContext(6287, 150, true);
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <!-- Content Row -->\r\n\r\n\r\n\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
