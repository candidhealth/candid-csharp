// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PatientPayments.V4;

[JsonConverter(typeof(PaymentMethodCreate.JsonConverter))]
[Serializable]
public record PaymentMethodCreate
{
    internal PaymentMethodCreate(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of PaymentMethodCreate with <see cref="PaymentMethodCreate.Cash"/>.
    /// </summary>
    public PaymentMethodCreate(PaymentMethodCreate.Cash value)
    {
        Type = "cash";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PaymentMethodCreate with <see cref="PaymentMethodCreate.Check"/>.
    /// </summary>
    public PaymentMethodCreate(PaymentMethodCreate.Check value)
    {
        Type = "check";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PaymentMethodCreate with <see cref="PaymentMethodCreate.Card"/>.
    /// </summary>
    public PaymentMethodCreate(PaymentMethodCreate.Card value)
    {
        Type = "card";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PaymentMethodCreate with <see cref="PaymentMethodCreate.MoneyOrder"/>.
    /// </summary>
    public PaymentMethodCreate(PaymentMethodCreate.MoneyOrder value)
    {
        Type = "money_order";
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
    /// Returns true if <see cref="Type"/> is "money_order"
    /// </summary>
    public bool IsMoneyOrder => Type == "money_order";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.PatientPayments.V4.CashPaymentMethodCreate"/> if <see cref="Type"/> is 'cash', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'cash'.</exception>
    public global::Candid.Net.PatientPayments.V4.CashPaymentMethodCreate AsCash() =>
        IsCash
            ? (global::Candid.Net.PatientPayments.V4.CashPaymentMethodCreate)Value!
            : throw new global::System.Exception("PaymentMethodCreate.Type is not 'cash'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.PatientPayments.V4.CheckPaymentMethodCreate"/> if <see cref="Type"/> is 'check', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'check'.</exception>
    public global::Candid.Net.PatientPayments.V4.CheckPaymentMethodCreate AsCheck() =>
        IsCheck
            ? (global::Candid.Net.PatientPayments.V4.CheckPaymentMethodCreate)Value!
            : throw new global::System.Exception("PaymentMethodCreate.Type is not 'check'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.PatientPayments.V4.CardPaymentMethodCreate"/> if <see cref="Type"/> is 'card', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'card'.</exception>
    public global::Candid.Net.PatientPayments.V4.CardPaymentMethodCreate AsCard() =>
        IsCard
            ? (global::Candid.Net.PatientPayments.V4.CardPaymentMethodCreate)Value!
            : throw new global::System.Exception("PaymentMethodCreate.Type is not 'card'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.PatientPayments.V4.MoneyOrderPaymentMethodCreate"/> if <see cref="Type"/> is 'money_order', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'money_order'.</exception>
    public global::Candid.Net.PatientPayments.V4.MoneyOrderPaymentMethodCreate AsMoneyOrder() =>
        IsMoneyOrder
            ? (global::Candid.Net.PatientPayments.V4.MoneyOrderPaymentMethodCreate)Value!
            : throw new global::System.Exception("PaymentMethodCreate.Type is not 'money_order'");

    public T Match<T>(
        Func<global::Candid.Net.PatientPayments.V4.CashPaymentMethodCreate, T> onCash,
        Func<global::Candid.Net.PatientPayments.V4.CheckPaymentMethodCreate, T> onCheck,
        Func<global::Candid.Net.PatientPayments.V4.CardPaymentMethodCreate, T> onCard,
        Func<global::Candid.Net.PatientPayments.V4.MoneyOrderPaymentMethodCreate, T> onMoneyOrder,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "cash" => onCash(AsCash()),
            "check" => onCheck(AsCheck()),
            "card" => onCard(AsCard()),
            "money_order" => onMoneyOrder(AsMoneyOrder()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.PatientPayments.V4.CashPaymentMethodCreate> onCash,
        Action<global::Candid.Net.PatientPayments.V4.CheckPaymentMethodCreate> onCheck,
        Action<global::Candid.Net.PatientPayments.V4.CardPaymentMethodCreate> onCard,
        Action<global::Candid.Net.PatientPayments.V4.MoneyOrderPaymentMethodCreate> onMoneyOrder,
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
            case "money_order":
                onMoneyOrder(AsMoneyOrder());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.PatientPayments.V4.CashPaymentMethodCreate"/> and returns true if successful.
    /// </summary>
    public bool TryAsCash(out global::Candid.Net.PatientPayments.V4.CashPaymentMethodCreate? value)
    {
        if (Type == "cash")
        {
            value = (global::Candid.Net.PatientPayments.V4.CashPaymentMethodCreate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.PatientPayments.V4.CheckPaymentMethodCreate"/> and returns true if successful.
    /// </summary>
    public bool TryAsCheck(
        out global::Candid.Net.PatientPayments.V4.CheckPaymentMethodCreate? value
    )
    {
        if (Type == "check")
        {
            value = (global::Candid.Net.PatientPayments.V4.CheckPaymentMethodCreate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.PatientPayments.V4.CardPaymentMethodCreate"/> and returns true if successful.
    /// </summary>
    public bool TryAsCard(out global::Candid.Net.PatientPayments.V4.CardPaymentMethodCreate? value)
    {
        if (Type == "card")
        {
            value = (global::Candid.Net.PatientPayments.V4.CardPaymentMethodCreate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.PatientPayments.V4.MoneyOrderPaymentMethodCreate"/> and returns true if successful.
    /// </summary>
    public bool TryAsMoneyOrder(
        out global::Candid.Net.PatientPayments.V4.MoneyOrderPaymentMethodCreate? value
    )
    {
        if (Type == "money_order")
        {
            value = (global::Candid.Net.PatientPayments.V4.MoneyOrderPaymentMethodCreate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator PaymentMethodCreate(PaymentMethodCreate.Cash value) =>
        new(value);

    public static implicit operator PaymentMethodCreate(PaymentMethodCreate.Check value) =>
        new(value);

    public static implicit operator PaymentMethodCreate(PaymentMethodCreate.Card value) =>
        new(value);

    public static implicit operator PaymentMethodCreate(PaymentMethodCreate.MoneyOrder value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<PaymentMethodCreate>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(PaymentMethodCreate).IsAssignableFrom(typeToConvert);

        public override PaymentMethodCreate Read(
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
                "cash" =>
                    jsonWithoutDiscriminator.Deserialize<global::Candid.Net.PatientPayments.V4.CashPaymentMethodCreate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.PatientPayments.V4.CashPaymentMethodCreate"
                        ),
                "check" =>
                    jsonWithoutDiscriminator.Deserialize<global::Candid.Net.PatientPayments.V4.CheckPaymentMethodCreate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.PatientPayments.V4.CheckPaymentMethodCreate"
                        ),
                "card" =>
                    jsonWithoutDiscriminator.Deserialize<global::Candid.Net.PatientPayments.V4.CardPaymentMethodCreate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.PatientPayments.V4.CardPaymentMethodCreate"
                        ),
                "money_order" =>
                    jsonWithoutDiscriminator.Deserialize<global::Candid.Net.PatientPayments.V4.MoneyOrderPaymentMethodCreate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.PatientPayments.V4.MoneyOrderPaymentMethodCreate"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new PaymentMethodCreate(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PaymentMethodCreate value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "cash" => JsonSerializer.SerializeToNode(value.Value, options),
                    "check" => JsonSerializer.SerializeToNode(value.Value, options),
                    "card" => JsonSerializer.SerializeToNode(value.Value, options),
                    "money_order" => JsonSerializer.SerializeToNode(value.Value, options),
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
        public Cash(global::Candid.Net.PatientPayments.V4.CashPaymentMethodCreate value)
        {
            Value = value;
        }

        internal global::Candid.Net.PatientPayments.V4.CashPaymentMethodCreate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PaymentMethodCreate.Cash(
            global::Candid.Net.PatientPayments.V4.CashPaymentMethodCreate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for check
    /// </summary>
    [Serializable]
    public struct Check
    {
        public Check(global::Candid.Net.PatientPayments.V4.CheckPaymentMethodCreate value)
        {
            Value = value;
        }

        internal global::Candid.Net.PatientPayments.V4.CheckPaymentMethodCreate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PaymentMethodCreate.Check(
            global::Candid.Net.PatientPayments.V4.CheckPaymentMethodCreate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for card
    /// </summary>
    [Serializable]
    public struct Card
    {
        public Card(global::Candid.Net.PatientPayments.V4.CardPaymentMethodCreate value)
        {
            Value = value;
        }

        internal global::Candid.Net.PatientPayments.V4.CardPaymentMethodCreate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PaymentMethodCreate.Card(
            global::Candid.Net.PatientPayments.V4.CardPaymentMethodCreate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for money_order
    /// </summary>
    [Serializable]
    public struct MoneyOrder
    {
        public MoneyOrder(global::Candid.Net.PatientPayments.V4.MoneyOrderPaymentMethodCreate value)
        {
            Value = value;
        }

        internal global::Candid.Net.PatientPayments.V4.MoneyOrderPaymentMethodCreate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PaymentMethodCreate.MoneyOrder(
            global::Candid.Net.PatientPayments.V4.MoneyOrderPaymentMethodCreate value
        ) => new(value);
    }
}
