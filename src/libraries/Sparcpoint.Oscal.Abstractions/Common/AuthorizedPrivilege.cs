namespace Sparcpoint.Oscal.Common;

public record AuthorizedPrivilege
{
    public MarkupLine Title { get; set; }
    public MarkupMultiline? Description { get; set; }
    public string[] FunctionsPerformed { get; set; } = Array.Empty<string>();
}

