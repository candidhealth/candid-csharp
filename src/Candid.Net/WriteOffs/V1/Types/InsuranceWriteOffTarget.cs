// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.WriteOffs.V1;

[JsonConverter(typeof(InsuranceWriteOffTarget.JsonConverter))]
[Serializable]
public record InsuranceWriteOffTarget
{
    internal InsuranceWriteOffTarget(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of InsuranceWriteOffTarget with <see cref="InsuranceWriteOffTarget.ServiceLineId"/>.
    /// </summary>
    public InsuranceWriteOffTarget(InsuranceWriteOffTarget.ServiceLineId value)
    {
        Type = "service_line_id";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of InsuranceWriteOffTarget with <see cref="InsuranceWriteOffTarget.ClaimId"/>.
    /// </summary>
    public InsuranceWriteOffTarget(InsuranceWriteOffTarget.ClaimId value)
    {
        Type = "claim_id";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of InsuranceWriteOffTarget with <see cref="InsuranceWriteOffTarget.BillingProviderId"/>.
    /// </summary>
    public InsuranceWriteOffTarget(InsuranceWriteOffTarget.BillingProviderId value)
    {
        Type = "billing_provider_id";
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
    /// Returns true if <see cref="Type"/> is "service_line_id"
    /// </summary>
    public bool IsServiceLineId => Type == "service_line_id";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "claim_id"
    /// </summary>
    public bool IsClaimId => Type == "claim_id";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "billing_provider_id"
    /// </summary>
    public bool IsBillingProviderId => Type == "billing_provider_id";

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'service_line_id', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'service_line_id'.</exception>
    public string AsServiceLineId() =>
        IsServiceLineId
            ? (string)Value!
            : throw new Exception("InsuranceWriteOffTarget.Type is not 'service_line_id'");

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'claim_id', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'claim_id'.</exception>
    public string AsClaimId() =>
        IsClaimId
            ? (string)Value!
            : throw new Exception("InsuranceWriteOffTarget.Type is not 'claim_id'");

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'billing_provider_id', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'billing_provider_id'.</exception>
    public string AsBillingProviderId() =>
        IsBillingProviderId
            ? (string)Value!
            : throw new Exception("InsuranceWriteOffTarget.Type is not 'billing_provider_id'");

    public T Match<T>(
        Func<string, T> onServiceLineId,
        Func<string, T> onClaimId,
        Func<string, T> onBillingProviderId,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "service_line_id" => onServiceLineId(AsServiceLineId()),
            "claim_id" => onClaimId(AsClaimId()),
            "billing_provider_id" => onBillingProviderId(AsBillingProviderId()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<string> onServiceLineId,
        Action<string> onClaimId,
        Action<string> onBillingProviderId,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "service_line_id":
                onServiceLineId(AsServiceLineId());
                break;
            case "claim_id":
                onClaimId(AsClaimId());
                break;
            case "billing_provider_id":
                onBillingProviderId(AsBillingProviderId());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="string"/> and returns true if successful.
    /// </summary>
    public bool TryAsServiceLineId(out string? value)
    {
        if (Type == "service_line_id")
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
    public bool TryAsClaimId(out string? value)
    {
        if (Type == "claim_id")
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
    public bool TryAsBillingProviderId(out string? value)
    {
        if (Type == "billing_provider_id")
        {
            value = (string)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator InsuranceWriteOffTarget(
        InsuranceWriteOffTarget.ServiceLineId value
    ) => new(value);

    public static implicit operator InsuranceWriteOffTarget(
        InsuranceWriteOffTarget.ClaimId value
    ) => new(value);

    public static implicit operator InsuranceWriteOffTarget(
        InsuranceWriteOffTarget.BillingProviderId value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<InsuranceWriteOffTarget>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(InsuranceWriteOffTarget).IsAssignableFrom(typeToConvert);

        public override InsuranceWriteOffTarget Read(
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
                "service_line_id" => json.GetProperty("value").Deserialize<string>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                "claim_id" => json.GetProperty("value").Deserialize<string>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                "billing_provider_id" => json.GetProperty("value").Deserialize<string>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                _ => json.Deserialize<object?>(options),
            };
            return new InsuranceWriteOffTarget(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InsuranceWriteOffTarget value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "service_line_id" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    "claim_id" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    "billing_provider_id" => new JsonObject
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
    /// Discriminated union type for service_line_id
    /// </summary>
    [Serializable]
    public record ServiceLineId
    {
        public ServiceLineId(string value)
        {
            Value = value;
        }

        internal string Value { get; set; }

        public override string ToString() => Value;

        public static implicit operator InsuranceWriteOffTarget.ServiceLineId(string value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for claim_id
    /// </summary>
    [Serializable]
    public record ClaimId
    {
        public ClaimId(string value)
        {
            Value = value;
        }

        internal string Value { get; set; }

        public override string ToString() => Value;

        public static implicit operator InsuranceWriteOffTarget.ClaimId(string value) => new(value);
    }

    /// <summary>
    /// Discriminated union type for billing_provider_id
    /// </summary>
    [Serializable]
    public record BillingProviderId
    {
        public BillingProviderId(string value)
        {
            Value = value;
        }

        internal string Value { get; set; }

        public override string ToString() => Value;

        public static implicit operator InsuranceWriteOffTarget.BillingProviderId(string value) =>
            new(value);
    }
}
