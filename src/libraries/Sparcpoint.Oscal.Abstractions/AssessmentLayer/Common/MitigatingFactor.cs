namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record MitigatingFactor : OscalAttributesModel
{
    public Uuid Uuid { get; set; }
    public Uuid? ImplementationUuid { get; set; }
    public MarkupMultiline Description { get; set; }
    public ObservationSubject[]? Subjects { get; set; }
}
