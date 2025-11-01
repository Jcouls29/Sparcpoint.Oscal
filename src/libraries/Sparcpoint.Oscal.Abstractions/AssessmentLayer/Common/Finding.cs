namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record Finding : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public MarkupLine Title { get; set; }
    public MarkupMultiline Description { get; set; }
    public Origin[]? Origins { get; set; }
    public FindingTarget Target { get; set; } = new();
    public Uuid? ImplementationStatementUuid { get; set; }
    public RelatedObservation[]? RelatedObservations { get; set; }
    public RelatedRisk[]? RelatedRisks { get; set; }
}
