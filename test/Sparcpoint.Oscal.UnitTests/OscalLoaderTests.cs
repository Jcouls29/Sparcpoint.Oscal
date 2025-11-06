using Sparcpoint.Oscal.Json;

namespace Sparcpoint.Oscal.UnitTests;

public class OscalLoaderTests
{
    [Theory]
    [InlineData("catalog.json", "Catalog")]
    [InlineData("catalog_oscal_official_1.1.3.json", "Catalog")]
    [InlineData("profile_oscal_official_1.1.3.json", "Profile")]
    public async Task SampleFileLoadsCorrectly(string filename, string expectedKind)
    {
        var sample = File.ReadAllText($"Samples/{filename}");
        var loadResult = await OscalLoader.ValidateAndLoad(sample);

        Assert.NotNull(loadResult.Model);
        Assert.Equal(expectedKind, loadResult.Model.Kind.ToString());
        Assert.NotNull(loadResult.Validation);
        Assert.True(loadResult.Validation.IsValid, $"Schema validation failed: {loadResult.Validation}");
    }
}