namespace Sparcpoint.Oscal.Common;

public record ResourceLinkHash
{
    public string Algorithm { get; set; } = string.Empty;
    public string? Value { get; set; }
}
