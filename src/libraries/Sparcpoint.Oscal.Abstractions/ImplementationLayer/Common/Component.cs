namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record Component : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public string Type { get; set; } = string.Empty;
    public MarkupLine Title { get; set; }
    public MarkupMultiline Description { get; set; }
    public MarkupLine? Purpose { get; set; }
    public ResponsibleRole[]? ResponsibleRoles { get; set; }
    public Protocol[]? Protocols { get; set; }
}
