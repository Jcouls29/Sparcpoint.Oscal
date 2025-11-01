namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record ComponentControlImplementation : OscalAttributesModel
{
    public Uuid Uuid { get; set; }
    public Uri Source { get; set; } = new Uri("about:blank");
    public MarkupMultiline Description { get; set; }
    public ImplementationSetParameter[]? SetParameters { get; set; }
    public ComponentImplementedRequirement[]? ImplementedRequirements { get; set; }
}
