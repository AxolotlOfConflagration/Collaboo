namespace Collaboo.App.WebAPI.Entities
{
    public class UserSkills
    {
        public int Id { get; set; }
        public int SkillId { get; set; }
        public int Rating { get; set; }
        public Skill Skill { get; set; }
    }
}