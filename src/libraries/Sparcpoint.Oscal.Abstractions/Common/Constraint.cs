namespace Sparcpoint.Oscal.Common;

public record Constraint
{
    public MarkupMultiline? Description { get; set; }
    public Test[]? Tests { get; set; }
}
