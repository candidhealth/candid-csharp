// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Users.V2;

[JsonConverter(typeof(IdpUserMetadata.JsonConverter))]
[Serializable]
public record IdpUserMetadata
{
    internal IdpUserMetadata(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of IdpUserMetadata with <see cref="IdpUserMetadata.AuthZeroMetadata"/>.
    /// </summary>
    public IdpUserMetadata(IdpUserMetadata.AuthZeroMetadata value)
    {
        Type = "auth_zero_metadata";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of IdpUserMetadata with <see cref="IdpUserMetadata.GoogleAppsMetadata"/>.
    /// </summary>
    public IdpUserMetadata(IdpUserMetadata.GoogleAppsMetadata value)
    {
        Type = "google_apps_metadata";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of IdpUserMetadata with <see cref="IdpUserMetadata.OtherIdpMetadata"/>.
    /// </summary>
    public IdpUserMetadata(IdpUserMetadata.OtherIdpMetadata value)
    {
        Type = "other_idp_metadata";
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
    /// Returns true if <see cref="Type"/> is "auth_zero_metadata"
    /// </summary>
    public bool IsAuthZeroMetadata => Type == "auth_zero_metadata";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "google_apps_metadata"
    /// </summary>
    public bool IsGoogleAppsMetadata => Type == "google_apps_metadata";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "other_idp_metadata"
    /// </summary>
    public bool IsOtherIdpMetadata => Type == "other_idp_metadata";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Users.V2.AuthZeroMetadata"/> if <see cref="Type"/> is 'auth_zero_metadata', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'auth_zero_metadata'.</exception>
    public global::Candid.Net.Users.V2.AuthZeroMetadata AsAuthZeroMetadata() =>
        IsAuthZeroMetadata
            ? (global::Candid.Net.Users.V2.AuthZeroMetadata)Value!
            : throw new global::System.Exception(
                "IdpUserMetadata.Type is not 'auth_zero_metadata'"
            );

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Users.V2.GoogleAppsMetadata"/> if <see cref="Type"/> is 'google_apps_metadata', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'google_apps_metadata'.</exception>
    public global::Candid.Net.Users.V2.GoogleAppsMetadata AsGoogleAppsMetadata() =>
        IsGoogleAppsMetadata
            ? (global::Candid.Net.Users.V2.GoogleAppsMetadata)Value!
            : throw new global::System.Exception(
                "IdpUserMetadata.Type is not 'google_apps_metadata'"
            );

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.Users.V2.OtherIdpMetadata"/> if <see cref="Type"/> is 'other_idp_metadata', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'other_idp_metadata'.</exception>
    public global::Candid.Net.Users.V2.OtherIdpMetadata AsOtherIdpMetadata() =>
        IsOtherIdpMetadata
            ? (global::Candid.Net.Users.V2.OtherIdpMetadata)Value!
            : throw new global::System.Exception(
                "IdpUserMetadata.Type is not 'other_idp_metadata'"
            );

    public T Match<T>(
        Func<global::Candid.Net.Users.V2.AuthZeroMetadata, T> onAuthZeroMetadata,
        Func<global::Candid.Net.Users.V2.GoogleAppsMetadata, T> onGoogleAppsMetadata,
        Func<global::Candid.Net.Users.V2.OtherIdpMetadata, T> onOtherIdpMetadata,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "auth_zero_metadata" => onAuthZeroMetadata(AsAuthZeroMetadata()),
            "google_apps_metadata" => onGoogleAppsMetadata(AsGoogleAppsMetadata()),
            "other_idp_metadata" => onOtherIdpMetadata(AsOtherIdpMetadata()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.Users.V2.AuthZeroMetadata> onAuthZeroMetadata,
        Action<global::Candid.Net.Users.V2.GoogleAppsMetadata> onGoogleAppsMetadata,
        Action<global::Candid.Net.Users.V2.OtherIdpMetadata> onOtherIdpMetadata,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "auth_zero_metadata":
                onAuthZeroMetadata(AsAuthZeroMetadata());
                break;
            case "google_apps_metadata":
                onGoogleAppsMetadata(AsGoogleAppsMetadata());
                break;
            case "other_idp_metadata":
                onOtherIdpMetadata(AsOtherIdpMetadata());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Users.V2.AuthZeroMetadata"/> and returns true if successful.
    /// </summary>
    public bool TryAsAuthZeroMetadata(out global::Candid.Net.Users.V2.AuthZeroMetadata? value)
    {
        if (Type == "auth_zero_metadata")
        {
            value = (global::Candid.Net.Users.V2.AuthZeroMetadata)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Users.V2.GoogleAppsMetadata"/> and returns true if successful.
    /// </summary>
    public bool TryAsGoogleAppsMetadata(out global::Candid.Net.Users.V2.GoogleAppsMetadata? value)
    {
        if (Type == "google_apps_metadata")
        {
            value = (global::Candid.Net.Users.V2.GoogleAppsMetadata)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.Users.V2.OtherIdpMetadata"/> and returns true if successful.
    /// </summary>
    public bool TryAsOtherIdpMetadata(out global::Candid.Net.Users.V2.OtherIdpMetadata? value)
    {
        if (Type == "other_idp_metadata")
        {
            value = (global::Candid.Net.Users.V2.OtherIdpMetadata)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator IdpUserMetadata(IdpUserMetadata.AuthZeroMetadata value) =>
        new(value);

    public static implicit operator IdpUserMetadata(IdpUserMetadata.GoogleAppsMetadata value) =>
        new(value);

    public static implicit operator IdpUserMetadata(IdpUserMetadata.OtherIdpMetadata value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<IdpUserMetadata>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(IdpUserMetadata).IsAssignableFrom(typeToConvert);

        public override IdpUserMetadata Read(
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
                "auth_zero_metadata" =>
                    json.Deserialize<global::Candid.Net.Users.V2.AuthZeroMetadata?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.Users.V2.AuthZeroMetadata"
                        ),
                "google_apps_metadata" =>
                    json.Deserialize<global::Candid.Net.Users.V2.GoogleAppsMetadata?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.Users.V2.GoogleAppsMetadata"
                        ),
                "other_idp_metadata" =>
                    json.Deserialize<global::Candid.Net.Users.V2.OtherIdpMetadata?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.Users.V2.OtherIdpMetadata"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new IdpUserMetadata(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            IdpUserMetadata value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "auth_zero_metadata" => JsonSerializer.SerializeToNode(value.Value, options),
                    "google_apps_metadata" => JsonSerializer.SerializeToNode(value.Value, options),
                    "other_idp_metadata" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for auth_zero_metadata
    /// </summary>
    [Serializable]
    public struct AuthZeroMetadata
    {
        public AuthZeroMetadata(global::Candid.Net.Users.V2.AuthZeroMetadata value)
        {
            Value = value;
        }

        internal global::Candid.Net.Users.V2.AuthZeroMetadata Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator IdpUserMetadata.AuthZeroMetadata(
            global::Candid.Net.Users.V2.AuthZeroMetadata value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for google_apps_metadata
    /// </summary>
    [Serializable]
    public struct GoogleAppsMetadata
    {
        public GoogleAppsMetadata(global::Candid.Net.Users.V2.GoogleAppsMetadata value)
        {
            Value = value;
        }

        internal global::Candid.Net.Users.V2.GoogleAppsMetadata Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator IdpUserMetadata.GoogleAppsMetadata(
            global::Candid.Net.Users.V2.GoogleAppsMetadata value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for other_idp_metadata
    /// </summary>
    [Serializable]
    public struct OtherIdpMetadata
    {
        public OtherIdpMetadata(global::Candid.Net.Users.V2.OtherIdpMetadata value)
        {
            Value = value;
        }

        internal global::Candid.Net.Users.V2.OtherIdpMetadata Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator IdpUserMetadata.OtherIdpMetadata(
            global::Candid.Net.Users.V2.OtherIdpMetadata value
        ) => new(value);
    }
}
