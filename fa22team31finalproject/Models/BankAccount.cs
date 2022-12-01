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

        [Display(Name = "Bank Account Nickname:")]
        [Required(ErrorMessage = "Bank Account Nickname is required.")]
        public String AccountName { get; set; }

        [Display(Name = "Bank Account Balance:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Balance { get; set; }

        [Display(Name = "Sum of Deposits:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Range(1, 49999, ErrorMessage = "The number must be atleast one")]
        public Decimal SumofDeposits { get; set; }

        [Display(Name = "Sum of Withdrawals:")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Range(1, 49999, ErrorMessage = "The number must be atleast one")]
        public Decimal SumofWithdrawals { get; set; }

        [Display(Name = "Account Type:")]
        public AccountType AccountType { get; set; }

        [Display(Name = "Account Status:")]
        public AccountStatus AccountStatus { get; set; }

        public AppUser AppUser { get; set; }
        public List<Transaction> Transaction { get; set; }

    }
}
