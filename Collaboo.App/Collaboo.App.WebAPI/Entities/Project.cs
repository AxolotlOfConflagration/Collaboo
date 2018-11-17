using System.Collections.Generic;

namespace Collaboo.App.WebAPI.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public int OwnerId { get; set; }
        public string Description { get; set; }
        public string GitHubRepoUrl { get; set; }
        public ICollection<ProjectRequirement> Requirements { get; set; }
        public ICollection<ProjectMember> ProjectMembers { get; set; }
    }
}