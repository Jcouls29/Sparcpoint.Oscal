namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record SystemSecurityPlanControlImplementation
{
    public MarkupMultiline Description { get; set; }
    public ImplementationSetParameter[]? SetParameters { get; set; }
    public SystemSecurityPlanImplementedRequirement[] ImplementedRequirements { get; set; } = Array.Empty<SystemSecurityPlanImplementedRequirement>();
}

