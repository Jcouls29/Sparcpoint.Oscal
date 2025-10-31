namespace Sparcpoint.Oscal.Common;

public record Address
{
    public Token? Type { get; set; }
    public string[]? AddressLines { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }
    public string? Country { get; set; }
}
