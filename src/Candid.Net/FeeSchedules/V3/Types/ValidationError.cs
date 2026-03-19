// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

[JsonConverter(typeof(ValidationError.JsonConverter))]
[Serializable]
public record ValidationError
{
    internal ValidationError(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of ValidationError with <see cref="ValidationError.OverlappingRateEntries"/>.
    /// </summary>
    public ValidationError(ValidationError.OverlappingRateEntries value)
    {
        Type = "overlapping_rate_entries";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ValidationError with <see cref="ValidationError.VersionConflict"/>.
    /// </summary>
    public ValidationError(ValidationError.VersionConflict value)
    {
        Type = "version_conflict";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ValidationError with <see cref="ValidationError.OrganizationProviderNotFound"/>.
    /// </summary>
    public ValidationError(ValidationError.OrganizationProviderNotFound value)
    {
        Type = "organization_provider_not_found";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ValidationError with <see cref="ValidationError.DuplicateRate"/>.
    /// </summary>
    public ValidationError(ValidationError.DuplicateRate value)
    {
        Type = "duplicate_rate";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ValidationError with <see cref="ValidationError.EmptyEntries"/>.
    /// </summary>
    public ValidationError(ValidationError.EmptyEntries value)
    {
        Type = "empty_entries";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ValidationError with <see cref="ValidationError.PayerPlanGroupNotFound"/>.
    /// </summary>
    public ValidationError(ValidationError.PayerPlanGroupNotFound value)
    {
        Type = "payer_plan_group_not_found";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ValidationError with <see cref="ValidationError.PayerPlanGroupDoesNotMatchRatePayer"/>.
    /// </summary>
    public ValidationError(ValidationError.PayerPlanGroupDoesNotMatchRatePayer value)
    {
        Type = "payer_plan_group_does_not_match_rate_payer";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ValidationError with <see cref="ValidationError.PayerPlanGroupNetworkTypeMutualExclusion"/>.
    /// </summary>
    public ValidationError(ValidationError.PayerPlanGroupNetworkTypeMutualExclusion value)
    {
        Type = "payer_plan_group_network_type_mutual_exclusion";
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
    /// Returns true if <see cref="Type"/> is "overlapping_rate_entries"
    /// </summary>
    public bool IsOverlappingRateEntries => Type == "overlapping_rate_entries";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "version_conflict"
    /// </summary>
    public bool IsVersionConflict => Type == "version_conflict";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "organization_provider_not_found"
    /// </summary>
    public bool IsOrganizationProviderNotFound => Type == "organization_provider_not_found";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "duplicate_rate"
    /// </summary>
    public bool IsDuplicateRate => Type == "duplicate_rate";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "empty_entries"
    /// </summary>
    public bool IsEmptyEntries => Type == "empty_entries";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "payer_plan_group_not_found"
    /// </summary>
    public bool IsPayerPlanGroupNotFound => Type == "payer_plan_group_not_found";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "payer_plan_group_does_not_match_rate_payer"
    /// </summary>
    public bool IsPayerPlanGroupDoesNotMatchRatePayer =>
        Type == "payer_plan_group_does_not_match_rate_payer";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "payer_plan_group_network_type_mutual_exclusion"
    /// </summary>
    public bool IsPayerPlanGroupNetworkTypeMutualExclusion =>
        Type == "payer_plan_group_network_type_mutual_exclusion";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.FeeSchedules.V3.OverlappingRateEntriesError"/> if <see cref="Type"/> is 'overlapping_rate_entries', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'overlapping_rate_entries'.</exception>
    public global::Candid.Net.FeeSchedules.V3.OverlappingRateEntriesError AsOverlappingRateEntries() =>
        IsOverlappingRateEntries
            ? (global::Candid.Net.FeeSchedules.V3.OverlappingRateEntriesError)Value!
            : throw new global::System.Exception(
                "ValidationError.Type is not 'overlapping_rate_entries'"
            );

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Commons.EntityConflictErrorMessage"/> if <see cref="Type"/> is 'version_conflict', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'version_conflict'.</exception>
    public global::Candid.Net.Commons.EntityConflictErrorMessage AsVersionConflict() =>
        IsVersionConflict
            ? (global::Candid.Net.Commons.EntityConflictErrorMessage)Value!
            : throw new global::System.Exception("ValidationError.Type is not 'version_conflict'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Commons.EntityNotFoundErrorMessage"/> if <see cref="Type"/> is 'organization_provider_not_found', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'organization_provider_not_found'.</exception>
    public global::Candid.Net.Commons.EntityNotFoundErrorMessage AsOrganizationProviderNotFound() =>
        IsOrganizationProviderNotFound
            ? (global::Candid.Net.Commons.EntityNotFoundErrorMessage)Value!
            : throw new global::System.Exception(
                "ValidationError.Type is not 'organization_provider_not_found'"
            );

    /// <summary>
    /// Returns the value as a <see cref="object"/> if <see cref="Type"/> is 'duplicate_rate', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'duplicate_rate'.</exception>
    public object AsDuplicateRate() =>
        IsDuplicateRate
            ? Value!
            : throw new global::System.Exception("ValidationError.Type is not 'duplicate_rate'");

    /// <summary>
    /// Returns the value as a <see cref="object"/> if <see cref="Type"/> is 'empty_entries', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'empty_entries'.</exception>
    public object AsEmptyEntries() =>
        IsEmptyEntries
            ? Value!
            : throw new global::System.Exception("ValidationError.Type is not 'empty_entries'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Commons.EntityNotFoundErrorMessage"/> if <see cref="Type"/> is 'payer_plan_group_not_found', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'payer_plan_group_not_found'.</exception>
    public global::Candid.Net.Commons.EntityNotFoundErrorMessage AsPayerPlanGroupNotFound() =>
        IsPayerPlanGroupNotFound
            ? (global::Candid.Net.Commons.EntityNotFoundErrorMessage)Value!
            : throw new global::System.Exception(
                "ValidationError.Type is not 'payer_plan_group_not_found'"
            );

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.FeeSchedules.V3.PayerPlanGroupDoesNotMatchRatePayerError"/> if <see cref="Type"/> is 'payer_plan_group_does_not_match_rate_payer', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'payer_plan_group_does_not_match_rate_payer'.</exception>
    public global::Candid.Net.FeeSchedules.V3.PayerPlanGroupDoesNotMatchRatePayerError AsPayerPlanGroupDoesNotMatchRatePayer() =>
        IsPayerPlanGroupDoesNotMatchRatePayer
            ? (global::Candid.Net.FeeSchedules.V3.PayerPlanGroupDoesNotMatchRatePayerError)Value!
            : throw new global::System.Exception(
                "ValidationError.Type is not 'payer_plan_group_does_not_match_rate_payer'"
            );

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Commons.EntityConflictErrorMessage"/> if <see cref="Type"/> is 'payer_plan_group_network_type_mutual_exclusion', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'payer_plan_group_network_type_mutual_exclusion'.</exception>
    public global::Candid.Net.Commons.EntityConflictErrorMessage AsPayerPlanGroupNetworkTypeMutualExclusion() =>
        IsPayerPlanGroupNetworkTypeMutualExclusion
            ? (global::Candid.Net.Commons.EntityConflictErrorMessage)Value!
            : throw new global::System.Exception(
                "ValidationError.Type is not 'payer_plan_group_network_type_mutual_exclusion'"
            );

    public T Match<T>(
        Func<
            global::Candid.Net.FeeSchedules.V3.OverlappingRateEntriesError,
            T
        > onOverlappingRateEntries,
        Func<global::Candid.Net.Commons.EntityConflictErrorMessage, T> onVersionConflict,
        Func<
            global::Candid.Net.Commons.EntityNotFoundErrorMessage,
            T
        > onOrganizationProviderNotFound,
        Func<object, T> onDuplicateRate,
        Func<object, T> onEmptyEntries,
        Func<global::Candid.Net.Commons.EntityNotFoundErrorMessage, T> onPayerPlanGroupNotFound,
        Func<
            global::Candid.Net.FeeSchedules.V3.PayerPlanGroupDoesNotMatchRatePayerError,
            T
        > onPayerPlanGroupDoesNotMatchRatePayer,
        Func<
            global::Candid.Net.Commons.EntityConflictErrorMessage,
            T
        > onPayerPlanGroupNetworkTypeMutualExclusion,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "overlapping_rate_entries" => onOverlappingRateEntries(AsOverlappingRateEntries()),
            "version_conflict" => onVersionConflict(AsVersionConflict()),
            "organization_provider_not_found" => onOrganizationProviderNotFound(
                AsOrganizationProviderNotFound()
            ),
            "duplicate_rate" => onDuplicateRate(AsDuplicateRate()),
            "empty_entries" => onEmptyEntries(AsEmptyEntries()),
            "payer_plan_group_not_found" => onPayerPlanGroupNotFound(AsPayerPlanGroupNotFound()),
            "payer_plan_group_does_not_match_rate_payer" => onPayerPlanGroupDoesNotMatchRatePayer(
                AsPayerPlanGroupDoesNotMatchRatePayer()
            ),
            "payer_plan_group_network_type_mutual_exclusion" =>
                onPayerPlanGroupNetworkTypeMutualExclusion(
                    AsPayerPlanGroupNetworkTypeMutualExclusion()
                ),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.FeeSchedules.V3.OverlappingRateEntriesError> onOverlappingRateEntries,
        Action<global::Candid.Net.Commons.EntityConflictErrorMessage> onVersionConflict,
        Action<global::Candid.Net.Commons.EntityNotFoundErrorMessage> onOrganizationProviderNotFound,
        Action<object> onDuplicateRate,
        Action<object> onEmptyEntries,
        Action<global::Candid.Net.Commons.EntityNotFoundErrorMessage> onPayerPlanGroupNotFound,
        Action<global::Candid.Net.FeeSchedules.V3.PayerPlanGroupDoesNotMatchRatePayerError> onPayerPlanGroupDoesNotMatchRatePayer,
        Action<global::Candid.Net.Commons.EntityConflictErrorMessage> onPayerPlanGroupNetworkTypeMutualExclusion,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "overlapping_rate_entries":
                onOverlappingRateEntries(AsOverlappingRateEntries());
                break;
            case "version_conflict":
                onVersionConflict(AsVersionConflict());
                break;
            case "organization_provider_not_found":
                onOrganizationProviderNotFound(AsOrganizationProviderNotFound());
                break;
            case "duplicate_rate":
                onDuplicateRate(AsDuplicateRate());
                break;
            case "empty_entries":
                onEmptyEntries(AsEmptyEntries());
                break;
            case "payer_plan_group_not_found":
                onPayerPlanGroupNotFound(AsPayerPlanGroupNotFound());
                break;
            case "payer_plan_group_does_not_match_rate_payer":
                onPayerPlanGroupDoesNotMatchRatePayer(AsPayerPlanGroupDoesNotMatchRatePayer());
                break;
            case "payer_plan_group_network_type_mutual_exclusion":
                onPayerPlanGroupNetworkTypeMutualExclusion(
                    AsPayerPlanGroupNetworkTypeMutualExclusion()
                );
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.FeeSchedules.V3.OverlappingRateEntriesError"/> and returns true if successful.
    /// </summary>
    public bool TryAsOverlappingRateEntries(
        out global::Candid.Net.FeeSchedules.V3.OverlappingRateEntriesError? value
    )
    {
        if (Type == "overlapping_rate_entries")
        {
            value = (global::Candid.Net.FeeSchedules.V3.OverlappingRateEntriesError)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Commons.EntityConflictErrorMessage"/> and returns true if successful.
    /// </summary>
    public bool TryAsVersionConflict(
        out global::Candid.Net.Commons.EntityConflictErrorMessage? value
    )
    {
        if (Type == "version_conflict")
        {
            value = (global::Candid.Net.Commons.EntityConflictErrorMessage)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Commons.EntityNotFoundErrorMessage"/> and returns true if successful.
    /// </summary>
    public bool TryAsOrganizationProviderNotFound(
        out global::Candid.Net.Commons.EntityNotFoundErrorMessage? value
    )
    {
        if (Type == "organization_provider_not_found")
        {
            value = (global::Candid.Net.Commons.EntityNotFoundErrorMessage)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="object"/> and returns true if successful.
    /// </summary>
    public bool TryAsDuplicateRate(out object? value)
    {
        if (Type == "duplicate_rate")
        {
            value = Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="object"/> and returns true if successful.
    /// </summary>
    public bool TryAsEmptyEntries(out object? value)
    {
        if (Type == "empty_entries")
        {
            value = Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Commons.EntityNotFoundErrorMessage"/> and returns true if successful.
    /// </summary>
    public bool TryAsPayerPlanGroupNotFound(
        out global::Candid.Net.Commons.EntityNotFoundErrorMessage? value
    )
    {
        if (Type == "payer_plan_group_not_found")
        {
            value = (global::Candid.Net.Commons.EntityNotFoundErrorMessage)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.FeeSchedules.V3.PayerPlanGroupDoesNotMatchRatePayerError"/> and returns true if successful.
    /// </summary>
    public bool TryAsPayerPlanGroupDoesNotMatchRatePayer(
        out global::Candid.Net.FeeSchedules.V3.PayerPlanGroupDoesNotMatchRatePayerError? value
    )
    {
        if (Type == "payer_plan_group_does_not_match_rate_payer")
        {
            value = (global::Candid.Net.FeeSchedules.V3.PayerPlanGroupDoesNotMatchRatePayerError)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Commons.EntityConflictErrorMessage"/> and returns true if successful.
    /// </summary>
    public bool TryAsPayerPlanGroupNetworkTypeMutualExclusion(
        out global::Candid.Net.Commons.EntityConflictErrorMessage? value
    )
    {
        if (Type == "payer_plan_group_network_type_mutual_exclusion")
        {
            value = (global::Candid.Net.Commons.EntityConflictErrorMessage)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator ValidationError(ValidationError.OverlappingRateEntries value) =>
        new(value);

    public static implicit operator ValidationError(ValidationError.VersionConflict value) =>
        new(value);

    public static implicit operator ValidationError(
        ValidationError.OrganizationProviderNotFound value
    ) => new(value);

    public static implicit operator ValidationError(ValidationError.PayerPlanGroupNotFound value) =>
        new(value);

    public static implicit operator ValidationError(
        ValidationError.PayerPlanGroupDoesNotMatchRatePayer value
    ) => new(value);

    public static implicit operator ValidationError(
        ValidationError.PayerPlanGroupNetworkTypeMutualExclusion value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<ValidationError>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(ValidationError).IsAssignableFrom(typeToConvert);

        public override ValidationError Read(
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
                "overlapping_rate_entries" =>
                    json.Deserialize<global::Candid.Net.FeeSchedules.V3.OverlappingRateEntriesError?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.FeeSchedules.V3.OverlappingRateEntriesError"
                        ),
                "version_conflict" =>
                    json.Deserialize<global::Candid.Net.Commons.EntityConflictErrorMessage?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.Commons.EntityConflictErrorMessage"
                        ),
                "organization_provider_not_found" =>
                    json.Deserialize<global::Candid.Net.Commons.EntityNotFoundErrorMessage?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.Commons.EntityNotFoundErrorMessage"
                        ),
                "duplicate_rate" => new { },
                "empty_entries" => new { },
                "payer_plan_group_not_found" =>
                    json.Deserialize<global::Candid.Net.Commons.EntityNotFoundErrorMessage?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.Commons.EntityNotFoundErrorMessage"
                        ),
                "payer_plan_group_does_not_match_rate_payer" =>
                    json.Deserialize<global::Candid.Net.FeeSchedules.V3.PayerPlanGroupDoesNotMatchRatePayerError?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.FeeSchedules.V3.PayerPlanGroupDoesNotMatchRatePayerError"
                        ),
                "payer_plan_group_network_type_mutual_exclusion" =>
                    json.Deserialize<global::Candid.Net.Commons.EntityConflictErrorMessage?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.Commons.EntityConflictErrorMessage"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new ValidationError(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ValidationError value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "overlapping_rate_entries" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "version_conflict" => JsonSerializer.SerializeToNode(value.Value, options),
                    "organization_provider_not_found" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "duplicate_rate" => null,
                    "empty_entries" => null,
                    "payer_plan_group_not_found" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "payer_plan_group_does_not_match_rate_payer" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "payer_plan_group_network_type_mutual_exclusion" =>
                        JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for overlapping_rate_entries
    /// </summary>
    [Serializable]
    public struct OverlappingRateEntries
    {
        public OverlappingRateEntries(
            global::Candid.Net.FeeSchedules.V3.OverlappingRateEntriesError value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.FeeSchedules.V3.OverlappingRateEntriesError Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ValidationError.OverlappingRateEntries(
            global::Candid.Net.FeeSchedules.V3.OverlappingRateEntriesError value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for version_conflict
    /// </summary>
    [Serializable]
    public struct VersionConflict
    {
        public VersionConflict(global::Candid.Net.Commons.EntityConflictErrorMessage value)
        {
            Value = value;
        }

        internal global::Candid.Net.Commons.EntityConflictErrorMessage Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ValidationError.VersionConflict(
            global::Candid.Net.Commons.EntityConflictErrorMessage value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for organization_provider_not_found
    /// </summary>
    [Serializable]
    public struct OrganizationProviderNotFound
    {
        public OrganizationProviderNotFound(
            global::Candid.Net.Commons.EntityNotFoundErrorMessage value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.Commons.EntityNotFoundErrorMessage Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ValidationError.OrganizationProviderNotFound(
            global::Candid.Net.Commons.EntityNotFoundErrorMessage value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for duplicate_rate
    /// </summary>
    [Serializable]
    public record DuplicateRate
    {
        internal object Value => new { };

        public override string ToString() => Value.ToString() ?? "null";
    }

    /// <summary>
    /// Discriminated union type for empty_entries
    /// </summary>
    [Serializable]
    public record EmptyEntries
    {
        internal object Value => new { };

        public override string ToString() => Value.ToString() ?? "null";
    }

    /// <summary>
    /// Discriminated union type for payer_plan_group_not_found
    /// </summary>
    [Serializable]
    public struct PayerPlanGroupNotFound
    {
        public PayerPlanGroupNotFound(global::Candid.Net.Commons.EntityNotFoundErrorMessage value)
        {
            Value = value;
        }

        internal global::Candid.Net.Commons.EntityNotFoundErrorMessage Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ValidationError.PayerPlanGroupNotFound(
            global::Candid.Net.Commons.EntityNotFoundErrorMessage value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for payer_plan_group_does_not_match_rate_payer
    /// </summary>
    [Serializable]
    public struct PayerPlanGroupDoesNotMatchRatePayer
    {
        public PayerPlanGroupDoesNotMatchRatePayer(
            global::Candid.Net.FeeSchedules.V3.PayerPlanGroupDoesNotMatchRatePayerError value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.FeeSchedules.V3.PayerPlanGroupDoesNotMatchRatePayerError Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ValidationError.PayerPlanGroupDoesNotMatchRatePayer(
            global::Candid.Net.FeeSchedules.V3.PayerPlanGroupDoesNotMatchRatePayerError value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for payer_plan_group_network_type_mutual_exclusion
    /// </summary>
    [Serializable]
    public struct PayerPlanGroupNetworkTypeMutualExclusion
    {
        public PayerPlanGroupNetworkTypeMutualExclusion(
            global::Candid.Net.Commons.EntityConflictErrorMessage value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.Commons.EntityConflictErrorMessage Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ValidationError.PayerPlanGroupNetworkTypeMutualExclusion(
            global::Candid.Net.Commons.EntityConflictErrorMessage value
        ) => new(value);
    }
}
