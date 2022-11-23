using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public enum AccountType { Savings, Checkings, IRA }
    public class Account
    {        
        public String AccountID { get; set; }

        [Display(Name = "Account Number:")]
        [Required(ErrorMessage = "Account Number is required.")]
        public Int32 AccountNumber { get; set; }

        [Display(Name = "Account Type:")]
        public AccountType AccountType { get; set; }
    }
}
