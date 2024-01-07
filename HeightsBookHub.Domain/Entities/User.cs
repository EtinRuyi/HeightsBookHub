using HeightsBookHub.Domain.Enums;
using Microsoft.AspNet.Identity.EntityFramework;

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
