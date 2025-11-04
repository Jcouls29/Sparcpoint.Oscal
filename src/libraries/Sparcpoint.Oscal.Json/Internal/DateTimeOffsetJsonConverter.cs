using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sparcpoint.Oscal.Json;

internal class DateTimeOffsetJsonConverter : JsonConverter<DateTimeOffset>
{
    public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return DateTimeOffset.Parse(reader.GetString() ?? string.Empty);
    }

    public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
    {
        var jsonValue = value.ToString("yyyy-MM-ddTHH:mm:ss.fffffK");
        if (jsonValue.EndsWith("+00:00"))
            jsonValue = jsonValue.Replace("+00:00", "-00:00");

        writer.WriteStringValue(jsonValue);
    }
}
