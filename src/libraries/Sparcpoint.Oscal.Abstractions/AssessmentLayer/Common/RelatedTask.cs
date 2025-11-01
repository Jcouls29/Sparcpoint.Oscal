namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record RelatedTask : OscalRemarksModel
{
    public Uuid TaskUuid { get; set; }
    public ResponsibleParty[]? ResponsibleParties { get; set; }
    public AssessmentSubject[]? Subjects { get; set; }
    public IdentifiedSubject? IdentifiedSubject { get; set; }
}
