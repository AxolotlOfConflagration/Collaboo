using Collaboo.App.WebAPI.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Collaboo.App.WebAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=elmer.db.elephantsql.com;Database=zzvkyspj;Username=zzvkyspj;Password=BJmqMK84NkJ6eD97xXGzZBLmiZOB4Se8") ;
        
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkills> UserSkills { get; set; }
    }

}
