namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record AssessmentPlatform : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public MarkupLine? Title { get; set; }
    public UsesComponent[]? UsesComponents { get; set; }
}
