namespace Sparcpoint.Oscal.Common;

public record Part
{
    public Token? Id { get; set; }
    public Token Name { get; set; }
    public Uri? Namespace { get; set; }
    public Token? Class { get; set; }
    public MarkupLine? Title { get; set; }
    public Prop[]? Props { get; set; }
    public MarkupMultiline? Prose { get; set; }
    public Part[]? Parts { get; set; }
    public Link[]? Links { get; set; }
}
