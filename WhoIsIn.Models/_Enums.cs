namespace WhoIsIn.Models;

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