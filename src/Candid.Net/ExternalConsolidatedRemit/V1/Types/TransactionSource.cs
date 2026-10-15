// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

/// <summary>
/// Every transaction in scope here originates either directly from an ERA service payment (the
/// common case) or from a provider-level adjustment (PLB) payment bundle.
/// </summary>
[JsonConverter(typeof(TransactionSource.JsonConverter))]
[Serializable]
public record TransactionSource
{
    internal TransactionSource(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of TransactionSource with <see cref="TransactionSource.EraServicePayment"/>.
    /// </summary>
    public TransactionSource(TransactionSource.EraServicePayment value)
    {
        Type = "era_service_payment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of TransactionSource with <see cref="TransactionSource.PaymentBundle"/>.
    /// </summary>
    public TransactionSource(TransactionSource.PaymentBundle value)
    {
        Type = "payment_bundle";
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
    /// Returns true if <see cref="Type"/> is "era_service_payment"
    /// </summary>
    public bool IsEraServicePayment => Type == "era_service_payment";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "payment_bundle"
    /// </summary>
    public bool IsPaymentBundle => Type == "payment_bundle";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourceEraServicePayment"/> if <see cref="Type"/> is 'era_service_payment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'era_service_payment'.</exception>
    public global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourceEraServicePayment AsEraServicePayment() =>
        IsEraServicePayment
            ? (global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourceEraServicePayment)
                Value!
            : throw new global::System.Exception(
                "TransactionSource.Type is not 'era_service_payment'"
            );

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourcePaymentBundle"/> if <see cref="Type"/> is 'payment_bundle', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'payment_bundle'.</exception>
    public global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourcePaymentBundle AsPaymentBundle() =>
        IsPaymentBundle
            ? (global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourcePaymentBundle)Value!
            : throw new global::System.Exception("TransactionSource.Type is not 'payment_bundle'");

    public T Match<T>(
        Func<
            global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourceEraServicePayment,
            T
        > onEraServicePayment,
        Func<
            global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourcePaymentBundle,
            T
        > onPaymentBundle,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "era_service_payment" => onEraServicePayment(AsEraServicePayment()),
            "payment_bundle" => onPaymentBundle(AsPaymentBundle()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourceEraServicePayment> onEraServicePayment,
        Action<global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourcePaymentBundle> onPaymentBundle,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "era_service_payment":
                onEraServicePayment(AsEraServicePayment());
                break;
            case "payment_bundle":
                onPaymentBundle(AsPaymentBundle());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourceEraServicePayment"/> and returns true if successful.
    /// </summary>
    public bool TryAsEraServicePayment(
        out global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourceEraServicePayment? value
    )
    {
        if (Type == "era_service_payment")
        {
            value =
                (global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourceEraServicePayment)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourcePaymentBundle"/> and returns true if successful.
    /// </summary>
    public bool TryAsPaymentBundle(
        out global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourcePaymentBundle? value
    )
    {
        if (Type == "payment_bundle")
        {
            value = (global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourcePaymentBundle)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator TransactionSource(TransactionSource.EraServicePayment value) =>
        new(value);

    public static implicit operator TransactionSource(TransactionSource.PaymentBundle value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<TransactionSource>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(TransactionSource).IsAssignableFrom(typeToConvert);

        public override TransactionSource Read(
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

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("type");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "era_service_payment" =>
                    jsonWithoutDiscriminator.Deserialize<global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourceEraServicePayment?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourceEraServicePayment"
                        ),
                "payment_bundle" =>
                    jsonWithoutDiscriminator.Deserialize<global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourcePaymentBundle?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourcePaymentBundle"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new TransactionSource(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TransactionSource value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "era_service_payment" => JsonSerializer.SerializeToNode(value.Value, options),
                    "payment_bundle" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }

        public override TransactionSource ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new TransactionSource(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TransactionSource value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Type);
        }
    }

    /// <summary>
    /// Discriminated union type for era_service_payment
    /// </summary>
    [Serializable]
    public struct EraServicePayment
    {
        public EraServicePayment(
            global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourceEraServicePayment value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourceEraServicePayment Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator TransactionSource.EraServicePayment(
            global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourceEraServicePayment value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for payment_bundle
    /// </summary>
    [Serializable]
    public struct PaymentBundle
    {
        public PaymentBundle(
            global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourcePaymentBundle value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourcePaymentBundle Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator TransactionSource.PaymentBundle(
            global::Candid.Net.ExternalConsolidatedRemit.V1.TransactionSourcePaymentBundle value
        ) => new(value);
    }
}
