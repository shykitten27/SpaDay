using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 characters long.")]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters long.")]
        //[Compare("VerifyPassword", ErrorMessage = "Password and Confirm Password must match!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "VerifyPassword is required.")]
        [Compare(nameof (Password), ErrorMessage = "Password and Confirm Password must match!")] //check two passwords are equal - this is magic string
        public string VerifyPassword { get; set; }
    }
}
