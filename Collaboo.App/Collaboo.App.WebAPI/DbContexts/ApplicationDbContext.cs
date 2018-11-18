using Bogus;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var faker = new Faker();

            const int skillIdBegin = 1;

            const int userIdBegin = 1;
            const int userIdCount = 100;
            const int userSkillIdBegin = 1;

            const int projectIdBegin = 1;
            const int projectIdCount = 20;
            const int projectRequirementsIdBegin = 1;

            var skills = new[] { "C#", "Haskel", "Swift", "Java", "R", "PHP", "Assembly", "Go", "Ruby", "Perl", "MS-SQL", "JavaScript", "TypeScript", "C", "C++", "Python", "PL/SQL", "MongoDb", "Lisp", "Prolog", "D", "Rust", "Android", ".Net" };
            int skillId = skillIdBegin;
            foreach (var skill in skills)
            {
                modelBuilder.Entity<Skill>().HasData(
                    new Skill { Id = skillId, SkillName = skill }
                    );

                skillId++;
            }

            for (int id = userIdBegin; id <= userIdBegin + userIdCount; id++)
            {
                modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = id,
                        Login = faker.Internet.UserName()
                    });
            }

            int userSkillId = userSkillIdBegin;
            for (int id = userIdBegin; id <= userIdBegin + userIdCount; id++)
            {
                var list = new List<UserSkills>();

                //for (int j = 0; j < faker.Random.Int(0, 5); j++)
                {
                    modelBuilder.Entity<UserSkills>().HasData(new UserSkills
                    {
                        Id = userSkillId,
                        Rating = faker.Random.Int(1, 5),
                        SkillId = faker.Random.Int(1, skills.Length-1),
                        UserId = id
                    });
                    userSkillId++;
                }
            }

            for (int id = projectIdBegin; id <= projectIdBegin + projectIdCount; id++)
            {
                modelBuilder.Entity<Project>().HasData(new Project
                {
                    Id = id,
                    Description = faker.Lorem.Sentences(faker.Random.Int(5, 20), ". "),
                    OwnerId = faker.Random.Int(1, 100),
                    ProjectName = faker.Internet.DomainName()
                });
            }

            int projectRequirementsId = projectRequirementsIdBegin;
            for (int id = projectIdBegin; id <= projectIdBegin + projectIdCount; id++)
            {
                //for (int i = 0; i < faker.Random.Int(0, 5); i++)
                {
                    modelBuilder.Entity<ProjectRequirement>().HasData(new ProjectRequirement
                    {
                        Id = projectRequirementsId,
                        Rating = faker.Random.Int(1, 5),
                        SkillId = faker.Random.Int(1, skills.Length - 1)
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
