using Microsoft.EntityFrameworkCore;
using WhoIsIn.Api.Data;
using WhoIsIn.Api.GQL.Models.ObjectTypes.InputObjectTypes;
using WhoIsIn.Api.GQL.Mutations;
using WhoIsIn.Api.GQL.Queries;
using WhoIsIn.Api.Repositories;
using WhoIsIn.Api.Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextPool<AppDbContext>(o => o.UseSqlite("Data Source=WhoIsIn.db"));

// repositories
builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
builder.Services.AddScoped<IMatchRepository, MatchRepository>();

// gql
builder.Services.AddGraphQLServer()
    .AddQueryType<Queries>()
    .AddMutationType<Mutations>()
    .AddType<AddPlayerToMatchInputType>()
    .AddType<CreateMatchInputType>()
    .AddType<CreatePlayerInputType>();

var app = builder.Build();

app.MapGraphQL();

app.Run();