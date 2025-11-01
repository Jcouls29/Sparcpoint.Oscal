namespace Sparcpoint.Oscal.Common;

public record ResponsibleParty : OscalRemarksModel
{
    public Token RoleId { get; set; } = Token.Empty;
    public Uuid[] PartyUuids { get; set; } = Array.Empty<Uuid>();
}
