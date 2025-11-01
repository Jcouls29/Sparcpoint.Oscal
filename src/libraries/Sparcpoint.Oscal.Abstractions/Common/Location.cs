namespace Sparcpoint.Oscal.Common;

public record Location : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public MarkupLine Title { get; set; }
    public Address? Address { get; set; }
    public EmailAddress[]? EmailAddresses { get; set; }
    public TelephoneNumber[]? TelephoneNumbers { get; set; }
    public Uri[]? Urls { get; set; }
}
