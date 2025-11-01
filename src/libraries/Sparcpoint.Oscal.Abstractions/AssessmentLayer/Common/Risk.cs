namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record Risk : OscalAttributesModel
{
    public Uuid Uuid { get; set; }
    public MarkupLine Title { get; set; }
    public MarkupMultiline Description { get; set; }
    public MarkupMultiline Statement { get; set; }
    public Token Status { get; set; }
    public Origin[]? Origins { get; set; }
    public ThreatId[]? ThreatIds { get; set; }
    public RiskCharacterization[]? Characterizations { get; set; }
    public MitigatingFactor[]? MitigatingFactors { get; set; }
    public DateTimeOffset? Deadline { get; set; }
    public Response[]? Remediations { get; set; }
    public RiskLog? RiskLog { get; set; }
    public RelatedObservation[]? RelatedObservations { get; set; }
}
