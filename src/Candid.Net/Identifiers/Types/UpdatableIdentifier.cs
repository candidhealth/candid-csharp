// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Identifiers;

[JsonConverter(typeof(UpdatableIdentifier.JsonConverter))]
[Serializable]
public record UpdatableIdentifier
{
    internal UpdatableIdentifier(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of UpdatableIdentifier with <see cref="UpdatableIdentifier.Add"/>.
    /// </summary>
    public UpdatableIdentifier(UpdatableIdentifier.Add value)
    {
        Type = "add";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of UpdatableIdentifier with <see cref="UpdatableIdentifier.Update"/>.
    /// </summary>
    public UpdatableIdentifier(UpdatableIdentifier.Update value)
    {
        Type = "update";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of UpdatableIdentifier with <see cref="UpdatableIdentifier.Remove"/>.
    /// </summary>
    public UpdatableIdentifier(UpdatableIdentifier.Remove value)
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
    /// Returns true if <see cref="Type"/> is "add"
    /// </summary>
    public bool IsAdd => Type == "add";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "update"
    /// </summary>
    public bool IsUpdate => Type == "update";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "remove"
    /// </summary>
    public bool IsRemove => Type == "remove";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Identifiers.IdentifierCreate"/> if <see cref="Type"/> is 'add', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'add'.</exception>
    public global::Candid.Net.Identifiers.IdentifierCreate AsAdd() =>
        IsAdd
            ? (global::Candid.Net.Identifiers.IdentifierCreate)Value!
            : throw new global::System.Exception("UpdatableIdentifier.Type is not 'add'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Identifiers.IdentifierUpdate"/> if <see cref="Type"/> is 'update', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'update'.</exception>
    public global::Candid.Net.Identifiers.IdentifierUpdate AsUpdate() =>
        IsUpdate
            ? (global::Candid.Net.Identifiers.IdentifierUpdate)Value!
            : throw new global::System.Exception("UpdatableIdentifier.Type is not 'update'");

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'remove', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'remove'.</exception>
    public string AsRemove() =>
        IsRemove
            ? (string)Value!
            : throw new global::System.Exception("UpdatableIdentifier.Type is not 'remove'");

    public T Match<T>(
        Func<global::Candid.Net.Identifiers.IdentifierCreate, T> onAdd,
        Func<global::Candid.Net.Identifiers.IdentifierUpdate, T> onUpdate,
        Func<string, T> onRemove,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "add" => onAdd(AsAdd()),
            "update" => onUpdate(AsUpdate()),
            "remove" => onRemove(AsRemove()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.Identifiers.IdentifierCreate> onAdd,
        Action<global::Candid.Net.Identifiers.IdentifierUpdate> onUpdate,
        Action<string> onRemove,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "add":
                onAdd(AsAdd());
                break;
            case "update":
                onUpdate(AsUpdate());
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
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Identifiers.IdentifierCreate"/> and returns true if successful.
    /// </summary>
    public bool TryAsAdd(out global::Candid.Net.Identifiers.IdentifierCreate? value)
    {
        if (Type == "add")
        {
            value = (global::Candid.Net.Identifiers.IdentifierCreate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Identifiers.IdentifierUpdate"/> and returns true if successful.
    /// </summary>
    public bool TryAsUpdate(out global::Candid.Net.Identifiers.IdentifierUpdate? value)
    {
        if (Type == "update")
        {
            value = (global::Candid.Net.Identifiers.IdentifierUpdate)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="string"/> and returns true if successful.
    /// </summary>
    public bool TryAsRemove(out string? value)
    {
        if (Type == "remove")
        {
            value = (string)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator UpdatableIdentifier(UpdatableIdentifier.Add value) =>
        new(value);

    public static implicit operator UpdatableIdentifier(UpdatableIdentifier.Update value) =>
        new(value);

    public static implicit operator UpdatableIdentifier(UpdatableIdentifier.Remove value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<UpdatableIdentifier>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(UpdatableIdentifier).IsAssignableFrom(typeToConvert);

        public override UpdatableIdentifier Read(
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
                "add" => json.Deserialize<global::Candid.Net.Identifiers.IdentifierCreate?>(options)
                    ?? throw new JsonException(
                        "Failed to deserialize global::Candid.Net.Identifiers.IdentifierCreate"
                    ),
                "update" => json.Deserialize<global::Candid.Net.Identifiers.IdentifierUpdate?>(
                    options
                )
                    ?? throw new JsonException(
                        "Failed to deserialize global::Candid.Net.Identifiers.IdentifierUpdate"
                    ),
                "remove" => json.GetProperty("value").Deserialize<string?>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                _ => json.Deserialize<object?>(options),
            };
            return new UpdatableIdentifier(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdatableIdentifier value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "add" => JsonSerializer.SerializeToNode(value.Value, options),
                    "update" => JsonSerializer.SerializeToNode(value.Value, options),
                    "remove" => new JsonObject
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
    /// Discriminated union type for add
    /// </summary>
    [Serializable]
    public struct Add
    {
        public Add(global::Candid.Net.Identifiers.IdentifierCreate value)
        {
            Value = value;
        }

        internal global::Candid.Net.Identifiers.IdentifierCreate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator UpdatableIdentifier.Add(
            global::Candid.Net.Identifiers.IdentifierCreate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for update
    /// </summary>
    [Serializable]
    public struct Update
    {
        public Update(global::Candid.Net.Identifiers.IdentifierUpdate value)
        {
            Value = value;
        }

        internal global::Candid.Net.Identifiers.IdentifierUpdate Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator UpdatableIdentifier.Update(
            global::Candid.Net.Identifiers.IdentifierUpdate value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for remove
    /// </summary>
    [Serializable]
    public record Remove
    {
        public Remove(string value)
        {
            Value = value;
        }

        internal string Value { get; set; }

        public override string ToString() => Value;

        public static implicit operator UpdatableIdentifier.Remove(string value) => new(value);
    }
}
