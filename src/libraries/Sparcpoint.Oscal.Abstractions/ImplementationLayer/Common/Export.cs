namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record Export : OscalRemarksModel
{
    public MarkupMultiline? Description { get; set; }
    public Provided[]? Provided { get; set; }
    public Responsibility[]? Responsibilities { get; set; }
}

