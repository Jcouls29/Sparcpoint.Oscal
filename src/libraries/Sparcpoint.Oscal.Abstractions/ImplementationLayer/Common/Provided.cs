namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record Provided : OscalRemarksModel
{
    
    public Uuid Uuid { get; set; }
    public MarkupMultiline Description { get; set; }
    public ResponsibleRole[]? ResponsibleRoles { get; set; }
}

