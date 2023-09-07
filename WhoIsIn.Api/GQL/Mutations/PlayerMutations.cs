using WhoIsIn.Api.GQL.Models.ObjectTypes.InputObjectTypes;
using WhoIsIn.Api.GQL.Models.RequestResults;
using WhoIsIn.Api.Mapping;
using WhoIsIn.Api.Repositories.Contracts;
using WhoIsIn.Models;

namespace WhoIsIn.Api.GQL.Mutations;

public partial class Mutations
{
    public async Task<CreatePlayerMutationStatus> CreatePlayer([Service] IPlayerRepository repository, [GraphQLNonNullType] CreatePlayerInput input)
    {
        var result = await repository.Create(input.Name, input.Email);
        
        return new CreatePlayerMutationStatus()
        {
            Result = RequestResult.Success,
            Player = result.ToData(),
            Message = "Player successfully created!!"
        };
    }

    public async Task<SetPlayerNicknameMutationStatus> SetPlayerNickname([Service] IPlayerRepository repository, [GraphQLNonNullType] SetPlayerNicknameInput input)
    {
        var result = await repository.SetNickname(input.PlayerId, input.Nickname);
        
        return new SetPlayerNicknameMutationStatus()
        {
            Result = RequestResult.Success,
            Player = result.ToData(),
            Message = "Player nickname successfully set!!"
        };
    }
}