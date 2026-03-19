// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Contracts.V3;

[JsonConverter(typeof(ContractUpdateUnion.JsonConverter))]
[Serializable]
public record ContractUpdateUnion
{
    internal ContractUpdateUnion(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of ContractUpdateUnion with <see cref="ContractUpdateUnion.Professional"/>.
    /// </summary>
    public ContractUpdateUnion(ContractUpdateUnion.Professional value)
    {
        Type = "professional";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ContractUpdateUnion with <see cref="ContractUpdateUnion.Institutional"/>.
    /// </summary>
    public ContractUpdateUnion(ContractUpdateUnion.Institutional value)
    {
        Type = "institutional";
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
    /// Returns true if <see cref="Type"/> is "professional"
    /// </summary>
    public bool IsProfessional => Type == "professional";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "institutional"
    /// </summary>
    public bool IsInstitutional => Type == "institutional";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Contracts.V3.ProfessionalContractUpdate"/> if <see cref="Type"/> is 'professional', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'professional'.</exception>
    public global::Candid.Net.Contracts.V3.ProfessionalContractUpdate AsProfessional() =>
        IsProfessional
            ? (global::Candid.Net.Contracts.V3.ProfessionalContractUpdate)Value!
            : throw new global::System.Exception("ContractUpdateUnion.Type is not 'professional'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Contracts.V3.InstitutionalContractUpdate"/> if <see cref="Type"/> is 'institutional', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'institutional'.</exception>
    public global::Candid.Net.Contracts.V3.InstitutionalContractUpdate AsInstitutional() =>
        IsInstitutional
            ? (global::Candid.Net.Contracts.V3.InstitutionalContractUpdate)Value!
            : throw new global::System.Exception("ContractUpdateUnion.Type is not 'institutional'");

    public T Match<T>(
        Func<global::Candid.Net.Contracts.V3.ProfessionalContractUpdate, T> onProfessional,
        Func<global::Candid.Net.Contracts.V3.InstitutionalContractUpdate, T> onInstitutional,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "professional" => onProfessional(AsProfessional()),
            "institutional" => onInstitutional(AsInstitutional()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.Contracts.V3.ProfessionalContractUpdate> onProfessional,
        Action<global::Candid.Net.Contracts.V3.InstitutionalContractUpdate> onInstitutional,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "professional":
                onProfessional(AsProfessional());
                break;
            case "institutional":
                onInstitutional(AsInstitutional());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Contracts.V3.ProfessionalContractUpdate"/> and returns true if successful.
    /// </summary>
    public bool TryAsProfessional(
        out global::Candid.Net.Contracts.V3.ProfessionalContractUpdate? value
    )
    {
        if (Type == "professional")
        {
            value = (global::Candid.Net.Contracts.V3.ProfessionalContractUpdate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Contracts.V3.InstitutionalContractUpdate"/> and returns true if successful.
    /// </summary>
    public bool TryAsInstitutional(
        out global::Candid.Net.Contracts.V3.InstitutionalContractUpdate? value
    )
    {
        if (Type == "institutional")
        {
            value = (global::Candid.Net.Contracts.V3.InstitutionalContractUpdate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator ContractUpdateUnion(ContractUpdateUnion.Professional value) =>
        new(value);

    public static implicit operator ContractUpdateUnion(ContractUpdateUnion.Institutional value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<ContractUpdateUnion>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(ContractUpdateUnion).IsAssignableFrom(typeToConvert);

        public override ContractUpdateUnion Read(
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
                "professional" =>
                    json.Deserialize<global::Candid.Net.Contracts.V3.ProfessionalContractUpdate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.Contracts.V3.ProfessionalContractUpdate"
                        ),
                "institutional" =>
                    json.Deserialize<global::Candid.Net.Contracts.V3.InstitutionalContractUpdate?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.Contracts.V3.InstitutionalContractUpdate"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new ContractUpdateUnion(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractUpdateUnion value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "professional" => JsonSerializer.SerializeToNode(value.Value, options),
                    "institutional" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for professional
    /// </summary>
    [Serializable]
    public struct Professional
    {
        public Professional(global::Candid.Net.Contracts.V3.ProfessionalContractUpdate value)
        {
            Value = value;
        }

        internal global::Candid.Net.Contracts.V3.ProfessionalContractUpdate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ContractUpdateUnion.Professional(
            global::Candid.Net.Contracts.V3.ProfessionalContractUpdate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for institutional
    /// </summary>
    [Serializable]
    public struct Institutional
    {
        public Institutional(global::Candid.Net.Contracts.V3.InstitutionalContractUpdate value)
        {
            Value = value;
        }

        internal global::Candid.Net.Contracts.V3.InstitutionalContractUpdate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ContractUpdateUnion.Institutional(
            global::Candid.Net.Contracts.V3.InstitutionalContractUpdate value
        ) => new(value);
    }
}
