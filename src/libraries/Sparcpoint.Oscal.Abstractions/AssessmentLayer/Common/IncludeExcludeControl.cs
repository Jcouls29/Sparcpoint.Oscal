namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record IncludeExcludeControl
{
    public Token ControlId { get; set; }
    public Token[]? StatementIds { get; set; }
}