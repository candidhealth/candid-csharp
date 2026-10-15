// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

/// <summary>
/// A single financial transaction posted from a consolidated remit's ERA payments - either an
/// InsurancePayment or an InsuranceAdjustment. Fields common to both (see
/// TransactionCommonFields) are always present alongside whichever type-specific fields apply,
/// so callers who only care about the common shape never need to branch on type.
/// </summary>
[JsonConverter(typeof(ExternalConsolidatedRemitTransaction.JsonConverter))]
[Serializable]
public record ExternalConsolidatedRemitTransaction
{
    internal ExternalConsolidatedRemitTransaction(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of ExternalConsolidatedRemitTransaction with <see cref="ExternalConsolidatedRemitTransaction.InsurancePayment"/>.
    /// </summary>
    public ExternalConsolidatedRemitTransaction(
        ExternalConsolidatedRemitTransaction.InsurancePayment value
    )
    {
        Type = "insurance_payment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ExternalConsolidatedRemitTransaction with <see cref="ExternalConsolidatedRemitTransaction.InsuranceAdjustment"/>.
    /// </summary>
    public ExternalConsolidatedRemitTransaction(
        ExternalConsolidatedRemitTransaction.InsuranceAdjustment value
    )
    {
        Type = "insurance_adjustment";
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
    /// Returns true if <see cref="Type"/> is "insurance_payment"
    /// </summary>
    public bool IsInsurancePayment => Type == "insurance_payment";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "insurance_adjustment"
    /// </summary>
    public bool IsInsuranceAdjustment => Type == "insurance_adjustment";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsurancePaymentTransaction"/> if <see cref="Type"/> is 'insurance_payment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'insurance_payment'.</exception>
    public global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsurancePaymentTransaction AsInsurancePayment() =>
        IsInsurancePayment
            ? (global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsurancePaymentTransaction)
                Value!
            : throw new global::System.Exception(
                "ExternalConsolidatedRemitTransaction.Type is not 'insurance_payment'"
            );

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsuranceAdjustmentTransaction"/> if <see cref="Type"/> is 'insurance_adjustment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'insurance_adjustment'.</exception>
    public global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsuranceAdjustmentTransaction AsInsuranceAdjustment() =>
        IsInsuranceAdjustment
            ? (global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsuranceAdjustmentTransaction)
                Value!
            : throw new global::System.Exception(
                "ExternalConsolidatedRemitTransaction.Type is not 'insurance_adjustment'"
            );

    public T Match<T>(
        Func<
            global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsurancePaymentTransaction,
            T
        > onInsurancePayment,
        Func<
            global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsuranceAdjustmentTransaction,
            T
        > onInsuranceAdjustment,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "insurance_payment" => onInsurancePayment(AsInsurancePayment()),
            "insurance_adjustment" => onInsuranceAdjustment(AsInsuranceAdjustment()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsurancePaymentTransaction> onInsurancePayment,
        Action<global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsuranceAdjustmentTransaction> onInsuranceAdjustment,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "insurance_payment":
                onInsurancePayment(AsInsurancePayment());
                break;
            case "insurance_adjustment":
                onInsuranceAdjustment(AsInsuranceAdjustment());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsurancePaymentTransaction"/> and returns true if successful.
    /// </summary>
    public bool TryAsInsurancePayment(
        out global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsurancePaymentTransaction? value
    )
    {
        if (Type == "insurance_payment")
        {
            value =
                (global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsurancePaymentTransaction)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsuranceAdjustmentTransaction"/> and returns true if successful.
    /// </summary>
    public bool TryAsInsuranceAdjustment(
        out global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsuranceAdjustmentTransaction? value
    )
    {
        if (Type == "insurance_adjustment")
        {
            value =
                (global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsuranceAdjustmentTransaction)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator ExternalConsolidatedRemitTransaction(
        ExternalConsolidatedRemitTransaction.InsurancePayment value
    ) => new(value);

    public static implicit operator ExternalConsolidatedRemitTransaction(
        ExternalConsolidatedRemitTransaction.InsuranceAdjustment value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<ExternalConsolidatedRemitTransaction>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(ExternalConsolidatedRemitTransaction).IsAssignableFrom(typeToConvert);

        public override ExternalConsolidatedRemitTransaction Read(
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
                "insurance_payment" =>
                    jsonWithoutDiscriminator.Deserialize<global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsurancePaymentTransaction?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsurancePaymentTransaction"
                        ),
                "insurance_adjustment" =>
                    jsonWithoutDiscriminator.Deserialize<global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsuranceAdjustmentTransaction?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsuranceAdjustmentTransaction"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new ExternalConsolidatedRemitTransaction(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ExternalConsolidatedRemitTransaction value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "insurance_payment" => JsonSerializer.SerializeToNode(value.Value, options),
                    "insurance_adjustment" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }

        public override ExternalConsolidatedRemitTransaction ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new ExternalConsolidatedRemitTransaction(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ExternalConsolidatedRemitTransaction value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Type);
        }
    }

    /// <summary>
    /// Discriminated union type for insurance_payment
    /// </summary>
    [Serializable]
    public struct InsurancePayment
    {
        public InsurancePayment(
            global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsurancePaymentTransaction value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsurancePaymentTransaction Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ExternalConsolidatedRemitTransaction.InsurancePayment(
            global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsurancePaymentTransaction value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for insurance_adjustment
    /// </summary>
    [Serializable]
    public struct InsuranceAdjustment
    {
        public InsuranceAdjustment(
            global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsuranceAdjustmentTransaction value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsuranceAdjustmentTransaction Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ExternalConsolidatedRemitTransaction.InsuranceAdjustment(
            global::Candid.Net.ExternalConsolidatedRemit.V1.ExternalConsolidatedRemitInsuranceAdjustmentTransaction value
        ) => new(value);
    }
}
