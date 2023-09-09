using WhoIsIn.Models.Dtos;
using WhoIsIn.Models.RequestResults.Base;

namespace WhoIsIn.Models.RequestResults;

public class SetPlayerNicknameMutationStatus : BaseGqlResponse
{
    public PlayerDto Player { get; set; }
}