namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record IncludeExcludeSubject : OscalRemarksModel
{
    public Uuid SubjectUuid { get; set; }
    public Token Type { get; set; }
}
