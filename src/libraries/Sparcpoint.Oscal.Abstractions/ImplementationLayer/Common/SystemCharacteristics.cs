namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record SystemCharacteristics : OscalRemarksModel
{
    public SystemId[] SystemIds { get; set; } = Array.Empty<SystemId>();
    public string SystemName { get; set; } = string.Empty;
    public string? SystemNameShort { get; set; }
    public MarkupMultiline Description { get; set; }
    public DateOnly? DateAuthorized { get; set; }
    public string? SecuritySensitivityLevel { get; set; }
    public SystemInformation SystemInformation { get; set; } = new();
    public SecurityImpactLevel? SecurityImpactLevel { get; set; }
    public Status Status { get; set; } = new();
    public DescriptionWithDiagrams AuthorizationBoundary { get; set; } = new();
    public DescriptionWithDiagrams? NetworkArchitecture { get; set; }
    public DescriptionWithDiagrams? DataFlow { get; set; }
    public ResponsibleParty[]? ResponsibleParties { get; set; }
}

