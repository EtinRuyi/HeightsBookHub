using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace HeightsBookHub.Persistence.Seeders
{
    public static class RoleSedder
    {
        public static void SeedRole(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                var role = new IdentityRole("Admin");
                roleManager.CreateAsync(role).Wait();
            }

            if (!roleManager.RoleExistsAsync("RegularUser").Result)
            {
                var role = new IdentityRole("RegularUser");
                roleManager.CreateAsync(role).Wait();
            }
        }
    }
}
