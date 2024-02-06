using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectA.Models;

namespace ProjectA.Data
{
    public class AppDbContext : IdentityDbContext<AppUser> //IdentityUser or custom(AppUser)
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
            
        }
    }
}
