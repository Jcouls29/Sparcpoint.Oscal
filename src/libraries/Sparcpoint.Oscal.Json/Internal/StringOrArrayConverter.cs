using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sparcpoint.Oscal.Json;

public class StringOrArrayConverter : JsonConverter<string[]>
{
    public override string[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            return new[] { reader.GetString()! };
        }

        if (reader.TokenType == JsonTokenType.StartArray)
        {
            var list = new List<string>();
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                    break;

                if (reader.TokenType == JsonTokenType.String)
                    list.Add(reader.GetString()!);
                else
                    throw new JsonException("Expected string in array");
            }
            return list.ToArray();
        }

        throw new JsonException($"Unexpected token: {reader.TokenType}");
    }

    public override void Write(Utf8JsonWriter writer, string[] value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        foreach (var v in value)
            writer.WriteStringValue(v);
        writer.WriteEndArray();
    }
}
