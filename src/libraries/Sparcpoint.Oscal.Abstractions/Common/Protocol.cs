namespace Sparcpoint.Oscal.Common;

public record Protocol
{
    public Uuid? Uuid { get; set; }
    public string? Name { get; set; }
    public MarkupLine? Title { get; set; }
    public PortRange[]? PortRanges { get; set; }
}
