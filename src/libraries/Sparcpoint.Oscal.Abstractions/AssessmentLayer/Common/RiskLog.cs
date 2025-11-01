namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record RiskLog
{
    public RiskLogEntry[] Entries { get; set; } = Array.Empty<RiskLogEntry>();
}
