namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record Response : OscalRemarksModel
{
    public Uuid Uuid { get; set; }
    public Token Lifecycle { get; set; }
    public MarkupLine Title { get; set; }
    public MarkupMultiline Description { get; set; }
    public Origin[]? Origins { get; set; }
    public RequiredAsset[]? RequiredAssets { get; set; }
    public AssessmentTask[]? Tasks { get; set; }
}
