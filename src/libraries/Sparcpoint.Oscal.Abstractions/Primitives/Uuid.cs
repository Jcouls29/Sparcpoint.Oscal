namespace Sparcpoint.Oscal.Primitives;

public readonly record struct Uuid(string Value)
{
    public static Uuid Empty { get; } = new(string.Empty);
}
