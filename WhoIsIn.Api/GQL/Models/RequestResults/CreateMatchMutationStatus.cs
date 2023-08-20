using WhoIsIn.Api.GQL.Models.RequestResults.Base;
using WhoIsIn.Api.Services.Models;

namespace WhoIsIn.Api.GQL.Models.RequestResults;

public class CreateMatchMutationStatus : BaseGqlResponse
{
    public MatchDto? Match { get; set; }
}