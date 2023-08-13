using WhoIsIn.Api.Data.Models;

namespace WhoIsIn.Api.Repositories.Contracts;

public interface IPlayerRepository
{
    Task<Player> GetById(Guid id);
    Task<Player> Create(string name, string email);
}