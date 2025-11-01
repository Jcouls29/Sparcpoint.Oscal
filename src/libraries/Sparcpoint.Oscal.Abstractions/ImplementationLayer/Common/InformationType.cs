namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record InformationType : OscalAttributesModel
{
    public Uuid? Uuid { get; set; }
    public MarkupLine Title { get; set; }
    public MarkupMultiline Description { get; set; }
    public Categorization[]? Categorizations { get; set; }
    public Impact? ConfidentialityImpact { get; set; }
    public Impact? IntegrityImpact { get; set; }
    public Impact? AvailabilityImpact { get; set; }
}

