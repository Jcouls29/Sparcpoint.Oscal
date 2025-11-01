namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record ImplementedComponent : OscalRemarksModel
{
    public Uuid ComponentUuid { get; set; }
    public ResponsibleParty[]? ResponsibleParties { get; set; }
}

