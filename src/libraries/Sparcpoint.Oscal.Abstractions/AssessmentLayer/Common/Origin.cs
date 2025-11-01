namespace Sparcpoint.Oscal.AssessmentLayer.Common;

public record Origin
{
    public Actor[] Actors { get; set; } = Array.Empty<Actor>();
    public RelatedTask[]? RelatedTasks { get; set; }
}
