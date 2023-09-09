using WhoIsIn.Models;

namespace WhoIsIn.Api.GQL.Models.ObjectTypes.InputObjectTypes;

public class CreateMatchInputType : InputObjectType<CreateMatchInput>
{
    protected override void Configure(IInputObjectTypeDescriptor<CreateMatchInput> descriptor)
    {
        descriptor.Description("Represents the input for creating a match");

        descriptor
            .Field(m => m.Location)
            .Type<NonNullType<StringType>>()
            .Description("The location of the match");

        descriptor
            .Field(m => m.Price)
            .Type<NonNullType<DecimalType>>()
            .Description("The price of the current match");

        descriptor
            .Field(m => m.StartTime)
            .Type<NonNullType<DateTimeType>>()
            .Description("When the match starts");
    }
}