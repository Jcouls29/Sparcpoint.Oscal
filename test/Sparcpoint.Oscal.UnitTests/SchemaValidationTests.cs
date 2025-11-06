using Sparcpoint.Oscal.Json;

namespace Sparcpoint.Oscal.UnitTests;

public class SchemaValidationTests
{
    [Theory]
    [InlineData("catalog.json", "Catalog")]
    [InlineData("catalog_oscal_official_1.1.3.json", "Catalog")]
    [InlineData("profile_oscal_official_1.1.3.json", "Profile")]
    public async Task SampleFileValidatesAgainstSchema(string filename, string schemaType)
    {
        var sample = File.ReadAllText($"Samples/{filename}");
        var results = schemaType switch
        {
            "Catalog" => await SchemaValidation.Catalog(sample),
            "Profile" => await SchemaValidation.Profile(sample),
            _ => throw new NotSupportedException($"Schema type '{schemaType}' is not supported.")
        };
        Assert.True(results.IsValid, $"Schema validation failed: {results}"); 
    }
}
