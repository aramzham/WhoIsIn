using WhoIsIn.Api.Data.Models;
using WhoIsIn.Models.Dtos;

namespace WhoIsIn.Api.Mapping;

public static class DataToDto
{
    public static Match ToDto(this MatchDto matchDto)
    {
        return new()
        {
            Id = matchDto.Id,
            Description = matchDto.Description,
            Name = matchDto.Description,
            StartTime = matchDto.StartTime,
            EndTime = matchDto.EndTime,
            Location = matchDto.Location,
            State = matchDto.State,
            Price = matchDto.Price,
            Players = matchDto.Players.Select(ToDto).ToList()
        };
    }

    public static Player ToDto(this PlayerDto playerDto)
    {
        return new()
        {
            Id = playerDto.Id,
            Name = playerDto.Name,
            Bio = playerDto.Bio,
            City = playerDto.City,
            Country = playerDto.Country,
            Email = playerDto.Email,
            Nickname = playerDto.Nickname,
            AvatarUrl = playerDto.AvatarUrl,
            BirthDate = playerDto.BirthDate
        };
    }
}