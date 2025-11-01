namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record FindingTarget : OscalRemarksModel
{
    public string Type { get; set; } = string.Empty;
    public Token TargetId { get; set; }
    public MarkupLine? Title { get; set; }
    public MarkupMultiline? Description { get; set; }
    public FindingStatus Status { get; set; } = new();
    public Status? ImplementationStatus { get; set; }
}
