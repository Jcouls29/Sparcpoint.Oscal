using Sparcpoint.Oscal.ControlLayer.Common;

namespace Sparcpoint.Oscal.ControlLayer;

public record Profile : OscalLayerModel
{
    public ProfileImport[] Imports { get; set; } = Array.Empty<ProfileImport>();
    public ProfileMerge? Merge { get; set; }
    public ProfileModify? Modify { get; set; }
}
