using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collaboo.App.WebAPI.Models
{
    public class UserSkillDTO
    {
        public int Id { get; set; }
        public int SkillId { get; set; }
        public int Rating { get; set; }
        public SkillDTO Skill { get; set; }
        public int UserId { get; set; }
    }
}
