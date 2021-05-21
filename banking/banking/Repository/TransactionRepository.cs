using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using banking.Models;

namespace banking.Repository
{
    public class TransactionRepository
    {
        public List<TransactionModel> GetTransactions(int fromaccountnumber)
        {
            return DataSource().Where(x => x.FromAccountNumber == fromaccountnumber).ToList();
        }

        private List<TransactionModel> DataSource()
        {
            return new List<TransactionModel>()
            {
                new TransactionModel(){Id = 1,FromAccountNumber=12345,SenderName="kandarp",ToAccountNumber=23456,ReceiverName="kunal",TransactionDate= new DateTime(2015, 12, 31),
                }
            };
        }
    }
}
