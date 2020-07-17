using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = " * required field")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = " * must be within 5-15 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = " * required field")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = " * must be within 6-20 characters")]
        public string Password { get; set; }
        [EmailAddress(ErrorMessage = "enter valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = " * required field")]

        [Compare("Password", ErrorMessage = " passwords do not match")]
        public string Verifypassword { get; set; }

        public AddUserViewModel(string username, string password, string email, string verifypassword)
        {
            Username = username;
            Password = password;
            Email = email;
            Verifypassword = verifypassword;
        }
        public AddUserViewModel(){}
    }
}
