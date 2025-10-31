namespace Sparcpoint.Oscal.Primitives;

public readonly record struct EmailAddress(string Value)
{
    public static EmailAddress Empty { get; } = new(string.Empty);
}
