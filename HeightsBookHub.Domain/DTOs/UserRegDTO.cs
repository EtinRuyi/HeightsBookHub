﻿using HeightsBookHub.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace HeightsBookHub.Domain.DTOs
{
    public class UserRegDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public Gender Gender { get; set; }
    }
}
