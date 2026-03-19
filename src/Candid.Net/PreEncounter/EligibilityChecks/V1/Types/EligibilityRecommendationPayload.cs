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
    /// Create an instance of EligibilityRecommendationPayload with <see cref="EligibilityRecommendationPayload.CopayEstimation"/>.
    /// </summary>
    public EligibilityRecommendationPayload(EligibilityRecommendationPayload.CopayEstimation value)
    {
        Type = "COPAY_ESTIMATION";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of EligibilityRecommendationPayload with <see cref="EligibilityRecommendationPayload.UserConfiguredPrompts"/>.
    /// </summary>
    public EligibilityRecommendationPayload(
        EligibilityRecommendationPayload.UserConfiguredPrompts value
    )
    {
        Type = "USER_CONFIGURED_PROMPTS";
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
    /// Returns true if <see cref="Type"/> is "COPAY_ESTIMATION"
    /// </summary>
    public bool IsCopayEstimation => Type == "COPAY_ESTIMATION";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "USER_CONFIGURED_PROMPTS"
    /// </summary>
    public bool IsUserConfiguredPrompts => Type == "USER_CONFIGURED_PROMPTS";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation"/> if <see cref="Type"/> is 'MEDICARE_ADVANTAGE', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'MEDICARE_ADVANTAGE'.</exception>
    public global::Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation AsMedicareAdvantage() =>
        IsMedicareAdvantage
            ? (global::Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation)
                Value!
            : throw new global::System.Exception(
                "EligibilityRecommendationPayload.Type is not 'MEDICARE_ADVANTAGE'"
            );

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation"/> if <see cref="Type"/> is 'COORDINATION_OF_BENEFITS', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'COORDINATION_OF_BENEFITS'.</exception>
    public global::Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation AsCoordinationOfBenefits() =>
        IsCoordinationOfBenefits
            ? (global::Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation)
                Value!
            : throw new global::System.Exception(
                "EligibilityRecommendationPayload.Type is not 'COORDINATION_OF_BENEFITS'"
            );

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.PreEncounter.EligibilityChecks.V1.CopayEstimationRecommendation"/> if <see cref="Type"/> is 'COPAY_ESTIMATION', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'COPAY_ESTIMATION'.</exception>
    public global::Candid.Net.PreEncounter.EligibilityChecks.V1.CopayEstimationRecommendation AsCopayEstimation() =>
        IsCopayEstimation
            ? (global::Candid.Net.PreEncounter.EligibilityChecks.V1.CopayEstimationRecommendation)
                Value!
            : throw new global::System.Exception(
                "EligibilityRecommendationPayload.Type is not 'COPAY_ESTIMATION'"
            );

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.PreEncounter.EligibilityChecks.V1.UserConfiguredPromptsRecommendation"/> if <see cref="Type"/> is 'USER_CONFIGURED_PROMPTS', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'USER_CONFIGURED_PROMPTS'.</exception>
    public global::Candid.Net.PreEncounter.EligibilityChecks.V1.UserConfiguredPromptsRecommendation AsUserConfiguredPrompts() =>
        IsUserConfiguredPrompts
            ? (global::Candid.Net.PreEncounter.EligibilityChecks.V1.UserConfiguredPromptsRecommendation)
                Value!
            : throw new global::System.Exception(
                "EligibilityRecommendationPayload.Type is not 'USER_CONFIGURED_PROMPTS'"
            );

    public T Match<T>(
        Func<
            global::Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation,
            T
        > onMedicareAdvantage,
        Func<
            global::Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation,
            T
        > onCoordinationOfBenefits,
        Func<
            global::Candid.Net.PreEncounter.EligibilityChecks.V1.CopayEstimationRecommendation,
            T
        > onCopayEstimation,
        Func<
            global::Candid.Net.PreEncounter.EligibilityChecks.V1.UserConfiguredPromptsRecommendation,
            T
        > onUserConfiguredPrompts,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "MEDICARE_ADVANTAGE" => onMedicareAdvantage(AsMedicareAdvantage()),
            "COORDINATION_OF_BENEFITS" => onCoordinationOfBenefits(AsCoordinationOfBenefits()),
            "COPAY_ESTIMATION" => onCopayEstimation(AsCopayEstimation()),
            "USER_CONFIGURED_PROMPTS" => onUserConfiguredPrompts(AsUserConfiguredPrompts()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation> onMedicareAdvantage,
        Action<global::Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation> onCoordinationOfBenefits,
        Action<global::Candid.Net.PreEncounter.EligibilityChecks.V1.CopayEstimationRecommendation> onCopayEstimation,
        Action<global::Candid.Net.PreEncounter.EligibilityChecks.V1.UserConfiguredPromptsRecommendation> onUserConfiguredPrompts,
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
            case "COPAY_ESTIMATION":
                onCopayEstimation(AsCopayEstimation());
                break;
            case "USER_CONFIGURED_PROMPTS":
                onUserConfiguredPrompts(AsUserConfiguredPrompts());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation"/> and returns true if successful.
    /// </summary>
    public bool TryAsMedicareAdvantage(
        out global::Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation? value
    )
    {
        if (Type == "MEDICARE_ADVANTAGE")
        {
            value =
                (global::Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation"/> and returns true if successful.
    /// </summary>
    public bool TryAsCoordinationOfBenefits(
        out global::Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation? value
    )
    {
        if (Type == "COORDINATION_OF_BENEFITS")
        {
            value =
                (global::Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.PreEncounter.EligibilityChecks.V1.CopayEstimationRecommendation"/> and returns true if successful.
    /// </summary>
    public bool TryAsCopayEstimation(
        out global::Candid.Net.PreEncounter.EligibilityChecks.V1.CopayEstimationRecommendation? value
    )
    {
        if (Type == "COPAY_ESTIMATION")
        {
            value =
                (global::Candid.Net.PreEncounter.EligibilityChecks.V1.CopayEstimationRecommendation)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.PreEncounter.EligibilityChecks.V1.UserConfiguredPromptsRecommendation"/> and returns true if successful.
    /// </summary>
    public bool TryAsUserConfiguredPrompts(
        out global::Candid.Net.PreEncounter.EligibilityChecks.V1.UserConfiguredPromptsRecommendation? value
    )
    {
        if (Type == "USER_CONFIGURED_PROMPTS")
        {
            value =
                (global::Candid.Net.PreEncounter.EligibilityChecks.V1.UserConfiguredPromptsRecommendation)
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

    public static implicit operator EligibilityRecommendationPayload(
        EligibilityRecommendationPayload.CopayEstimation value
    ) => new(value);

    public static implicit operator EligibilityRecommendationPayload(
        EligibilityRecommendationPayload.UserConfiguredPrompts value
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
                    json.Deserialize<global::Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation"
                        ),
                "COORDINATION_OF_BENEFITS" =>
                    json.Deserialize<global::Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation"
                        ),
                "COPAY_ESTIMATION" =>
                    json.Deserialize<global::Candid.Net.PreEncounter.EligibilityChecks.V1.CopayEstimationRecommendation?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.PreEncounter.EligibilityChecks.V1.CopayEstimationRecommendation"
                        ),
                "USER_CONFIGURED_PROMPTS" =>
                    json.Deserialize<global::Candid.Net.PreEncounter.EligibilityChecks.V1.UserConfiguredPromptsRecommendation?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.PreEncounter.EligibilityChecks.V1.UserConfiguredPromptsRecommendation"
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
                    "COPAY_ESTIMATION" => JsonSerializer.SerializeToNode(value.Value, options),
                    "USER_CONFIGURED_PROMPTS" => JsonSerializer.SerializeToNode(
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
            global::Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator EligibilityRecommendationPayload.MedicareAdvantage(
            global::Candid.Net.PreEncounter.EligibilityChecks.V1.MedicareAdvantageRecommendation value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for COORDINATION_OF_BENEFITS
    /// </summary>
    [Serializable]
    public struct CoordinationOfBenefits
    {
        public CoordinationOfBenefits(
            global::Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator EligibilityRecommendationPayload.CoordinationOfBenefits(
            global::Candid.Net.PreEncounter.EligibilityChecks.V1.CoordinationOfBenefitsRecommendation value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for COPAY_ESTIMATION
    /// </summary>
    [Serializable]
    public struct CopayEstimation
    {
        public CopayEstimation(
            global::Candid.Net.PreEncounter.EligibilityChecks.V1.CopayEstimationRecommendation value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.PreEncounter.EligibilityChecks.V1.CopayEstimationRecommendation Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator EligibilityRecommendationPayload.CopayEstimation(
            global::Candid.Net.PreEncounter.EligibilityChecks.V1.CopayEstimationRecommendation value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for USER_CONFIGURED_PROMPTS
    /// </summary>
    [Serializable]
    public struct UserConfiguredPrompts
    {
        public UserConfiguredPrompts(
            global::Candid.Net.PreEncounter.EligibilityChecks.V1.UserConfiguredPromptsRecommendation value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.PreEncounter.EligibilityChecks.V1.UserConfiguredPromptsRecommendation Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator EligibilityRecommendationPayload.UserConfiguredPrompts(
            global::Candid.Net.PreEncounter.EligibilityChecks.V1.UserConfiguredPromptsRecommendation value
        ) => new(value);
    }
}
