using System.Reflection;

namespace Sparcpoint.Oscal.Json;

internal static class EmbeddedSchemas
{
    private static readonly Assembly This = typeof(EmbeddedSchemas).Assembly;

    /// Lists all resource names (useful for debugging)
    public static IEnumerable<string> List() => This.GetManifestResourceNames();

    /// Reads an embedded schema by file name (e.g., "oscal_catalog_schema.json")
    public static Stream Read(string fileName)
    {
        var name = This.GetManifestResourceNames()
            .FirstOrDefault(n => n.EndsWith($".Schemas.{fileName}", StringComparison.Ordinal));

        if (name is null)
            throw new InvalidOperationException(
                $"Embedded schema '{fileName}' not found. " +
                $"Available: {string.Join(", ", List())}");

        return This.GetManifestResourceStream(name)
            ?? throw new InvalidOperationException($"Resource stream '{name}' not found.");
    }
}
