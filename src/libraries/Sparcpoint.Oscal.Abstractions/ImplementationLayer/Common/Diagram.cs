namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record Diagram : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public MarkupMultiline? Description { get; set; }
    public MarkupLine? Caption { get; set; }
}

