using MaluFlix.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MaluFlix.Data;
    public class AppDbContext: IdentityDbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
         public DbSet<AppUser> AppUsers { get; set; }
    }
