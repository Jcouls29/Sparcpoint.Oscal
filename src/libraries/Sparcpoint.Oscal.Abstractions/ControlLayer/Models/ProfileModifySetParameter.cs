namespace Sparcpoint.Oscal.ControlLayer.Common;

public record ProfileModifySetParameter
{
    public Token ParamId { get; set; }
    public Token? Class { get; set; }
    public Token? DependsOn { get; set; }
    public Prop[]? Props { get; set; }
    public Link[]? Links { get; set; }
    public MarkupLine? Label { get; set; }
    public MarkupMultiline? Usage { get; set; }
    public Constraint[]? Constraints { get; set; }
    public Guideline[]? Guidelines { get; set; }

    // Choice of one of the following:
    public string[]? Values { get; set; }
    public Select? Select { get; set; }
    // *******************************
}
