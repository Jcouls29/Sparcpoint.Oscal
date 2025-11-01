namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record ObservationSubject : OscalRemarksModel
{
    public Uuid SubjectUuid { get; set; }
    public Token Type { get; set; }
    public MarkupLine? Title { get; set; }
}
