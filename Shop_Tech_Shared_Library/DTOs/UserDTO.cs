﻿using System.ComponentModel.DataAnnotations;

namespace Shop_Tech_Shared_Library.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        [Required]

        public string? Name { get; set; }
        [Required,EmailAddress]

        public string? Email { get; set; }
        [Required, DataType(DataType.Password)]

        public string? Password { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password))]

        public string? ConfirmPassword { get; set; }
    }
}