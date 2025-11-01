namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record Timing
{
    // Choice of one of these:
    public TimingOnDate? OnDate { get; set; }
    public TimingWithinDateRange? WithinDateRange { get; set; }
    public TimingAtFrequency? AtFrequency { get; set; }
}
