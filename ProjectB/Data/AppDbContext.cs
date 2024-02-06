using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectB.Models;

namespace ProjectB.Data
{
    public class AppDbContext : IdentityDbContext<AppUser> //IdentityUser or custom(AppUser)
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
