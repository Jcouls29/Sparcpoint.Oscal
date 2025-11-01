namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record Attestation
{
    public ResponsibleParty[]? ResponsibleParties { get; set; }
    public Part[] Parts { get; set; } = Array.Empty<Part>();
}
