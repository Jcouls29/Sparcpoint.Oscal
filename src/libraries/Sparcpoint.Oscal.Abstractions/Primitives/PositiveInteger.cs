namespace Sparcpoint.Oscal.Primitives;

public readonly record struct PositiveInteger(uint Value)
{
    public static PositiveInteger Create(uint value)
    {
        if (value == 0)
            throw new InvalidOperationException($"Positive Integer must be greater than 0.");

        return new PositiveInteger(value);
    }
}
