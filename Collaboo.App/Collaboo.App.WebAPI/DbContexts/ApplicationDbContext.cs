using Collaboo.App.WebAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Collaboo.App.WebAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=elmer.db.elephantsql.com;Database=zzvkyspj;Username=zzvkyspj;Password=BJmqMK84NkJ6eD97xXGzZBLmiZOB4Se8");

        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkills> UserSkills { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectMember> ProjectMember { get; set; }
        public DbSet<ProjectRequirement> ProjectRequirments { get; set; }
        public DbSet<UserFollowers> UserFollowers { get; set; }
        public DbSet<Follower> Followers { get; set; }
    }

}
