namespace Sparcpoint.Oscal.Common;

public record Citation : OscalAttributesModel
{
    public MarkupLine Text { get; set; }
}
