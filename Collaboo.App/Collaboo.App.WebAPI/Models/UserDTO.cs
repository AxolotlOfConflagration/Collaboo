using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collaboo.App.WebAPI.Models
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public int GitHubId { get; set; }
        public string AvatarUrl { get; set; }

        public IEnumerable<UserSkillDTO> Skills { get; set; }
    }
}
