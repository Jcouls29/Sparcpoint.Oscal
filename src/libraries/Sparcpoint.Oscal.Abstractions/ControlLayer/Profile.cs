using Sparcpoint.Oscal.ControlLayer.Common;

namespace Sparcpoint.Oscal.ControlLayer;

public record Profile
{
    public Uuid Uuid { get; set; }
    public Metadata Metadata { get; set; } = new Metadata();
    public ProfileImport[] Imports { get; set; } = Array.Empty<ProfileImport>();
    public ProfileMerge? Merge { get; set; }
    public ProfileModify? Modify { get; set; }
    public BackMatter? BackMatter { get; set; }
}
