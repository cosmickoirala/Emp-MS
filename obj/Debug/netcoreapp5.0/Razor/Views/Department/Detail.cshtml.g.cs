#pragma checksum "E:\Study Materials\MBM\6th Sem\Net Centric Computing\Repo\Cosmic.Koirala\EmployeeManagement\Views\Department\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f0614d7edc9cf2e8fb382d0b0eefb02fea10b58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Detail), @"mvc.1.0.view", @"/Views/Department/Detail.cshtml")]
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
#line 1 "E:\Study Materials\MBM\6th Sem\Net Centric Computing\Repo\Cosmic.Koirala\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Study Materials\MBM\6th Sem\Net Centric Computing\Repo\Cosmic.Koirala\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f0614d7edc9cf2e8fb382d0b0eefb02fea10b58", @"/Views/Department/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1de0e4bf9db1cac44c7c95614c6fadd41f242b81", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Department_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Department>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Study Materials\MBM\6th Sem\Net Centric Computing\Repo\Cosmic.Koirala\EmployeeManagement\Views\Department\Detail.cshtml"
  







    ViewData["Titlephrase"] = @Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Detail For Employee <a class=\"btn btn-outline-primary\" href=\"/department/index\" role=\"button\">Go Back</a></h1>\n\n<ul class=\"list-group\">\n    <li class=\"list-group-item\">Name: ");
#nullable restore
#line 15 "E:\Study Materials\MBM\6th Sem\Net Centric Computing\Repo\Cosmic.Koirala\EmployeeManagement\Views\Department\Detail.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    <li class=\"list-group-item\">Code: ");
#nullable restore
#line 16 "E:\Study Materials\MBM\6th Sem\Net Centric Computing\Repo\Cosmic.Koirala\EmployeeManagement\Views\Department\Detail.cshtml"
                                 Write(Model.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    <li class=\"list-group-item\">Address: ");
#nullable restore
#line 17 "E:\Study Materials\MBM\6th Sem\Net Centric Computing\Repo\Cosmic.Koirala\EmployeeManagement\Views\Department\Detail.cshtml"
                                    Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n</ul>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Department> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
