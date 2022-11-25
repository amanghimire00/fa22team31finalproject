using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public enum StockTransactionType { Purchase, Sell }
    public class StockTransaction
    {
        public Int32 StockTransactionID { get; set; }

        [Display(Name = "Quantity of Stock:")]
        [Required(ErrorMessage = "You must select at least one stock")]
        public Int32 SharesQuantity { get; set; }

        [Display(Name = "Purchase Price:")]
        [Required(ErrorMessage = "Purchase Price must be at least 1 cent")]
        public Int32 PurchasePrice { get; set; }

        [Display(Name = "Stock Transaction Type")]
        public StockTransactionType StockTransactionType { get; set; }

        [Display(Name = "Date of Purchase:")]
        [Required(ErrorMessage = "Date is required!")]
        public DateTime StickPurchaseDate { get; set; }
        public Stock Stock { get; set; }
        public StockPortfolio StockPortfolio { get; set; }

    }
}
