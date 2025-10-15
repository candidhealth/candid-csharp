// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Financials;

/// <summary>
/// Allocation targets describe whether the portion of a payment is being applied toward a specific service line,
/// claim, billing provider, or is unallocated.
/// </summary>
[JsonConverter(typeof(AllocationTarget.JsonConverter))]
[Serializable]
public record AllocationTarget
{
    internal AllocationTarget(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of AllocationTarget with <see cref="AllocationTarget.ServiceLine"/>.
    /// </summary>
    public AllocationTarget(AllocationTarget.ServiceLine value)
    {
        Type = "service_line";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AllocationTarget with <see cref="AllocationTarget.Claim"/>.
    /// </summary>
    public AllocationTarget(AllocationTarget.Claim value)
    {
        Type = "claim";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AllocationTarget with <see cref="AllocationTarget.BillingProviderId"/>.
    /// </summary>
    public AllocationTarget(AllocationTarget.BillingProviderId value)
    {
        Type = "billing_provider_id";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AllocationTarget with <see cref="AllocationTarget.Appointment"/>.
    /// </summary>
    public AllocationTarget(AllocationTarget.Appointment value)
    {
        Type = "appointment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AllocationTarget with <see cref="AllocationTarget.Unattributed"/>.
    /// </summary>
    public AllocationTarget(AllocationTarget.Unattributed value)
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
    /// Returns true if <see cref="Type"/> is "service_line"
    /// </summary>
    public bool IsServiceLine => Type == "service_line";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "claim"
    /// </summary>
    public bool IsClaim => Type == "claim";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "billing_provider_id"
    /// </summary>
    public bool IsBillingProviderId => Type == "billing_provider_id";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "appointment"
    /// </summary>
    public bool IsAppointment => Type == "appointment";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "unattributed"
    /// </summary>
    public bool IsUnattributed => Type == "unattributed";

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.Financials.ServiceLineAllocationTarget"/> if <see cref="Type"/> is 'service_line', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'service_line'.</exception>
    public Candid.Net.Financials.ServiceLineAllocationTarget AsServiceLine() =>
        IsServiceLine
            ? (Candid.Net.Financials.ServiceLineAllocationTarget)Value!
            : throw new Exception("AllocationTarget.Type is not 'service_line'");

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.Financials.ClaimAllocationTarget"/> if <see cref="Type"/> is 'claim', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'claim'.</exception>
    public Candid.Net.Financials.ClaimAllocationTarget AsClaim() =>
        IsClaim
            ? (Candid.Net.Financials.ClaimAllocationTarget)Value!
            : throw new Exception("AllocationTarget.Type is not 'claim'");

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.Financials.BillingProviderAllocationTarget"/> if <see cref="Type"/> is 'billing_provider_id', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'billing_provider_id'.</exception>
    public Candid.Net.Financials.BillingProviderAllocationTarget AsBillingProviderId() =>
        IsBillingProviderId
            ? (Candid.Net.Financials.BillingProviderAllocationTarget)Value!
            : throw new Exception("AllocationTarget.Type is not 'billing_provider_id'");

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.Financials.AppointmentAllocationTarget"/> if <see cref="Type"/> is 'appointment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'appointment'.</exception>
    public Candid.Net.Financials.AppointmentAllocationTarget AsAppointment() =>
        IsAppointment
            ? (Candid.Net.Financials.AppointmentAllocationTarget)Value!
            : throw new Exception("AllocationTarget.Type is not 'appointment'");

    /// <summary>
    /// Returns the value as a <see cref="object"/> if <see cref="Type"/> is 'unattributed', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'unattributed'.</exception>
    public object AsUnattributed() =>
        IsUnattributed
            ? Value!
            : throw new Exception("AllocationTarget.Type is not 'unattributed'");

    public T Match<T>(
        Func<Candid.Net.Financials.ServiceLineAllocationTarget, T> onServiceLine,
        Func<Candid.Net.Financials.ClaimAllocationTarget, T> onClaim,
        Func<Candid.Net.Financials.BillingProviderAllocationTarget, T> onBillingProviderId,
        Func<Candid.Net.Financials.AppointmentAllocationTarget, T> onAppointment,
        Func<object, T> onUnattributed,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "service_line" => onServiceLine(AsServiceLine()),
            "claim" => onClaim(AsClaim()),
            "billing_provider_id" => onBillingProviderId(AsBillingProviderId()),
            "appointment" => onAppointment(AsAppointment()),
            "unattributed" => onUnattributed(AsUnattributed()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<Candid.Net.Financials.ServiceLineAllocationTarget> onServiceLine,
        Action<Candid.Net.Financials.ClaimAllocationTarget> onClaim,
        Action<Candid.Net.Financials.BillingProviderAllocationTarget> onBillingProviderId,
        Action<Candid.Net.Financials.AppointmentAllocationTarget> onAppointment,
        Action<object> onUnattributed,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "service_line":
                onServiceLine(AsServiceLine());
                break;
            case "claim":
                onClaim(AsClaim());
                break;
            case "billing_provider_id":
                onBillingProviderId(AsBillingProviderId());
                break;
            case "appointment":
                onAppointment(AsAppointment());
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
    /// Attempts to cast the value to a <see cref="Candid.Net.Financials.ServiceLineAllocationTarget"/> and returns true if successful.
    /// </summary>
    public bool TryAsServiceLine(out Candid.Net.Financials.ServiceLineAllocationTarget? value)
    {
        if (Type == "service_line")
        {
            value = (Candid.Net.Financials.ServiceLineAllocationTarget)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.Financials.ClaimAllocationTarget"/> and returns true if successful.
    /// </summary>
    public bool TryAsClaim(out Candid.Net.Financials.ClaimAllocationTarget? value)
    {
        if (Type == "claim")
        {
            value = (Candid.Net.Financials.ClaimAllocationTarget)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.Financials.BillingProviderAllocationTarget"/> and returns true if successful.
    /// </summary>
    public bool TryAsBillingProviderId(
        out Candid.Net.Financials.BillingProviderAllocationTarget? value
    )
    {
        if (Type == "billing_provider_id")
        {
            value = (Candid.Net.Financials.BillingProviderAllocationTarget)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.Financials.AppointmentAllocationTarget"/> and returns true if successful.
    /// </summary>
    public bool TryAsAppointment(out Candid.Net.Financials.AppointmentAllocationTarget? value)
    {
        if (Type == "appointment")
        {
            value = (Candid.Net.Financials.AppointmentAllocationTarget)Value!;
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

    public static implicit operator AllocationTarget(AllocationTarget.ServiceLine value) =>
        new(value);

    public static implicit operator AllocationTarget(AllocationTarget.Claim value) => new(value);

    public static implicit operator AllocationTarget(AllocationTarget.BillingProviderId value) =>
        new(value);

    public static implicit operator AllocationTarget(AllocationTarget.Appointment value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<AllocationTarget>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(AllocationTarget).IsAssignableFrom(typeToConvert);

        public override AllocationTarget Read(
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
                "service_line" =>
                    json.Deserialize<Candid.Net.Financials.ServiceLineAllocationTarget>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.Financials.ServiceLineAllocationTarget"
                        ),
                "claim" => json.Deserialize<Candid.Net.Financials.ClaimAllocationTarget>(options)
                    ?? throw new JsonException(
                        "Failed to deserialize Candid.Net.Financials.ClaimAllocationTarget"
                    ),
                "billing_provider_id" =>
                    json.Deserialize<Candid.Net.Financials.BillingProviderAllocationTarget>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.Financials.BillingProviderAllocationTarget"
                        ),
                "appointment" =>
                    json.Deserialize<Candid.Net.Financials.AppointmentAllocationTarget>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.Financials.AppointmentAllocationTarget"
                        ),
                "unattributed" => new { },
                _ => json.Deserialize<object?>(options),
            };
            return new AllocationTarget(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AllocationTarget value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "service_line" => JsonSerializer.SerializeToNode(value.Value, options),
                    "claim" => JsonSerializer.SerializeToNode(value.Value, options),
                    "billing_provider_id" => JsonSerializer.SerializeToNode(value.Value, options),
                    "appointment" => JsonSerializer.SerializeToNode(value.Value, options),
                    "unattributed" => null,
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for service_line
    /// </summary>
    [Serializable]
    public struct ServiceLine
    {
        public ServiceLine(Candid.Net.Financials.ServiceLineAllocationTarget value)
        {
            Value = value;
        }

        internal Candid.Net.Financials.ServiceLineAllocationTarget Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator AllocationTarget.ServiceLine(
            Candid.Net.Financials.ServiceLineAllocationTarget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for claim
    /// </summary>
    [Serializable]
    public struct Claim
    {
        public Claim(Candid.Net.Financials.ClaimAllocationTarget value)
        {
            Value = value;
        }

        internal Candid.Net.Financials.ClaimAllocationTarget Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator AllocationTarget.Claim(
            Candid.Net.Financials.ClaimAllocationTarget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for billing_provider_id
    /// </summary>
    [Serializable]
    public struct BillingProviderId
    {
        public BillingProviderId(Candid.Net.Financials.BillingProviderAllocationTarget value)
        {
            Value = value;
        }

        internal Candid.Net.Financials.BillingProviderAllocationTarget Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator AllocationTarget.BillingProviderId(
            Candid.Net.Financials.BillingProviderAllocationTarget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for appointment
    /// </summary>
    [Serializable]
    public struct Appointment
    {
        public Appointment(Candid.Net.Financials.AppointmentAllocationTarget value)
        {
            Value = value;
        }

        internal Candid.Net.Financials.AppointmentAllocationTarget Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator AllocationTarget.Appointment(
            Candid.Net.Financials.AppointmentAllocationTarget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unattributed
    /// </summary>
    [Serializable]
    public record Unattributed
    {
        internal object Value => new { };

        public override string ToString() => Value.ToString();
    }
}
