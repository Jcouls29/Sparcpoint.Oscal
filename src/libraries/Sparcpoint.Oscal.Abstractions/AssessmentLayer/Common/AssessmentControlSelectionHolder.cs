namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record AssessmentControlSelectionHolder : OscalRemarksModel
{
    public MarkupMultiline? Description { get; set; }
    public ControlSelection[]? ControlSelections { get; set; }
    public ControlObjectiveSelection[]? ControlObjectiveSelections { get; set; }
}
