using Collaboo.App.WebAPI.Entities;
using Collaboo.App.WebAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collaboo.App.WebAPI.Services.Interfaces
{
    public interface ISkillsServices
    {
        Task<IEnumerable<Skill>> GetSkills();
        Task<Skill> GetSkill(int id);
        Task<IEnumerable<UserSkills>> GetSkillsForUser(int id);
        Task AddSkill(Skill skill);
        Task AddSkillForUser(UserSkills userSkill);
    }
}
