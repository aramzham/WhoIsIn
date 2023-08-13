using WhoIsIn.Api.GQL.Models.RequestResults.Base;
using WhoIsIn.Api.Services.Models;

namespace WhoIsIn.Api.GQL.Models.RequestResults;

public class AddPlayerToMatchMutationStatus : BaseGqlResponse
{
    public MatchDto? Match { get; set; }
}