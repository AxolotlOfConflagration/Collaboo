namespace Collaboo.App.WebAPI.Entities
{
    public class ProjectMember
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}