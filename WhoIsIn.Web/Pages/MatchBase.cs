using Microsoft.AspNetCore.Components;
using WhoIsIn.Models.Dtos;
using WhoIsIn.Web.Services.Contracts;

namespace WhoIsIn.Web.Pages;

public class MatchBase : ComponentBase
{
    protected string searchString1 = "";
    protected MatchDto selectedItem1 = null;
    protected HashSet<MatchDto> selectedItems = new();
    protected bool FilterFunc1(MatchDto element) => FilterFunc(element, searchString1);

    [Inject] public IMatchService MatchService { get; set; }

    public List<MatchDto> Matches { get; set; }

    public string ButtonText { get; set; } = "Create match";

    public async void ButtonOnClick()
    {
        var r = new Random();
        var match = await MatchService.Create(DateTime.Now, $"{r.Next(0, 100)} place", r.Next(0, 50));
        if (match is not null)
            Matches.Add(match);
    }

    protected override async Task OnInitializedAsync()
    {
        Matches = await MatchService.GetAll();
    }

    private bool FilterFunc(MatchDto element, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (element.Description.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if ($"{element.Name} {element.Description} {element.Location}".Contains(searchString))
            return true;
        return false;
    }
}