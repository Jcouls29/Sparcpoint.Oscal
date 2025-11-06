using Sparcpoint.Oscal.AssessmentLayer;
using Sparcpoint.Oscal.ControlLayer;
using Sparcpoint.Oscal.ImplementationLayer;

namespace Sparcpoint.Oscal;

public record OscalModel
{
    public OscalModelKind Kind
    {
        get
        {
            var count = (Catalog is not null ? 1 : 0) +
                        (Profile is not null ? 1 : 0) +
                        (ComponentDefinition is not null ? 1 : 0) +
                        (SystemSecurityPlan is not null ? 1 : 0) +
                        (AssessmentPlan is not null ? 1 : 0) +
                        (AssessmentResults is not null ? 1 : 0) +
                        (PlanOfActionAndMilestones is not null ? 1 : 0);

            if (count > 1)
                return OscalModelKind.Unknown;

            if (Catalog is not null)
                return OscalModelKind.Catalog;
            if (Profile is not null)
                return OscalModelKind.Profile;
            if (ComponentDefinition is not null)
                return OscalModelKind.ComponentDefinition;
            if (SystemSecurityPlan is not null)
                return OscalModelKind.SystemSecurityPlan;
            if (AssessmentPlan is not null)
                return OscalModelKind.AssessmentPlan;
            if (AssessmentResults is not null)
                return OscalModelKind.AssessmentResults;
            if (PlanOfActionAndMilestones is not null)
                return OscalModelKind.PlanOfActionAndMilestones;
            
            return OscalModelKind.Unknown;
        }
    }

    public Catalog? Catalog { get; set; }
    public Profile? Profile { get; set; }
    public ComponentDefinition? ComponentDefinition { get; set; }
    public SystemSecurityPlan? SystemSecurityPlan { get; set; }
    public AssessmentPlan? AssessmentPlan { get; set; }
    public AssessmentResults? AssessmentResults { get; set; }
    public PlanOfActionAndMilestones? PlanOfActionAndMilestones { get; set; }
}

public enum OscalModelKind
{
    Unknown,
    Catalog,
    Profile,
    ComponentDefinition,
    SystemSecurityPlan,
    AssessmentPlan,
    AssessmentResults,
    PlanOfActionAndMilestones
}