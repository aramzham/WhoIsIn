using WhoIsIn.Models;
using WhoIsIn.Models.Dtos;

namespace WhoIsIn.Web.Services.Contracts;

public interface IMatchService
{
    Task<MatchDto?> Create(CreateMatchInput input);
    Task<List<MatchDto>> GetAll();
}