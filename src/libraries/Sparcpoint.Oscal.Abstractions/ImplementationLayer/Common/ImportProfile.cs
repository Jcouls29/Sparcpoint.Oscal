namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record ImportProfile
{
    public Uri Href { get; set; } = new("about:blank");
    public MarkupMultiline? Remarks { get; set; }
}

