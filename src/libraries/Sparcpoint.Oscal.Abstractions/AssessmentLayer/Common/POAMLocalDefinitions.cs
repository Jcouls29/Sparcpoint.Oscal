namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record POAMLocalDefinitions
{
    public AssessmentResultComponent[]? Components { get; set; }
    public InventoryItem[]? InventoryItems { get; set; }
    public AssessmentAssets? AssessmentAssets { get; set; }
    public MarkupMultiline? Remarks { get; set; }
}