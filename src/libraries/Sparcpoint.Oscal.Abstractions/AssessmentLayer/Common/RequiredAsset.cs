namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record RequiredAsset : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public ObservationSubject[]? Subjects { get; set; }
    public MarkupLine? Title { get; set; }
    public MarkupMultiline Description { get; set; }
}
