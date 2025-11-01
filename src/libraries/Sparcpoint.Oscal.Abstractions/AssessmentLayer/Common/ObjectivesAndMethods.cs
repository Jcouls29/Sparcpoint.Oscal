namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record ObjectivesAndMethods : OscalRemarksModel
{
    public Token ControlId { get; set; }
    public MarkupMultiline? Description { get; set; }
    public Part[]? Parts { get; set; }
}
