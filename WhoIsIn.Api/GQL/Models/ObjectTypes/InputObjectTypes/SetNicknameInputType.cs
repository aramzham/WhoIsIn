namespace WhoIsIn.Api.GQL.Models.ObjectTypes.InputObjectTypes;

public class SetNicknameInputType : InputObjectType<SetPlayerNicknameInput>
{
    protected override void Configure(IInputObjectTypeDescriptor<SetPlayerNicknameInput> descriptor)
    {
        descriptor.Description("Set nickname for user");
        descriptor
            .Field(x => x.Nickname)
            .Type<NonNullType<StringType>>()
            .Description("Nickname for user");
        descriptor
            .Field(x => x.PlayerId)
            .Type<NonNullType<UuidType>>()
            .Description("Player id");
    }
}