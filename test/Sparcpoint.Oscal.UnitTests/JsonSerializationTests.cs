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

    [Theory]
    [InlineData("catalog.json")]
    [InlineData("profile.json")]
    [InlineData("catalog_oscal_official_1.1.3.json")]
    [InlineData("profile_oscal_official_1.1.3.json")]
    public void ReserializedJsonMatches(string filename)
    {
        var expected = GetSampleFile(filename);
        var catalog = JsonSerializer.Deserialize<OscalModel>(expected, _Options);

        Assert.NotNull(catalog);
        var actual = StructuralComparison.Canonicalize(JsonSerializer.Serialize(catalog, _Options));
        Assert.Equal(expected, actual);
    }

    private string GetSampleFile(string filename)
    {
        var sample = File.ReadAllText($"Samples/{filename}");
        return StructuralComparison.Canonicalize(sample);
    }
}
