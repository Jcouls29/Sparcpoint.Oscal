namespace Sparcpoint.Oscal.Common;

public record Status
{
    public Token State { get; set; }
    public MarkupMultiline? Remarks { get; set; }
}

