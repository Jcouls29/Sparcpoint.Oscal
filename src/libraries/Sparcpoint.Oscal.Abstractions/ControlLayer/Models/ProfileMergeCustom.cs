namespace Sparcpoint.Oscal.ControlLayer.Common;

public record ProfileMergeCustom
{
    public Group[]? Groups { get; set; }
    public InsertControls[]? InsertControls { get; set; }
}
