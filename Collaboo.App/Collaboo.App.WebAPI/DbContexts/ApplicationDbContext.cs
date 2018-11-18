using Bogus;
using Collaboo.App.WebAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Collaboo.App.WebAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var faker = new Faker();

            var skills = new[] { "C#", "Haskel", "Swift", "Java", "R", "PHP", "Assembly", "Go", "Ruby", "Perl", "MS-SQL", "JavaScript", "TypeScript", "C", "C++", "Python", "PL/SQL", "MongoDb", "Lisp", "Prolog", "D", "Rust", "Android", ".Net" };
            int skillId = 1;
            foreach (var skill in skills)
            {
                modelBuilder.Entity<Skill>().HasData(
                    new Skill { Id = skillId, SkillName = skill }
                    );

                skillId++;
            }

            for (int i = 1; i < 101; i++)
            {
                modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = i,
                        Login = faker.Internet.UserName()
                    }
                    );
            }

            int userSkillId = 1;
            foreach (var user in Users)
            {
                for (int i = 0; i < faker.Random.Int(0, 5); i++)
                {
                    modelBuilder.Entity<UserSkills>().HasData(new UserSkills
                    {
                        Id = userSkillId,
                        Rating = faker.Random.Int(0, 5),
                        SkillId = faker.PickRandom(Skills, 1).FirstOrDefault().Id,
                        UserId = user.Id
                    });
                    userSkillId++;
                }
            }

            for (int i = 1; i < 21; i++)
            {
                modelBuilder.Entity<Project>().HasData(new Project
                {
                    Id = i,
                    Description = faker.Lorem.Sentences(faker.Random.Int(5, 20)),
                    OwnerId = faker.PickRandom(Users, 1).FirstOrDefault().Id,
                    ProjectName = faker.Internet.DomainName()
                });
            }

            int projectRequirementsId = 1;
            foreach (var proj in Projects)
            {
                for (int i = 0; i < faker.Random.Int(0, 5); i++)
                {
                    modelBuilder.Entity<ProjectRequirement>().HasData(new ProjectRequirement
                    {
                        Id = projectRequirementsId,
                        Rating = faker.Random.Int(1, 5),
                        SkillId = faker.PickRandom(Skills, 1).FirstOrDefault().Id
                    });

                    projectRequirementsId++;
                }
            }
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
