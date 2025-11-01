namespace Sparcpoint.Oscal.Common;

public record User : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public MarkupLine? Title { get; set; }
    public string? ShortName { get; set; }
    public MarkupMultiline? Description { get; set; }
    public Token[]? RoleIds { get; set; }
    public AuthorizedPrivilege[]? AuthorizedPrivileges { get; set; }
}

