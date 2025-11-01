using Sparcpoint.Oscal.AssessmentLayer.Common;
using Sparcpoint.Oscal.ImplementationLayer.Common;

namespace Sparcpoint.Oscal.AssessmentLayer;

public record PlanOfActionAndMilestones : OscalLayerModel
{
    public Import SystemSecurityPlan { get; set; } = new();
    public SystemId? SystemId { get; set; }
    public POAMLocalDefinitions? LocalDefinitions { get; set; }
    public Observation[]? Observations { get; set; }
    public Risk[]? Risks { get; set; }
    public Finding[]? Findings { get; set; }
    public POAMItem[] PoamItems { get; set; } = Array.Empty<POAMItem>();
}
