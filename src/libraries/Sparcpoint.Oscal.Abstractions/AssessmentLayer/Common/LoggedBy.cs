namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record LoggedBy
{
    public Uuid PartyUuid { get; set; }
    public Token? RoleId { get; set; }
}
