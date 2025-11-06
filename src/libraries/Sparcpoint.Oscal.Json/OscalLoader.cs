using Json.Schema;
using System.Buffers;
using System.Collections.Concurrent;
using System.Text.Json;

namespace Sparcpoint.Oscal.Json;

public static class OscalLoader
{
    // Cache compiled schemas
    private static readonly ConcurrentDictionary<string, ValueTask<JsonSchema>> _schemaCache = new();
    private static readonly JsonDocumentOptions JsonDocumentOptions = new()
    {
        AllowTrailingCommas = true,
        CommentHandling = JsonCommentHandling.Skip
    };

    public static Task<OscalLoadResult> ValidateAndLoad(ReadOnlySequence<byte> json)
        => ValidateAndLoad(JsonDocument.Parse(json, JsonDocumentOptions));
    public static Task<OscalLoadResult> ValidateAndLoad(Stream json)
        => ValidateAndLoad(JsonDocument.Parse(json, JsonDocumentOptions));
    public static Task<OscalLoadResult> ValidateAndLoad(string json)
        => ValidateAndLoad(JsonDocument.Parse(json, JsonDocumentOptions));

    public static async Task<OscalLoadResult> ValidateAndLoad(JsonDocument document)
    {
        var kind = DetectModelKind(document.RootElement);

        // Fall back: brute-force try all schemas (useful for edge cases)
        if (kind == OscalModelKind.Unknown)
        {
            foreach (var kvp in SchemaFileByKind)
            {
                var schema = await GetSchema(kvp.Value);
                var result = schema.Evaluate(document.RootElement);

                if (result.IsValid)
                    return new OscalLoadResult(null, result);
            }

            // none matched; return the best (first) failure
            var firstSchema = await GetSchema(SchemaFileByKind.First().Value);
            var firstResult = firstSchema.Evaluate(document.RootElement);
            return new OscalLoadResult(null, firstResult);
        }

        // Validate against the detected schema
        if (!SchemaFileByKind.TryGetValue(kind, out var schemaFile))
        {
            // Detected a known key but you don't have that schema embedded yet.
            return new OscalLoadResult(null, null);
        }

        var detectedSchema = await GetSchema(schemaFile);
        var validation = detectedSchema.Evaluate(document.RootElement);

        var model = document.Deserialize<OscalModel>(JsonSerializerOptionsBuilder.ForOscalModels());

        return new OscalLoadResult(model, validation);
    }

    private static OscalModelKind DetectModelKind(JsonElement root)
    {
        if (root.ValueKind != JsonValueKind.Object)
            return OscalModelKind.Unknown;

        // Match by canonical top-level property names
        foreach (var prop in root.EnumerateObject())
        {
            return prop.Name switch
            {
                "catalog" => OscalModelKind.Catalog,
                "profile" => OscalModelKind.Profile,
                "component-definition" => OscalModelKind.ComponentDefinition,
                "system-security-plan" => OscalModelKind.SystemSecurityPlan,
                "assessment-plan" => OscalModelKind.AssessmentPlan,
                "assessment-results" => OscalModelKind.AssessmentResults,
                "plan-of-action-and-milestones" => OscalModelKind.PlanOfActionAndMilestones,
                _ => OscalModelKind.Unknown
            };
        }

        return OscalModelKind.Unknown;
    }

    // Map detection → schema file name in your Schemas/ folder
    private static readonly Dictionary<OscalModelKind, string> SchemaFileByKind = new()
    {
        [OscalModelKind.Catalog] = "oscal_catalog_schema.json",
        [OscalModelKind.Profile] = "oscal_profile_schema.json",
        [OscalModelKind.ComponentDefinition] = "oscal_component_schema.json",
        [OscalModelKind.SystemSecurityPlan] = "oscal_ssp_schema.json", // adjust to your actual file name
        [OscalModelKind.AssessmentPlan] = "oscal_assessment-plan_schema.json",
        [OscalModelKind.AssessmentResults] = "oscal_assessment-results_schema.json",
        [OscalModelKind.PlanOfActionAndMilestones] = "oscal_poam_schema.json",
    };

    private static ValueTask<JsonSchema> GetSchema(string fileName)
    {
        return _schemaCache.GetOrAdd(fileName, fn =>
        {
            using var stream = EmbeddedSchemas.Read(fn); // from earlier helper
            return JsonSchema.FromStream(stream);
        });
    }
}