namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record ControlSelection : OscalRemarksModel
{
    public MarkupMultiline? Description { get; set; }
    // Choice of one of the following:
    public object? IncludeAll { get; set; }
    public IncludeExcludeControl[]? IncludeControls { get; set; }
    // *******************************
    public IncludeExcludeControl[]? ExcludeControls { get; set; }
}
