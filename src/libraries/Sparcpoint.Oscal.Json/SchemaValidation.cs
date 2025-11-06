using Json.Schema;
using System.Text.Json;

namespace Sparcpoint.Oscal.Json;

public static class SchemaValidation
{
    // String-Based
    public static Task<EvaluationResults> Catalog(string document)
        => Evaluate(document, "oscal_catalog_schema.json");
    public static Task<EvaluationResults> Profile(string document)
        => Evaluate(document, "oscal_profile_schema.json");
    public static Task<EvaluationResults> Component(string document)
        => Evaluate(document, "oscal_component_schema.json");
    public static Task<EvaluationResults> SystemSecurityPlan(string document)
        => Evaluate(document, "oscal_ssp_schema.json");
    public static Task<EvaluationResults> AssessmentPlan(string document)
        => Evaluate(document, "oscal_assessment-plan_schema.json");
    public static Task<EvaluationResults> AssessmentResults(string document)
        => Evaluate(document, "oscal_assessment-results_schema.json");
    public static Task<EvaluationResults> PlanOfActionAndMilestones(string document)
        => Evaluate(document, "oscal_poam_schema.json");

    // Stream-Based
    public static Task<EvaluationResults> Catalog(Stream document)
        => Evaluate(document, "oscal_catalog_schema.json");
    public static Task<EvaluationResults> Profile(Stream document)
        => Evaluate(document, "oscal_profile_schema.json");
    public static Task<EvaluationResults> Component(Stream document)
        => Evaluate(document, "oscal_component_schema.json");
    public static Task<EvaluationResults> SystemSecurityPlan(Stream document)
        => Evaluate(document, "oscal_ssp_schema.json");
    public static Task<EvaluationResults> AssessmentPlan(Stream document)
        => Evaluate(document, "oscal_assessment-plan_schema.json");
    public static Task<EvaluationResults> AssessmentResults(Stream document)
        => Evaluate(document, "oscal_assessment-results_schema.json");
    
    public static Task<EvaluationResults> PlanOfActionAndMilestones(Stream document)
        => Evaluate(document, "oscal_poam_schema.json");

    private static Task<EvaluationResults> Evaluate(string document, string schemaFilename)
        => Evaluate(JsonDocument.Parse(document), schemaFilename);
    private static Task<EvaluationResults> Evaluate(Stream document, string schemaFilename)
        => Evaluate(JsonDocument.Parse(document), schemaFilename);

    private static async Task<EvaluationResults> Evaluate(JsonDocument json, string schemaFilename)
    {
        using var schemaStream = EmbeddedSchemas.Read(schemaFilename);
        var schema = await JsonSchema.FromStream(schemaStream);

        return schema.Evaluate(json);
    }
}
