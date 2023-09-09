namespace WhoIsIn.Models.RequestResults.Base;

public abstract class BaseGqlResponse
{
    public RequestResult Result { get; set; }
    public string Message { get; set; }
    public IEnumerable<ErrorModel>? Errors { get; set; }
}