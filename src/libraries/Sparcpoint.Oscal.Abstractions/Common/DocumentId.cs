namespace Sparcpoint.Oscal.Common;

public record DocumentId
{
    public Uri? Scheme { get; set; }
    public string? Identifier { get; set; }
}
