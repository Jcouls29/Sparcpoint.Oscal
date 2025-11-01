namespace Sparcpoint.Oscal.Common;

public record MetadataRevision : OscalRemarksModel
{
    public MarkupLine? Title { get; set; }
    public DateTimeOffset? Published { get; set; }
    public DateTimeOffset? LastModified { get; set; }
    public string Version { get; set; } = string.Empty;
    public string? OscalVersion { get; set; }
}
