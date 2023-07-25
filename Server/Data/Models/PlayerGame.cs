namespace Server.Data.Models
{
    public class PlayerGame
    {
        public Guid PlayerGameId { get; set; }
        public Guid UserId { get; set; }
        public Guid GameId { get; set; }
        public int Score { get; set; }
        public User User { get; set; }
        public Game Game { get; set; }
    }
}
