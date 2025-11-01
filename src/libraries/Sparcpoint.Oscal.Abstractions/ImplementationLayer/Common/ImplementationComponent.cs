namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record ImplementationComponent : Component
{
    public Status Status { get; set; } = new();
}

