namespace Sparcpoint.Oscal.Common;

public record Action : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public DateTimeOffset? Date { get; set; }
    public Token Type { get; set; }
    public Uri System { get; set; } = new Uri("about:blank");
    public ResponsibleParty[]? ResponsibleParties { get; set; }
}