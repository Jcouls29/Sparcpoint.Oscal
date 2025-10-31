namespace Sparcpoint.Oscal.Primitives;

public readonly record struct MarkupLine(string Value)
{
    public static MarkupLine Empty { get; } = new(string.Empty);
}
