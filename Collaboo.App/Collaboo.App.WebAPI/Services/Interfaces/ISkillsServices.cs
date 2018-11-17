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
        IEnumerable<Skill> GetSkills();
        Skill GetSkill(int id);
        IEnumerable<UserSkills> GetSkillsForUser(int id);
        Task AddSkill(Skill skill);
        Task AddSkillForUser(AddUserSkillDTO userSkillDto, int userId);
    }
}
