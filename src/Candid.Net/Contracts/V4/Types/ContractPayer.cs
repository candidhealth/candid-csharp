// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Contracts.V4;

/// <summary>
/// The payer under contract. Either an EDI payer or a payer group.
/// </summary>
[JsonConverter(typeof(ContractPayer.JsonConverter))]
[Serializable]
public record ContractPayer
{
    internal ContractPayer(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of ContractPayer with <see cref="ContractPayer.Payer"/>.
    /// </summary>
    public ContractPayer(ContractPayer.Payer value)
    {
        Type = "payer";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ContractPayer with <see cref="ContractPayer.PayerGroup"/>.
    /// </summary>
    public ContractPayer(ContractPayer.PayerGroup value)
    {
        Type = "payer_group";
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
    /// Returns true if <see cref="Type"/> is "payer"
    /// </summary>
    public bool IsPayer => Type == "payer";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "payer_group"
    /// </summary>
    public bool IsPayerGroup => Type == "payer_group";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Payers.V4.Payer"/> if <see cref="Type"/> is 'payer', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'payer'.</exception>
    public global::Candid.Net.Payers.V4.Payer AsPayer() =>
        IsPayer
            ? (global::Candid.Net.Payers.V4.Payer)Value!
            : throw new global::System.Exception("ContractPayer.Type is not 'payer'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.PayerGroups.V1.PayerGroup"/> if <see cref="Type"/> is 'payer_group', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'payer_group'.</exception>
    public global::Candid.Net.PayerGroups.V1.PayerGroup AsPayerGroup() =>
        IsPayerGroup
            ? (global::Candid.Net.PayerGroups.V1.PayerGroup)Value!
            : throw new global::System.Exception("ContractPayer.Type is not 'payer_group'");

    public T Match<T>(
        Func<global::Candid.Net.Payers.V4.Payer, T> onPayer,
        Func<global::Candid.Net.PayerGroups.V1.PayerGroup, T> onPayerGroup,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "payer" => onPayer(AsPayer()),
            "payer_group" => onPayerGroup(AsPayerGroup()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.Payers.V4.Payer> onPayer,
        Action<global::Candid.Net.PayerGroups.V1.PayerGroup> onPayerGroup,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "payer":
                onPayer(AsPayer());
                break;
            case "payer_group":
                onPayerGroup(AsPayerGroup());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Payers.V4.Payer"/> and returns true if successful.
    /// </summary>
    public bool TryAsPayer(out global::Candid.Net.Payers.V4.Payer? value)
    {
        if (Type == "payer")
        {
            value = (global::Candid.Net.Payers.V4.Payer)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.PayerGroups.V1.PayerGroup"/> and returns true if successful.
    /// </summary>
    public bool TryAsPayerGroup(out global::Candid.Net.PayerGroups.V1.PayerGroup? value)
    {
        if (Type == "payer_group")
        {
            value = (global::Candid.Net.PayerGroups.V1.PayerGroup)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator ContractPayer(ContractPayer.Payer value) => new(value);

    public static implicit operator ContractPayer(ContractPayer.PayerGroup value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<ContractPayer>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(ContractPayer).IsAssignableFrom(typeToConvert);

        public override ContractPayer Read(
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

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("type");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "payer" =>
                    jsonWithoutDiscriminator.Deserialize<global::Candid.Net.Payers.V4.Payer?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.Payers.V4.Payer"
                        ),
                "payer_group" =>
                    jsonWithoutDiscriminator.Deserialize<global::Candid.Net.PayerGroups.V1.PayerGroup?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.PayerGroups.V1.PayerGroup"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new ContractPayer(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContractPayer value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "payer" => JsonSerializer.SerializeToNode(value.Value, options),
                    "payer_group" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }

        public override ContractPayer ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new ContractPayer(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContractPayer value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Type);
        }
    }

    /// <summary>
    /// Discriminated union type for payer
    /// </summary>
    [Serializable]
    public struct Payer
    {
        public Payer(global::Candid.Net.Payers.V4.Payer value)
        {
            Value = value;
        }

        internal global::Candid.Net.Payers.V4.Payer Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ContractPayer.Payer(
            global::Candid.Net.Payers.V4.Payer value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for payer_group
    /// </summary>
    [Serializable]
    public struct PayerGroup
    {
        public PayerGroup(global::Candid.Net.PayerGroups.V1.PayerGroup value)
        {
            Value = value;
        }

        internal global::Candid.Net.PayerGroups.V1.PayerGroup Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ContractPayer.PayerGroup(
            global::Candid.Net.PayerGroups.V1.PayerGroup value
        ) => new(value);
    }
}
