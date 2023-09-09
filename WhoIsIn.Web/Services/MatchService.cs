using GraphQL;
using GraphQL.Client.Abstractions;
using WhoIsIn.Models;
using WhoIsIn.Models.Dtos;
using WhoIsIn.Models.RequestResults;
using WhoIsIn.Web.Services.Contracts;

namespace WhoIsIn.Web.Services;

public class MatchService : IMatchService
{
    private readonly IGraphQLClient _client;

    public MatchService(IGraphQLClient client)
    {
        _client = client;
    }

    public async Task<MatchDto?> Create(CreateMatchInput input)
    {
        var query = new GraphQLRequest
        {
            Query = """
                    mutation CreateMatch($input: CreateMatchInput!) {
                      createMatch(input: $input) {
                        match {
                          id
                          name
                          description
                          startTime
                          endTime
                          state
                          location
                          price
                        }
                        result
                        message
                        errors {
                          code
                          message
                          domain
                          details {
                            code
                            message
                            target
                          }
                        }
                      }
                    }
                    """,
            Variables = new { input }
        };

        var response = await _client.SendMutationAsync<CreateMatchMutationStatus>(query);
        return response.Data.Match;
    }

    public async Task<List<MatchDto>> GetAll()
    {
        var query = new GraphQLRequest
        {
            Query = """
                    query GetAllMatches{
                      allMatches{
                        id
                        name
                        description
                        startTime
                        endTime
                        state
                        location
                        price
                      }
                    }
                    """
        };

        var response = await _client.SendQueryAsync<List<MatchDto>>(query);
        return response.Data;
    }
}