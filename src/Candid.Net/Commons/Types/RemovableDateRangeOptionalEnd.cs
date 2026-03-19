// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(RemovableDateRangeOptionalEnd.JsonConverter))]
[Serializable]
public record RemovableDateRangeOptionalEnd
{
    internal RemovableDateRangeOptionalEnd(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of RemovableDateRangeOptionalEnd with <see cref="RemovableDateRangeOptionalEnd.DateRange"/>.
    /// </summary>
    public RemovableDateRangeOptionalEnd(RemovableDateRangeOptionalEnd.DateRange value)
    {
        Type = "date_range";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of RemovableDateRangeOptionalEnd with <see cref="RemovableDateRangeOptionalEnd.Remove"/>.
    /// </summary>
    public RemovableDateRangeOptionalEnd(RemovableDateRangeOptionalEnd.Remove value)
    {
        Type = "remove";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Type"/> is "date_range"
    /// </summary>
    public bool IsDateRange => Type == "date_range";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "remove"
    /// </summary>
    public bool IsRemove => Type == "remove";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Commons.DateRangeOptionalEnd"/> if <see cref="Type"/> is 'date_range', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'date_range'.</exception>
    public global::Candid.Net.Commons.DateRangeOptionalEnd AsDateRange() =>
        IsDateRange
            ? (global::Candid.Net.Commons.DateRangeOptionalEnd)Value!
            : throw new global::System.Exception(
                "RemovableDateRangeOptionalEnd.Type is not 'date_range'"
            );

    /// <summary>
    /// Returns the value as a <see cref="object"/> if <see cref="Type"/> is 'remove', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'remove'.</exception>
    public object AsRemove() =>
        IsRemove
            ? Value!
            : throw new global::System.Exception(
                "RemovableDateRangeOptionalEnd.Type is not 'remove'"
            );

    public T Match<T>(
        Func<global::Candid.Net.Commons.DateRangeOptionalEnd, T> onDateRange,
        Func<object, T> onRemove,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "date_range" => onDateRange(AsDateRange()),
            "remove" => onRemove(AsRemove()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.Commons.DateRangeOptionalEnd> onDateRange,
        Action<object> onRemove,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "date_range":
                onDateRange(AsDateRange());
                break;
            case "remove":
                onRemove(AsRemove());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Commons.DateRangeOptionalEnd"/> and returns true if successful.
    /// </summary>
    public bool TryAsDateRange(out global::Candid.Net.Commons.DateRangeOptionalEnd? value)
    {
        if (Type == "date_range")
        {
            value = (global::Candid.Net.Commons.DateRangeOptionalEnd)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="object"/> and returns true if successful.
    /// </summary>
    public bool TryAsRemove(out object? value)
    {
        if (Type == "remove")
        {
            value = Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator RemovableDateRangeOptionalEnd(
        RemovableDateRangeOptionalEnd.DateRange value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<RemovableDateRangeOptionalEnd>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(RemovableDateRangeOptionalEnd).IsAssignableFrom(typeToConvert);

        public override RemovableDateRangeOptionalEnd Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("type", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'type'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'type' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'type' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'type' is null");

            var value = discriminator switch
            {
                "date_range" => json.Deserialize<global::Candid.Net.Commons.DateRangeOptionalEnd?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize global::Candid.Net.Commons.DateRangeOptionalEnd"
                    ),
                "remove" => new { },
                _ => json.Deserialize<object?>(options),
            };
            return new RemovableDateRangeOptionalEnd(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RemovableDateRangeOptionalEnd value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "date_range" => JsonSerializer.SerializeToNode(value.Value, options),
                    "remove" => null,
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for date_range
    /// </summary>
    [Serializable]
    public struct DateRange
    {
        public DateRange(global::Candid.Net.Commons.DateRangeOptionalEnd value)
        {
            Value = value;
        }

        internal global::Candid.Net.Commons.DateRangeOptionalEnd Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator RemovableDateRangeOptionalEnd.DateRange(
            global::Candid.Net.Commons.DateRangeOptionalEnd value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for remove
    /// </summary>
    [Serializable]
    public record Remove
    {
        internal object Value => new { };

        public override string ToString() => Value.ToString() ?? "null";
    }
}
