﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoManager.Models.Users
{
    public class CreateVM
    {
        [DisplayName("Username: ")]
        [Required(ErrorMessage = "This field is Required!")]
        public string Username { get; set; }

        [DisplayName("Password: ")]
        [Required(ErrorMessage = "This field is Required!")]
        public string Password { get; set; }

        [DisplayName("First Name: ")]
        [Required(ErrorMessage = "This field is Required!")]
        public string FirstName { get; set; }

        [DisplayName("Last Name: ")]
        [Required(ErrorMessage = "This field is Required!")]
        public string LastName { get; set; }
        
        
        [DisplayName("Admin? ")]
        [Required(ErrorMessage = "This field is Required!")]
        public bool IsAdmin { get; set; }
    }
}
