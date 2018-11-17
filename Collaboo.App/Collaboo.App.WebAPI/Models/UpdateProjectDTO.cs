namespace Collaboo.App.WebAPI.Models
{
    public class UpdateProjectDTO
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string GitHubRepoUrl { get; set; }
    }
}