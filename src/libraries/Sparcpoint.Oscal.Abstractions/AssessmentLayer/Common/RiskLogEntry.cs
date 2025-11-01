namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record RiskLogEntry : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public MarkupLine? Title { get; set; }
    public MarkupMultiline? Description { get; set; }
    public DateTimeOffset Start { get; set; }
    public DateTimeOffset? End { get; set; }
    public LoggedBy[]? LoggedBy { get; set; }
    public Token? StatusChange { get; set; }
    public RelatedResponse[]? RelatedResponses { get; set; }
}
