namespace RzutkarzeApi.Models;

public sealed class Match
{
    public Guid Id { get; set; }
    public string GameType { get; set; } = "501";
    public DateTimeOffset PlayedAt { get; set; } = DateTime.UtcNow;
    public int? WinnerId { get; set; }
    public bool IsCompleted { get; set; }

    public ICollection<MatchPlayer> MatchPlayers { get; set; } = new List<MatchPlayer>();
    public ICollection<ThrowRecord> ThrowRecords { get; set; } = new List<ThrowRecord>();
}