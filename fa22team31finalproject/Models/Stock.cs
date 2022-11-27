using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public class Stock
    {
        public Int32 StockID { get; set; }

        [Display(Name = "Quantity of Stock:")]
        [Required(ErrorMessage = "You must select at least one stock")]
        public Int32 SharesQuantity { get; set; }

        [Display(Name = "Name of Stock:")]
        [Required(ErrorMessage = "Your stock must have a name")]
        public string StockName { get; set; }

        public Decimal StockPrice { get; set; }

        public Decimal StockBalance
        {
            get
            {
                return SharesQuantity * StockPrice;
            }
        }

    }
}
