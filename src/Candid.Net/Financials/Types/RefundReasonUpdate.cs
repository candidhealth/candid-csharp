// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Financials;

[JsonConverter(typeof(RefundReasonUpdate.JsonConverter))]
[Serializable]
public record RefundReasonUpdate
{
    internal RefundReasonUpdate(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of RefundReasonUpdate with <see cref="RefundReasonUpdate.Set"/>.
    /// </summary>
    public RefundReasonUpdate(RefundReasonUpdate.Set value)
    {
        Type = "set";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of RefundReasonUpdate with <see cref="RefundReasonUpdate.Remove"/>.
    /// </summary>
    public RefundReasonUpdate(RefundReasonUpdate.Remove value)
    {
        Type = "remove";
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
    /// Returns true if <see cref="Type"/> is "set"
    /// </summary>
    public bool IsSet => Type == "set";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "remove"
    /// </summary>
    public bool IsRemove => Type == "remove";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Financials.RefundReason"/> if <see cref="Type"/> is 'set', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'set'.</exception>
    public global::Candid.Net.Financials.RefundReason AsSet() =>
        IsSet
            ? (global::Candid.Net.Financials.RefundReason)Value!
            : throw new global::System.Exception("RefundReasonUpdate.Type is not 'set'");

    /// <summary>
    /// Returns the value as a <see cref="object"/> if <see cref="Type"/> is 'remove', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'remove'.</exception>
    public object AsRemove() =>
        IsRemove
            ? Value!
            : throw new global::System.Exception("RefundReasonUpdate.Type is not 'remove'");

    public T Match<T>(
        Func<global::Candid.Net.Financials.RefundReason, T> onSet,
        Func<object, T> onRemove,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "set" => onSet(AsSet()),
            "remove" => onRemove(AsRemove()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.Financials.RefundReason> onSet,
        Action<object> onRemove,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "set":
                onSet(AsSet());
                break;
            case "remove":
                onRemove(AsRemove());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Financials.RefundReason"/> and returns true if successful.
    /// </summary>
    public bool TryAsSet(out global::Candid.Net.Financials.RefundReason? value)
    {
        if (Type == "set")
        {
            value = (global::Candid.Net.Financials.RefundReason)Value!;
            return true;
        }
        value = null;
        return false;
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

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator RefundReasonUpdate(RefundReasonUpdate.Set value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<RefundReasonUpdate>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(RefundReasonUpdate).IsAssignableFrom(typeToConvert);

        public override RefundReasonUpdate Read(
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
                "set" => json.GetProperty("value")
                    .Deserialize<global::Candid.Net.Financials.RefundReason?>(options)
                ?? throw new JsonException(
                        "Failed to deserialize global::Candid.Net.Financials.RefundReason"
                    ),
                "remove" => new { },
                _ => json.Deserialize<object?>(options),
            };
            return new RefundReasonUpdate(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RefundReasonUpdate value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "set" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    "remove" => null,
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for set
    /// </summary>
    [Serializable]
    public struct Set
    {
        public Set(global::Candid.Net.Financials.RefundReason value)
        {
            Value = value;
        }

        internal global::Candid.Net.Financials.RefundReason Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator RefundReasonUpdate.Set(
            global::Candid.Net.Financials.RefundReason value
        ) => new(value);
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
}
