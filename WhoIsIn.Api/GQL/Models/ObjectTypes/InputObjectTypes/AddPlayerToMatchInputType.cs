using WhoIsIn.Models;

namespace WhoIsIn.Api.GQL.Models.ObjectTypes.InputObjectTypes;

public class AddPlayerToMatchInputType : InputObjectType<AddPlayerToMatchInput>
{
    protected override void Configure(IInputObjectTypeDescriptor<AddPlayerToMatchInput> descriptor)
    {
        descriptor.Description("The input type for adding a player to a match");
        
        // Fields.
        descriptor.Field(x => x.PlayerId)
            .Type<NonNullType<IdType>>()
            .Description("The id of the player to add to the match");
        descriptor.Field(x => x.MatchId)
            .Type<NonNullType<IdType>>()
            .Description("The id of the match to add the player to");
    }
}