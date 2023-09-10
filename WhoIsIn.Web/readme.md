To configure StrawberryShake GraphQL client:
- start with adding new tool manifest file
```bash 
 dotnet new tool-manifest
```
- then locally install StrawberryShake.Tools
```shell
dotnet tool install StrawberryShake.Tools --local
```
- add the ```StrawberryShake.Server``` nuget package for code generation
```shell
dotnet add WhoIsIn.Web package StrawberryShake.Server
```
- initialize the client with the server url
```shell
dotnet graphql init https://localhost:7077/graphql
```
- set the name and namespace of the client in ```.graphqlrc.json``` file
```json lines
"name": "WhoIsInWebGraphQLClient",
"namespace": "WhoIsIn.Web",
```
- add your queries/mutations in GQL folder with ```.graphql``` extension
```graphql
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
```
- compile the project
```shell
dotnet build
```
With the project compiled, you should now see in the directory ```./obj/<configuration>/<target-framework>/berry``` the generated code that your applications can leverage.

- go to ```Program.cs``` and add the client into DI container
```csharp
builder.Services.AddWhoIsInWebGraphQLClient()
    .ConfigureHttpClient(httpClient => httpClient.BaseAddress = new Uri(builder.Configuration["GraphQLURI"]!));
```