namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record ResultLocalDefinitions
{
    public AssessmentResultComponent[]? Components { get; set; }
    public InventoryItem[]? InventoryItems { get; set; }
    public User[]? Users { get; set; }
    public AssessmentResultAssets? AssessmentAssets { get; set; }
    public AssessmentTask[]? Tasks { get; set; }
}
