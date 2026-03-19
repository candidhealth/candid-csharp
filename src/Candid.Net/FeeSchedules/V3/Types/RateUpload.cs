// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

[JsonConverter(typeof(RateUpload.JsonConverter))]
[Serializable]
public record RateUpload
{
    internal RateUpload(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of RateUpload with <see cref="RateUpload.NewRate"/>.
    /// </summary>
    public RateUpload(RateUpload.NewRate value)
    {
        Type = "new_rate";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of RateUpload with <see cref="RateUpload.NewVersion"/>.
    /// </summary>
    public RateUpload(RateUpload.NewVersion value)
    {
        Type = "new_version";
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
    /// Returns true if <see cref="Type"/> is "new_rate"
    /// </summary>
    public bool IsNewRate => Type == "new_rate";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "new_version"
    /// </summary>
    public bool IsNewVersion => Type == "new_version";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.FeeSchedules.V3.NewRate"/> if <see cref="Type"/> is 'new_rate', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'new_rate'.</exception>
    public global::Candid.Net.FeeSchedules.V3.NewRate AsNewRate() =>
        IsNewRate
            ? (global::Candid.Net.FeeSchedules.V3.NewRate)Value!
            : throw new global::System.Exception("RateUpload.Type is not 'new_rate'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.FeeSchedules.V3.NewRateVersion"/> if <see cref="Type"/> is 'new_version', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'new_version'.</exception>
    public global::Candid.Net.FeeSchedules.V3.NewRateVersion AsNewVersion() =>
        IsNewVersion
            ? (global::Candid.Net.FeeSchedules.V3.NewRateVersion)Value!
            : throw new global::System.Exception("RateUpload.Type is not 'new_version'");

    public T Match<T>(
        Func<global::Candid.Net.FeeSchedules.V3.NewRate, T> onNewRate,
        Func<global::Candid.Net.FeeSchedules.V3.NewRateVersion, T> onNewVersion,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "new_rate" => onNewRate(AsNewRate()),
            "new_version" => onNewVersion(AsNewVersion()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.FeeSchedules.V3.NewRate> onNewRate,
        Action<global::Candid.Net.FeeSchedules.V3.NewRateVersion> onNewVersion,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "new_rate":
                onNewRate(AsNewRate());
                break;
            case "new_version":
                onNewVersion(AsNewVersion());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.FeeSchedules.V3.NewRate"/> and returns true if successful.
    /// </summary>
    public bool TryAsNewRate(out global::Candid.Net.FeeSchedules.V3.NewRate? value)
    {
        if (Type == "new_rate")
        {
            value = (global::Candid.Net.FeeSchedules.V3.NewRate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.FeeSchedules.V3.NewRateVersion"/> and returns true if successful.
    /// </summary>
    public bool TryAsNewVersion(out global::Candid.Net.FeeSchedules.V3.NewRateVersion? value)
    {
        if (Type == "new_version")
        {
            value = (global::Candid.Net.FeeSchedules.V3.NewRateVersion)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator RateUpload(RateUpload.NewRate value) => new(value);

    public static implicit operator RateUpload(RateUpload.NewVersion value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<RateUpload>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(RateUpload).IsAssignableFrom(typeToConvert);

        public override RateUpload Read(
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
                "new_rate" => json.Deserialize<global::Candid.Net.FeeSchedules.V3.NewRate?>(options)
                    ?? throw new JsonException(
                        "Failed to deserialize global::Candid.Net.FeeSchedules.V3.NewRate"
                    ),
                "new_version" =>
                    json.Deserialize<global::Candid.Net.FeeSchedules.V3.NewRateVersion?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.FeeSchedules.V3.NewRateVersion"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new RateUpload(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RateUpload value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "new_rate" => JsonSerializer.SerializeToNode(value.Value, options),
                    "new_version" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for new_rate
    /// </summary>
    [Serializable]
    public struct NewRate
    {
        public NewRate(global::Candid.Net.FeeSchedules.V3.NewRate value)
        {
            Value = value;
        }

        internal global::Candid.Net.FeeSchedules.V3.NewRate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator RateUpload.NewRate(
            global::Candid.Net.FeeSchedules.V3.NewRate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for new_version
    /// </summary>
    [Serializable]
    public struct NewVersion
    {
        public NewVersion(global::Candid.Net.FeeSchedules.V3.NewRateVersion value)
        {
            Value = value;
        }

        internal global::Candid.Net.FeeSchedules.V3.NewRateVersion Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator RateUpload.NewVersion(
            global::Candid.Net.FeeSchedules.V3.NewRateVersion value
        ) => new(value);
    }
}
