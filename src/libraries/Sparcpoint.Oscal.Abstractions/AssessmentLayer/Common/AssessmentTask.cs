namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record AssessmentTask : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public Token Type { get; set; }
    public MarkupLine Title { get; set; }
    public MarkupMultiline? Description { get; set; }
    public Timing? Timing { get; set; }
    public Dependency[]? Dependencies { get; set; }
    public AssessmentTask[]? Tasks { get; set; }
    public AssociatedActivity[]? AssociatedActivities { get; set; }
    public AssessmentSubject[]? Subjects { get; set; }
    public ResponsibleRole[]? ResponsibleRoles { get; set; }
}
