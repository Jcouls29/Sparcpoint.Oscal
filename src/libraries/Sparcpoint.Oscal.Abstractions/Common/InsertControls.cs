namespace Sparcpoint.Oscal.Common;

public record InsertControls
{
    public Token? Order { get; set; }

    // Choice of one of the following:
    public object? IncludeAll { get; set; }
    public IncludeControls[]? IncludeControls { get; set; }
    // *******************************

    public ExcludeControls[]? ExcludeControls { get; set; }
}
