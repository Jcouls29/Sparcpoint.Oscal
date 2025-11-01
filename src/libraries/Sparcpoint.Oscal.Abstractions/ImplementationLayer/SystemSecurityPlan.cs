using Sparcpoint.Oscal.ImplementationLayer.Common;

namespace Sparcpoint.Oscal.ImplementationLayer;

public record SystemSecurityPlan : OscalLayerModel
{
    public ImportProfile ImportProfile { get; set; } = new();
    public SystemCharacteristics SystemCharacteristics { get; set; } = new();
    public SystemImplementation SystemImplementation { get; set; } = new();
    public SystemSecurityPlanControlImplementation ControlImplementation { get; set; } = new();
}