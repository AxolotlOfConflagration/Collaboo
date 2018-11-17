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

        public async Task AddSkillForUser(UserSkills userSkill)
        {
            _context.UserSkills.Add(userSkill);
            await _context.SaveChangesAsync();
        }

        public Skill GetSkill(int id)
        {
            return _context.Skills.Where(s => s.Id == id).FirstOrDefault();
        }

        public IEnumerable<Skill> GetSkills()
        {
            return _context.Skills;
        }

        public IEnumerable<UserSkills> GetSkillsForUser(int id)
        {
            return _context.UserSkills.Where(s => s.UserId == id);
        }
    }
}
