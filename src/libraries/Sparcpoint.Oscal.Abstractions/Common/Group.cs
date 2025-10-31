namespace Sparcpoint.Oscal.Common;

public record Group
{
    public Token? Id { get; set; }
    public Token? Class { get; set; }
    public MarkupLine Title { get; set; }
    public Param[]? Params { get; set; }
    public Prop[]? Props { get; set; }
    public Link[]? Links { get; set; }
    public Part[]? Parts { get; set; }

    // Choice of one of the following:
    public Group[]? Groups { get; set; }
    public Control[]? Controls { get; set; }
    // *******************************
}
