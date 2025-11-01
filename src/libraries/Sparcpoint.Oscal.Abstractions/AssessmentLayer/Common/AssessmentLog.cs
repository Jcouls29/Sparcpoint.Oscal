namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record AssessmentLog
{
    public AssessmentLogEntry[] Entries { get; set; } = Array.Empty<AssessmentLogEntry>();
}
