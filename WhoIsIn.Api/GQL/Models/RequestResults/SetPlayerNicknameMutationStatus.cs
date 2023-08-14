using WhoIsIn.Api.GQL.Models.RequestResults.Base;
using WhoIsIn.Api.Services.Models;

namespace WhoIsIn.Api.GQL.Models.RequestResults;

public class SetPlayerNicknameMutationStatus : BaseGqlResponse
{
    public PlayerDto Player { get; set; }
}