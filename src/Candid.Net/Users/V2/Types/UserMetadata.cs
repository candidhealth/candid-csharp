// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Users.V2;

[JsonConverter(typeof(UserMetadata.JsonConverter))]
[Serializable]
public record UserMetadata
{
    internal UserMetadata(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of UserMetadata with <see cref="UserMetadata.MachineUserMetadata"/>.
    /// </summary>
    public UserMetadata(UserMetadata.MachineUserMetadata value)
    {
        Type = "machine_user_metadata";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of UserMetadata with <see cref="UserMetadata.HumanUserMetadata"/>.
    /// </summary>
    public UserMetadata(UserMetadata.HumanUserMetadata value)
    {
        Type = "human_user_metadata";
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
    /// Returns true if <see cref="Type"/> is "machine_user_metadata"
    /// </summary>
    public bool IsMachineUserMetadata => Type == "machine_user_metadata";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "human_user_metadata"
    /// </summary>
    public bool IsHumanUserMetadata => Type == "human_user_metadata";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Users.V2.MachineUserMetadata"/> if <see cref="Type"/> is 'machine_user_metadata', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'machine_user_metadata'.</exception>
    public global::Candid.Net.Users.V2.MachineUserMetadata AsMachineUserMetadata() =>
        IsMachineUserMetadata
            ? (global::Candid.Net.Users.V2.MachineUserMetadata)Value!
            : throw new global::System.Exception(
                "UserMetadata.Type is not 'machine_user_metadata'"
            );

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Users.V2.HumanUserMetadata"/> if <see cref="Type"/> is 'human_user_metadata', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'human_user_metadata'.</exception>
    public global::Candid.Net.Users.V2.HumanUserMetadata AsHumanUserMetadata() =>
        IsHumanUserMetadata
            ? (global::Candid.Net.Users.V2.HumanUserMetadata)Value!
            : throw new global::System.Exception("UserMetadata.Type is not 'human_user_metadata'");

    public T Match<T>(
        Func<global::Candid.Net.Users.V2.MachineUserMetadata, T> onMachineUserMetadata,
        Func<global::Candid.Net.Users.V2.HumanUserMetadata, T> onHumanUserMetadata,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "machine_user_metadata" => onMachineUserMetadata(AsMachineUserMetadata()),
            "human_user_metadata" => onHumanUserMetadata(AsHumanUserMetadata()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.Users.V2.MachineUserMetadata> onMachineUserMetadata,
        Action<global::Candid.Net.Users.V2.HumanUserMetadata> onHumanUserMetadata,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "machine_user_metadata":
                onMachineUserMetadata(AsMachineUserMetadata());
                break;
            case "human_user_metadata":
                onHumanUserMetadata(AsHumanUserMetadata());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Users.V2.MachineUserMetadata"/> and returns true if successful.
    /// </summary>
    public bool TryAsMachineUserMetadata(out global::Candid.Net.Users.V2.MachineUserMetadata? value)
    {
        if (Type == "machine_user_metadata")
        {
            value = (global::Candid.Net.Users.V2.MachineUserMetadata)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Users.V2.HumanUserMetadata"/> and returns true if successful.
    /// </summary>
    public bool TryAsHumanUserMetadata(out global::Candid.Net.Users.V2.HumanUserMetadata? value)
    {
        if (Type == "human_user_metadata")
        {
            value = (global::Candid.Net.Users.V2.HumanUserMetadata)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator UserMetadata(UserMetadata.MachineUserMetadata value) =>
        new(value);

    public static implicit operator UserMetadata(UserMetadata.HumanUserMetadata value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<UserMetadata>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(UserMetadata).IsAssignableFrom(typeToConvert);

        public override UserMetadata Read(
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
                "machine_user_metadata" =>
                    json.Deserialize<global::Candid.Net.Users.V2.MachineUserMetadata?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.Users.V2.MachineUserMetadata"
                        ),
                "human_user_metadata" =>
                    json.Deserialize<global::Candid.Net.Users.V2.HumanUserMetadata?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.Users.V2.HumanUserMetadata"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new UserMetadata(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UserMetadata value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "machine_user_metadata" => JsonSerializer.SerializeToNode(value.Value, options),
                    "human_user_metadata" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for machine_user_metadata
    /// </summary>
    [Serializable]
    public struct MachineUserMetadata
    {
        public MachineUserMetadata(global::Candid.Net.Users.V2.MachineUserMetadata value)
        {
            Value = value;
        }

        internal global::Candid.Net.Users.V2.MachineUserMetadata Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator UserMetadata.MachineUserMetadata(
            global::Candid.Net.Users.V2.MachineUserMetadata value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for human_user_metadata
    /// </summary>
    [Serializable]
    public struct HumanUserMetadata
    {
        public HumanUserMetadata(global::Candid.Net.Users.V2.HumanUserMetadata value)
        {
            Value = value;
        }

        internal global::Candid.Net.Users.V2.HumanUserMetadata Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator UserMetadata.HumanUserMetadata(
            global::Candid.Net.Users.V2.HumanUserMetadata value
        ) => new(value);
    }
}
