namespace Sparcpoint.Oscal.Common;

public record Guideline
{
    public MarkupMultiline Prose { get; set; } = MarkupMultiline.Empty;
}
