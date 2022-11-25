using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public enum AccountType { Savings, Checkings, IRA }
    public enum BankAcccountStatus { Active, Inactive }
    public class Account
    {        
        public Int32 AccountID { get; set; }

        [Display(Name = "Account Number:")]
        [Required(ErrorMessage = "Account Number is required.")]
        public Int32 AccountNumber { get; set; }

        [Display(Name = "Account Name:")]
        [Required(ErrorMessage = "Account Name is required.")]
        public Int32 AccountName { get; set; }

        [Display(Name = "Account Type:")]
        public AccountType AccountType { get; set; }

        [Display(Name = "Account Status:")]
        //public isActive AcccountStatus { get; set; }
        public BankAcccountStatus BankAcccountStatus { get; set; }

    }
}
