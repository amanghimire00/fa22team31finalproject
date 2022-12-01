using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public class AppUser : IdentityUser
    {
        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "First name is required.")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "Last name is required.")]
        public String LastName { get; set; }

        [Display(Name = "Middle Initial:")]
        public String MI { get; set; }

        [Display(Name = "Full Name:")]
        public String FullName
        {
            get { return FirstName + " "+ MI+" " + LastName; }
        }

        [Display(Name = "Street Address:")]
        [Required(ErrorMessage = "Street Address is required.")]
        public String Address { get; set; }

        [Display(Name = "City:")]
        [Required(ErrorMessage = "City is required.")]
        public String City { get; set; }

        [Display(Name = "State:")]
        [Required(ErrorMessage = "State is required.")]
        public String State { get; set; }

        [Display(Name = "ZipCode:")]
        [Required(ErrorMessage = "ZipCode is required.")]
        public String ZipCode { get; set; }

        [Display(Name = "Address:")]
        public String FullAddress
        {
            get { return Address + ", " + City + ", "+ State+ ", "+ZipCode; }
        }

        [Display(Name = "Birthday (MM/DD/YYYY):")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Birthday is required.")]
        public DateTime DOB { get; set; }
        //Turn this into datetime
        public Boolean Fired { get; set; }
        public Boolean isActive { get; set; }

        public StockPortfolio StockPortfolio { get;  set; }

        public List<BankAccount> BankAccount { get; set; }
    }
}
