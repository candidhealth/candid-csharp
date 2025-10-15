// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.CustomSchemas.V1;

[JsonConverter(typeof(SchemaValidationError.JsonConverter))]
[Serializable]
public record SchemaValidationError
{
    internal SchemaValidationError(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of SchemaValidationError with <see cref="SchemaValidationError.SchemaNameAlreadyExists"/>.
    /// </summary>
    public SchemaValidationError(SchemaValidationError.SchemaNameAlreadyExists value)
    {
        Type = "schema_name_already_exists";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SchemaValidationError with <see cref="SchemaValidationError.KeyNameAlreadyExists"/>.
    /// </summary>
    public SchemaValidationError(SchemaValidationError.KeyNameAlreadyExists value)
    {
        Type = "key_name_already_exists";
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
    /// Returns true if <see cref="Type"/> is "schema_name_already_exists"
    /// </summary>
    public bool IsSchemaNameAlreadyExists => Type == "schema_name_already_exists";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "key_name_already_exists"
    /// </summary>
    public bool IsKeyNameAlreadyExists => Type == "key_name_already_exists";

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.CustomSchemas.V1.SchemaWithNameAlreadyExistsError"/> if <see cref="Type"/> is 'schema_name_already_exists', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'schema_name_already_exists'.</exception>
    public Candid.Net.CustomSchemas.V1.SchemaWithNameAlreadyExistsError AsSchemaNameAlreadyExists() =>
        IsSchemaNameAlreadyExists
            ? (Candid.Net.CustomSchemas.V1.SchemaWithNameAlreadyExistsError)Value!
            : throw new Exception("SchemaValidationError.Type is not 'schema_name_already_exists'");

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.CustomSchemas.V1.KeyWithNameAlreadyExistsError"/> if <see cref="Type"/> is 'key_name_already_exists', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'key_name_already_exists'.</exception>
    public Candid.Net.CustomSchemas.V1.KeyWithNameAlreadyExistsError AsKeyNameAlreadyExists() =>
        IsKeyNameAlreadyExists
            ? (Candid.Net.CustomSchemas.V1.KeyWithNameAlreadyExistsError)Value!
            : throw new Exception("SchemaValidationError.Type is not 'key_name_already_exists'");

    public T Match<T>(
        Func<
            Candid.Net.CustomSchemas.V1.SchemaWithNameAlreadyExistsError,
            T
        > onSchemaNameAlreadyExists,
        Func<Candid.Net.CustomSchemas.V1.KeyWithNameAlreadyExistsError, T> onKeyNameAlreadyExists,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "schema_name_already_exists" => onSchemaNameAlreadyExists(AsSchemaNameAlreadyExists()),
            "key_name_already_exists" => onKeyNameAlreadyExists(AsKeyNameAlreadyExists()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<Candid.Net.CustomSchemas.V1.SchemaWithNameAlreadyExistsError> onSchemaNameAlreadyExists,
        Action<Candid.Net.CustomSchemas.V1.KeyWithNameAlreadyExistsError> onKeyNameAlreadyExists,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "schema_name_already_exists":
                onSchemaNameAlreadyExists(AsSchemaNameAlreadyExists());
                break;
            case "key_name_already_exists":
                onKeyNameAlreadyExists(AsKeyNameAlreadyExists());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.CustomSchemas.V1.SchemaWithNameAlreadyExistsError"/> and returns true if successful.
    /// </summary>
    public bool TryAsSchemaNameAlreadyExists(
        out Candid.Net.CustomSchemas.V1.SchemaWithNameAlreadyExistsError? value
    )
    {
        if (Type == "schema_name_already_exists")
        {
            value = (Candid.Net.CustomSchemas.V1.SchemaWithNameAlreadyExistsError)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.CustomSchemas.V1.KeyWithNameAlreadyExistsError"/> and returns true if successful.
    /// </summary>
    public bool TryAsKeyNameAlreadyExists(
        out Candid.Net.CustomSchemas.V1.KeyWithNameAlreadyExistsError? value
    )
    {
        if (Type == "key_name_already_exists")
        {
            value = (Candid.Net.CustomSchemas.V1.KeyWithNameAlreadyExistsError)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator SchemaValidationError(
        SchemaValidationError.SchemaNameAlreadyExists value
    ) => new(value);

    public static implicit operator SchemaValidationError(
        SchemaValidationError.KeyNameAlreadyExists value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<SchemaValidationError>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(SchemaValidationError).IsAssignableFrom(typeToConvert);

        public override SchemaValidationError Read(
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
                "schema_name_already_exists" =>
                    json.Deserialize<Candid.Net.CustomSchemas.V1.SchemaWithNameAlreadyExistsError>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.CustomSchemas.V1.SchemaWithNameAlreadyExistsError"
                        ),
                "key_name_already_exists" =>
                    json.Deserialize<Candid.Net.CustomSchemas.V1.KeyWithNameAlreadyExistsError>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.CustomSchemas.V1.KeyWithNameAlreadyExistsError"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new SchemaValidationError(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SchemaValidationError value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "schema_name_already_exists" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "key_name_already_exists" => JsonSerializer.SerializeToNode(
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
    /// Discriminated union type for schema_name_already_exists
    /// </summary>
    [Serializable]
    public struct SchemaNameAlreadyExists
    {
        public SchemaNameAlreadyExists(
            Candid.Net.CustomSchemas.V1.SchemaWithNameAlreadyExistsError value
        )
        {
            Value = value;
        }

        internal Candid.Net.CustomSchemas.V1.SchemaWithNameAlreadyExistsError Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator SchemaValidationError.SchemaNameAlreadyExists(
            Candid.Net.CustomSchemas.V1.SchemaWithNameAlreadyExistsError value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for key_name_already_exists
    /// </summary>
    [Serializable]
    public struct KeyNameAlreadyExists
    {
        public KeyNameAlreadyExists(Candid.Net.CustomSchemas.V1.KeyWithNameAlreadyExistsError value)
        {
            Value = value;
        }

        internal Candid.Net.CustomSchemas.V1.KeyWithNameAlreadyExistsError Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator SchemaValidationError.KeyNameAlreadyExists(
            Candid.Net.CustomSchemas.V1.KeyWithNameAlreadyExistsError value
        ) => new(value);
    }
}
