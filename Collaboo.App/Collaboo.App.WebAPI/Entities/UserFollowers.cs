namespace Collaboo.App.WebAPI.Entities
{
    public class UserFollowers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        
        public int FollowerId { get; set; }
        public Follower Follower { get; set; }
    }
}