namespace Sparcpoint.Oscal.ControlLayer.Common;

public record ProfileMerge
{
    public ProfileMergeCombine? Combine { get; set; }

    // Choice of one of the following:
    public object? Flat { get; set; }
    public bool? AsIs { get; set; }
    public ProfileMergeCustom? Custom { get; set; }
    // *******************************
}
