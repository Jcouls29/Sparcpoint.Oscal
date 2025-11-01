namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record Dependency
{
    public Uuid TaskUuid { get; set; }
    public MarkupMultiline? Remarks { get; set; }
}
