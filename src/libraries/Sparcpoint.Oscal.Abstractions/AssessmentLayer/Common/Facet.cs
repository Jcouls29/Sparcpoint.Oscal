namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record Facet : OscalRemarksModel
{
    public Token Name { get; set; }
    public Uri System { get; set; } = new Uri("about:blank");
    public string Value { get; set; }
}
