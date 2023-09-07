using WhoIsIn.Api.GQL.Models.RequestResults.Base;
using WhoIsIn.Models.Dtos;

namespace WhoIsIn.Api.GQL.Models.RequestResults;

public class RemovePlayerFromMatchMutationStatus : BaseGqlResponse
{
    public MatchDto Match { get; set; }
}