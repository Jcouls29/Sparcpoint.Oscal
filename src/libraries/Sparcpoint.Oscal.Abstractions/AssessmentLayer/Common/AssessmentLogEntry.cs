namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record AssessmentLogEntry : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public MarkupLine? Title { get; set; }
    public MarkupMultiline? Description { get; set; }
    public DateTimeOffset Start { get; set; }
    public DateTimeOffset? End { get; set; }
    public LoggedBy[]? LoggedBy { get; set; }
    public RelatedTask[]? RelatedTasks { get; set; }
}
