namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record Result : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public MarkupLine Title { get; set; }
    public MarkupMultiline Description { get; set; }
    public DateTimeOffset Start { get; set; }
    public DateTimeOffset? End { get; set; }
    public ResultLocalDefinitions? LocalDefinitions { get; set; }
    public AssessmentControlSelectionHolder[] ReviewedControls { get; set; } = Array.Empty<AssessmentControlSelectionHolder>();
    public Attestation[]? Attestations { get; set; }
    public AssessmentLog? AssessmentLog { get; set; }
    public Observation[]? Observations { get; set; }
    public Risk[]? Risks { get; set; }
    public Finding[]? Findings { get; set; }
}
