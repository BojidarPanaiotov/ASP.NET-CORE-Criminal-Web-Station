#pragma checksum "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\ItemDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "510e7234bcb6d072e57eacb8b4bd17beb20c5185"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Items_ItemDetail), @"mvc.1.0.view", @"/Areas/Admin/Views/Items/ItemDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"510e7234bcb6d072e57eacb8b4bd17beb20c5185", @"/Areas/Admin/Views/Items/ItemDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5374cec41d9bd9e688de4377664a4eb51a97150a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Items_ItemDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserItemsAdminModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Items", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\ItemDetail.cshtml"
  
    ViewBag.Title = "Items";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\ItemDetail.cshtml"
 if (Model.Items.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"text-center text-secondary\">User ");
#nullable restore
#line 8 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\ItemDetail.cshtml"
                                           Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has no adds.</h1>\r\n");
#nullable restore
#line 9 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\ItemDetail.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"text-center mb-3\">User ");
#nullable restore
#line 12 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\ItemDetail.cshtml"
                                 Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Adds</h1>
    <table class=""table table-bordered"">
        <thead>
            <tr class=""table-success text-center"">
                <th scope=""col"">#</th>
                <th scope=""col"">Image</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">Price</th>
                <th scope=""col"">Created On</th>
                <th scope=""col"">Last Update On</th>
                <th scope=""col"" class=""col-lg-2"">Actions</th>
            </tr>
        </thead>
        <tbody class=""text-center"">
");
#nullable restore
#line 26 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\ItemDetail.cshtml"
             for (int i = 0; i < Model.Items.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\ItemDetail.cshtml"
                    Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"w-25\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 980, "\"", 1012, 1);
#nullable restore
#line 31 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\ItemDetail.cshtml"
WriteAttributeValue("", 986, Model.Items[i].MainImgUrl, 986, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid img-thumbnail\" width=\"150\" height=\"110\" alt=\"Sheep\">\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\ItemDetail.cshtml"
                   Write(Model.Items[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>$");
#nullable restore
#line 34 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\ItemDetail.cshtml"
                    Write(Model.Items[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\ItemDetail.cshtml"
                   Write(Model.Items[i].CreatedOn.ToString("MM/dd/yyyy H:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\ItemDetail.cshtml"
                   Write(Model.Items[i].LastUpdate.ToString("MM/dd/yyyy H:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "510e7234bcb6d072e57eacb8b4bd17beb20c518511059", async() => {
                WriteLiteral("<div class=\"btn btn-success mr-1\">Edit</div>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\ItemDetail.cshtml"
                                                                                       WriteLiteral(Model.Items[0].Id);

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
            WriteLiteral("\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1606, "\"", 1613, 0);
            EndWriteAttribute();
            WriteLiteral("><div class=\"btn btn-danger mr-1\">Delete</div></a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\ItemDetail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 45 "C:\Users\User\Desktop\SoftUni_Project\ASP.NET-CORE-Criminal-Web-Station\Criminal-Web-Station\Areas\Admin\Views\Items\ItemDetail.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserItemsAdminModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
