using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public class TransactionDetail
    {
        [Display(Name = "Transaction Detail ID")]
        public Int32 TransactionDetailID { get; set; }

        [Range(0, 1000000, ErrorMessage = "Amount must be greater than 0")]
        public Int32 TransactionAmount { get; set; }

        public Transaction Transaction { get; set; }
        public BankAccount BankAccount { get; set; }
        public Dispute Dispute { get; set; }
    }
}
