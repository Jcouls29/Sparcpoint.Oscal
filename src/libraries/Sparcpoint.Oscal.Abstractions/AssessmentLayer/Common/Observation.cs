namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record Observation : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public MarkupLine? Title { get; set; }
    public MarkupMultiline Description { get; set; }
    public string[] Methods { get; set; } = Array.Empty<string>();
    public Token[]? Types { get; set; }
    public Origin[]? Origins { get; set; }
    public ObservationSubject[]? Subjects { get; set; }
    public RelevantEvidence[]? RelevantEvidence { get; set; }
    public DateTimeOffset Collected { get; set; }
    public DateTimeOffset? Expires { get; set; }
}
