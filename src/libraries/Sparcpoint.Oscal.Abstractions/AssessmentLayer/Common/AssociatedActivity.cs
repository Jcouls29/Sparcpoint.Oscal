namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record AssociatedActivity : OscalRemarksModel
{
    public Uuid ActivityUuid { get; set; }
    public ResponsibleRole[]? ResponsibleRoles { get; set; }
    public AssessmentSubject[] Subjects { get; set; } = Array.Empty<AssessmentSubject>();
}
