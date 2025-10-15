// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Payers.V3;

[JsonConverter(typeof(PayerIdentifier.JsonConverter))]
[Serializable]
public record PayerIdentifier
{
    internal PayerIdentifier(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of PayerIdentifier with <see cref="PayerIdentifier.PayerInfo"/>.
    /// </summary>
    public PayerIdentifier(PayerIdentifier.PayerInfo value)
    {
        Type = "payer_info";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PayerIdentifier with <see cref="PayerIdentifier.PayerUuid"/>.
    /// </summary>
    public PayerIdentifier(PayerIdentifier.PayerUuid value)
    {
        Type = "payer_uuid";
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
    /// Returns true if <see cref="Type"/> is "payer_info"
    /// </summary>
    public bool IsPayerInfo => Type == "payer_info";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "payer_uuid"
    /// </summary>
    public bool IsPayerUuid => Type == "payer_uuid";

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.Payers.V3.PayerInfo"/> if <see cref="Type"/> is 'payer_info', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'payer_info'.</exception>
    public Candid.Net.Payers.V3.PayerInfo AsPayerInfo() =>
        IsPayerInfo
            ? (Candid.Net.Payers.V3.PayerInfo)Value!
            : throw new Exception("PayerIdentifier.Type is not 'payer_info'");

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'payer_uuid', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'payer_uuid'.</exception>
    public string AsPayerUuid() =>
        IsPayerUuid
            ? (string)Value!
            : throw new Exception("PayerIdentifier.Type is not 'payer_uuid'");

    public T Match<T>(
        Func<Candid.Net.Payers.V3.PayerInfo, T> onPayerInfo,
        Func<string, T> onPayerUuid,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "payer_info" => onPayerInfo(AsPayerInfo()),
            "payer_uuid" => onPayerUuid(AsPayerUuid()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<Candid.Net.Payers.V3.PayerInfo> onPayerInfo,
        Action<string> onPayerUuid,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "payer_info":
                onPayerInfo(AsPayerInfo());
                break;
            case "payer_uuid":
                onPayerUuid(AsPayerUuid());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.Payers.V3.PayerInfo"/> and returns true if successful.
    /// </summary>
    public bool TryAsPayerInfo(out Candid.Net.Payers.V3.PayerInfo? value)
    {
        if (Type == "payer_info")
        {
            value = (Candid.Net.Payers.V3.PayerInfo)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="string"/> and returns true if successful.
    /// </summary>
    public bool TryAsPayerUuid(out string? value)
    {
        if (Type == "payer_uuid")
        {
            value = (string)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator PayerIdentifier(PayerIdentifier.PayerInfo value) => new(value);

    public static implicit operator PayerIdentifier(PayerIdentifier.PayerUuid value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<PayerIdentifier>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(PayerIdentifier).IsAssignableFrom(typeToConvert);

        public override PayerIdentifier Read(
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
                "payer_info" => json.Deserialize<Candid.Net.Payers.V3.PayerInfo>(options)
                    ?? throw new JsonException(
                        "Failed to deserialize Candid.Net.Payers.V3.PayerInfo"
                    ),
                "payer_uuid" => json.GetProperty("value").Deserialize<string>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                _ => json.Deserialize<object?>(options),
            };
            return new PayerIdentifier(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PayerIdentifier value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "payer_info" => JsonSerializer.SerializeToNode(value.Value, options),
                    "payer_uuid" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for payer_info
    /// </summary>
    [Serializable]
    public struct PayerInfo
    {
        public PayerInfo(Candid.Net.Payers.V3.PayerInfo value)
        {
            Value = value;
        }

        internal Candid.Net.Payers.V3.PayerInfo Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator PayerIdentifier.PayerInfo(
            Candid.Net.Payers.V3.PayerInfo value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for payer_uuid
    /// </summary>
    [Serializable]
    public record PayerUuid
    {
        public PayerUuid(string value)
        {
            Value = value;
        }

        internal string Value { get; set; }

        public override string ToString() => Value;

        public static implicit operator PayerIdentifier.PayerUuid(string value) => new(value);
    }
}
