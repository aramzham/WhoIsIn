using WhoIsIn.Api.GQL.Models.RequestResults.Base;
using WhoIsIn.Models.Dtos;

namespace WhoIsIn.Api.GQL.Models.RequestResults;

public class AddPlayerToMatchMutationStatus : BaseGqlResponse
{
    public MatchDto? Match { get; set; }
}