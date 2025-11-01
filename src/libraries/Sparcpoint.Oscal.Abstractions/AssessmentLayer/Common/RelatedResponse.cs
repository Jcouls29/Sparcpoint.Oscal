namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record RelatedResponse : OscalRemarksModel
{
    public Uuid ResponseUuid { get; set; }
    public RelatedTask[]? RelatedTasks { get; set; }
}
