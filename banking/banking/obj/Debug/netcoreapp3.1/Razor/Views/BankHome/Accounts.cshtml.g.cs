#pragma checksum "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Accounts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b58d9951c3d17bdfcf534573f87cab862189b99b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BankHome_Accounts), @"mvc.1.0.view", @"/Views/BankHome/Accounts.cshtml")]
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
#line 1 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\_ViewImports.cshtml"
using banking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\_ViewImports.cshtml"
using banking.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b58d9951c3d17bdfcf534573f87cab862189b99b", @"/Views/BankHome/Accounts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea249d6fa83cc55e0867aed66f7610552559928", @"/Views/_ViewImports.cshtml")]
    public class Views_BankHome_Accounts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<banking.Models.AccountModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"            <!-- Begin Page Content -->
            <div class=""container-fluid"">
                <div class=""row"">
                    <h2>Account Number</h2>
                </div>
                <!-- Content Row -->
                <div class=""row"">

                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                <thead>
                                    <tr>
                                        <th>Name</th>
                                        <th>Branch</th>
                                        <th>IFSC</th>
                                        <th>Account Type</th>
                                        <th>Account Id</th>
                                        <th>Account Number</th>
                                        <th>Phone Number</th>
                                        <th>Emai");
            WriteLiteral(@"l Address</th>
                                        <th>Available Balance</th>
                                    </tr>
                                </thead>
                                <tfoot>
                                    <tr>
                                        <th>Name</th>
                                        <th>Branch</th>
                                        <th>IFSC</th>
                                        <th>Account Type</th>
                                        <th>Account Id</th>
                                        <th>Account Number</th>
                                        <th>Phone Number</th>
                                        <th>Email Address</th>
                                        <th>Available Balance</th>
                                    </tr>
                                </tfoot>
                                <tbody>
");
#nullable restore
#line 46 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Accounts.cshtml"
                                     foreach (var account in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 49 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Accounts.cshtml"
                                       Write(account.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 50 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Accounts.cshtml"
                                       Write(account.Branch);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 51 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Accounts.cshtml"
                                       Write(account.IFSC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 52 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Accounts.cshtml"
                                       Write(account.AccountType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 53 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Accounts.cshtml"
                                       Write(account.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 54 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Accounts.cshtml"
                                       Write(account.AccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 55 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Accounts.cshtml"
                                       Write(account.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 56 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Accounts.cshtml"
                                       Write(account.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 57 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Accounts.cshtml"
                                       Write(account.AvailableBalance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 59 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Accounts.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        \r\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<banking.Models.AccountModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
