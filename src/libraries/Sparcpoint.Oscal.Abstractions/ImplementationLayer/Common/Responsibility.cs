namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record Responsibility : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public Uuid? ProvidedUuid { get; set; }
    public MarkupMultiline Description { get; set; }
    public ResponsibleRole[]? ResponsibleRoles { get; set; }
}

