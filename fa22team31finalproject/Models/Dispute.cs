using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace fa22team31finalproject.Models
{
    public enum DisputeStatus { Incomplete, Submitted }
    public class Dispute
    {
        public Int32 DisputeID { get; set; }

        [Display(Name = "Dispute Status:")]
        //public isActive AcccountStatus { get; set; }
        public DisputeStatus DisputeStatus { get; set; }
    }
}
