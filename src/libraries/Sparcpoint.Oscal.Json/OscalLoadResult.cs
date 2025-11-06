using Json.Schema;

namespace Sparcpoint.Oscal.Json;

public sealed record OscalLoadResult(OscalModel? Model, EvaluationResults? Validation)
{
    public bool IsValid => Validation?.IsValid ?? false;
    public OscalModelKind Kind => Model?.Kind ?? OscalModelKind.Unknown;
}