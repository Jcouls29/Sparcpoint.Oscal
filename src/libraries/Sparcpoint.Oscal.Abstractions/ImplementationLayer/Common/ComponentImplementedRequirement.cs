namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record ComponentImplementedRequirement : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public Token ControlId { get; set; }
    public MarkupMultiline Description { get; set; }
    public ImplementationSetParameter[]? SetParameters { get; set; }
    public ResponsibleRole[]? ResponsibleRoles { get; set; }
    public ComponentStatement[]? Statements { get; set; }
}
