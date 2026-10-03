using Microsoft.EntityFrameworkCore;
using RzutkarzeApi.Models;

namespace RzutkarzeApi.Data;

public sealed class RzutkarzeDbContext : DbContext
{
    public RzutkarzeDbContext(DbContextOptions<RzutkarzeDbContext> options) : base(options)
    {
    }

    public DbSet<Player> Players => Set<Player>();
    public DbSet<Match> Matches => Set<Match>();
    public DbSet<MatchPlayer> MatchPlayers => Set<MatchPlayer>();
    public DbSet<ThrowRecord> ThrowRecords => Set<ThrowRecord>();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<MatchPlayer>()
            .HasOne(mp => mp.Match)
            .WithMany(m => m.MatchPlayers)
            .HasForeignKey(mp => mp.MatchId);

        modelBuilder.Entity<MatchPlayer>()
            .HasOne(mp => mp.Player)
            .WithMany(p => p.MatchPlayers)
            .HasForeignKey(mp => mp.PlayerId);

        modelBuilder.Entity<ThrowRecord>()
            .HasOne(tr => tr.Match)
            .WithMany(m => m.ThrowRecords)
            .HasForeignKey(tr => tr.MatchId);

        modelBuilder.Entity<ThrowRecord>()
            .HasOne(tr => tr.Player)
            .WithMany(p => p.ThrowRecords)
            .HasForeignKey(tr => tr.PlayerId);
    }
}