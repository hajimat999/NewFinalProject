﻿using System.ComponentModel.DataAnnotations;

namespace FinallyFinalProject.HomeVModels
{
    public class RegisterVModel
    {
        [Required, StringLength(30)]
        public string FirstName { get; set; }
        [Required, StringLength(30)]
        public string LastName { get; set; }
        [Required, StringLength(30)]
        public string UserName { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
