namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record POAMItem : OscalRemarksModel
{
    public Uuid? Uuid { get; set; }
    public MarkupLine Title { get; set; }
    public MarkupMultiline Description { get; set; }
    public Origin[]? Origins { get; set; }
    public RelatedFinding[]? RelatedFindings { get; set; }
    public RelatedObservation[]? RelatedObservations { get; set; }
    public RelatedRisk[]? RelatedRisks { get; set; }
}
