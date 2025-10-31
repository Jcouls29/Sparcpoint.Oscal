namespace Sparcpoint.Oscal.Common;

public record Party
{
    public Uuid Uuid { get; set; }
    public string Type { get; set; } = string.Empty;
    public string? Name { get; set; }
    public string? ShortName { get; set; }
    public ExternalId[]? ExternalIds { get; set; }
    public Prop[]? Props { get; set; }
    public Link[]? Links { get; set; }
    public EmailAddress[]? EmailAddresses { get; set; }
    public TelephoneNumber[]? TelephoneNumbers { get; set; }

    // Choice of one of the following:
    public Address[]? Addresses { get; set; }
    public Uuid[]? LocationUuids { get; set; }
    // *******************************

    public string[]? MemberOfOrganizations { get; set; }
    public MarkupMultiline? Remarks { get; set; }
}
