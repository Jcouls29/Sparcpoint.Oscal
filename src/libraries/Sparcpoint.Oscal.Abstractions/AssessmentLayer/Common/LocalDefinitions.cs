namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record LocalDefinitions
{
    public Component[]? Components { get; set; }
    public InventoryItem[]? InventoryItems { get; set; }
    public User[]? Users { get; set; }
    public ObjectivesAndMethods[]? ObjectivesAndMethods { get; set; }
    public Activity[]? Activities { get; set; }
}
