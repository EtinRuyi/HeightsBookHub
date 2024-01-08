//using HeightsBookHub.Domain.Entities;
//using HeightsBookHub.Domain.Enums;
//using HeightsBookHub.Persistence.DbContext;
//using Microsoft.AspNetCore.Identity;

//namespace HeightsBookHub.Persistence.Seeders
//{
//    public class UserSeeder
//    {
//        private readonly HeightsBHDbContext _dbContext;
//        private readonly UserManager<User> _userManager;

//        public UserSeeder(UserManager<User> userManager, HeightsBHDbContext dbContext)
//        {
//            _userManager = userManager;
//            _dbContext = dbContext;
//        }

//        public async Task SeedUsersAsync()
//        {
//            if (!_userManager.Users.Any())
//            {
//                var users = new[]
//                {
//                    new User
//                    {
//                        UserName = "Etin",
//                        Email = "etin@heights.com",
//                        FirstName = "Etinosa",
//                        LastName = "Omoruyi",
//                        Gender = Gender.Male
//                    },
//                    new User
//                    {
//                        UserName = "Ogoh",
//                        Email = "ogoh@gmail.com",
//                        FirstName = "Ogochukwu",
//                        LastName = "Azuju",
//                        Gender = Gender.Female
//                    },
//                };

//                foreach (var user in users)
//                {
//                    await _userManager.CreateAsync(user, "Password123");
//                }
//                await _dbContext.SaveChangesAsync();
//            }
//        }
//    }
//}
