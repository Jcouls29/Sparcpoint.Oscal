namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record ThreatId
{
    public Uri System { get; set; } = new Uri("about:blank");
    public Uri? Href { get; set; }
    public Uri? Id { get; set; }
}
