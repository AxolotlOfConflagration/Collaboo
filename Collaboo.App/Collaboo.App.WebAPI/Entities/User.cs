using System.Collections.Generic;

namespace Collaboo.App.WebAPI.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int GitHubId { get; set; }
        public string Login { get; set; }

        public ICollection<UserSkills> UserSkills { get; set; }
    }
}