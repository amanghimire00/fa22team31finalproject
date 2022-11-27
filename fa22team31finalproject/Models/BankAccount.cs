using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public enum BankAccountType { Savings, Checkings, IRA }
    public enum BankAcccountStatus { Active, Inactive }
    public class BankAccount
    {        
        public Int32 BankAccountID { get; set; }

        [Display(Name = "Bank Account Number:")]
        [Required(ErrorMessage = "Bank Account Number is required.")]
        public Int32 BankAccountNumber { get; set; }

        [Display(Name = "Bank Account Nickname:")]
        [Required(ErrorMessage = "Bank Account Nickname is required.")]
        public String BankAccountNickname { get; set; }

        [Display(Name = "Bank Account Balance Nickname:")]
        [Required(ErrorMessage = "Bank Account Balance is required.")]
        public Decimal BankAccountBalance { get; set; }

        [Display(Name = "Account Type:")]
        public BankAccountType BankAccountType { get; set; }

        [Display(Name = "Account Status:")]
        //public isActive AcccountStatus { get; set; }
        public BankAcccountStatus BankAcccountStatus { get; set; }
    }
}
