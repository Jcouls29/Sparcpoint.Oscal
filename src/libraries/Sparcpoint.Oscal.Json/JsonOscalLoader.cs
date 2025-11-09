using System.Net.Http.Headers;

namespace Sparcpoint.Oscal.Json;

public class JsonOscalLoader : IOscalLoader
{
    public bool CanLoad(string mediaType)
    {
        var parsed = MediaTypeParser.Parse(mediaType);
        if (!parsed.Type.Equals("application", StringComparison.OrdinalIgnoreCase))
            return false;

        if (parsed.Subtype.Equals("json", StringComparison.OrdinalIgnoreCase) && string.IsNullOrWhiteSpace(parsed.Suffix))
            return true;

        if (parsed.Suffix != null && parsed.Suffix.Equals("json", StringComparison.OrdinalIgnoreCase))
            return parsed.Subtype.StartsWith("oscal", StringComparison.OrdinalIgnoreCase);

        return false;
    }

    public Task<OscalLoadResult> ValidateAndLoadAsync(Stream stream)
        => OscalLoader.ValidateAndLoad(stream);
}
