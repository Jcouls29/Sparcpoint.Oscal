namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record SecurityImpactLevel
{
    public string SecurityObjectiveConfidentiality { get; set; } = string.Empty;
    public string SecurityObjectiveIntegrity { get; set; } = string.Empty;
    public string SecurityObjectiveAvailability { get; set; } = string.Empty;
}

