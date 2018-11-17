using Collaboo.App.WebAPI.DbContexts;
using Collaboo.App.WebAPI.Models;
using Collaboo.App.WebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Collaboo.App.WebAPI.Entities;

namespace Collaboo.App.WebAPI.Services
{
    public class SkillsServices : ISkillsServices
    {
        private readonly ApplicationDbContext _context;

        public SkillsServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddSkill(Skill skill)
        {
            _context.Skills.Add(skill);
            return _context.SaveChangesAsync();
        }

        public Task AddSkillForUser(UserSkills userSkill)
        {
            _context.UserSkills.Add(userSkill);
        }

        public IEnumerable<Skill> GetSkills()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserSkills> GetSkillsForUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
