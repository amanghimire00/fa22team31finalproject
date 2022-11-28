using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public class Stock
    {
        public Int32 StockID { get; set; }

        [Display(Name = "Name of Stock:")]
        [Required(ErrorMessage = "Your stock must have a name")]
        public String StockName { get; set; }

        [Display(Name = "Ticker of Stock:")]
        [Required(ErrorMessage = "Your stock must have a Ticker")]
        [StringLength(5, MinimumLength = 1, ErrorMessage = "Maximum 5 characters")]
        public String TickerSymbol { get; set; }

        public Decimal StockPrice { get; set; }

        [Display(Name = "Quantity of Stock:")]
        [Required(ErrorMessage = "You must select at least one stock")]
        public Int32 SharesQuantity { get; set; }

        public Decimal StockBalance
        {
            get
            {
                return SharesQuantity * StockPrice;
            }
        }
        public StockType StockType { get; set; }

    }
}
