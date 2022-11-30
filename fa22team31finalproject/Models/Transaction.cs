using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public enum TransactionType { Deposit, Withdrawal }
    public class Transaction
    {
        public String TransactionID { get; set; }

        [Display(Name = "Transcation Number")]
        public Int32 TransactionNumber { get; set; }
        public TransactionType TransactionType { get; set; }

        [Display(Name = "Transaction Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime TransactionDate { get; set; }

        [Display(Name = "Transcation Comment")]
        [Required]
        public String TransactionComment { get; set; }

        [Display(Name = "Approved?")]
        public bool isApproved { get; set; }
        public List<TransactionDetail> TransactionDetails { get; set; }
        public List<Dispute> Dispute { get; set; }
    }
}
