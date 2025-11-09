using Sparcpoint.Extensions.Json;
using Sparcpoint.Oscal;
using Sparcpoint.Oscal.Base;
using Sparcpoint.Oscal.Common;
using Sparcpoint.Oscal.ControlLayer;
using Sparcpoint.Oscal.ControlLayer.Common;
using Sparcpoint.Oscal.Json;
using Sparcpoint.Oscal.Primitives;

namespace System.Text.Json;

public static class JsonSerializerOptionsBuilder
{
    public static JsonSerializerOptions ForOscalModels()
        => ForOscalModels(new JsonSerializerOptions());
    public static JsonSerializerOptions ForOscalModels(this JsonSerializerOptions options)
    {
        options.PropertyNamingPolicy = JsonNamingPolicy.KebabCaseLower;
        options.ConfigureCommonModels();
        options.Encoder = Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

        return options;
    }

    private static JsonSerializerOptions ConfigureCommonModels(this JsonSerializerOptions options)
    {
        options
            .Configure<Part>(b => b.Property(p => p.Namespace).Name("ns"))
            .Configure<Prop>(b => b.Property(p => p.Namespace).Name("ns"))
            .Configure<Resource>(b => b.Property(p => p.ResourceLinks).Name("rlinks"))
            .Configure<ProfileModifyRemove>(b => b.Property(p => p.ByNamespace).Name("by-ns"))
            .Configure<Catalog>(b => b
                .Property(p => p.Uuid).Order(0)
                .Property(p => p.Metadata).Order(10)
                .Property(p => p.Groups).Order(20)
                .Property(p => p.BackMatter).Order(30)
            )
            .Configure<OscalRemarksModel>(b => b
                .Property(p => p.Remarks).Order(1000)
            )
            .Configure<Address>(b => b
                .Property(p => p.AddressLines).Name("addr-lines")
            )
            .Configure<OscalModel>(b => b
                .Property(p => p.Kind).Ignore()
            )
        ;

        options
            .WithStringConverter<Base64Value>((value) => new Base64Value(value), (value) => value.Value)
            .WithStringConverter<EmailAddress>((value) => new EmailAddress(value), (value) => value.Value)
            .WithStringConverter<MarkupLine>((value) => new MarkupLine(value), (value) => value.Value)
            .WithStringConverter<MarkupMultiline>((value) => new MarkupMultiline(value), (value) => value.Value)
            .WithUintConverter<NonNegativeInteger>((value) => new NonNegativeInteger(value), (value) => value?.Value ?? 0)
            .WithUintConverter<PositiveInteger>((value) => PositiveInteger.Create(value), (value) => value?.Value ?? 1)
            .WithStringConverter<Token>((value) => new Token(value), (value) => value.Value)
            .WithStringConverter<Uuid>((value) => new Uuid(value), (value) => value.Value)
        ;

        options.Converters.Add(new DateTimeOffsetJsonConverter());

        return options;
    }

    private static JsonSerializerOptions WithStringConverter<T>(this JsonSerializerOptions options, Func<string?, T> setter, Func<T, string?> getter)
        where T : struct
    {
        options.Converters.Add(new StructToStringJsonConverter<T>(setter, getter));
        return options;
    }

    private static JsonSerializerOptions WithUintConverter<T>(this JsonSerializerOptions options, Func<uint, T?> setter, Func<T?, uint> getter)
        where T : struct
    {
        options.Converters.Add(new StructToUintJsonConverter<T>(setter, getter));
        return options;
    }
}
