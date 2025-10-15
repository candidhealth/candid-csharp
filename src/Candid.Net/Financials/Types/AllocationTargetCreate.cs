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
[JsonConverter(typeof(AllocationTargetCreate.JsonConverter))]
[Serializable]
public record AllocationTargetCreate
{
    internal AllocationTargetCreate(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of AllocationTargetCreate with <see cref="AllocationTargetCreate.ServiceLineById"/>.
    /// </summary>
    public AllocationTargetCreate(AllocationTargetCreate.ServiceLineById value)
    {
        Type = "service_line_by_id";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AllocationTargetCreate with <see cref="AllocationTargetCreate.ClaimById"/>.
    /// </summary>
    public AllocationTargetCreate(AllocationTargetCreate.ClaimById value)
    {
        Type = "claim_by_id";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AllocationTargetCreate with <see cref="AllocationTargetCreate.ClaimByEncounterExternalId"/>.
    /// </summary>
    public AllocationTargetCreate(AllocationTargetCreate.ClaimByEncounterExternalId value)
    {
        Type = "claim_by_encounter_external_id";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AllocationTargetCreate with <see cref="AllocationTargetCreate.BillingProviderById"/>.
    /// </summary>
    public AllocationTargetCreate(AllocationTargetCreate.BillingProviderById value)
    {
        Type = "billing_provider_by_id";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AllocationTargetCreate with <see cref="AllocationTargetCreate.AppointmentByIdAndPatientExternalId"/>.
    /// </summary>
    public AllocationTargetCreate(AllocationTargetCreate.AppointmentByIdAndPatientExternalId value)
    {
        Type = "appointment_by_id_and_patient_external_id";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AllocationTargetCreate with <see cref="AllocationTargetCreate.Unattributed"/>.
    /// </summary>
    public AllocationTargetCreate(AllocationTargetCreate.Unattributed value)
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
    /// Returns true if <see cref="Type"/> is "service_line_by_id"
    /// </summary>
    public bool IsServiceLineById => Type == "service_line_by_id";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "claim_by_id"
    /// </summary>
    public bool IsClaimById => Type == "claim_by_id";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "claim_by_encounter_external_id"
    /// </summary>
    public bool IsClaimByEncounterExternalId => Type == "claim_by_encounter_external_id";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "billing_provider_by_id"
    /// </summary>
    public bool IsBillingProviderById => Type == "billing_provider_by_id";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "appointment_by_id_and_patient_external_id"
    /// </summary>
    public bool IsAppointmentByIdAndPatientExternalId =>
        Type == "appointment_by_id_and_patient_external_id";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "unattributed"
    /// </summary>
    public bool IsUnattributed => Type == "unattributed";

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'service_line_by_id', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'service_line_by_id'.</exception>
    public string AsServiceLineById() =>
        IsServiceLineById
            ? (string)Value!
            : throw new Exception("AllocationTargetCreate.Type is not 'service_line_by_id'");

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'claim_by_id', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'claim_by_id'.</exception>
    public string AsClaimById() =>
        IsClaimById
            ? (string)Value!
            : throw new Exception("AllocationTargetCreate.Type is not 'claim_by_id'");

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'claim_by_encounter_external_id', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'claim_by_encounter_external_id'.</exception>
    public string AsClaimByEncounterExternalId() =>
        IsClaimByEncounterExternalId
            ? (string)Value!
            : throw new Exception(
                "AllocationTargetCreate.Type is not 'claim_by_encounter_external_id'"
            );

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'billing_provider_by_id', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'billing_provider_by_id'.</exception>
    public string AsBillingProviderById() =>
        IsBillingProviderById
            ? (string)Value!
            : throw new Exception("AllocationTargetCreate.Type is not 'billing_provider_by_id'");

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.Financials.AppointmentByIdAndPatientExternalId"/> if <see cref="Type"/> is 'appointment_by_id_and_patient_external_id', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'appointment_by_id_and_patient_external_id'.</exception>
    public Candid.Net.Financials.AppointmentByIdAndPatientExternalId AsAppointmentByIdAndPatientExternalId() =>
        IsAppointmentByIdAndPatientExternalId
            ? (Candid.Net.Financials.AppointmentByIdAndPatientExternalId)Value!
            : throw new Exception(
                "AllocationTargetCreate.Type is not 'appointment_by_id_and_patient_external_id'"
            );

    /// <summary>
    /// Returns the value as a <see cref="object"/> if <see cref="Type"/> is 'unattributed', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'unattributed'.</exception>
    public object AsUnattributed() =>
        IsUnattributed
            ? Value!
            : throw new Exception("AllocationTargetCreate.Type is not 'unattributed'");

    public T Match<T>(
        Func<string, T> onServiceLineById,
        Func<string, T> onClaimById,
        Func<string, T> onClaimByEncounterExternalId,
        Func<string, T> onBillingProviderById,
        Func<
            Candid.Net.Financials.AppointmentByIdAndPatientExternalId,
            T
        > onAppointmentByIdAndPatientExternalId,
        Func<object, T> onUnattributed,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "service_line_by_id" => onServiceLineById(AsServiceLineById()),
            "claim_by_id" => onClaimById(AsClaimById()),
            "claim_by_encounter_external_id" => onClaimByEncounterExternalId(
                AsClaimByEncounterExternalId()
            ),
            "billing_provider_by_id" => onBillingProviderById(AsBillingProviderById()),
            "appointment_by_id_and_patient_external_id" => onAppointmentByIdAndPatientExternalId(
                AsAppointmentByIdAndPatientExternalId()
            ),
            "unattributed" => onUnattributed(AsUnattributed()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<string> onServiceLineById,
        Action<string> onClaimById,
        Action<string> onClaimByEncounterExternalId,
        Action<string> onBillingProviderById,
        Action<Candid.Net.Financials.AppointmentByIdAndPatientExternalId> onAppointmentByIdAndPatientExternalId,
        Action<object> onUnattributed,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "service_line_by_id":
                onServiceLineById(AsServiceLineById());
                break;
            case "claim_by_id":
                onClaimById(AsClaimById());
                break;
            case "claim_by_encounter_external_id":
                onClaimByEncounterExternalId(AsClaimByEncounterExternalId());
                break;
            case "billing_provider_by_id":
                onBillingProviderById(AsBillingProviderById());
                break;
            case "appointment_by_id_and_patient_external_id":
                onAppointmentByIdAndPatientExternalId(AsAppointmentByIdAndPatientExternalId());
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
    public bool TryAsServiceLineById(out string? value)
    {
        if (Type == "service_line_by_id")
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
    public bool TryAsClaimById(out string? value)
    {
        if (Type == "claim_by_id")
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
    public bool TryAsClaimByEncounterExternalId(out string? value)
    {
        if (Type == "claim_by_encounter_external_id")
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
    public bool TryAsBillingProviderById(out string? value)
    {
        if (Type == "billing_provider_by_id")
        {
            value = (string)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.Financials.AppointmentByIdAndPatientExternalId"/> and returns true if successful.
    /// </summary>
    public bool TryAsAppointmentByIdAndPatientExternalId(
        out Candid.Net.Financials.AppointmentByIdAndPatientExternalId? value
    )
    {
        if (Type == "appointment_by_id_and_patient_external_id")
        {
            value = (Candid.Net.Financials.AppointmentByIdAndPatientExternalId)Value!;
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

    public static implicit operator AllocationTargetCreate(
        AllocationTargetCreate.ServiceLineById value
    ) => new(value);

    public static implicit operator AllocationTargetCreate(
        AllocationTargetCreate.ClaimById value
    ) => new(value);

    public static implicit operator AllocationTargetCreate(
        AllocationTargetCreate.ClaimByEncounterExternalId value
    ) => new(value);

    public static implicit operator AllocationTargetCreate(
        AllocationTargetCreate.BillingProviderById value
    ) => new(value);

    public static implicit operator AllocationTargetCreate(
        AllocationTargetCreate.AppointmentByIdAndPatientExternalId value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<AllocationTargetCreate>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(AllocationTargetCreate).IsAssignableFrom(typeToConvert);

        public override AllocationTargetCreate Read(
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
                "service_line_by_id" => json.GetProperty("value").Deserialize<string>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                "claim_by_id" => json.GetProperty("value").Deserialize<string>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                "claim_by_encounter_external_id" => json.GetProperty("value")
                    .Deserialize<string>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                "billing_provider_by_id" => json.GetProperty("value").Deserialize<string>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                "appointment_by_id_and_patient_external_id" =>
                    json.Deserialize<Candid.Net.Financials.AppointmentByIdAndPatientExternalId>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.Financials.AppointmentByIdAndPatientExternalId"
                        ),
                "unattributed" => new { },
                _ => json.Deserialize<object?>(options),
            };
            return new AllocationTargetCreate(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AllocationTargetCreate value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "service_line_by_id" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    "claim_by_id" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    "claim_by_encounter_external_id" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    "billing_provider_by_id" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    "appointment_by_id_and_patient_external_id" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "unattributed" => null,
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for service_line_by_id
    /// </summary>
    [Serializable]
    public record ServiceLineById
    {
        public ServiceLineById(string value)
        {
            Value = value;
        }

        internal string Value { get; set; }

        public override string ToString() => Value;

        public static implicit operator AllocationTargetCreate.ServiceLineById(string value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for claim_by_id
    /// </summary>
    [Serializable]
    public record ClaimById
    {
        public ClaimById(string value)
        {
            Value = value;
        }

        internal string Value { get; set; }

        public override string ToString() => Value;

        public static implicit operator AllocationTargetCreate.ClaimById(string value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for claim_by_encounter_external_id
    /// </summary>
    [Serializable]
    public record ClaimByEncounterExternalId
    {
        public ClaimByEncounterExternalId(string value)
        {
            Value = value;
        }

        internal string Value { get; set; }

        public override string ToString() => Value;

        public static implicit operator AllocationTargetCreate.ClaimByEncounterExternalId(
            string value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for billing_provider_by_id
    /// </summary>
    [Serializable]
    public record BillingProviderById
    {
        public BillingProviderById(string value)
        {
            Value = value;
        }

        internal string Value { get; set; }

        public override string ToString() => Value;

        public static implicit operator AllocationTargetCreate.BillingProviderById(string value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for appointment_by_id_and_patient_external_id
    /// </summary>
    [Serializable]
    public struct AppointmentByIdAndPatientExternalId
    {
        public AppointmentByIdAndPatientExternalId(
            Candid.Net.Financials.AppointmentByIdAndPatientExternalId value
        )
        {
            Value = value;
        }

        internal Candid.Net.Financials.AppointmentByIdAndPatientExternalId Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator AllocationTargetCreate.AppointmentByIdAndPatientExternalId(
            Candid.Net.Financials.AppointmentByIdAndPatientExternalId value
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
