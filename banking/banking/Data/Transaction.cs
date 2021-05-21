using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banking.Data
{
    public class Transaction
    {
        public int Id { get; set; }
        public int ToAccountNumber { get; set; }
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Amount { get; set; }
        public int AvailableBalance { get; set; }
        public string EmailAddress { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
