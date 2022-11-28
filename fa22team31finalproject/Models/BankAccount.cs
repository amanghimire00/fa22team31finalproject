using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public enum AccountType { Savings, Checkings, IRA }
    public enum AccountStatus { Active, Inactive }
    public class Account
    {        
        public Int32 AccountID { get; set; }

        [Display(Name = "Bank Account Number:")]
        [Required(ErrorMessage = "Bank Account Number is required.")]
        public Int32 AccountNumber { get; set; }

        [Display(Name = "Bank Account Nickname:")]
        [Required(ErrorMessage = "Bank Account Nickname is required.")]
        public String AccountNickname { get; set; }

        [Display(Name = "Bank Account Balance Nickname:")]
        [Required(ErrorMessage = "Bank Account Balance is required.")]
        public Decimal AccountBalance { get; set; }

        [Display(Name = "Account Type:")]
        public AccountType AccountType { get; set; }

        [Display(Name = "Account Status:")]
        //public isActive AcccountStatus { get; set; }
        public AccountStatus AccountStatus { get; set; }
    }
}
