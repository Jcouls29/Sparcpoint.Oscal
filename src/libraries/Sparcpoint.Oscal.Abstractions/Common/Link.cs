namespace Sparcpoint.Oscal.Common;

public record Link
{
    public Uri Href { get; set; } = new Uri("about:blank");
    public Token? Rel { get; set; }
    public string? MediaType { get; set; }
    public string? ResourceFragment { get; set; }
    public MarkupLine? Text { get; set; }
}
