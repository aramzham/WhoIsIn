using WhoIsIn.Models.Dtos;
using WhoIsIn.Web.Services.Contracts;

namespace WhoIsIn.Web.Services;

public class MatchService : IMatchService
{
    private readonly IWhoIsInWebGraphQLClient _graphqlClient;

    public MatchService(IWhoIsInWebGraphQLClient graphqlClient)
    {
        _graphqlClient = graphqlClient;
    }

    public async Task<MatchDto?> Create(DateTime startTime, string location, decimal price)
    {
        var result = await _graphqlClient.GenerateMatch.ExecuteAsync(startTime, location, price);

        return new MatchDto()
        {
            Location = result.Data.CreateMatch.Match.Location,
            StartTime = result.Data.CreateMatch.Match.StartTime.DateTime,
            Description = result.Data.CreateMatch.Match.Description,
            Price = result.Data.CreateMatch.Match.Price,
            Id = result.Data.CreateMatch.Match.Id,
            Name = result.Data.CreateMatch.Match.Name,
            State = (Models.MatchState)result.Data.CreateMatch.Match.State,
            EndTime = result.Data.CreateMatch.Match.EndTime.DateTime
        };
    }

    public async Task<List<MatchDto>> GetAll()
    {
        var result = await _graphqlClient.GetAllMatches.ExecuteAsync();

        return result.Data.AllMatches.Select(x => new MatchDto()
        {
            Location = x.Location,
            StartTime = x.StartTime.DateTime,
            Description = x.Description,
            Price = x.Price,
            Id = x.Id,
            Name = x.Name,
            State = (Models.MatchState)x.State,
            EndTime = x.EndTime.DateTime
        }).ToList();
    }
}