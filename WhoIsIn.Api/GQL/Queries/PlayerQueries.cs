using WhoIsIn.Api.Mapping;
using WhoIsIn.Api.Repositories.Contracts;
using WhoIsIn.Models.Dtos;

namespace WhoIsIn.Api.GQL.Queries;

public partial class Queries
{
    public async Task<PlayerDto> GetById([Service] IPlayerRepository repository, Guid id)
    {
        var player = await repository.GetById(id);
        return player.ToData();
    }
}