namespace Sparcpoint.Oscal.Common;

public record ImplementedComponent : OscalRemarksModel
{
    public Uuid ComponentUuid { get; set; }
    public ResponsibleParty[]? ResponsibleParties { get; set; }
}

