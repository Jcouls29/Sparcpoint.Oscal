namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record Categorization
{
    public Uri System { get; set; } = new Uri("about:blank");
    public string[]? InformationTypeIds { get; set; }
}

