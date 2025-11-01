namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record SystemSecurityPlanImplementedRequirement : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public Token ControlId { get; set; }
    public ImplementationSetParameter[]? SetParameters { get; set; }
    public ResponsibleRole[]? ResponsibleRoles { get; set; }
    public SystemSecurityPlanStatement[]? Statements { get; set; }
    public ByComponent[]? ByComponents { get; set; }
}

