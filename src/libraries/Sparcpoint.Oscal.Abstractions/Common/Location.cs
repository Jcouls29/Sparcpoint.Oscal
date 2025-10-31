namespace Sparcpoint.Oscal.Common;

public record Location
{
    public Uuid Uuid { get; set; }
    public MarkupLine Title { get; set; }
    public Address? Address { get; set; }
    public EmailAddress[]? EmailAddresses { get; set; }
    public TelephoneNumber[]? TelephoneNumbers { get; set; }
    public Uri[]? Urls { get; set; }
    public Prop[]? Props { get; set; }
    public Link[]? Links { get; set; }
    public MarkupMultiline? Remarks { get; set; }
}
