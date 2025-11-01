namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record AssessmentSubject : OscalRemarksModel
{
    public Token Type { get; set; }
    public MarkupMultiline? Description { get; set; }
    // Choose One of the Following:
    public object? IncludeAll { get; set; }
    public IncludeExcludeSubject[]? IncludeSubjects { get; set; }
    // ****************************
    public IncludeExcludeSubject[]? ExcludeSubjects { get; set; }
}
