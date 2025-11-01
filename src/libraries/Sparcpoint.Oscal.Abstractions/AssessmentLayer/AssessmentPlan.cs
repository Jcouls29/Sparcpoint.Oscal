using Sparcpoint.Oscal.AssessmentLayer.Common;

namespace Sparcpoint.Oscal.AssessmentLayer;

public record AssessmentPlan : OscalLayerModel
{
    public ImportSSP ImportSsp { get; set; } = new();
    public AssessmentPlanLocalDefinitions? LocalDefinitions { get; set; }
    public TermsAndConditions? TermsAndConditions { get; set; }
    public AssessmentControlSelectionHolder ReviewedControls { get; set; } = new();
    public AssessmentSubject[]? AsessmentSubjects { get; set; }
    public AssessmentAssets? AssessmentAssets { get; set; }
    public AssessmentTask[]? Tasks { get; set; }
}
