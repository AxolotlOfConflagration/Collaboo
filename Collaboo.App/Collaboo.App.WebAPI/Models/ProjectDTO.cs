using System.Collections.Generic;

namespace Collaboo.App.WebAPI.Models
{
    public class ProjectDTO
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public IEnumerable<ProjectRequirementDTO> Requirements { get; set; }
    }
}