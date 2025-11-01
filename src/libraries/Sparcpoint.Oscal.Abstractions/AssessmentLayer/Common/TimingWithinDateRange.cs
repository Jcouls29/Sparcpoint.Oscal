namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record TimingWithinDateRange
{
    public DateTimeOffset Start { get; set; }
    public DateTimeOffset End { get; set; }
}
