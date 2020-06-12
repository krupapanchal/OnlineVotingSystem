using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VotingSystem.Models
{
    public class AdminLoginModel
    {
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage = "please enter email")]
        public string AEmail { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "password should be 8 character", MinimumLength = 8)]
        public string APassward { get; set; }
    }
}