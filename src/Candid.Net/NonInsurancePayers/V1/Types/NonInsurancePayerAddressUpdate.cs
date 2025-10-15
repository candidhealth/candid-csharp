// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.NonInsurancePayers.V1;

[JsonConverter(typeof(NonInsurancePayerAddressUpdate.JsonConverter))]
[Serializable]
public record NonInsurancePayerAddressUpdate
{
    internal NonInsurancePayerAddressUpdate(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of NonInsurancePayerAddressUpdate with <see cref="NonInsurancePayerAddressUpdate.Remove"/>.
    /// </summary>
    public NonInsurancePayerAddressUpdate(NonInsurancePayerAddressUpdate.Remove value)
    {
        Type = "remove";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of NonInsurancePayerAddressUpdate with <see cref="NonInsurancePayerAddressUpdate.Set"/>.
    /// </summary>
    public NonInsurancePayerAddressUpdate(NonInsurancePayerAddressUpdate.Set value)
    {
        Type = "set";
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
    /// Returns true if <see cref="Type"/> is "remove"
    /// </summary>
    public bool IsRemove => Type == "remove";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "set"
    /// </summary>
    public bool IsSet => Type == "set";

    /// <summary>
    /// Returns the value as a <see cref="object"/> if <see cref="Type"/> is 'remove', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'remove'.</exception>
    public object AsRemove() =>
        IsRemove
            ? Value!
            : throw new global::System.Exception(
                "NonInsurancePayerAddressUpdate.Type is not 'remove'"
            );

    /// <summary>
    /// Returns the value as a <see cref="StreetAddressShortZip?"/> if <see cref="Type"/> is 'set', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'set'.</exception>
    public StreetAddressShortZip? AsSet() =>
        IsSet
            ? (StreetAddressShortZip?)Value!
            : throw new global::System.Exception(
                "NonInsurancePayerAddressUpdate.Type is not 'set'"
            );

    public T Match<T>(
        Func<object, T> onRemove,
        Func<StreetAddressShortZip?, T> onSet,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "remove" => onRemove(AsRemove()),
            "set" => onSet(AsSet()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<object> onRemove,
        Action<StreetAddressShortZip?> onSet,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "remove":
                onRemove(AsRemove());
                break;
            case "set":
                onSet(AsSet());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="object"/> and returns true if successful.
    /// </summary>
    public bool TryAsRemove(out object? value)
    {
        if (Type == "remove")
        {
            value = Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="StreetAddressShortZip?"/> and returns true if successful.
    /// </summary>
    public bool TryAsSet(out StreetAddressShortZip? value)
    {
        if (Type == "set")
        {
            value = (StreetAddressShortZip?)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator NonInsurancePayerAddressUpdate(
        NonInsurancePayerAddressUpdate.Set value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<NonInsurancePayerAddressUpdate>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(NonInsurancePayerAddressUpdate).IsAssignableFrom(typeToConvert);

        public override NonInsurancePayerAddressUpdate Read(
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
                "remove" => new { },
                "set" => json.GetProperty("value").Deserialize<StreetAddressShortZip?>(options),
                _ => json.Deserialize<object?>(options),
            };
            return new NonInsurancePayerAddressUpdate(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            NonInsurancePayerAddressUpdate value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "remove" => null,
                    "set" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for remove
    /// </summary>
    [Serializable]
    public record Remove
    {
        internal object Value => new { };

        public override string ToString() => Value.ToString() ?? "null";
    }

    /// <summary>
    /// Discriminated union type for set
    /// </summary>
    [Serializable]
    public record Set
    {
        public Set(StreetAddressShortZip? value)
        {
            Value = value;
        }

        internal StreetAddressShortZip? Value { get; set; }

        public override string ToString() => Value?.ToString() ?? "null";

        public static implicit operator NonInsurancePayerAddressUpdate.Set(
            StreetAddressShortZip? value
        ) => new(value);
    }
}
