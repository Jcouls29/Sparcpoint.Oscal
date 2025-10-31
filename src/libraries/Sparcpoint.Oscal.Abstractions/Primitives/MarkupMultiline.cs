namespace Sparcpoint.Oscal.Primitives;

public readonly record struct MarkupMultiline(string Value)
{
    public static MarkupMultiline Empty { get; } = new(string.Empty);
}
