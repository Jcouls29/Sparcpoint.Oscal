namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record RelevantEvidence : OscalRemarksModel
{
    public Uri? Href { get; set; }
    public MarkupMultiline Description { get; set; }
}
