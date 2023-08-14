namespace WhoIsIn.Api.GQL.Models.ObjectTypes.InputObjectTypes;

public class CancelParticipationInputType : InputObjectType<CancelParticipationInput>
{
    protected override void Configure(IInputObjectTypeDescriptor<CancelParticipationInput> descriptor)
    {
        descriptor.Description("Input type for cancelling match participation");
        descriptor.Field(p => p.PlayerId).Description("The id of the player to cancel the participation");
        descriptor.Field(p => p.MatchId).Description("The id of the match to cancel the participation");
        descriptor.Field(p => p.Reason).Description("The reason for cancelling the participation");
        base.Configure(descriptor);
    }
}