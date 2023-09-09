namespace WhoIsIn.Models.RequestResults.Base;

public class ErrorModel
{
    public string Code { get; set; }
    public string Message { get; set; }
    public string Domain { get; set; }
    public IEnumerable<ErrorDetailModel> Details { get; set; }
}