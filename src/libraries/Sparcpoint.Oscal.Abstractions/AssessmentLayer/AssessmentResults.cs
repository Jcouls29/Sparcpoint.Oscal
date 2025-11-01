using Sparcpoint.Oscal.AssessmentLayer.Common;

namespace Sparcpoint.Oscal.AssessmentLayer;

public record AssessmentResults : OscalLayerModel
{
    public Import AssessmentPlan { get; set; } = new();
    public AssessmentResultsLocalDefinitions? LocalDefinitions { get; set; }
    public Result[] Results { get; set; } = Array.Empty<Result>();
}
