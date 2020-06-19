﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoManager.Models.Users
{
    public class EditVM
    {
        public int Id { get; set; }

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

        public bool IsAdmin { get; set; }
    }
}
