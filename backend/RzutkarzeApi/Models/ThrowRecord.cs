namespace RzutkarzeApi.Models;

public sealed class ThrowRecord
{
    public Guid Id { get; set; }
    public Guid MatchId { get; set; }
    public Match Match { get; set; } = null!;

    public Guid PlayerId { get; set; }
    public Player Player { get; set; } = null!;

    public int RoundNumber { get; set; }
    public int ScoreThrown { get; set; }
    public int ScoreLeft { get; set; }
}