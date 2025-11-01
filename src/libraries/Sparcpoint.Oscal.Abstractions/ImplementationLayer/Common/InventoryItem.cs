namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record InventoryItem : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public MarkupMultiline Description { get; set; }
    public ResponsibleParty[]? ResponsibleParties { get; set; }
    public ImplementedComponent[]? ImplementedComponents { get; set; }
}

