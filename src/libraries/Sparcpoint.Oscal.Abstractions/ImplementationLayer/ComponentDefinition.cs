using Sparcpoint.Oscal.ImplementationLayer.Common;

namespace Sparcpoint.Oscal.ImplementationLayer;

public record ComponentDefinition : OscalLayerModel
{
    public ImportComponentDefinition[]? ImportComponentDefinitions { get; set; }
    public Component[]? Components { get; set; }
    public Capability[]? Capabilities { get; set; }
}
