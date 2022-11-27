using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public class StockType
    {
        [Display(Name = "Stock Type Name:")]
        [Required(ErrorMessage = "Stock Type Name is required.")]
        [StringLength(5, MinimumLength = 3, ErrorMessage = "Stock Ticker must be 3-5 characters!\r\n")]
        public String StockTypeName { get; set; }
    }
}
