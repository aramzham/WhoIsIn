namespace WhoIsIn.Api.Dtos;

public enum MatchState
{
    NotStarted,
    InProgress,
    Finished,
    Cancelled
}

public enum RequestResult
{
    Fail,
    Success
}