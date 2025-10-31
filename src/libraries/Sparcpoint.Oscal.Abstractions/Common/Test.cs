namespace Sparcpoint.Oscal.Common;

public record Test
{
    public string Expression { get; set; } = string.Empty;
    public MarkupMultiline? Remarks { get; set; }
}
