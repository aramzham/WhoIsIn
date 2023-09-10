using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using WhoIsIn.Web;
using WhoIsIn.Web.Services;
using WhoIsIn.Web.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddMudServices();

builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddWhoIsInWebGraphQLClient()
    .ConfigureHttpClient(httpClient => httpClient.BaseAddress = new Uri(builder.Configuration["GraphQLURI"]!));

// services
builder.Services.AddTransient<IMatchService, MatchService>();

await builder.Build().RunAsync();