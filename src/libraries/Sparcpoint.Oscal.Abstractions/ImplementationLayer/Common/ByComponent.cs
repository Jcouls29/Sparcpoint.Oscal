namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record ByComponent : OscalRemarksModel
{
    public Uuid ComponentUuid { get; set; }
    public Uuid Uuid { get; set; }
    public MarkupMultiline Description { get; set; }
    public ImplementationSetParameter[]? SetParameters { get; set; }
    public Status? ImplementationStatus { get; set; }
    public Export? Export { get; set; }
    public Inherited[]? Inherited { get; set; }
    public Satisfied[]? Satisfied { get; set; }
    public ResponsibleRole[]? ResponsibleRoles { get; set; }
}

