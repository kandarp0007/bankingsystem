#pragma checksum "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Transaction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eca4563ce9ac0cfc9f10daa8449fbb772e05712e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BankHome_Transaction), @"mvc.1.0.view", @"/Views/BankHome/Transaction.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eca4563ce9ac0cfc9f10daa8449fbb772e05712e", @"/Views/BankHome/Transaction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea249d6fa83cc55e0867aed66f7610552559928", @"/Views/_ViewImports.cshtml")]
    public class Views_BankHome_Transaction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<banking.Models.TransactionModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

            <!-- Begin Page Content -->
            <div class=""container-fluid"">

                <!-- Page Heading -->
                <h1 class=""h3 mb-2 text-gray-800"">All Transaction</h1>

                <!-- DataTales Example -->
                <div class=""card shadow mb-4"">
                    <div class=""card-header py-3"">
                        <h6 class=""m-0 font-weight-bold text-primary"">Account Number</h6>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                <thead>
                                    <tr>
                                        <th>AccountId</th>
                                        <th>AccountNumber</th>
                                        <th>SenderName</th>
                                        <th>ToAccountNumber</th>
             ");
            WriteLiteral(@"                           <th>ReceiverName</th>
                                        <th>Date</th>
                                        <th>Amount</th>
                                        <th>Available Balance</th>
                                    </tr>
                                </thead>
                                <tfoot>
                                    <tr>
                                        <th>AccountId</th>
                                        <th>AccountNumber</th>
                                        <th>SenderName</th>
                                        <th>ToAccountNumber</th>
                                        <th>ReceiverName</th>
                                        <th>Date</th>
                                        <th>Amount</th>
                                        <th>Available Balance</th>
                                    </tr>
                                </tfoot>
                                <tbody>
");
#nullable restore
#line 48 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Transaction.cshtml"
                                     foreach (var transaction in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 51 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Transaction.cshtml"
                                       Write(transaction.AccountId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 52 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Transaction.cshtml"
                                       Write(transaction.FromAccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 53 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Transaction.cshtml"
                                       Write(transaction.SenderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 54 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Transaction.cshtml"
                                       Write(transaction.ToAccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 55 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Transaction.cshtml"
                                       Write(transaction.ReceiverName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 56 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Transaction.cshtml"
                                       Write(transaction.TransactionDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 57 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Transaction.cshtml"
                                       Write(transaction.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 58 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Transaction.cshtml"
                                       Write(transaction.AvailableBalance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>");
#nullable restore
#line 59 "C:\Users\kandarp\Desktop\sem 5\projectsSem5\Project_CE095\banking\banking\Views\BankHome\Transaction.cshtml"
                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<banking.Models.TransactionModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
