// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.WriteOffs.V1;

[JsonConverter(typeof(WriteOff.JsonConverter))]
[Serializable]
public record WriteOff
{
    internal WriteOff(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of WriteOff with <see cref="WriteOff.Patient"/>.
    /// </summary>
    public WriteOff(WriteOff.Patient value)
    {
        Type = "patient";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of WriteOff with <see cref="WriteOff.Insurance"/>.
    /// </summary>
    public WriteOff(WriteOff.Insurance value)
    {
        Type = "insurance";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of WriteOff with <see cref="WriteOff.NonInsurancePayer"/>.
    /// </summary>
    public WriteOff(WriteOff.NonInsurancePayer value)
    {
        Type = "non_insurance_payer";
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
    /// Returns true if <see cref="Type"/> is "patient"
    /// </summary>
    public bool IsPatient => Type == "patient";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "insurance"
    /// </summary>
    public bool IsInsurance => Type == "insurance";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "non_insurance_payer"
    /// </summary>
    public bool IsNonInsurancePayer => Type == "non_insurance_payer";

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.WriteOffs.V1.PatientWriteOff"/> if <see cref="Type"/> is 'patient', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'patient'.</exception>
    public Candid.Net.WriteOffs.V1.PatientWriteOff AsPatient() =>
        IsPatient
            ? (Candid.Net.WriteOffs.V1.PatientWriteOff)Value!
            : throw new Exception("WriteOff.Type is not 'patient'");

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.WriteOffs.V1.InsuranceWriteOff"/> if <see cref="Type"/> is 'insurance', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'insurance'.</exception>
    public Candid.Net.WriteOffs.V1.InsuranceWriteOff AsInsurance() =>
        IsInsurance
            ? (Candid.Net.WriteOffs.V1.InsuranceWriteOff)Value!
            : throw new Exception("WriteOff.Type is not 'insurance'");

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOff"/> if <see cref="Type"/> is 'non_insurance_payer', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'non_insurance_payer'.</exception>
    public Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOff AsNonInsurancePayer() =>
        IsNonInsurancePayer
            ? (Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOff)Value!
            : throw new Exception("WriteOff.Type is not 'non_insurance_payer'");

    public T Match<T>(
        Func<Candid.Net.WriteOffs.V1.PatientWriteOff, T> onPatient,
        Func<Candid.Net.WriteOffs.V1.InsuranceWriteOff, T> onInsurance,
        Func<Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOff, T> onNonInsurancePayer,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "patient" => onPatient(AsPatient()),
            "insurance" => onInsurance(AsInsurance()),
            "non_insurance_payer" => onNonInsurancePayer(AsNonInsurancePayer()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<Candid.Net.WriteOffs.V1.PatientWriteOff> onPatient,
        Action<Candid.Net.WriteOffs.V1.InsuranceWriteOff> onInsurance,
        Action<Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOff> onNonInsurancePayer,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "patient":
                onPatient(AsPatient());
                break;
            case "insurance":
                onInsurance(AsInsurance());
                break;
            case "non_insurance_payer":
                onNonInsurancePayer(AsNonInsurancePayer());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.WriteOffs.V1.PatientWriteOff"/> and returns true if successful.
    /// </summary>
    public bool TryAsPatient(out Candid.Net.WriteOffs.V1.PatientWriteOff? value)
    {
        if (Type == "patient")
        {
            value = (Candid.Net.WriteOffs.V1.PatientWriteOff)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.WriteOffs.V1.InsuranceWriteOff"/> and returns true if successful.
    /// </summary>
    public bool TryAsInsurance(out Candid.Net.WriteOffs.V1.InsuranceWriteOff? value)
    {
        if (Type == "insurance")
        {
            value = (Candid.Net.WriteOffs.V1.InsuranceWriteOff)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOff"/> and returns true if successful.
    /// </summary>
    public bool TryAsNonInsurancePayer(out Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOff? value)
    {
        if (Type == "non_insurance_payer")
        {
            value = (Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOff)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator WriteOff(WriteOff.Patient value) => new(value);

    public static implicit operator WriteOff(WriteOff.Insurance value) => new(value);

    public static implicit operator WriteOff(WriteOff.NonInsurancePayer value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<WriteOff>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(WriteOff).IsAssignableFrom(typeToConvert);

        public override WriteOff Read(
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
                "patient" => json.Deserialize<Candid.Net.WriteOffs.V1.PatientWriteOff>(options)
                    ?? throw new JsonException(
                        "Failed to deserialize Candid.Net.WriteOffs.V1.PatientWriteOff"
                    ),
                "insurance" => json.Deserialize<Candid.Net.WriteOffs.V1.InsuranceWriteOff>(options)
                    ?? throw new JsonException(
                        "Failed to deserialize Candid.Net.WriteOffs.V1.InsuranceWriteOff"
                    ),
                "non_insurance_payer" =>
                    json.Deserialize<Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOff>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOff"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new WriteOff(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WriteOff value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "patient" => JsonSerializer.SerializeToNode(value.Value, options),
                    "insurance" => JsonSerializer.SerializeToNode(value.Value, options),
                    "non_insurance_payer" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for patient
    /// </summary>
    [Serializable]
    public struct Patient
    {
        public Patient(Candid.Net.WriteOffs.V1.PatientWriteOff value)
        {
            Value = value;
        }

        internal Candid.Net.WriteOffs.V1.PatientWriteOff Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator WriteOff.Patient(
            Candid.Net.WriteOffs.V1.PatientWriteOff value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for insurance
    /// </summary>
    [Serializable]
    public struct Insurance
    {
        public Insurance(Candid.Net.WriteOffs.V1.InsuranceWriteOff value)
        {
            Value = value;
        }

        internal Candid.Net.WriteOffs.V1.InsuranceWriteOff Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator WriteOff.Insurance(
            Candid.Net.WriteOffs.V1.InsuranceWriteOff value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for non_insurance_payer
    /// </summary>
    [Serializable]
    public struct NonInsurancePayer
    {
        public NonInsurancePayer(Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOff value)
        {
            Value = value;
        }

        internal Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOff Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator WriteOff.NonInsurancePayer(
            Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOff value
        ) => new(value);
    }
}
