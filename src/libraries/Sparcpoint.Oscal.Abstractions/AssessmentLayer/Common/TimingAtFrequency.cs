namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record TimingAtFrequency
{
    public PositiveInteger Period { get; set; }
    public string Unit { get; set; } = string.Empty;
}
