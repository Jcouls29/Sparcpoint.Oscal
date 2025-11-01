namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record Step : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public MarkupLine? Title { get; set; }
    public MarkupMultiline Description { get; set; }
    public ResponsibleRole[]? ResponsibleRoles { get; set; }
    public AssessmentControlSelectionHolder? ReviewedControls { get; set; }
}
