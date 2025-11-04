namespace Sparcpoint.Oscal.Common;

public record ExternalId
{
    public Uri Scheme { get; set; } = new Uri("about:blank");
    public string? Id { get; set; }
}
