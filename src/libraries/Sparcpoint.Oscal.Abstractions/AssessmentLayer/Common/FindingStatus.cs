namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record FindingStatus
{
    public Token State { get; set; }
    public Token? Reason { get; set; }
    public MarkupMultiline? Remarks { get; set; }
}
