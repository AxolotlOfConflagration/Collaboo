using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collaboo.App.WebAPI.Models
{
    public class AddUserSkillDTO
    {
        public int SkillId { get; set; }
        public int UserId { get; set; }
        public string SkillName { get; set; }
        public int Rating { get; set; }
    }
}
