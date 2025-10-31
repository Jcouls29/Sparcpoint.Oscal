namespace Sparcpoint.Oscal.Common;

public record Citation
{
    public MarkupLine Text { get; set; }
    public Prop[]? Props { get; set; }
    public Link[]? Links { get; set; }
}
