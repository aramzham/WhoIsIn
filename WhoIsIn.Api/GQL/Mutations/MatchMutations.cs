using WhoIsIn.Api.Dtos;
using WhoIsIn.Api.GQL.Models.ObjectTypes.InputObjectTypes;
using WhoIsIn.Api.GQL.Models.RequestResults;
using WhoIsIn.Api.GQL.Models.RequestResults.Base;
using WhoIsIn.Api.Mapping;
using WhoIsIn.Api.Repositories.Contracts;

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
                MatchDto = result.ToData(),
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
}