namespace Collaboo.App.WebAPI.Entities
{
    public class ProjectRequirement
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}