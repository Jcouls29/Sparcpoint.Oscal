namespace Sparcpoint.Oscal.ImplementationLayer.Common;

public record SystemImplementation : OscalRemarksModel
{
    public LeveragedAuthorization[]? LeveragedAuthorizations { get; set; }
    public User[] Users { get; set; } = Array.Empty<User>();
    public ImplementationComponent[] Components { get; set; } = Array.Empty<ImplementationComponent>();
    public InventoryItem[]? InventoryItems { get; set; }
}

