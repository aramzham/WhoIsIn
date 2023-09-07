using WhoIsIn.Models.Dtos;

namespace WhoIsIn.Web.Services.Contracts;

public interface IMatchService
{
    Task<MatchDto> Create();
}