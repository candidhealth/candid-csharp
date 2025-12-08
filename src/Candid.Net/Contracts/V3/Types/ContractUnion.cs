// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Contracts.V3;

[JsonConverter(typeof(ContractUnion.JsonConverter))]
[Serializable]
public record ContractUnion
{
    internal ContractUnion(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of ContractUnion with <see cref="ContractUnion.Professional"/>.
    /// </summary>
    public ContractUnion(ContractUnion.Professional value)
    {
        Type = "professional";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ContractUnion with <see cref="ContractUnion.Institutional"/>.
    /// </summary>
    public ContractUnion(ContractUnion.Institutional value)
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
    /// Returns the value as a <see cref="global::Candid.Net.Contracts.V3.Contract"/> if <see cref="Type"/> is 'professional', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'professional'.</exception>
    public global::Candid.Net.Contracts.V3.Contract AsProfessional() =>
        IsProfessional
            ? (global::Candid.Net.Contracts.V3.Contract)Value!
            : throw new global::System.Exception("ContractUnion.Type is not 'professional'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Contracts.V3.Contract"/> if <see cref="Type"/> is 'institutional', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'institutional'.</exception>
    public global::Candid.Net.Contracts.V3.Contract AsInstitutional() =>
        IsInstitutional
            ? (global::Candid.Net.Contracts.V3.Contract)Value!
            : throw new global::System.Exception("ContractUnion.Type is not 'institutional'");

    public T Match<T>(
        Func<global::Candid.Net.Contracts.V3.Contract, T> onProfessional,
        Func<global::Candid.Net.Contracts.V3.Contract, T> onInstitutional,
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
        Action<global::Candid.Net.Contracts.V3.Contract> onProfessional,
        Action<global::Candid.Net.Contracts.V3.Contract> onInstitutional,
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
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Contracts.V3.Contract"/> and returns true if successful.
    /// </summary>
    public bool TryAsProfessional(out global::Candid.Net.Contracts.V3.Contract? value)
    {
        if (Type == "professional")
        {
            value = (global::Candid.Net.Contracts.V3.Contract)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Contracts.V3.Contract"/> and returns true if successful.
    /// </summary>
    public bool TryAsInstitutional(out global::Candid.Net.Contracts.V3.Contract? value)
    {
        if (Type == "institutional")
        {
            value = (global::Candid.Net.Contracts.V3.Contract)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator ContractUnion(ContractUnion.Professional value) => new(value);

    public static implicit operator ContractUnion(ContractUnion.Institutional value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<ContractUnion>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(ContractUnion).IsAssignableFrom(typeToConvert);

        public override ContractUnion Read(
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
                "professional" => json.Deserialize<global::Candid.Net.Contracts.V3.Contract?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize global::Candid.Net.Contracts.V3.Contract"
                    ),
                "institutional" => json.Deserialize<global::Candid.Net.Contracts.V3.Contract?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize global::Candid.Net.Contracts.V3.Contract"
                    ),
                _ => json.Deserialize<object?>(options),
            };
            return new ContractUnion(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractUnion value,
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
        public Professional(global::Candid.Net.Contracts.V3.Contract value)
        {
            Value = value;
        }

        internal global::Candid.Net.Contracts.V3.Contract Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ContractUnion.Professional(
            global::Candid.Net.Contracts.V3.Contract value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for institutional
    /// </summary>
    [Serializable]
    public struct Institutional
    {
        public Institutional(global::Candid.Net.Contracts.V3.Contract value)
        {
            Value = value;
        }

        internal global::Candid.Net.Contracts.V3.Contract Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ContractUnion.Institutional(
            global::Candid.Net.Contracts.V3.Contract value
        ) => new(value);
    }
}
