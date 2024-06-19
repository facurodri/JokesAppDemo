using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JokesAppDemo.Models;

namespace JokesAppDemo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("aspnet-JokesAppDemo-cb0b107c-dc0f-4bc0-949f-32247316eb72");
        //}
        public DbSet<JokesAppDemo.Models.Joke> Joke { get; set; } = default!;
    }
}
