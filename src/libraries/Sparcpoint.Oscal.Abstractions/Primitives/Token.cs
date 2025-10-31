namespace Sparcpoint.Oscal.Primitives;

public readonly record struct Token(string Value)
{
    public static Token Empty { get; } = new(string.Empty);
}
