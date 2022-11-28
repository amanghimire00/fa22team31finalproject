using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public class StockPortfolio
    {
        [Display(Name = "Account Number:")]
        [Required(ErrorMessage = "Account Number is required.")]
        public Int32 AccountNumber { get; set; }

        [Display(Name = "Account Name:")]
        [Required(ErrorMessage = "Account Name is required.")]
        public Int32 AccountName { get; set; }

        public AppUser AppUser { get; set; }
        public List<StockTransaction> StockTransactions { get; set; }

        [Display(Name = "Bank Account Nickname:")]
        [Required(ErrorMessage = "Bank Account Nickname is required.")]
        public String AccountNickname { get; set; }
    }
}
