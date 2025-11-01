namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record UsesComponent : OscalRemarksModel
{
    public Uuid ComponentUuid { get; set; }
    public ResponsibleParty[]? ResponsibleParties { get; set; }
}
