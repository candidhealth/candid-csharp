// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Contracts.V2;

[JsonConverter(typeof(AuthorizedSignatoryUpdate.JsonConverter))]
[Serializable]
public record AuthorizedSignatoryUpdate
{
    internal AuthorizedSignatoryUpdate(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of AuthorizedSignatoryUpdate with <see cref="AuthorizedSignatoryUpdate.Set"/>.
    /// </summary>
    public AuthorizedSignatoryUpdate(AuthorizedSignatoryUpdate.Set value)
    {
        Type = "set";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AuthorizedSignatoryUpdate with <see cref="AuthorizedSignatoryUpdate.Remove"/>.
    /// </summary>
    public AuthorizedSignatoryUpdate(AuthorizedSignatoryUpdate.Remove value)
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
    /// Returns the value as a <see cref="Candid.Net.Contracts.V2.AuthorizedSignatory"/> if <see cref="Type"/> is 'set', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'set'.</exception>
    public Candid.Net.Contracts.V2.AuthorizedSignatory AsSet() =>
        IsSet
            ? (Candid.Net.Contracts.V2.AuthorizedSignatory)Value!
            : throw new Exception("AuthorizedSignatoryUpdate.Type is not 'set'");

    /// <summary>
    /// Returns the value as a <see cref="object"/> if <see cref="Type"/> is 'remove', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'remove'.</exception>
    public object AsRemove() =>
        IsRemove ? Value! : throw new Exception("AuthorizedSignatoryUpdate.Type is not 'remove'");

    public T Match<T>(
        Func<Candid.Net.Contracts.V2.AuthorizedSignatory, T> onSet,
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
        Action<Candid.Net.Contracts.V2.AuthorizedSignatory> onSet,
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
    /// Attempts to cast the value to a <see cref="Candid.Net.Contracts.V2.AuthorizedSignatory"/> and returns true if successful.
    /// </summary>
    public bool TryAsSet(out Candid.Net.Contracts.V2.AuthorizedSignatory? value)
    {
        if (Type == "set")
        {
            value = (Candid.Net.Contracts.V2.AuthorizedSignatory)Value!;
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

    public static implicit operator AuthorizedSignatoryUpdate(
        AuthorizedSignatoryUpdate.Set value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<AuthorizedSignatoryUpdate>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(AuthorizedSignatoryUpdate).IsAssignableFrom(typeToConvert);

        public override AuthorizedSignatoryUpdate Read(
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
                "set" => json.Deserialize<Candid.Net.Contracts.V2.AuthorizedSignatory>(options)
                    ?? throw new JsonException(
                        "Failed to deserialize Candid.Net.Contracts.V2.AuthorizedSignatory"
                    ),
                "remove" => new { },
                _ => json.Deserialize<object?>(options),
            };
            return new AuthorizedSignatoryUpdate(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AuthorizedSignatoryUpdate value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "set" => JsonSerializer.SerializeToNode(value.Value, options),
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
        public Set(Candid.Net.Contracts.V2.AuthorizedSignatory value)
        {
            Value = value;
        }

        internal Candid.Net.Contracts.V2.AuthorizedSignatory Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator AuthorizedSignatoryUpdate.Set(
            Candid.Net.Contracts.V2.AuthorizedSignatory value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for remove
    /// </summary>
    [Serializable]
    public record Remove
    {
        internal object Value => new { };

        public override string ToString() => Value.ToString();
    }
}
