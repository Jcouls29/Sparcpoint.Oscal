namespace Sparcpoint.Oscal.Common;

public record ResponsibleRole : OscalRemarksModel
{
    public Token RoleId { get; set; }
    public Uuid[]? PartyUuids { get; set; }
}
