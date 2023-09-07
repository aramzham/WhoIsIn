using Microsoft.AspNetCore.Components;
using WhoIsIn.Web.Services.Contracts;

namespace WhoIsIn.Web.Pages;

public class MatchBase : ComponentBase
{
    [Inject] public IMatchService MatchService { get; set; }

    public async void ButtonOnClick()
    {
        await MatchService.Create();
    }

    public string ButtonText { get; set; } = "Create match";
}