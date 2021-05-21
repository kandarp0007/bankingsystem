using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banking.Models
{
    public class ATViewModel
    {
        public List<AccountModel> account { get; set; }

        public List<TransactionModel> transaction { get; set; }
    }
}
