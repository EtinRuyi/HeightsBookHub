using HeightsBookHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightsBookHub.Persistence.Repository.Interface
{
    public interface IAuthenticationRepository
    {
        Task<bool> AddUser(User user, string password);
        Task<User> GetUserByEmail(string email);
    }
}
