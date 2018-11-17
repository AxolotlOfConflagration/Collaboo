using Collaboo.App.WebAPI.DbContexts;
using Collaboo.App.WebAPI.Models;
using Collaboo.App.WebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Collaboo.App.WebAPI.Entities;
using Microsoft.EntityFrameworkCore;

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

        public async Task AddSkillForUser(AddUserSkillDTO userSkillDto, int userId)
        {
            var skill = _context.Skills
                .FirstOrDefault(s => s.SkillName
                    .Equals(userSkillDto.SkillName, StringComparison.OrdinalIgnoreCase));
            if(skill != null)
            {
                var userSkill = await _context.UserSkills
                    .Include(us => us.Skill)
                    .FirstOrDefaultAsync(us => us.UserId == userId && us.Skill.SkillName.Equals(userSkillDto.SkillName));
                if(userSkill == null)
                {
                    _context.UserSkills.Add(new UserSkills 
                    {
                        UserId = userId,
                        SkillId = skill.Id,
                        Rating = userSkillDto.Rating
                    });
                }

            }
            else
            {
                    _context.UserSkills.Add(new UserSkills 
                    {
                        UserId = userId,
                        Skill = new Skill
                        {
                            SkillName = userSkillDto.SkillName
                        },
                        Rating = userSkillDto.Rating
                });

            }
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
