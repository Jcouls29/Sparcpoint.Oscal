namespace Sparcpoint.Oscal.ControlLayer.Common;

public record ProfileModify
{
    public ProfileModifySetParameter[]? SetParameters { get; set; }
    public ProfileModifyAlter[]? Alters { get; set; }
}
