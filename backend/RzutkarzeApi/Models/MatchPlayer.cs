namespace RzutkarzeApi.Models;

public sealed class MatchPlayer
{
    public Guid Id { get; set; }
    public Guid MatchId { get; set; }
    public Match Match { get; set; } = null!;
    
    public Guid PlayerId { get; set; }
    public Player Player { get; set; } = null!;

    public int InitialOrder { get; set; }
    public int CurrentScore { get; set; }
    public int? FinalRank { get; set; }
}