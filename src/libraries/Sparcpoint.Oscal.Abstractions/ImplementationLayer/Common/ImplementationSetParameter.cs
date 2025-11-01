namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record ImplementationSetParameter
{
    public Token ParamId { get; set; }
    public string[] Values { get; set; } = Array.Empty<string>();
    public MarkupMultiline? Remarks { get; set; }
}
