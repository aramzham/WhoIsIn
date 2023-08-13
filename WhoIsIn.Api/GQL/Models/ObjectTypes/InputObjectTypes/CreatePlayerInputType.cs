namespace WhoIsIn.Api.GQL.Models.ObjectTypes.InputObjectTypes;

public class CreatePlayerInputType : InputObjectType<CreatePlayerInput>
{
    protected override void Configure(IInputObjectTypeDescriptor<CreatePlayerInput> descriptor)
    {
        descriptor.Description("Represents the input to create a player.");
        
        descriptor
            .Field(m => m.Name)
            .Type<NonNullType<StringType>>()
            .Description("The name of the player");
        
        descriptor
            .Field(m => m.Email)
            .Type<NonNullType<StringType>>()
            .Description("The email of the player");
    }
}