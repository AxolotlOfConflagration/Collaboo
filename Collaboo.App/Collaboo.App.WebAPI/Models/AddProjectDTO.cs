using System.Collections.Generic;

namespace Collaboo.App.WebAPI.Models
{
    public class AddProjectDTO : ProjectDTO
    {
        public string GitHubRepoUrl { get; set; }
    }
}