using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace banking.Models
{
    public class TransactionModel
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Please enter Your Account Number")]
        public int FromAccountNumber { get; set; }


        [Required(ErrorMessage = "Please enter Beneficial Account Number")]
        public int ToAccountNumber { get; set; }


        [Required(ErrorMessage = "Please enter Purpose For Money Transfer")]
        public string SenderName { get; set; }


        [Required(ErrorMessage = "Please enter beneficial Name")]
        public string ReceiverName { get; set; }

        public DateTime TransactionDate { get; set; }


        [Required(ErrorMessage = "Please enter Amount To transfer")]
        public int Amount { get; set; }
        public int AvailableBalance { get; set; }
        public string EmailAddress { get; set; }
        public int AccountId { get; set; }

       
    }
}
