namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record DescriptionWithDiagrams : OscalRemarksModel
{
    public MarkupMultiline Description { get; set; }
    public Diagram[]? Diagrams { get; set; }
}

