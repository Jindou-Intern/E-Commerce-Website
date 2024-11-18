

using System.ComponentModel.DataAnnotations;

namespace Shop_Tech_Shared_Library.DTOs
{
    public class LoginDTO
    {
        [Required,EmailAddress,DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required, DataType(DataType.Password)]

        public string? Password { get; set; }

    }
}
