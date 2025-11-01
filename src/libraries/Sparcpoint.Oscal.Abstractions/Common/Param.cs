namespace Sparcpoint.Oscal.Common;

public record Param : OscalRemarksModel
{
    public Token Id { get; set; }
    public Token? Class { get; set; }
    public Token? DependsOn { get; set; }
    public MarkupLine? Label { get; set; }
    public MarkupMultiline? Usage { get; set; }
    public Constraint[]? Constraints { get; set; }
    public Guideline[]? Guidelines { get; set; }

    // Choice of one of the following:
    public string[]? Values { get; set; }
    public Select? Select { get; set; }
    // *******************************
}
