namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record IncorporatesComponent
{
    public Uuid ComponentUuid { get; set; }
    public MarkupMultiline Description { get; set; }
}
