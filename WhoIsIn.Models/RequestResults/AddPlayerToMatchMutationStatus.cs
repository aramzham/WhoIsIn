using WhoIsIn.Models.Dtos;
using WhoIsIn.Models.RequestResults.Base;

namespace WhoIsIn.Models.RequestResults;

public class AddPlayerToMatchMutationStatus : BaseGqlResponse
{
    public MatchDto? Match { get; set; }
}