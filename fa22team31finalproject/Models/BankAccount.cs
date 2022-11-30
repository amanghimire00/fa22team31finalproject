using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public enum AccountType { Savings, Checking, IRA }
    public enum AccountStatus { Active, Inactive }
    public class BankAccount
    {        
        public Int32 BankAccountID { get; set; }

        [Display(Name = "Bank Account Number:")]
        [Required(ErrorMessage = "Bank Account Number is required.")]
        public Int64 AccountNumber { get; set; }

        [Display(Name = "Bank Account Customer:")]
        [Required(ErrorMessage = "Bank Account Customer is required.")]
        public String Customer { get; set; }

        [Display(Name = "Bank Account Nickname:")]
        [Required(ErrorMessage = "Bank Account Nickname is required.")]
        public String AccountName { get; set; }

        [Display(Name = "Bank Account Balance:")]
        [Required(ErrorMessage = "Bank Account Balance is required.")]
        public Decimal Balance { get; set; }

        [Display(Name = "Account Type:")]
        public AccountType AccountType { get; set; }

        [Display(Name = "Account Status:")]
        public AccountStatus AccountStatus { get; set; }

        public List<AppUser> AppUser { get; set; }
        public Transaction Transaction { get; set; }

    }
}
