using Sparcpoint.Oscal.ControlLayer.Common;

namespace Sparcpoint.Oscal.ControlLayer;

public record Profile : OscalLayerModel
{
    public CatalogImport[] Imports { get; set; } = Array.Empty<CatalogImport>();
    public ProfileMerge? Merge { get; set; }
    public ProfileModify? Modify { get; set; }
}
