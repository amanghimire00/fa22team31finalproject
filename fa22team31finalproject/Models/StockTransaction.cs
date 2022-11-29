using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public enum StockTransactionType { Purchase, Sell }
    public class StockTransaction
    {
        private const Int32 Stock_Purchase_Fee = 10;
        private const Int32 Stock_Selling_Fee = 15;
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

        [Display(Name = "Stock:")]
        [Required(ErrorMessage = "Stock Ticker is required!")]
        public String StockTicker { get; set; }

        public Decimal StockBalance
        {
            get
            {
                return SharesQuantity * PurchasePrice;
            }
        }
        public AppUser AppUser { get; set; }

    }
}
