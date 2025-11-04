using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sparcpoint.Oscal.Json;

internal class StructToUintJsonConverter<TStruct> : JsonConverter<TStruct?>
    where TStruct : struct
{
    private readonly Func<uint, TStruct?> _Setter;
    private readonly Func<TStruct?, uint> _Getter;

    public StructToUintJsonConverter(Func<uint, TStruct?> setter, Func<TStruct?, uint> getter)
    {
        _Setter = setter ?? throw new ArgumentNullException(nameof(setter));
        _Getter = getter ?? throw new ArgumentNullException(nameof(getter));
    }

    public override TStruct? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (typeToConvert != typeof(TStruct))
            return null;

        if (reader.TokenType == JsonTokenType.Null)
            return null;

        if (reader.TokenType != JsonTokenType.Number)
            return null;

        return _Setter(reader.GetUInt32());
    }

    public override void Write(Utf8JsonWriter writer, TStruct? value, JsonSerializerOptions options)
    {
        var jsonValue = _Getter(value);
        writer.WriteNumberValue(jsonValue);
    }
}
