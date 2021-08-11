#pragma checksum "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "049789d28bbeba59002c778499400fb6eba1de73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Items_Statistics), @"mvc.1.0.view", @"/Areas/Admin/Views/Items/Statistics.cshtml")]
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
#line 1 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\_ViewImports.cshtml"
using Criminal_Web_Station;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\_ViewImports.cshtml"
using Criminal_Web_Station.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\_ViewImports.cshtml"
using Criminal_Web_Station.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\_ViewImports.cshtml"
using Criminal_Web_Station.Models.Item;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\_ViewImports.cshtml"
using Criminal_Web_Station.Services.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\_ViewImports.cshtml"
using Criminal_Web_Station.Services.Implementations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\_ViewImports.cshtml"
using Criminal_Web_Station.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\_ViewImports.cshtml"
using Criminal_Web_Station.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\_ViewImports.cshtml"
using Criminal_Web_Station.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"049789d28bbeba59002c778499400fb6eba1de73", @"/Areas/Admin/Views/Items/Statistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5374cec41d9bd9e688de4377664a4eb51a97150a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Items_Statistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\Statistics.cshtml"
  
    var totalAmountOfAllPurchase = string.Format("{0:0.00}", StatisticsService.TotalAmountOfAllPurchases());
    var totalSiteIncome = string.Format("{0:0.00}", StatisticsService.TotalSiteIncome());
    var todaySiteIncome = string.Format("{0:0.00}", StatisticsService.TodaySiteIncome());
    ViewBag.Title = "Admin Statistics";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""col-md-12"">
        <div class=""jumbotron"">
            <h1 class=""display-4 text-center"">Hello, Admin!</h1>
            <p class=""lead text-center text-capitalize"">Criminal Station Statistics</p>
            <hr class=""my-4"">
            <div class=""row text-center mb-5"">
                <div class=""col-sm"">
                    <h2>Total Users ");
#nullable restore
#line 17 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\Statistics.cshtml"
                               Write(StatisticsService.TotalUsers());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n                <div class=\"col-sm\">\r\n                    <h2>Total Adds ");
#nullable restore
#line 20 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\Statistics.cshtml"
                              Write(StatisticsService.TotalAdds());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n            </div>\r\n            <div class=\"row text-center mb-5\">\r\n\r\n                <div class=\"col-sm\">\r\n                    <h2>Total Adds Added Today ");
#nullable restore
#line 26 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\Statistics.cshtml"
                                          Write(StatisticsService.AddsAddedToday());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n                <div class=\"col-sm\">\r\n                    <h2>Total Users Registered Today ");
#nullable restore
#line 29 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\Statistics.cshtml"
                                                Write(StatisticsService.UsersRegisteredToday());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n            </div>\r\n            <div class=\"row text-center mb-5\">\r\n                <div class=\"col-sm\">\r\n                    <h2>Total Items Sold ");
#nullable restore
#line 34 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\Statistics.cshtml"
                                    Write(StatisticsService.TotalItemsSold());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n                <div class=\"col-sm\">\r\n                    <h2>Total Money Spend $");
#nullable restore
#line 37 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\Statistics.cshtml"
                                      Write(totalAmountOfAllPurchase);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n            </div>\r\n            <div class=\"row text-center mb-5\">\r\n                <div class=\"col-sm\">\r\n                    <h2>Total Items Sold Today ");
#nullable restore
#line 42 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\Statistics.cshtml"
                                          Write(StatisticsService.PurchasesToday());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n                <div class=\"col-sm\">\r\n                    <h2>Total Money Spend Today $");
#nullable restore
#line 45 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\Statistics.cshtml"
                                            Write(StatisticsService.MoneySpendToday());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n            </div>\r\n            <div class=\"row text-center mb-5\">\r\n                <div class=\"col-sm\">\r\n                    <h2>Total Income $");
#nullable restore
#line 50 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\Statistics.cshtml"
                                 Write(totalSiteIncome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <p>Total income is obtained by getting 5% of all sold items</p>
                </div>
            </div>
            <div class=""row text-center mb-5"">
                <div class=""col-sm"">
                    <h2>Today Income $");
#nullable restore
#line 56 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\Statistics.cshtml"
                                 Write(todaySiteIncome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    <p>Daily income is obtained by getting 5% of all sold items today</p>
                </div>
            </div>
            <div class=""container mt-3"">
                <div class=""row"">
                    <div class=""col text-center"">
                        <button class=""btn btn-primary"">Further Information</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStatisticsService StatisticsService { get; private set; }
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