using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace banking.Models
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contry { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PostCode { get; set; }
        public string Branch { get; set; }
        public int IFSC { get; set; }
        public string AccountType { get; set; }
        public int AccountNumber { get; set; }
        public long PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int AvailableBalance { get; set; }
    }
}
