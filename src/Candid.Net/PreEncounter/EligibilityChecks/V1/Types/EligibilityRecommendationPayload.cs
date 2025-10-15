// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[JsonConverter(typeof(EligibilityRecommendationPayload.JsonConverter))]
[Serializable]
public record EligibilityRecommendationPayload
{
    internal EligibilityRecommendationPayload(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of EligibilityRecommendationPayload with <see cref="EligibilityRecommendationPayload.MedicareAdvantage"/>.
    /// </summary>
    public EligibilityRecommendationPayload(
        EligibilityRecommendationPayload.MedicareAdvantage value
    )
    {
        Type = "MEDICARE_ADVANTAGE";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of EligibilityRecommendationPayload with <see cref="EligibilityRecommendationPayload.CoordinationOfBenefits"/>.
    /// </summary>
    public EligibilityRecommendationPayload(
        EligibilityRecommendationPayload.CoordinationOfBenefits value
    )
    {
        Type = "COORDINATION_OF_BENEFITS";
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
    /// Returns true if <see cref="Type"/> is "MEDICARE_ADVANTAGE"
    /// </summary>
    public bool IsMedicareAdvantage => Type == "MEDICARE_ADVANTAGE";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "COORDINATION_OF_BENEFITS"
    /// </summary>
    public bool IsCoordinationOfBenefits => Type == "COORDINATION_OF_BENEFITS";

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation"/> if <see cref="Type"/> is 'MEDICARE_ADVANTAGE', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'MEDICARE_ADVANTAGE'.</exception>
    public Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation AsMedicareAdvantage() =>
        IsMedicareAdvantage
            ? (Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation)Value!
            : throw new Exception(
                "EligibilityRecommendationPayload.Type is not 'MEDICARE_ADVANTAGE'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation"/> if <see cref="Type"/> is 'COORDINATION_OF_BENEFITS', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'COORDINATION_OF_BENEFITS'.</exception>
    public Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation AsCoordinationOfBenefits() =>
        IsCoordinationOfBenefits
            ? (Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation)
                Value!
            : throw new Exception(
                "EligibilityRecommendationPayload.Type is not 'COORDINATION_OF_BENEFITS'"
            );

    public T Match<T>(
        Func<
            Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation,
            T
        > onMedicareAdvantage,
        Func<
            Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation,
            T
        > onCoordinationOfBenefits,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "MEDICARE_ADVANTAGE" => onMedicareAdvantage(AsMedicareAdvantage()),
            "COORDINATION_OF_BENEFITS" => onCoordinationOfBenefits(AsCoordinationOfBenefits()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation> onMedicareAdvantage,
        Action<Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation> onCoordinationOfBenefits,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "MEDICARE_ADVANTAGE":
                onMedicareAdvantage(AsMedicareAdvantage());
                break;
            case "COORDINATION_OF_BENEFITS":
                onCoordinationOfBenefits(AsCoordinationOfBenefits());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation"/> and returns true if successful.
    /// </summary>
    public bool TryAsMedicareAdvantage(
        out Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation? value
    )
    {
        if (Type == "MEDICARE_ADVANTAGE")
        {
            value = (Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation"/> and returns true if successful.
    /// </summary>
    public bool TryAsCoordinationOfBenefits(
        out Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation? value
    )
    {
        if (Type == "COORDINATION_OF_BENEFITS")
        {
            value =
                (Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator EligibilityRecommendationPayload(
        EligibilityRecommendationPayload.MedicareAdvantage value
    ) => new(value);

    public static implicit operator EligibilityRecommendationPayload(
        EligibilityRecommendationPayload.CoordinationOfBenefits value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<EligibilityRecommendationPayload>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(EligibilityRecommendationPayload).IsAssignableFrom(typeToConvert);

        public override EligibilityRecommendationPayload Read(
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
                "MEDICARE_ADVANTAGE" =>
                    json.Deserialize<Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation"
                        ),
                "COORDINATION_OF_BENEFITS" =>
                    json.Deserialize<Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new EligibilityRecommendationPayload(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EligibilityRecommendationPayload value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "MEDICARE_ADVANTAGE" => JsonSerializer.SerializeToNode(value.Value, options),
                    "COORDINATION_OF_BENEFITS" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for MEDICARE_ADVANTAGE
    /// </summary>
    [Serializable]
    public struct MedicareAdvantage
    {
        public MedicareAdvantage(
            Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation value
        )
        {
            Value = value;
        }

        internal Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator EligibilityRecommendationPayload.MedicareAdvantage(
            Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for COORDINATION_OF_BENEFITS
    /// </summary>
    [Serializable]
    public struct CoordinationOfBenefits
    {
        public CoordinationOfBenefits(
            Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation value
        )
        {
            Value = value;
        }

        internal Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator EligibilityRecommendationPayload.CoordinationOfBenefits(
            Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation value
        ) => new(value);
    }
}
