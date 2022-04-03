﻿using System.ComponentModel.DataAnnotations;

namespace TestApi.ViewModels
{
    public class AuthModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}