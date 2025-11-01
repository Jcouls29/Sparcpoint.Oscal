namespace Sparcpoint.Oscal.Common;

public record Control : OscalAttributesModel
{
    public Token Id { get; set; }
    public Token? Class { get; set; }
    public MarkupLine Title { get; set; }
    public Param[]? Params { get; set; }
    public Part[]? Parts { get; set; }
    public Control[]? Controls { get; set; }
}
