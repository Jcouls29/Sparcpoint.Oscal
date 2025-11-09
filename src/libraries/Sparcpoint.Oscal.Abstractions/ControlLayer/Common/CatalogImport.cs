namespace Sparcpoint.Oscal.ControlLayer.Common;

public record CatalogImport
{
    public Uri Href { get; set; } = new Uri("about:blank");
    
    // Choice of one of the following:
    public object? IncludeAll { get; set; }
    public IncludeControls[]? IncludeControls { get; set; }
    // *******************************

    public ExcludeControls[]? ExcludeControls { get; set; }
}
