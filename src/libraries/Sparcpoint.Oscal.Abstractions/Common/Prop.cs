namespace Sparcpoint.Oscal.Common;

public record Prop
{
    public Token Name { get; set; } = Token.Empty;
    public Uuid? Uuid { get; set; }
    public Uri? Namespace { get; set; }
    public string Value { get; set; } = string.Empty;
    public Token? Class { get; set; }
    public Token? Group { get; set; }
    public MarkupMultiline? Remarks { get; set; }
}
