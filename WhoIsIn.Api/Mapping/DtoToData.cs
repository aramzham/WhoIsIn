using WhoIsIn.Api.Data.Models;
using WhoIsIn.Api.Services.Models;

namespace WhoIsIn.Api.Mapping;

public static class DtoToData
{
    public static MatchDto ToData(this Match matchData)
    {
        return new()
        {
            Id = matchData.Id,
            Description = matchData.Description,
            Name = matchData.Name,
            StartTime = matchData.StartTime,
            EndTime = matchData.EndTime,
            Location = matchData.Location,
            State = matchData.State,
            Price = matchData.Price,
            Players = matchData.Players.Select(ToData).ToList()
        };
    }

    public static PlayerDto ToData(this Player playerData)
    {
        return new()
        {
            Id = playerData.Id,
            Name = playerData.Name,
            Bio = playerData.Bio,
            City = playerData.City,
            Country = playerData.Country,
            Email = playerData.Email,
            Nickname = playerData.Nickname,
            AvatarUrl = playerData.AvatarUrl,
            BirthDate = playerData.BirthDate
        };
    }
}