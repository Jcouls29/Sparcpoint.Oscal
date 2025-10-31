namespace Sparcpoint.Oscal.Common;

public record RecordFileBase64
{
    public Token? Filename { get; set; }
    public string? MediaType { get; set; }
    public Base64Value? Value { get; set; }
}
