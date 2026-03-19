// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Identifiers;

[JsonConverter(typeof(IdentifierValue.JsonConverter))]
[Serializable]
public record IdentifierValue
{
    internal IdentifierValue(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of IdentifierValue with <see cref="IdentifierValue.MedicareProviderIdentifier"/>.
    /// </summary>
    public IdentifierValue(IdentifierValue.MedicareProviderIdentifier value)
    {
        Type = "medicare_provider_identifier";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of IdentifierValue with <see cref="IdentifierValue.MedicaidProviderIdentifier"/>.
    /// </summary>
    public IdentifierValue(IdentifierValue.MedicaidProviderIdentifier value)
    {
        Type = "medicaid_provider_identifier";
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
    /// Returns true if <see cref="Type"/> is "medicare_provider_identifier"
    /// </summary>
    public bool IsMedicareProviderIdentifier => Type == "medicare_provider_identifier";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "medicaid_provider_identifier"
    /// </summary>
    public bool IsMedicaidProviderIdentifier => Type == "medicaid_provider_identifier";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Identifiers.MedicareProviderIdentifier"/> if <see cref="Type"/> is 'medicare_provider_identifier', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'medicare_provider_identifier'.</exception>
    public global::Candid.Net.Identifiers.MedicareProviderIdentifier AsMedicareProviderIdentifier() =>
        IsMedicareProviderIdentifier
            ? (global::Candid.Net.Identifiers.MedicareProviderIdentifier)Value!
            : throw new global::System.Exception(
                "IdentifierValue.Type is not 'medicare_provider_identifier'"
            );

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Identifiers.MedicaidProviderIdentifier"/> if <see cref="Type"/> is 'medicaid_provider_identifier', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'medicaid_provider_identifier'.</exception>
    public global::Candid.Net.Identifiers.MedicaidProviderIdentifier AsMedicaidProviderIdentifier() =>
        IsMedicaidProviderIdentifier
            ? (global::Candid.Net.Identifiers.MedicaidProviderIdentifier)Value!
            : throw new global::System.Exception(
                "IdentifierValue.Type is not 'medicaid_provider_identifier'"
            );

    public T Match<T>(
        Func<
            global::Candid.Net.Identifiers.MedicareProviderIdentifier,
            T
        > onMedicareProviderIdentifier,
        Func<
            global::Candid.Net.Identifiers.MedicaidProviderIdentifier,
            T
        > onMedicaidProviderIdentifier,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "medicare_provider_identifier" => onMedicareProviderIdentifier(
                AsMedicareProviderIdentifier()
            ),
            "medicaid_provider_identifier" => onMedicaidProviderIdentifier(
                AsMedicaidProviderIdentifier()
            ),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.Identifiers.MedicareProviderIdentifier> onMedicareProviderIdentifier,
        Action<global::Candid.Net.Identifiers.MedicaidProviderIdentifier> onMedicaidProviderIdentifier,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "medicare_provider_identifier":
                onMedicareProviderIdentifier(AsMedicareProviderIdentifier());
                break;
            case "medicaid_provider_identifier":
                onMedicaidProviderIdentifier(AsMedicaidProviderIdentifier());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Identifiers.MedicareProviderIdentifier"/> and returns true if successful.
    /// </summary>
    public bool TryAsMedicareProviderIdentifier(
        out global::Candid.Net.Identifiers.MedicareProviderIdentifier? value
    )
    {
        if (Type == "medicare_provider_identifier")
        {
            value = (global::Candid.Net.Identifiers.MedicareProviderIdentifier)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Identifiers.MedicaidProviderIdentifier"/> and returns true if successful.
    /// </summary>
    public bool TryAsMedicaidProviderIdentifier(
        out global::Candid.Net.Identifiers.MedicaidProviderIdentifier? value
    )
    {
        if (Type == "medicaid_provider_identifier")
        {
            value = (global::Candid.Net.Identifiers.MedicaidProviderIdentifier)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator IdentifierValue(
        IdentifierValue.MedicareProviderIdentifier value
    ) => new(value);

    public static implicit operator IdentifierValue(
        IdentifierValue.MedicaidProviderIdentifier value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<IdentifierValue>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(IdentifierValue).IsAssignableFrom(typeToConvert);

        public override IdentifierValue Read(
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
                "medicare_provider_identifier" =>
                    json.Deserialize<global::Candid.Net.Identifiers.MedicareProviderIdentifier?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.Identifiers.MedicareProviderIdentifier"
                        ),
                "medicaid_provider_identifier" =>
                    json.Deserialize<global::Candid.Net.Identifiers.MedicaidProviderIdentifier?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.Identifiers.MedicaidProviderIdentifier"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new IdentifierValue(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            IdentifierValue value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "medicare_provider_identifier" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "medicaid_provider_identifier" => JsonSerializer.SerializeToNode(
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
    /// Discriminated union type for medicare_provider_identifier
    /// </summary>
    [Serializable]
    public struct MedicareProviderIdentifier
    {
        public MedicareProviderIdentifier(
            global::Candid.Net.Identifiers.MedicareProviderIdentifier value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.Identifiers.MedicareProviderIdentifier Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator IdentifierValue.MedicareProviderIdentifier(
            global::Candid.Net.Identifiers.MedicareProviderIdentifier value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for medicaid_provider_identifier
    /// </summary>
    [Serializable]
    public struct MedicaidProviderIdentifier
    {
        public MedicaidProviderIdentifier(
            global::Candid.Net.Identifiers.MedicaidProviderIdentifier value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.Identifiers.MedicaidProviderIdentifier Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator IdentifierValue.MedicaidProviderIdentifier(
            global::Candid.Net.Identifiers.MedicaidProviderIdentifier value
        ) => new(value);
    }
}
