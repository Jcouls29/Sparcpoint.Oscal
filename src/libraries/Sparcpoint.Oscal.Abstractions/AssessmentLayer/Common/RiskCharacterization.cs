namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record RiskCharacterization : OscalAttributesModel
{
    public Origin Origin { get; set; } = new();
    public Facet[] Facets { get; set; } = Array.Empty<Facet>();
}
