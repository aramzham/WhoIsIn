using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.SystemTextJson;
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

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IGraphQLClient>(s => new GraphQLHttpClient(builder.Configuration["GraphQLURI"]!, new SystemTextJsonSerializer()));

// services
builder.Services.AddTransient<IMatchService, MatchService>();

await builder.Build().RunAsync();