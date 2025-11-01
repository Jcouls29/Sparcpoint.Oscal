namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record Satisfied : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public Uuid? ResponsibilityUuid { get; set; }
    public MarkupMultiline Description { get; set; }
    public ResponsibleRole[]? ResponsibleRoles { get; set; }
}

