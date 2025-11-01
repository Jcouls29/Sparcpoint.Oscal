namespace Sparcpoint.Oscal.Common;

public record Role : OscalRemarksModel
{
    public Token Id { get; set; } = Token.Empty;
    public MarkupLine Title { get; set; } = MarkupLine.Empty;
    public string? ShortName { get; set; }
    public MarkupMultiline? Description { get; set; }
}
