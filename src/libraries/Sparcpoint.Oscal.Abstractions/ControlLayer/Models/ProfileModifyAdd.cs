namespace Sparcpoint.Oscal.ControlLayer.Common;

public record ProfileModifyAdd
{
    public Token? Position { get; set; }
    public Token? ById { get; set; }
    public MarkupLine? Title { get; set; }
    public Param[]? Params { get; set; }
    public Prop[]? Props { get; set; }
    public Link[]? Links { get; set; }
    public Part[]? Parts { get; set; }
}
