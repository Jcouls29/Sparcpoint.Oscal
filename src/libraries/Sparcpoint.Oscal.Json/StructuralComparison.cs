using System.Globalization;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Sparcpoint.Oscal.Json;

public static class StructuralComparison
{
    public static string Canonicalize(string json)
    {
        var node = JsonNode.Parse(json)!;
        var normalized = Normalize(node);
        // Compact, stable output
        return normalized.ToJsonString(new JsonSerializerOptions { WriteIndented = false });
    }

    private static JsonNode Normalize(JsonNode node)
    {
        switch (node)
        {
            case JsonObject obj:
                {
                    var sorted = new JsonObject();
                    foreach (var kv in obj.OrderBy(k => k.Key, StringComparer.Ordinal))
                    {
                        // DROP null-valued properties
                        if (kv.Value is null)
                            continue;

                        var child = Normalize(kv.Value);
                        sorted[kv.Key] = child;
                    }
                    return sorted;
                }

            case JsonArray arr:
                {
                    var newArr = new JsonArray();
                    foreach (var item in arr)
                    {
                        // Keep array nulls; remove if you prefer: if (item is null) continue;
                        newArr.Add(item is null ? null : Normalize(item));
                    }
                    return newArr;
                }

            case JsonValue val:
                {
                    if (val.TryGetValue<string>(out var s) &&
                        TryCanonDto(s, out var canon))
                    {
                        return JsonValue.Create(canon)!;
                    }
                    // Always return a fresh node to avoid "node already has a parent"
                    return val.DeepClone();
                }

            default:
                return node.DeepClone();
        }
    }

    private static bool TryCanonDto(string s, out string canonical)
    {
        if (DateTimeOffset.TryParse(s, CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind, out var dto))
        {
            canonical = dto.ToUniversalTime().ToString("O", CultureInfo.InvariantCulture);
            return true;
        }
        canonical = default!;
        return false;
    }
}