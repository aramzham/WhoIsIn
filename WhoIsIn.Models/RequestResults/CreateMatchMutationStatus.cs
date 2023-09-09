using WhoIsIn.Models.Dtos;
using WhoIsIn.Models.RequestResults.Base;

namespace WhoIsIn.Models.RequestResults;

public class CreateMatchMutationStatus : BaseGqlResponse
{
    public MatchDto? Match { get; set; }
}