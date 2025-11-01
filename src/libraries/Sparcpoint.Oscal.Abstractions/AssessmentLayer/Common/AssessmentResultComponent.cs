namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record AssessmentResultComponent : Component
{
    public Status Status { get; set; } = new();
}
