namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record AssessmentResultsLocalDefinitions
{
    public ObjectivesAndMethods[]? ObjectivesAndMethods { get; set; }
    public Activity[]? Activities { get; set; }
    public MarkupMultiline? Remarks { get; set; }
}
