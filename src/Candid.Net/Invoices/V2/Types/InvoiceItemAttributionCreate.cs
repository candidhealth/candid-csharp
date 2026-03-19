// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Invoices.V2;

/// <summary>
/// Points to the claim or service line that this invoice is attributed to
/// </summary>
[JsonConverter(typeof(InvoiceItemAttributionCreate.JsonConverter))]
[Serializable]
public record InvoiceItemAttributionCreate
{
    internal InvoiceItemAttributionCreate(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of InvoiceItemAttributionCreate with <see cref="InvoiceItemAttributionCreate.ServiceLineId"/>.
    /// </summary>
    public InvoiceItemAttributionCreate(InvoiceItemAttributionCreate.ServiceLineId value)
    {
        Type = "service_line_id";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of InvoiceItemAttributionCreate with <see cref="InvoiceItemAttributionCreate.ClaimId"/>.
    /// </summary>
    public InvoiceItemAttributionCreate(InvoiceItemAttributionCreate.ClaimId value)
    {
        Type = "claim_id";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of InvoiceItemAttributionCreate with <see cref="InvoiceItemAttributionCreate.Unattributed"/>.
    /// </summary>
    public InvoiceItemAttributionCreate(InvoiceItemAttributionCreate.Unattributed value)
    {
        Type = "unattributed";
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
    /// Returns true if <see cref="Type"/> is "unattributed"
    /// </summary>
    public bool IsUnattributed => Type == "unattributed";

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'service_line_id', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'service_line_id'.</exception>
    public string AsServiceLineId() =>
        IsServiceLineId
            ? (string)Value!
            : throw new global::System.Exception(
                "InvoiceItemAttributionCreate.Type is not 'service_line_id'"
            );

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'claim_id', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'claim_id'.</exception>
    public string AsClaimId() =>
        IsClaimId
            ? (string)Value!
            : throw new global::System.Exception(
                "InvoiceItemAttributionCreate.Type is not 'claim_id'"
            );

    /// <summary>
    /// Returns the value as a <see cref="object"/> if <see cref="Type"/> is 'unattributed', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'unattributed'.</exception>
    public object AsUnattributed() =>
        IsUnattributed
            ? Value!
            : throw new global::System.Exception(
                "InvoiceItemAttributionCreate.Type is not 'unattributed'"
            );

    public T Match<T>(
        Func<string, T> onServiceLineId,
        Func<string, T> onClaimId,
        Func<object, T> onUnattributed,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "service_line_id" => onServiceLineId(AsServiceLineId()),
            "claim_id" => onClaimId(AsClaimId()),
            "unattributed" => onUnattributed(AsUnattributed()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<string> onServiceLineId,
        Action<string> onClaimId,
        Action<object> onUnattributed,
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
            case "unattributed":
                onUnattributed(AsUnattributed());
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
    /// Attempts to cast the value to a <see cref="object"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnattributed(out object? value)
    {
        if (Type == "unattributed")
        {
            value = Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator InvoiceItemAttributionCreate(
        InvoiceItemAttributionCreate.ServiceLineId value
    ) => new(value);

    public static implicit operator InvoiceItemAttributionCreate(
        InvoiceItemAttributionCreate.ClaimId value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<InvoiceItemAttributionCreate>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(InvoiceItemAttributionCreate).IsAssignableFrom(typeToConvert);

        public override InvoiceItemAttributionCreate Read(
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
                "service_line_id" => json.GetProperty("value").Deserialize<string?>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                "claim_id" => json.GetProperty("value").Deserialize<string?>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                "unattributed" => new { },
                _ => json.Deserialize<object?>(options),
            };
            return new InvoiceItemAttributionCreate(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InvoiceItemAttributionCreate value,
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
                    "unattributed" => null,
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

        public static implicit operator InvoiceItemAttributionCreate.ServiceLineId(string value) =>
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

        public static implicit operator InvoiceItemAttributionCreate.ClaimId(string value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for unattributed
    /// </summary>
    [Serializable]
    public record Unattributed
    {
        internal object Value => new { };

        public override string ToString() => Value.ToString() ?? "null";
    }
}
