namespace Sparcpoint.Oscal.Common;

public record Resource
{
    public Uuid Uuid { get; set; }
    public MarkupLine? Title { get; set; }
    public MarkupMultiline? Description { get; set; }
    public Prop[]? Props { get; set; }
    public DocumentId[]? DocumentIds { get; set; }
    public Citation? Citation { get; set; }
    public ResourceLink[]? ResourceLinks { get; set; }
    public RecordFileBase64? Base64 { get; set; }
    public MarkupMultiline? Remarks { get; set; }
}
