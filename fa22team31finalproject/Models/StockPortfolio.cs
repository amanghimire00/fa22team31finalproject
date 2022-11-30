using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public class StockPortfolio
    {
        public Int32 StockPortfolioID { get; set; }

        [Display(Name = "Account Number:")]
        [Required(ErrorMessage = "Account Number is required.")]
        public Int64 AccountNumber { get; set; }

        [Display(Name = "Account Name:")]
        [Required(ErrorMessage = "Account Name is required.")]
        public String AccountName { get; set; }

        [Display(Name = "Cash Balance:")]
        [Required(ErrorMessage = "Cash Balance is required.")]
        public Decimal CashBalance { get; set; }

        public AppUser AppUser { get; set; }

        public Transaction Transaction { get; set; }

        public List<StockTransaction> StockTransaction { get; set; }
    }
}
