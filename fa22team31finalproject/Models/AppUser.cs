using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public enum isActive { Active, Inactive }
    public class AppUser : IdentityUser
    {
        [Display(Name = "First Name:")]
        [Required(ErrorMessage = "First name is required.")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name:")]
        [Required(ErrorMessage = "Last name is required.")]
        public String LastName { get; set; }

        [Display(Name = "User Name:")]
        public String FullName
        {
            get { return FirstName + " " + LastName; }
        }

        [Display(Name = "Address ((street, city, & state):")]
        [Required(ErrorMessage = "Address is required.")]
        public String Address { get; set; }

        [Display(Name = "Birthday (MM/DD/YYYY):")]
        [Required(ErrorMessage = "Birthday is required.")]
        public String Birthday { get; set; }

        [Display(Name = "Account Status:")]
        public isActive AccStatus { get; set; }
    }
}
