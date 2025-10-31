namespace Sparcpoint.Oscal.Primitives;

public readonly record struct Base64Value(string Value)
{
    public static Base64Value Empty { get; } = new(string.Empty);
}
