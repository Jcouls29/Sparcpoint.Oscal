namespace Sparcpoint.Oscal.Common;

public record Role
{
    public Token Id { get; set; } = Token.Empty;
    public MarkupLine Title { get; set; } = MarkupLine.Empty;
    public string? ShortName { get; set; }
    public MarkupMultiline? Description { get; set; }
    public Prop[]? Props { get; set; }
    public Link[]? LInks { get; set; }
    public MarkupMultiline? Remarks { get; set; }
}
