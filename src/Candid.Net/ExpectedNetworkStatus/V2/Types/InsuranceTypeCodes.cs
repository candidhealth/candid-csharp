// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V2;

[JsonConverter(typeof(InsuranceTypeCodes.JsonConverter))]
[Serializable]
public record InsuranceTypeCodes
{
    internal InsuranceTypeCodes(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of InsuranceTypeCodes with <see cref="InsuranceTypeCodes.InsuranceTypeCode"/>.
    /// </summary>
    public InsuranceTypeCodes(InsuranceTypeCodes.InsuranceTypeCode value)
    {
        Type = "insurance_type_code";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of InsuranceTypeCodes with <see cref="InsuranceTypeCodes.UnknownInsuranceTypeCode"/>.
    /// </summary>
    public InsuranceTypeCodes(InsuranceTypeCodes.UnknownInsuranceTypeCode value)
    {
        Type = "unknown_insurance_type_code";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of InsuranceTypeCodes with <see cref="InsuranceTypeCodes.NotApplicable"/>.
    /// </summary>
    public InsuranceTypeCodes(InsuranceTypeCodes.NotApplicable value)
    {
        Type = "not_applicable";
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
    /// Returns true if <see cref="Type"/> is "insurance_type_code"
    /// </summary>
    public bool IsInsuranceTypeCode => Type == "insurance_type_code";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "unknown_insurance_type_code"
    /// </summary>
    public bool IsUnknownInsuranceTypeCode => Type == "unknown_insurance_type_code";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "not_applicable"
    /// </summary>
    public bool IsNotApplicable => Type == "not_applicable";

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.Commons.InsuranceTypeCode"/> if <see cref="Type"/> is 'insurance_type_code', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'insurance_type_code'.</exception>
    public Candid.Net.Commons.InsuranceTypeCode AsInsuranceTypeCode() =>
        IsInsuranceTypeCode
            ? (Candid.Net.Commons.InsuranceTypeCode)Value!
            : throw new Exception("InsuranceTypeCodes.Type is not 'insurance_type_code'");

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.ExpectedNetworkStatus.V2.EmptyObject"/> if <see cref="Type"/> is 'unknown_insurance_type_code', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'unknown_insurance_type_code'.</exception>
    public Candid.Net.ExpectedNetworkStatus.V2.EmptyObject AsUnknownInsuranceTypeCode() =>
        IsUnknownInsuranceTypeCode
            ? (Candid.Net.ExpectedNetworkStatus.V2.EmptyObject)Value!
            : throw new Exception("InsuranceTypeCodes.Type is not 'unknown_insurance_type_code'");

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.ExpectedNetworkStatus.V2.EmptyObject"/> if <see cref="Type"/> is 'not_applicable', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'not_applicable'.</exception>
    public Candid.Net.ExpectedNetworkStatus.V2.EmptyObject AsNotApplicable() =>
        IsNotApplicable
            ? (Candid.Net.ExpectedNetworkStatus.V2.EmptyObject)Value!
            : throw new Exception("InsuranceTypeCodes.Type is not 'not_applicable'");

    public T Match<T>(
        Func<Candid.Net.Commons.InsuranceTypeCode, T> onInsuranceTypeCode,
        Func<Candid.Net.ExpectedNetworkStatus.V2.EmptyObject, T> onUnknownInsuranceTypeCode,
        Func<Candid.Net.ExpectedNetworkStatus.V2.EmptyObject, T> onNotApplicable,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "insurance_type_code" => onInsuranceTypeCode(AsInsuranceTypeCode()),
            "unknown_insurance_type_code" => onUnknownInsuranceTypeCode(
                AsUnknownInsuranceTypeCode()
            ),
            "not_applicable" => onNotApplicable(AsNotApplicable()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<Candid.Net.Commons.InsuranceTypeCode> onInsuranceTypeCode,
        Action<Candid.Net.ExpectedNetworkStatus.V2.EmptyObject> onUnknownInsuranceTypeCode,
        Action<Candid.Net.ExpectedNetworkStatus.V2.EmptyObject> onNotApplicable,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "insurance_type_code":
                onInsuranceTypeCode(AsInsuranceTypeCode());
                break;
            case "unknown_insurance_type_code":
                onUnknownInsuranceTypeCode(AsUnknownInsuranceTypeCode());
                break;
            case "not_applicable":
                onNotApplicable(AsNotApplicable());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.Commons.InsuranceTypeCode"/> and returns true if successful.
    /// </summary>
    public bool TryAsInsuranceTypeCode(out Candid.Net.Commons.InsuranceTypeCode? value)
    {
        if (Type == "insurance_type_code")
        {
            value = (Candid.Net.Commons.InsuranceTypeCode)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.ExpectedNetworkStatus.V2.EmptyObject"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnknownInsuranceTypeCode(
        out Candid.Net.ExpectedNetworkStatus.V2.EmptyObject? value
    )
    {
        if (Type == "unknown_insurance_type_code")
        {
            value = (Candid.Net.ExpectedNetworkStatus.V2.EmptyObject)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.ExpectedNetworkStatus.V2.EmptyObject"/> and returns true if successful.
    /// </summary>
    public bool TryAsNotApplicable(out Candid.Net.ExpectedNetworkStatus.V2.EmptyObject? value)
    {
        if (Type == "not_applicable")
        {
            value = (Candid.Net.ExpectedNetworkStatus.V2.EmptyObject)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator InsuranceTypeCodes(
        InsuranceTypeCodes.InsuranceTypeCode value
    ) => new(value);

    public static implicit operator InsuranceTypeCodes(
        InsuranceTypeCodes.UnknownInsuranceTypeCode value
    ) => new(value);

    public static implicit operator InsuranceTypeCodes(InsuranceTypeCodes.NotApplicable value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<InsuranceTypeCodes>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(InsuranceTypeCodes).IsAssignableFrom(typeToConvert);

        public override InsuranceTypeCodes Read(
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
                "insurance_type_code" => json.GetProperty("value")
                    .Deserialize<Candid.Net.Commons.InsuranceTypeCode>(options)
                ?? throw new JsonException(
                        "Failed to deserialize Candid.Net.Commons.InsuranceTypeCode"
                    ),
                "unknown_insurance_type_code" =>
                    json.Deserialize<Candid.Net.ExpectedNetworkStatus.V2.EmptyObject>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.ExpectedNetworkStatus.V2.EmptyObject"
                        ),
                "not_applicable" =>
                    json.Deserialize<Candid.Net.ExpectedNetworkStatus.V2.EmptyObject>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.ExpectedNetworkStatus.V2.EmptyObject"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new InsuranceTypeCodes(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InsuranceTypeCodes value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "insurance_type_code" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    "unknown_insurance_type_code" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "not_applicable" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for insurance_type_code
    /// </summary>
    [Serializable]
    public struct InsuranceTypeCode
    {
        public InsuranceTypeCode(Candid.Net.Commons.InsuranceTypeCode value)
        {
            Value = value;
        }

        internal Candid.Net.Commons.InsuranceTypeCode Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator InsuranceTypeCodes.InsuranceTypeCode(
            Candid.Net.Commons.InsuranceTypeCode value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unknown_insurance_type_code
    /// </summary>
    [Serializable]
    public struct UnknownInsuranceTypeCode
    {
        public UnknownInsuranceTypeCode(Candid.Net.ExpectedNetworkStatus.V2.EmptyObject value)
        {
            Value = value;
        }

        internal Candid.Net.ExpectedNetworkStatus.V2.EmptyObject Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator InsuranceTypeCodes.UnknownInsuranceTypeCode(
            Candid.Net.ExpectedNetworkStatus.V2.EmptyObject value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for not_applicable
    /// </summary>
    [Serializable]
    public struct NotApplicable
    {
        public NotApplicable(Candid.Net.ExpectedNetworkStatus.V2.EmptyObject value)
        {
            Value = value;
        }

        internal Candid.Net.ExpectedNetworkStatus.V2.EmptyObject Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator InsuranceTypeCodes.NotApplicable(
            Candid.Net.ExpectedNetworkStatus.V2.EmptyObject value
        ) => new(value);
    }
}
