using Sparcpoint.Oscal.AssessmentLayer;
using Sparcpoint.Oscal.ControlLayer;
using Sparcpoint.Oscal.ImplementationLayer;

namespace Sparcpoint.Oscal.Base;

public record OscalModel
{
    public Catalog? Catalog { get; set; }
    public Profile? Profile { get; set; }
    public ComponentDefinition? ComponentDefinition { get; set; }
    public SystemSecurityPlan? SystemSecurityPlan { get; set; }
    public AssessmentPlan? AssessmentPlan { get; set; }
    public AssessmentResults? AssessmentResults { get; set; }
    public PlanOfActionAndMilestones? PlanOfActionAndMilestones { get; set; }
}