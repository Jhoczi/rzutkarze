namespace RzutkarzeApi.Models;

public sealed class Player
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool Active { get; set; } = true;

    public int MatchesPlayed { get; set; }
    public int MatchesWon { get; set; }

    public ICollection<MatchPlayer> MatchPlayers { get; set; } = new List<MatchPlayer>();
    public ICollection<ThrowRecord> ThrowRecords { get; set; } = new List<ThrowRecord>();
}