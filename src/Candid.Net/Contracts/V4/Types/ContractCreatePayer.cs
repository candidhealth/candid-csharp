// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Contracts.V4;

/// <summary>
/// Identifies the payer under contract. Provide either a payer_uuid (an EDI payer) or a payer_group_id.
/// </summary>
[JsonConverter(typeof(ContractCreatePayer.JsonConverter))]
[Serializable]
public record ContractCreatePayer
{
    internal ContractCreatePayer(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of ContractCreatePayer with <see cref="ContractCreatePayer.PayerUuid"/>.
    /// </summary>
    public ContractCreatePayer(ContractCreatePayer.PayerUuid value)
    {
        Type = "payer_uuid";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ContractCreatePayer with <see cref="ContractCreatePayer.PayerGroupId"/>.
    /// </summary>
    public ContractCreatePayer(ContractCreatePayer.PayerGroupId value)
    {
        Type = "payer_group_id";
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
    /// Returns true if <see cref="Type"/> is "payer_uuid"
    /// </summary>
    public bool IsPayerUuid => Type == "payer_uuid";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "payer_group_id"
    /// </summary>
    public bool IsPayerGroupId => Type == "payer_group_id";

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'payer_uuid', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'payer_uuid'.</exception>
    public string AsPayerUuid() =>
        IsPayerUuid
            ? (string)Value!
            : throw new global::System.Exception("ContractCreatePayer.Type is not 'payer_uuid'");

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'payer_group_id', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'payer_group_id'.</exception>
    public string AsPayerGroupId() =>
        IsPayerGroupId
            ? (string)Value!
            : throw new global::System.Exception(
                "ContractCreatePayer.Type is not 'payer_group_id'"
            );

    public T Match<T>(
        Func<string, T> onPayerUuid,
        Func<string, T> onPayerGroupId,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "payer_uuid" => onPayerUuid(AsPayerUuid()),
            "payer_group_id" => onPayerGroupId(AsPayerGroupId()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<string> onPayerUuid,
        Action<string> onPayerGroupId,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "payer_uuid":
                onPayerUuid(AsPayerUuid());
                break;
            case "payer_group_id":
                onPayerGroupId(AsPayerGroupId());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
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

    /// <summary>
    /// Attempts to cast the value to a <see cref="string"/> and returns true if successful.
    /// </summary>
    public bool TryAsPayerGroupId(out string? value)
    {
        if (Type == "payer_group_id")
        {
            value = (string)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator ContractCreatePayer(ContractCreatePayer.PayerUuid value) =>
        new(value);

    public static implicit operator ContractCreatePayer(ContractCreatePayer.PayerGroupId value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<ContractCreatePayer>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(ContractCreatePayer).IsAssignableFrom(typeToConvert);

        public override ContractCreatePayer Read(
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
                "payer_uuid" => json.GetProperty("value").Deserialize<string?>(options)
                    ?? throw new JsonException("Failed to deserialize string"),
                "payer_group_id" => json.GetProperty("value").Deserialize<string?>(options)
                    ?? throw new JsonException("Failed to deserialize string"),
                _ => json.Deserialize<object?>(options),
            };
            return new ContractCreatePayer(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractCreatePayer value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "payer_uuid" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    "payer_group_id" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }

        public override ContractCreatePayer ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new ContractCreatePayer(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractCreatePayer value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Type);
        }
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

        public static implicit operator ContractCreatePayer.PayerUuid(string value) => new(value);
    }

    /// <summary>
    /// Discriminated union type for payer_group_id
    /// </summary>
    [Serializable]
    public record PayerGroupId
    {
        public PayerGroupId(string value)
        {
            Value = value;
        }

        internal string Value { get; set; }

        public override string ToString() => Value;

        public static implicit operator ContractCreatePayer.PayerGroupId(string value) =>
            new(value);
    }
}
