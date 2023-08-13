using Humanizer;
using Microsoft.EntityFrameworkCore;
using WhoIsIn.Api.Data;
using WhoIsIn.Api.Data.Models;
using WhoIsIn.Api.Repositories.Contracts;

namespace WhoIsIn.Api.Repositories;

public class MatchRepository : BaseRepository, IMatchRepository
{
    public MatchRepository(AppDbContext db) : base(db)
    {
    }

    public Task<Match> GetById(Guid id)
    {
        return _db.Matches.FirstOrDefaultAsync(x => x.Id == id);
    }

    public Task<List<Match>> GetAll()
    {
        return _db.Matches.ToListAsync();
    }

    public async Task<Match> Create(DateTime startTime, string location, decimal price)
    {
        var result = await _db.Matches.AddAsync(new Match
        {
            StartTime = startTime,
            Location = location,
            Price = price,
            Name = $"{startTime.ToOrdinalWords()}, {location}, {price}€",
            EndTime = startTime + 1.5.Hours()
        });

        await _db.SaveChangesAsync();

        return result.Entity;
    }

    public async Task<Match> AddPlayer(Guid matchId, Guid playerId)
    {
        var match = await _db.Matches.Include(x => x.Players).FirstOrDefaultAsync(x => x.Id == matchId);
        var player = await _db.Players.FirstOrDefaultAsync(x => x.Id == playerId);
        
        match.Players.Add(player);
        
        await _db.SaveChangesAsync();

        return match;
    }
}