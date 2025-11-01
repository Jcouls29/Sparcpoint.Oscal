namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record AssessmentResultAssets
{
    public AssessmentResultComponent[]? Components { get; set; }
    public AssessmentPlatform[] AsessmentPlatforms { get; set; } = Array.Empty<AssessmentPlatform>();
}
