
using Microsoft.EntityFrameworkCore;
using Blazor.Data.Entities;

namespace Blazor.Data
{
    public class BlazorContext : DbContext
    {
        public BlazorContext(DbContextOptions<BlazorContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }

        public DbSet<Question> Questions { get; set; }

    }
}
