using HeightsBookHub.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace HeightsBookHub.Domain.DTOs
{
    public class UserReturnDto
    {
        public string Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public Gender Gender { get; set; }
    }
}
