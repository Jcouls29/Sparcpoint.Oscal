namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record Status
{
    public string State { get; set; } = string.Empty;
    public MarkupMultiline? Remarks { get; set; }
}

