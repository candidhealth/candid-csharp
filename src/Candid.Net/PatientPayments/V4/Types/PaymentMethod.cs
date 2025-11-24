// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PatientPayments.V4;

[JsonConverter(typeof(PaymentMethod.JsonConverter))]
[Serializable]
public record PaymentMethod
{
    internal PaymentMethod(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of PaymentMethod with <see cref="PaymentMethod.Cash"/>.
    /// </summary>
    public PaymentMethod(PaymentMethod.Cash value)
    {
        Type = "cash";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PaymentMethod with <see cref="PaymentMethod.Check"/>.
    /// </summary>
    public PaymentMethod(PaymentMethod.Check value)
    {
        Type = "check";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PaymentMethod with <see cref="PaymentMethod.Card"/>.
    /// </summary>
    public PaymentMethod(PaymentMethod.Card value)
    {
        Type = "card";
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
    /// Returns true if <see cref="Type"/> is "cash"
    /// </summary>
    public bool IsCash => Type == "cash";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "check"
    /// </summary>
    public bool IsCheck => Type == "check";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "card"
    /// </summary>
    public bool IsCard => Type == "card";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.PatientPayments.V4.CashPaymentMethod"/> if <see cref="Type"/> is 'cash', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'cash'.</exception>
    public global::Candid.Net.PatientPayments.V4.CashPaymentMethod AsCash() =>
        IsCash
            ? (global::Candid.Net.PatientPayments.V4.CashPaymentMethod)Value!
            : throw new global::System.Exception("PaymentMethod.Type is not 'cash'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.PatientPayments.V4.CheckPaymentMethod"/> if <see cref="Type"/> is 'check', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'check'.</exception>
    public global::Candid.Net.PatientPayments.V4.CheckPaymentMethod AsCheck() =>
        IsCheck
            ? (global::Candid.Net.PatientPayments.V4.CheckPaymentMethod)Value!
            : throw new global::System.Exception("PaymentMethod.Type is not 'check'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.PatientPayments.V4.CardPaymentMethod"/> if <see cref="Type"/> is 'card', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'card'.</exception>
    public global::Candid.Net.PatientPayments.V4.CardPaymentMethod AsCard() =>
        IsCard
            ? (global::Candid.Net.PatientPayments.V4.CardPaymentMethod)Value!
            : throw new global::System.Exception("PaymentMethod.Type is not 'card'");

    public T Match<T>(
        Func<global::Candid.Net.PatientPayments.V4.CashPaymentMethod, T> onCash,
        Func<global::Candid.Net.PatientPayments.V4.CheckPaymentMethod, T> onCheck,
        Func<global::Candid.Net.PatientPayments.V4.CardPaymentMethod, T> onCard,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "cash" => onCash(AsCash()),
            "check" => onCheck(AsCheck()),
            "card" => onCard(AsCard()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.PatientPayments.V4.CashPaymentMethod> onCash,
        Action<global::Candid.Net.PatientPayments.V4.CheckPaymentMethod> onCheck,
        Action<global::Candid.Net.PatientPayments.V4.CardPaymentMethod> onCard,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "cash":
                onCash(AsCash());
                break;
            case "check":
                onCheck(AsCheck());
                break;
            case "card":
                onCard(AsCard());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.PatientPayments.V4.CashPaymentMethod"/> and returns true if successful.
    /// </summary>
    public bool TryAsCash(out global::Candid.Net.PatientPayments.V4.CashPaymentMethod? value)
    {
        if (Type == "cash")
        {
            value = (global::Candid.Net.PatientPayments.V4.CashPaymentMethod)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.PatientPayments.V4.CheckPaymentMethod"/> and returns true if successful.
    /// </summary>
    public bool TryAsCheck(out global::Candid.Net.PatientPayments.V4.CheckPaymentMethod? value)
    {
        if (Type == "check")
        {
            value = (global::Candid.Net.PatientPayments.V4.CheckPaymentMethod)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.PatientPayments.V4.CardPaymentMethod"/> and returns true if successful.
    /// </summary>
    public bool TryAsCard(out global::Candid.Net.PatientPayments.V4.CardPaymentMethod? value)
    {
        if (Type == "card")
        {
            value = (global::Candid.Net.PatientPayments.V4.CardPaymentMethod)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator PaymentMethod(PaymentMethod.Cash value) => new(value);

    public static implicit operator PaymentMethod(PaymentMethod.Check value) => new(value);

    public static implicit operator PaymentMethod(PaymentMethod.Card value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<PaymentMethod>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(PaymentMethod).IsAssignableFrom(typeToConvert);

        public override PaymentMethod Read(
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
                "cash" =>
                    json.Deserialize<global::Candid.Net.PatientPayments.V4.CashPaymentMethod?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.PatientPayments.V4.CashPaymentMethod"
                        ),
                "check" =>
                    json.Deserialize<global::Candid.Net.PatientPayments.V4.CheckPaymentMethod?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.PatientPayments.V4.CheckPaymentMethod"
                        ),
                "card" =>
                    json.Deserialize<global::Candid.Net.PatientPayments.V4.CardPaymentMethod?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.PatientPayments.V4.CardPaymentMethod"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new PaymentMethod(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PaymentMethod value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "cash" => JsonSerializer.SerializeToNode(value.Value, options),
                    "check" => JsonSerializer.SerializeToNode(value.Value, options),
                    "card" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for cash
    /// </summary>
    [Serializable]
    public struct Cash
    {
        public Cash(global::Candid.Net.PatientPayments.V4.CashPaymentMethod value)
        {
            Value = value;
        }

        internal global::Candid.Net.PatientPayments.V4.CashPaymentMethod Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PaymentMethod.Cash(
            global::Candid.Net.PatientPayments.V4.CashPaymentMethod value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for check
    /// </summary>
    [Serializable]
    public struct Check
    {
        public Check(global::Candid.Net.PatientPayments.V4.CheckPaymentMethod value)
        {
            Value = value;
        }

        internal global::Candid.Net.PatientPayments.V4.CheckPaymentMethod Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PaymentMethod.Check(
            global::Candid.Net.PatientPayments.V4.CheckPaymentMethod value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for card
    /// </summary>
    [Serializable]
    public struct Card
    {
        public Card(global::Candid.Net.PatientPayments.V4.CardPaymentMethod value)
        {
            Value = value;
        }

        internal global::Candid.Net.PatientPayments.V4.CardPaymentMethod Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PaymentMethod.Card(
            global::Candid.Net.PatientPayments.V4.CardPaymentMethod value
        ) => new(value);
    }
}
