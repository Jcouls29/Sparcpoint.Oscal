namespace Sparcpoint.Oscal;

public static class MediaTypeParser
{
    public static MediaTypeParts Parse(string mediaType)
    {
        if (string.IsNullOrWhiteSpace(mediaType))
            throw new ArgumentException("Media type cannot be null or empty.", nameof(mediaType));

        // Split parameters (after the first ';')
        var parts = mediaType.Split(';', 2, StringSplitOptions.TrimEntries);
        var fullType = parts[0].Trim();
        var parametersPart = parts.Length > 1 ? parts[1].Trim() : string.Empty;

        // Split type/subtype
        var typeParts = fullType.Split('/', 2, StringSplitOptions.TrimEntries);
        if (typeParts.Length != 2)
            throw new FormatException($"Invalid media type: '{mediaType}'");

        var type = typeParts[0];
        var subtype = typeParts[1];
        string? suffix = null;

        // Handle structured syntax suffix (e.g., +json)
        var plusIndex = subtype.IndexOf('+');
        if (plusIndex >= 0)
        {
            suffix = subtype[(plusIndex + 1)..];
            subtype = subtype[..plusIndex];
        }

        // Parse parameters (e.g., charset=utf8)
        var parameters = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        if (!string.IsNullOrEmpty(parametersPart))
        {
            var paramPairs = parametersPart.Split(';', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            foreach (var pair in paramPairs)
            {
                var kv = pair.Split('=', 2, StringSplitOptions.TrimEntries);
                if (kv.Length == 2)
                    parameters[kv[0]] = kv[1];
                else
                    parameters[kv[0]] = string.Empty;
            }
        }

        return new MediaTypeParts(type, subtype, suffix, parameters);
    }
}
