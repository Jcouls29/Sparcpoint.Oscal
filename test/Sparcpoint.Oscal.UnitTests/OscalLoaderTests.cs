using Sparcpoint.Oscal.Json;
using System.Net.Http.Headers;

namespace Sparcpoint.Oscal.UnitTests;

public class OscalLoaderTests
{
    private readonly JsonOscalLoader _Loader;

    public OscalLoaderTests()
    {
        _Loader = new JsonOscalLoader();
    }

    [Fact]
    public void Parse()
    {
        var parsed = new MediaTypeWithQualityHeaderValue("application/oscal.catalog_json");

    }

    [Theory]
    [InlineData("catalog.json", "Catalog")]
    [InlineData("catalog_oscal_official_1.1.3.json", "Catalog")]
    [InlineData("profile_oscal_official_1.1.3.json", "Profile")]
    public async Task SampleFileLoadsCorrectly(string filename, string expectedKind)
    {
        var sample = File.ReadAllText($"Samples/{filename}");
        var loadResult = await _Loader.ValidateAndLoadAsync(sample);

        Assert.NotNull(loadResult.Model);
        Assert.Equal(expectedKind, loadResult.Model.Kind.ToString());
        Assert.Null(loadResult.LoadException);
        Assert.True(loadResult.IsLoaded);
    }
}