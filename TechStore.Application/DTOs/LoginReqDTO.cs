
using System.ComponentModel.DataAnnotations;

namespace TechStore.Application.DTOs
{
    public class LoginReqDTO
    {
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
