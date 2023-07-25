namespace Server.Data.Models
{
    public class Game
{
    public Guid GameId { get; set; }
    public Guid HoopId { get; set; }
    public string GameType { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool IsInProgress { get; set; }

    public Hoop Hoop { get; set; }
    public List<PlayerGame> PlayerGames { get; set; }
}
}
