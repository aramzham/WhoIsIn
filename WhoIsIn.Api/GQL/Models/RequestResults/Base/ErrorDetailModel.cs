namespace WhoIsIn.Api.GQL.Models.RequestResults.Base;

public class ErrorDetailModel
{
    public string Code { get; set; }
    public string Message { get; set; }
    public string Target { get; set; }
}