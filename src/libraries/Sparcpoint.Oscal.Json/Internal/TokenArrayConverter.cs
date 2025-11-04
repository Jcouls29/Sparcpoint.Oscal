using Sparcpoint.Oscal.Primitives;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sparcpoint.Oscal.Json;

public class TokenArrayConverter : JsonConverter<Token[]>
{
    public override Token[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
            return new[] { new Token(reader.GetString()) };

        if (reader.TokenType == JsonTokenType.StartArray)
        {
            var list = new List<Token>();
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                    break;
                if (reader.TokenType != JsonTokenType.String)
                    throw new JsonException("Expected string");
                list.Add(new Token(reader.GetString()));
            }
            return list.ToArray();
        }

        throw new JsonException($"Unexpected token: {reader.TokenType}");
    }

    public override void Write(Utf8JsonWriter writer, Token[] value, JsonSerializerOptions options)
    {
        if (value.Length == 1)
        {
            writer.WriteStringValue(value[0].Value);
        }
        else if (value.Length > 0)
        {
            writer.WriteStartArray();
            foreach (var t in value)
                writer.WriteStringValue(t.Value); // uses explicit Token->string above
            writer.WriteEndArray();
        }

            
    }
}