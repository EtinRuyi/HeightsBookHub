using HeightsBookHub.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace HeightsBookHub.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public Cart Cart { get; set; }
    }
}
