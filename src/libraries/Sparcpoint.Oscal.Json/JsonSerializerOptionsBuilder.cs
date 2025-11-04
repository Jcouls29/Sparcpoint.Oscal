using Sparcpoint.Extensions.Json;
using Sparcpoint.Oscal.Common;
using Sparcpoint.Oscal.ControlLayer.Common;
using Sparcpoint.Oscal.Primitives;
using System.Text.Json;

namespace Sparcpoint.Oscal.Json;

public static class JsonSerializerOptionsBuilder
{
    public static JsonSerializerOptions Build()
    {
        var options = new JsonSerializerOptions();
        options.PropertyNamingPolicy = JsonNamingPolicy.KebabCaseLower;
        options.ConfigureCommonModels();

        return options;
    }

    private static JsonSerializerOptions ConfigureCommonModels(this JsonSerializerOptions options)
    {
        options
            .Configure<Part>(b => b.Property(p => p.Namespace).Name("ns"))
            .Configure<Prop>(b => b.Property(p => p.Namespace).Name("ns"))
            .Configure<Resource>(b => b.Property(p => p.ResourceLinks).Name("rlinks"))
            .Configure<ProfileModifyRemove>(b => b.Property(p => p.ByNamespace).Name("by-ns"))
        ;

        options
            .WithStringConverter<Base64Value>((value) => value == null ? null : new Base64Value(value), (value) => value?.Value)
            .WithStringConverter<EmailAddress>((value) => value == null ? null : new EmailAddress(value), (value) => value?.Value)
            .WithStringConverter<MarkupLine>((value) => value == null ? null : new MarkupLine(value), (value) => value?.Value)
            .WithStringConverter<MarkupMultiline>((value) => value == null ? null : new MarkupMultiline(value), (value) => value?.Value)
            .WithUintConverter<NonNegativeInteger>((value) => value == null ? null : new NonNegativeInteger(value.Value), (value) => value?.Value)
            .WithUintConverter<PositiveInteger>((value) => value == null ? null : PositiveInteger.Create(value.Value), (value) => value?.Value)
            .WithStringConverter<Token>((value) => value == null ? null : new Token(value), (value) => value?.Value)
            .WithStringConverter<Uuid>((value) => value == null ? null : new Uuid(value), (value) => value?.Value)
        ;

        return options;
    }

    private static JsonSerializerOptions WithStringConverter<T>(this JsonSerializerOptions options, Func<string?, T?> setter, Func<T?, string?> getter)
        where T : struct
    {
        options.Converters.Add(new StructToStringJsonConverter<T>(setter, getter));
        return options;
    }

    private static JsonSerializerOptions WithUintConverter<T>(this JsonSerializerOptions options, Func<uint?, T?> setter, Func<T?, uint?> getter)
        where T : struct
    {
        options.Converters.Add(new StructToUintJsonConverter<T>(setter, getter));
        return options;
    }
}
