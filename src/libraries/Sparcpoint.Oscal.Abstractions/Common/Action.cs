namespace Sparcpoint.Oscal.Common;

public record Action
{
    public Uuid Uuid { get; set; }
    public DateTimeOffset? Date { get; set; }
    public Token Type { get; set; }
    public Uri System { get; set; }
    public Prop[]? Props { get; set; }
    public Link[]? Links { get; set; }
    public ResponsibleParty[]? ResponsibleParties { get; set; }
    public MarkupMultiline? Remarks { get; set; }
}