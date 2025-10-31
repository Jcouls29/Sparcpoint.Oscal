namespace Sparcpoint.Oscal.Common;

public record IncludeControls
{
    public Token? WithChildControls { get; set; }
    public Token[]? WithIds { get; set; }
    public ControlsMatching[]? Matching { get; set; }
}
