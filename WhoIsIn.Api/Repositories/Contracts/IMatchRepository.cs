using WhoIsIn.Api.Data.Models;

namespace WhoIsIn.Api.Repositories.Contracts;

public interface IMatchRepository
{
    Task<Match> GetById(Guid id);
    Task<List<Match>> GetAll();
    Task<Match> Create(DateTime startTime, string location, decimal price);
    Task<Match> AddPlayer(Guid matchId, Guid playerId);
}