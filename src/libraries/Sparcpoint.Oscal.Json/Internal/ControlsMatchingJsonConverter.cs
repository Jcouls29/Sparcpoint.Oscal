using Sparcpoint.Oscal.Common;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sparcpoint.Oscal.Json;

internal class ControlsMatchingJsonConverter : JsonConverter<ControlsMatching>
{
    public override ControlsMatching? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var value = reader.GetString();
            return new ControlsMatching { Pattern = value };
        }

        return null;
    }

    public override void Write(Utf8JsonWriter writer, ControlsMatching value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Pattern);
    }
}
