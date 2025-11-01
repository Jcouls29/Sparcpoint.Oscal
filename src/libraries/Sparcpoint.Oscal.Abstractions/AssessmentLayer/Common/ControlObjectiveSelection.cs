namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record ControlObjectiveSelection : OscalRemarksModel
{
    public MarkupMultiline? Description { get; set; }
    // Choice of one of the following:
    public object? IncludeAll { get; set; }
    public IncludeExcludeObjective[]? IncludeControls { get; set; }
    // *******************************
    public IncludeExcludeObjective[]? ExcludeControls { get; set; }
}
