using WhoIsIn.Api.Mapping;
using WhoIsIn.Api.Repositories.Contracts;
using WhoIsIn.Models.Dtos;

namespace WhoIsIn.Api.GQL.Queries;

public partial class Queries
{
    private readonly ILogger<Queries> _logger;

    public Queries(ILogger<Queries> logger)
    {
        _logger = logger;
    }

    public async Task<List<MatchDto>> GetAllMatches([Service] IMatchRepository repository)
    {
        var matches = await repository.GetAll();
        return matches.Select(x => x.ToData()).ToList();
    }

    public async Task<MatchDto> GetMatchById([Service] IMatchRepository repository, Guid id)
    {
        var match = await repository.GetById(id);
        return  match.ToData();
    }
}