using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using banking.Models;
using banking.Data;
using Microsoft.Extensions.DependencyInjection;

namespace banking.Repository
{
    public class AccountRepository
    {

        private readonly AccountContext _AccountContext ;

        public AccountRepository(AccountContext context)
        {
            _AccountContext = context;
        }

        public int AddNewAccount(AccountModel model,string email,long phonenumber)
        {
            Random r = new Random();
            int AccountNum = r.Next(100000000, 999999999);

            Random r1 = new Random();
            int Ifsc = r1.Next(100000, 999999);
            var newAccount = new Account()
            {
                Name = model.Name,
                Contry = model.Contry,
                Address = model.Address,
                City = model.City,
                PostCode = model.PostCode,
                Branch = model.Branch,
                AccountType = "Saving",
                PhoneNumber = phonenumber,
                EmailAddress = email,
                AccountNumber = AccountNum,
                IFSC = Ifsc,
                AvailableBalance = model.AvailableBalance,
            };
            _AccountContext.Account.Add(newAccount);
            _AccountContext.SaveChanges();

            return newAccount.Id;

        }

        public int Transaction(TransactionModel model, string email)
        {

            var newtransaction = new Transaction()
            {

                ToAccountNumber = model.ToAccountNumber,
                SenderName = model.SenderName,
                ReceiverName = model.ReceiverName,
                Amount = model.Amount,
                AvailableBalance = _AccountContext.Account.FirstOrDefault(x => x.EmailAddress == email && x.Id == model.AccountId ).AvailableBalance,
                EmailAddress = email,
                TransactionDate = DateTime.Now,
                AccountId = model.AccountId,
            };

            newtransaction.AvailableBalance = newtransaction.AvailableBalance - newtransaction.Amount;
            if(newtransaction.AvailableBalance<=0)
            {
                return -1;
            }
            _AccountContext.Account.FirstOrDefault(x => x.EmailAddress == email && x.Id == newtransaction.AccountId).AvailableBalance = newtransaction.AvailableBalance;
            _AccountContext.AllTransaction.Add(newtransaction);
            _AccountContext.SaveChanges();
            return newtransaction.Id;

        }

        public  List<AccountModel> GetAccounts(string email)
        {
            return  _AccountContext.Account.Where(x => x.EmailAddress == email).Select(account => new AccountModel()
            {
                Id = account.Id,
                Name = account.Name,
                Contry = account.Contry,
                Address = account.Address,
                City = account.City,
                PostCode = account.PostCode,
                Branch = account.Branch,
                IFSC = account.IFSC,
                AccountType = account.AccountType,
                AccountNumber = account.AccountNumber,
                PhoneNumber = account.PhoneNumber,
                EmailAddress = account.EmailAddress,
                AvailableBalance = account.AvailableBalance
            }).ToList();
        }

        public List<TransactionModel> GetTransactions(string email)
        {
            return _AccountContext.AllTransaction.Where(x => x.EmailAddress == email).Select(transaction => new TransactionModel()
            {
                AccountId = transaction.AccountId,
                FromAccountNumber = _AccountContext.Account.FirstOrDefault(x => x.Id == transaction.AccountId).AccountNumber,
                ToAccountNumber = transaction.ToAccountNumber,
                SenderName = transaction.SenderName,
                ReceiverName = transaction.ReceiverName,
                TransactionDate = transaction.TransactionDate,
                Amount = transaction.Amount,
                AvailableBalance = transaction.AvailableBalance,
                EmailAddress = transaction.EmailAddress
            }).ToList();
        }


    }
}
