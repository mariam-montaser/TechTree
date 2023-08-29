﻿using System.ComponentModel.DataAnnotations;

namespace TechTree.Models
{
    public class LoginModel
    {
        [Required]
        [StringLength(100, MinimumLength = 6)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
        public string LoginInValid { get; set; }
    }
}
