using HeightsBookHub.Domain.Entities;

namespace HeightsBookHub.Persistence.Repository.Interface
{
    public interface IAuthenticationRepository
    {
        Task<bool> AddUser(User user, string password);
        Task<User> GetUserByEmail(string email);
    }
}
