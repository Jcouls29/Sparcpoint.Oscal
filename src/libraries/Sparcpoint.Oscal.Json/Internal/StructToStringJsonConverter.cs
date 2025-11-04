using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sparcpoint.Oscal.Json;

internal class StructToStringJsonConverter<TStruct> : JsonConverter<TStruct>
    where TStruct : struct
{
    private readonly Func<string?, TStruct> _Setter;
    private readonly Func<TStruct, string?> _Getter;

    public StructToStringJsonConverter(Func<string?, TStruct> setter, Func<TStruct, string?> getter)
    {
        _Setter = setter ?? throw new ArgumentNullException(nameof(setter));
        _Getter = getter ?? throw new ArgumentNullException(nameof(getter));
    }

    public override TStruct Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert != typeof(TStruct))
            return default;

        if (reader.TokenType == JsonTokenType.Null)
            return default;

        if (reader.TokenType != JsonTokenType.String)
            return default;

        return _Setter(reader.GetString());
    }

    public override void Write(Utf8JsonWriter writer, TStruct value, JsonSerializerOptions options)
        => writer.WriteStringValue(_Getter(value));
}
