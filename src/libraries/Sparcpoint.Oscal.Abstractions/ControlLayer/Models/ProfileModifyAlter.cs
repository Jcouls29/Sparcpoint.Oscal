namespace Sparcpoint.Oscal.ControlLayer.Common;

public record ProfileModifyAlter
{
    public Token ControlId { get; set; }
    public ProfileModifyRemove[]? Removes { get; set; }
    public ProfileModifyAdd[]? Adds { get; set; }
}
