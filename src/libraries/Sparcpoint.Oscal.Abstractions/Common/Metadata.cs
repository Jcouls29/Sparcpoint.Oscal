namespace Sparcpoint.Oscal.Common;

public record Metadata : OscalRemarksModel
{
    public MarkupLine Title { get; set; } = MarkupLine.Empty;
    public DateTimeOffset? Published { get; set; }
    public DateTimeOffset LastModified { get; set; } = DateTimeOffset.MinValue;
    public string Version { get; set; } = string.Empty;
    public string OscalVersion { get; set; } = string.Empty;
    public MetadataRevision[] Revisions { get; set; } = Array.Empty<MetadataRevision>();
    public DocumentId[]? DocumentIds { get; set; }
    public Role[]? Roles { get; set; }
    public Location[]? Locations { get; set; }
    public Party[]? Parties { get; set; }
    public ResponsibleParty[]? ResponsibleParties { get; set; }
    public Action[]? Actions { get; set; }
}
