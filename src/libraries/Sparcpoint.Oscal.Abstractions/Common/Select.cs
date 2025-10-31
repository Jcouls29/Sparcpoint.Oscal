namespace Sparcpoint.Oscal.Common;

public record Select
{
    // "one" or "one-or-more"
    public Token HowMany { get; set; }
    public MarkupLine[]? Choice { get; set; }
}
