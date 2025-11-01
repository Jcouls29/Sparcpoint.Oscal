namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record Capability : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public string Name { get; set; } = string.Empty;
    public MarkupMultiline Description { get; set; }
    public IncorporatesComponent[]? IncorporatesComponents { get; set; }
    public ComponentControlImplementation[]? ControlImplementations { get; set; }
}
