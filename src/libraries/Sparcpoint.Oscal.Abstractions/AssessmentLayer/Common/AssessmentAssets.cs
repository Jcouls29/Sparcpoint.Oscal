namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record AssessmentAssets
{
    public Component[]? Components { get; set; }
    public AssessmentPlatform[] AssessmentPlatforms { get; set; } = Array.Empty<AssessmentPlatform>();
}
