namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record Import
{
    public Uri Href { get; set; } = new Uri("about:blank");
    public MarkupMultiline? Remarks { get; set; }
}
