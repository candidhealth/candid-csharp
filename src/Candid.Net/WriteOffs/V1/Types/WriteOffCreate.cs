// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.WriteOffs.V1;

[JsonConverter(typeof(WriteOffCreate.JsonConverter))]
[Serializable]
public record WriteOffCreate
{
    internal WriteOffCreate(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of WriteOffCreate with <see cref="WriteOffCreate.Patient"/>.
    /// </summary>
    public WriteOffCreate(WriteOffCreate.Patient value)
    {
        Type = "patient";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of WriteOffCreate with <see cref="WriteOffCreate.Insurance"/>.
    /// </summary>
    public WriteOffCreate(WriteOffCreate.Insurance value)
    {
        Type = "insurance";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of WriteOffCreate with <see cref="WriteOffCreate.NonInsurancePayer"/>.
    /// </summary>
    public WriteOffCreate(WriteOffCreate.NonInsurancePayer value)
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
    /// Returns the value as a <see cref="global::Candid.Net.WriteOffs.V1.PatientWriteOffCreate"/> if <see cref="Type"/> is 'patient', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'patient'.</exception>
    public global::Candid.Net.WriteOffs.V1.PatientWriteOffCreate AsPatient() =>
        IsPatient
            ? (global::Candid.Net.WriteOffs.V1.PatientWriteOffCreate)Value!
            : throw new global::System.Exception("WriteOffCreate.Type is not 'patient'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.WriteOffs.V1.InsuranceWriteOffCreate"/> if <see cref="Type"/> is 'insurance', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'insurance'.</exception>
    public global::Candid.Net.WriteOffs.V1.InsuranceWriteOffCreate AsInsurance() =>
        IsInsurance
            ? (global::Candid.Net.WriteOffs.V1.InsuranceWriteOffCreate)Value!
            : throw new global::System.Exception("WriteOffCreate.Type is not 'insurance'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOffCreate"/> if <see cref="Type"/> is 'non_insurance_payer', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'non_insurance_payer'.</exception>
    public global::Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOffCreate AsNonInsurancePayer() =>
        IsNonInsurancePayer
            ? (global::Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOffCreate)Value!
            : throw new global::System.Exception(
                "WriteOffCreate.Type is not 'non_insurance_payer'"
            );

    public T Match<T>(
        Func<global::Candid.Net.WriteOffs.V1.PatientWriteOffCreate, T> onPatient,
        Func<global::Candid.Net.WriteOffs.V1.InsuranceWriteOffCreate, T> onInsurance,
        Func<
            global::Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOffCreate,
            T
        > onNonInsurancePayer,
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
        Action<global::Candid.Net.WriteOffs.V1.PatientWriteOffCreate> onPatient,
        Action<global::Candid.Net.WriteOffs.V1.InsuranceWriteOffCreate> onInsurance,
        Action<global::Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOffCreate> onNonInsurancePayer,
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
    /// Attempts to cast the value to a <see cref="global::Candid.Net.WriteOffs.V1.PatientWriteOffCreate"/> and returns true if successful.
    /// </summary>
    public bool TryAsPatient(out global::Candid.Net.WriteOffs.V1.PatientWriteOffCreate? value)
    {
        if (Type == "patient")
        {
            value = (global::Candid.Net.WriteOffs.V1.PatientWriteOffCreate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.WriteOffs.V1.InsuranceWriteOffCreate"/> and returns true if successful.
    /// </summary>
    public bool TryAsInsurance(out global::Candid.Net.WriteOffs.V1.InsuranceWriteOffCreate? value)
    {
        if (Type == "insurance")
        {
            value = (global::Candid.Net.WriteOffs.V1.InsuranceWriteOffCreate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOffCreate"/> and returns true if successful.
    /// </summary>
    public bool TryAsNonInsurancePayer(
        out global::Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOffCreate? value
    )
    {
        if (Type == "non_insurance_payer")
        {
            value = (global::Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOffCreate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator WriteOffCreate(WriteOffCreate.Patient value) => new(value);

    public static implicit operator WriteOffCreate(WriteOffCreate.Insurance value) => new(value);

    public static implicit operator WriteOffCreate(WriteOffCreate.NonInsurancePayer value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<WriteOffCreate>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(WriteOffCreate).IsAssignableFrom(typeToConvert);

        public override WriteOffCreate Read(
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
                "patient" =>
                    json.Deserialize<global::Candid.Net.WriteOffs.V1.PatientWriteOffCreate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.WriteOffs.V1.PatientWriteOffCreate"
                        ),
                "insurance" =>
                    json.Deserialize<global::Candid.Net.WriteOffs.V1.InsuranceWriteOffCreate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.WriteOffs.V1.InsuranceWriteOffCreate"
                        ),
                "non_insurance_payer" =>
                    json.Deserialize<global::Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOffCreate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOffCreate"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new WriteOffCreate(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WriteOffCreate value,
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
        public Patient(global::Candid.Net.WriteOffs.V1.PatientWriteOffCreate value)
        {
            Value = value;
        }

        internal global::Candid.Net.WriteOffs.V1.PatientWriteOffCreate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator WriteOffCreate.Patient(
            global::Candid.Net.WriteOffs.V1.PatientWriteOffCreate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for insurance
    /// </summary>
    [Serializable]
    public struct Insurance
    {
        public Insurance(global::Candid.Net.WriteOffs.V1.InsuranceWriteOffCreate value)
        {
            Value = value;
        }

        internal global::Candid.Net.WriteOffs.V1.InsuranceWriteOffCreate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator WriteOffCreate.Insurance(
            global::Candid.Net.WriteOffs.V1.InsuranceWriteOffCreate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for non_insurance_payer
    /// </summary>
    [Serializable]
    public struct NonInsurancePayer
    {
        public NonInsurancePayer(
            global::Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOffCreate value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOffCreate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator WriteOffCreate.NonInsurancePayer(
            global::Candid.Net.WriteOffs.V1.NonInsurancePayerWriteOffCreate value
        ) => new(value);
    }
}
