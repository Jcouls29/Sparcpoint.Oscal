namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record SystemSecurityPlanStatement
{
    public Token StatementId { get; set; }
    public Uuid Uuid { get; set; }
    public ResponsibleRole[]? ResponsibleRoles { get; set; }
    public ByComponent[]? ByComponents { get; set; }
}

