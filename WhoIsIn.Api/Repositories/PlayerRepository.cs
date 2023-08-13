using Microsoft.EntityFrameworkCore;
using WhoIsIn.Api.Data;
using WhoIsIn.Api.Data.Models;
using WhoIsIn.Api.Repositories.Contracts;

namespace WhoIsIn.Api.Repositories;

public class PlayerRepository : BaseRepository, IPlayerRepository
{
    public PlayerRepository(AppDbContext db) : base(db)
    {
    }

    public Task<Player> GetById(Guid id)
    {
        return _db.Players.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Player> Create(string name, string email)
    {
        var player = new Player
        {
            Name = name,
            Email = email
        };

        var result = await _db.Players.AddAsync(player);
        await _db.SaveChangesAsync();

        return result.Entity;
    }
}