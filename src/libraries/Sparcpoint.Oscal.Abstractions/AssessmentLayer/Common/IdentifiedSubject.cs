namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record IdentifiedSubject
{
    public Uuid SubjectPlaceholderUuid { get; set; }
    public AssessmentSubject[] Subjects { get; set; } = Array.Empty<AssessmentSubject>();
}
