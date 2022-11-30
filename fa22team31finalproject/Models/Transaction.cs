using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public enum TransactionType { Deposit, Withdrawal, Transfer }
    public enum TransactionApproved { Yes, No }
    public class Transaction
    {
        public String TransactionID { get; set; }

        [Display(Name = "Transcation Number")]
        public Int32 TransactionNumber { get; set; }
        public TransactionType TransactionType { get; set; }

        [Display(Name = "Bank Account Number:")]
        [Required(ErrorMessage = "Bank Account Number is required.")]
        public Int64 AccountNumber { get; set; }

        [Display(Name = "Transaction Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime TransactionDate { get; set; }

        [Display(Name = "Transcation Comment")]
        public String TransactionComment { get; set; }

        [Display(Name = "Approved?")]

        public TransactionApproved TransactionApproved { get; set; }

        [Display(Name = "Transaction Amount:")]
        [Required(ErrorMessage = "Transaction Amount is required.")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TransactionAmount { get; set; }
        public BankAccount BankAccount { get; set; }
        public List<TransactionDetail> TransactionDetails { get; set; }
        public List<Dispute> Dispute { get; set; }
    }
}
