using HeightsBookHub.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HeightsBookHub.Persistence.DbContext
{
    public class HeightsBHDbContext : IdentityDbContext<User>
    {
        public HeightsBHDbContext(DbContextOptions<HeightsBHDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
