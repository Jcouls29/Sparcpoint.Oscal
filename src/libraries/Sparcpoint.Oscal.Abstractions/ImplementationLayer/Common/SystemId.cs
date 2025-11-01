namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record SystemId
{
    public Uri? IdentifierType { get; set; }
    public string? Id { get; set; }
}

