namespace WhoIsIn.Models;

// match
public record CreateMatchInput(DateTime StartTime, string Location, decimal Price);
public record AddPlayerToMatchInput(Guid MatchId, Guid PlayerId);

// player
public record CreatePlayerInput(string Name, string Email);
public record SetPlayerNicknameInput(Guid PlayerId, string Nickname);
public record CancelParticipationInput(Guid PlayerId, Guid MatchId, string Reason);