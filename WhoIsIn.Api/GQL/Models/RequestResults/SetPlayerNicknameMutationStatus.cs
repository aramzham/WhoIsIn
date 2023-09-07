using WhoIsIn.Api.GQL.Models.RequestResults.Base;
using WhoIsIn.Models.Dtos;

namespace WhoIsIn.Api.GQL.Models.RequestResults;

public class SetPlayerNicknameMutationStatus : BaseGqlResponse
{
    public PlayerDto Player { get; set; }
}