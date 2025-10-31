namespace Sparcpoint.Oscal.Common;

public record ResponsibleParty
{
    public Token RoleId { get; set; } = Token.Empty;
    public Uuid[] PartyUuids { get; set; } = Array.Empty<Uuid>();
    public Prop[]? Props { get; set; }
    public Link[]? Links { get; set; }
    public MarkupMultiline? Remarks { get; set; }
}
