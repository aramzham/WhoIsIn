using WhoIsIn.Models;
using WhoIsIn.Models.Dtos;

namespace WhoIsIn.Web.Services.Contracts;

public interface IMatchService
{
    Task<MatchDto?> Create(DateTime startTime, string location, decimal price);
    Task<List<MatchDto>> GetAll();
}