using Sparcpoint.Oscal.Base;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Sparcpoint.Oscal.UnitTests;

public class JsonSerializationTests
{
    private readonly JsonSerializerOptions _Options;

    public JsonSerializationTests()
    {
        _Options = new JsonSerializerOptions().ForOscalModels();
    }

    [Theory]
    [InlineData("catalog.json")]
    [InlineData("catalog_oscal_official_1.1.3.json")]
    [InlineData("profile_oscal_official_1.1.3.json")]
    public void ReserializedJsonMatches(string filename)
    {
        var expected = GetSampleFile(filename);
        var catalog = JsonSerializer.Deserialize<OscalModel>(expected, _Options);

        Assert.NotNull(catalog);
        var actual = JsonSerializer.Serialize(catalog, _Options).CanonicalizeJson();
        Assert.Equal(expected, actual);
    }

    private string GetSampleFile(string filename)
    {
        var sample = File.ReadAllText($"Samples/{filename}");
        return sample.CanonicalizeJson();
    }
}
