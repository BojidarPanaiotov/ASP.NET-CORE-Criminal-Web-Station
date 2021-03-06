#pragma checksum "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\UserAdds\PurchaseHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfd3b7222de5a75ff1ccb6632b1dc867d4984e23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserAdds_PurchaseHistory), @"mvc.1.0.view", @"/Views/UserAdds/PurchaseHistory.cshtml")]
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
#line 1 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\_ViewImports.cshtml"
using Criminal_Web_Station;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\_ViewImports.cshtml"
using Criminal_Web_Station.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\_ViewImports.cshtml"
using Criminal_Web_Station.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\_ViewImports.cshtml"
using Criminal_Web_Station.Models.Item;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\_ViewImports.cshtml"
using Criminal_Web_Station.Services.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\_ViewImports.cshtml"
using Criminal_Web_Station.Services.Implementations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\_ViewImports.cshtml"
using Criminal_Web_Station.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\_ViewImports.cshtml"
using Criminal_Web_Station.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\_ViewImports.cshtml"
using Criminal_Web_Station.Areas.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfd3b7222de5a75ff1ccb6632b1dc867d4984e23", @"/Views/UserAdds/PurchaseHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3f6b5cfe29a244079dbaa380ebee3c88443adfb", @"/Views/_ViewImports.cshtml")]
    public class Views_UserAdds_PurchaseHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PurchaseServiceModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\UserAdds\PurchaseHistory.cshtml"
  
    ViewBag.Title = "Purchase History";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <h2 class=""heading-margin text-center text-dark mb-4"">Purchase History</h2>
    <table class=""table border border-dark"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Price</th>
                <th scope=""col"">Date</th>
                <th scope=""col"">Status</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 18 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\UserAdds\PurchaseHistory.cshtml"
             for (int i = 0; i < Model.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 21 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\UserAdds\PurchaseHistory.cshtml"
                            Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>_");
#nullable restore
#line 22 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\UserAdds\PurchaseHistory.cshtml"
                Write(Model[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>$");
#nullable restore
#line 23 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\UserAdds\PurchaseHistory.cshtml"
                Write(Model[i].Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\UserAdds\PurchaseHistory.cshtml"
               Write(Model[i].PurchaseDate.ToString("MM/dd/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><span class=\"badge badge-success\">Success</span></td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Views\UserAdds\PurchaseHistory.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PurchaseServiceModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
