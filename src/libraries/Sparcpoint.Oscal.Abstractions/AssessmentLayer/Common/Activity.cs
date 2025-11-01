namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record Activity : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public MarkupLine? Title { get; set; }
    public MarkupMultiline Description { get; set; }
    public Step[]? Steps { get; set; }
    public AssessmentControlSelectionHolder? RelatedControls { get; set; }
    public ResponsibleRole[]? ResponsibleRoles { get; set; }
}
