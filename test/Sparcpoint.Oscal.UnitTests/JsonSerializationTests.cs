using Sparcpoint.Oscal.Base;
using Sparcpoint.Oscal.Json;
using System.Text.Json;

namespace Sparcpoint.Oscal.UnitTests;

public class JsonSerializationTests
{
    private readonly JsonSerializerOptions _Options;

    public JsonSerializationTests()
    {
        _Options = JsonSerializerOptionsBuilder.Build(writeIndented: true);
    }

    [Fact]
    public void ReserializedCatalogJsonMatches()
    {
        var expected = GetSampleFile("catalog.json");
        var catalog = JsonSerializer.Deserialize<OscalModel>(expected, _Options);

        Assert.NotNull(catalog);
        var actual = StructuralComparison.Canonicalize(JsonSerializer.Serialize(catalog, _Options));
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ReserializedProfileJsonMatches()
    {
        var expected = GetSampleFile("profile.json");
        var catalog = JsonSerializer.Deserialize<OscalModel>(expected, _Options);

        Assert.NotNull(catalog);
        var actual = StructuralComparison.Canonicalize(JsonSerializer.Serialize(catalog, _Options));
        Assert.Equal(expected, actual);
    }

    private string GetSampleFile(string filename)
    {
        var sample = File.ReadAllText($"Samples/{filename}");

        // Normalize DateTimeOffsets
        sample = sample.Replace("0.000000-0", "0.00000-0");

        return StructuralComparison.Canonicalize(sample);
    }
}
