using WhoIsIn.Api.GQL.Models.ObjectTypes.InputObjectTypes;
using WhoIsIn.Api.Mapping;
using WhoIsIn.Api.Repositories.Contracts;
using WhoIsIn.Models;
using WhoIsIn.Models.RequestResults;
using WhoIsIn.Models.RequestResults.Base;

namespace WhoIsIn.Api.GQL.Mutations;

public partial class Mutations
{
    public Mutations(ILogger<Mutations> logger)
    {
    }

    public async Task<CreateMatchMutationStatus> CreateMatch([Service] IMatchRepository repository,
        [GraphQLNonNullType] CreateMatchInput input)
    {
        try
        {
            var result = await repository.Create(input.StartTime, input.Location, input.Price);

            return new CreateMatchMutationStatus()
            {
                Result = RequestResult.Success,
                Match = result.ToData(),
                Message = "Match successfully created!!"
            };
        }
        catch (Exception e)
        {
            return new CreateMatchMutationStatus()
            {
                Result = RequestResult.Fail,
                Message = "Something went wrong",
                Errors = new[]
                {
                    new ErrorModel()
                    {
                        Message = e.Message,
                        Domain = "System",
                        Code = "500",
                    }
                }
            };
        }
    }

    public async Task<AddPlayerToMatchMutationStatus> AddPlayerToMatch([Service] IMatchRepository matchRepository,
        [GraphQLNonNullType] AddPlayerToMatchInput input)
    {
        var result = await matchRepository.AddPlayer(input.MatchId, input.PlayerId);

        return new AddPlayerToMatchMutationStatus
        {
            Result = RequestResult.Success,
            Match = result.ToData(),
            Message = "Player added to the match!!"
        };
    }

    public async Task<RemovePlayerFromMatchMutationStatus> RemovePlayerFromMatch(
        [Service] IMatchRepository matchRepository, [GraphQLNonNullType] CancelParticipationInput input)
    {
        var result = await matchRepository.CancelParticipation(input.MatchId, input.PlayerId, input.Reason);

        return new RemovePlayerFromMatchMutationStatus
        {
            Result = RequestResult.Success,
            Match = result.ToData(),
            Message = "Player removed from the match!!"
        };
    }
}