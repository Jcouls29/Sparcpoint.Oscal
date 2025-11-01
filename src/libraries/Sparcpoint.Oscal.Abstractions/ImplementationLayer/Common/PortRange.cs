namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record PortRange
{
    public NonNegativeInteger? Start { get; set; }
    public NonNegativeInteger? End { get; set; }
    public Token? Transport { get; set; }
}
