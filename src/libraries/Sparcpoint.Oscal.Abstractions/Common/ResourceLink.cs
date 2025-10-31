namespace Sparcpoint.Oscal.Common;

public record ResourceLink
{
    public Uri Href { get; set; } = new Uri("about:blank");
    public string? MediaType { get; set; }
    public ResourceLinkHash[]? Hashes { get; set; }
}
