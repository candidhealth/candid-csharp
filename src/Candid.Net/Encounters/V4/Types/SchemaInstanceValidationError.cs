// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(SchemaInstanceValidationError.JsonConverter))]
[Serializable]
public record SchemaInstanceValidationError
{
    internal SchemaInstanceValidationError(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of SchemaInstanceValidationError with <see cref="SchemaInstanceValidationError.MultipleInstancesForSchema"/>.
    /// </summary>
    public SchemaInstanceValidationError(
        SchemaInstanceValidationError.MultipleInstancesForSchema value
    )
    {
        Type = "multiple_instances_for_schema";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SchemaInstanceValidationError with <see cref="SchemaInstanceValidationError.ValueDoesNotMatchKeyType"/>.
    /// </summary>
    public SchemaInstanceValidationError(
        SchemaInstanceValidationError.ValueDoesNotMatchKeyType value
    )
    {
        Type = "value_does_not_match_key_type";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SchemaInstanceValidationError with <see cref="SchemaInstanceValidationError.KeyDoesNotExist"/>.
    /// </summary>
    public SchemaInstanceValidationError(SchemaInstanceValidationError.KeyDoesNotExist value)
    {
        Type = "key_does_not_exist";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SchemaInstanceValidationError with <see cref="SchemaInstanceValidationError.SchemaDoesNotExist"/>.
    /// </summary>
    public SchemaInstanceValidationError(SchemaInstanceValidationError.SchemaDoesNotExist value)
    {
        Type = "schema_does_not_exist";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of SchemaInstanceValidationError with <see cref="SchemaInstanceValidationError.SchemaUnauthorizedAccess"/>.
    /// </summary>
    public SchemaInstanceValidationError(
        SchemaInstanceValidationError.SchemaUnauthorizedAccess value
    )
    {
        Type = "schema_unauthorized_access";
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
    /// Returns true if <see cref="Type"/> is "multiple_instances_for_schema"
    /// </summary>
    public bool IsMultipleInstancesForSchema => Type == "multiple_instances_for_schema";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "value_does_not_match_key_type"
    /// </summary>
    public bool IsValueDoesNotMatchKeyType => Type == "value_does_not_match_key_type";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "key_does_not_exist"
    /// </summary>
    public bool IsKeyDoesNotExist => Type == "key_does_not_exist";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "schema_does_not_exist"
    /// </summary>
    public bool IsSchemaDoesNotExist => Type == "schema_does_not_exist";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "schema_unauthorized_access"
    /// </summary>
    public bool IsSchemaUnauthorizedAccess => Type == "schema_unauthorized_access";

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.Encounters.V4.MultipleInstancesForSchemaError"/> if <see cref="Type"/> is 'multiple_instances_for_schema', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'multiple_instances_for_schema'.</exception>
    public Candid.Net.Encounters.V4.MultipleInstancesForSchemaError AsMultipleInstancesForSchema() =>
        IsMultipleInstancesForSchema
            ? (Candid.Net.Encounters.V4.MultipleInstancesForSchemaError)Value!
            : throw new Exception(
                "SchemaInstanceValidationError.Type is not 'multiple_instances_for_schema'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.Encounters.V4.ValueDoesNotMatchKeyTypeError"/> if <see cref="Type"/> is 'value_does_not_match_key_type', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'value_does_not_match_key_type'.</exception>
    public Candid.Net.Encounters.V4.ValueDoesNotMatchKeyTypeError AsValueDoesNotMatchKeyType() =>
        IsValueDoesNotMatchKeyType
            ? (Candid.Net.Encounters.V4.ValueDoesNotMatchKeyTypeError)Value!
            : throw new Exception(
                "SchemaInstanceValidationError.Type is not 'value_does_not_match_key_type'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.Encounters.V4.KeyDoesNotExistError"/> if <see cref="Type"/> is 'key_does_not_exist', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'key_does_not_exist'.</exception>
    public Candid.Net.Encounters.V4.KeyDoesNotExistError AsKeyDoesNotExist() =>
        IsKeyDoesNotExist
            ? (Candid.Net.Encounters.V4.KeyDoesNotExistError)Value!
            : throw new Exception("SchemaInstanceValidationError.Type is not 'key_does_not_exist'");

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.Encounters.V4.SchemaDoesNotExistError"/> if <see cref="Type"/> is 'schema_does_not_exist', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'schema_does_not_exist'.</exception>
    public Candid.Net.Encounters.V4.SchemaDoesNotExistError AsSchemaDoesNotExist() =>
        IsSchemaDoesNotExist
            ? (Candid.Net.Encounters.V4.SchemaDoesNotExistError)Value!
            : throw new Exception(
                "SchemaInstanceValidationError.Type is not 'schema_does_not_exist'"
            );

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.Encounters.V4.SchemaUnauthorizedAccessError"/> if <see cref="Type"/> is 'schema_unauthorized_access', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'schema_unauthorized_access'.</exception>
    public Candid.Net.Encounters.V4.SchemaUnauthorizedAccessError AsSchemaUnauthorizedAccess() =>
        IsSchemaUnauthorizedAccess
            ? (Candid.Net.Encounters.V4.SchemaUnauthorizedAccessError)Value!
            : throw new Exception(
                "SchemaInstanceValidationError.Type is not 'schema_unauthorized_access'"
            );

    public T Match<T>(
        Func<
            Candid.Net.Encounters.V4.MultipleInstancesForSchemaError,
            T
        > onMultipleInstancesForSchema,
        Func<Candid.Net.Encounters.V4.ValueDoesNotMatchKeyTypeError, T> onValueDoesNotMatchKeyType,
        Func<Candid.Net.Encounters.V4.KeyDoesNotExistError, T> onKeyDoesNotExist,
        Func<Candid.Net.Encounters.V4.SchemaDoesNotExistError, T> onSchemaDoesNotExist,
        Func<Candid.Net.Encounters.V4.SchemaUnauthorizedAccessError, T> onSchemaUnauthorizedAccess,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "multiple_instances_for_schema" => onMultipleInstancesForSchema(
                AsMultipleInstancesForSchema()
            ),
            "value_does_not_match_key_type" => onValueDoesNotMatchKeyType(
                AsValueDoesNotMatchKeyType()
            ),
            "key_does_not_exist" => onKeyDoesNotExist(AsKeyDoesNotExist()),
            "schema_does_not_exist" => onSchemaDoesNotExist(AsSchemaDoesNotExist()),
            "schema_unauthorized_access" => onSchemaUnauthorizedAccess(
                AsSchemaUnauthorizedAccess()
            ),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<Candid.Net.Encounters.V4.MultipleInstancesForSchemaError> onMultipleInstancesForSchema,
        Action<Candid.Net.Encounters.V4.ValueDoesNotMatchKeyTypeError> onValueDoesNotMatchKeyType,
        Action<Candid.Net.Encounters.V4.KeyDoesNotExistError> onKeyDoesNotExist,
        Action<Candid.Net.Encounters.V4.SchemaDoesNotExistError> onSchemaDoesNotExist,
        Action<Candid.Net.Encounters.V4.SchemaUnauthorizedAccessError> onSchemaUnauthorizedAccess,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "multiple_instances_for_schema":
                onMultipleInstancesForSchema(AsMultipleInstancesForSchema());
                break;
            case "value_does_not_match_key_type":
                onValueDoesNotMatchKeyType(AsValueDoesNotMatchKeyType());
                break;
            case "key_does_not_exist":
                onKeyDoesNotExist(AsKeyDoesNotExist());
                break;
            case "schema_does_not_exist":
                onSchemaDoesNotExist(AsSchemaDoesNotExist());
                break;
            case "schema_unauthorized_access":
                onSchemaUnauthorizedAccess(AsSchemaUnauthorizedAccess());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.Encounters.V4.MultipleInstancesForSchemaError"/> and returns true if successful.
    /// </summary>
    public bool TryAsMultipleInstancesForSchema(
        out Candid.Net.Encounters.V4.MultipleInstancesForSchemaError? value
    )
    {
        if (Type == "multiple_instances_for_schema")
        {
            value = (Candid.Net.Encounters.V4.MultipleInstancesForSchemaError)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.Encounters.V4.ValueDoesNotMatchKeyTypeError"/> and returns true if successful.
    /// </summary>
    public bool TryAsValueDoesNotMatchKeyType(
        out Candid.Net.Encounters.V4.ValueDoesNotMatchKeyTypeError? value
    )
    {
        if (Type == "value_does_not_match_key_type")
        {
            value = (Candid.Net.Encounters.V4.ValueDoesNotMatchKeyTypeError)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.Encounters.V4.KeyDoesNotExistError"/> and returns true if successful.
    /// </summary>
    public bool TryAsKeyDoesNotExist(out Candid.Net.Encounters.V4.KeyDoesNotExistError? value)
    {
        if (Type == "key_does_not_exist")
        {
            value = (Candid.Net.Encounters.V4.KeyDoesNotExistError)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.Encounters.V4.SchemaDoesNotExistError"/> and returns true if successful.
    /// </summary>
    public bool TryAsSchemaDoesNotExist(out Candid.Net.Encounters.V4.SchemaDoesNotExistError? value)
    {
        if (Type == "schema_does_not_exist")
        {
            value = (Candid.Net.Encounters.V4.SchemaDoesNotExistError)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.Encounters.V4.SchemaUnauthorizedAccessError"/> and returns true if successful.
    /// </summary>
    public bool TryAsSchemaUnauthorizedAccess(
        out Candid.Net.Encounters.V4.SchemaUnauthorizedAccessError? value
    )
    {
        if (Type == "schema_unauthorized_access")
        {
            value = (Candid.Net.Encounters.V4.SchemaUnauthorizedAccessError)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator SchemaInstanceValidationError(
        SchemaInstanceValidationError.MultipleInstancesForSchema value
    ) => new(value);

    public static implicit operator SchemaInstanceValidationError(
        SchemaInstanceValidationError.ValueDoesNotMatchKeyType value
    ) => new(value);

    public static implicit operator SchemaInstanceValidationError(
        SchemaInstanceValidationError.KeyDoesNotExist value
    ) => new(value);

    public static implicit operator SchemaInstanceValidationError(
        SchemaInstanceValidationError.SchemaDoesNotExist value
    ) => new(value);

    public static implicit operator SchemaInstanceValidationError(
        SchemaInstanceValidationError.SchemaUnauthorizedAccess value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<SchemaInstanceValidationError>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(SchemaInstanceValidationError).IsAssignableFrom(typeToConvert);

        public override SchemaInstanceValidationError Read(
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
                "multiple_instances_for_schema" =>
                    json.Deserialize<Candid.Net.Encounters.V4.MultipleInstancesForSchemaError>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.Encounters.V4.MultipleInstancesForSchemaError"
                        ),
                "value_does_not_match_key_type" =>
                    json.Deserialize<Candid.Net.Encounters.V4.ValueDoesNotMatchKeyTypeError>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.Encounters.V4.ValueDoesNotMatchKeyTypeError"
                        ),
                "key_does_not_exist" =>
                    json.Deserialize<Candid.Net.Encounters.V4.KeyDoesNotExistError>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.Encounters.V4.KeyDoesNotExistError"
                        ),
                "schema_does_not_exist" =>
                    json.Deserialize<Candid.Net.Encounters.V4.SchemaDoesNotExistError>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.Encounters.V4.SchemaDoesNotExistError"
                        ),
                "schema_unauthorized_access" =>
                    json.Deserialize<Candid.Net.Encounters.V4.SchemaUnauthorizedAccessError>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.Encounters.V4.SchemaUnauthorizedAccessError"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new SchemaInstanceValidationError(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SchemaInstanceValidationError value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "multiple_instances_for_schema" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "value_does_not_match_key_type" => JsonSerializer.SerializeToNode(
                        value.Value,
                        options
                    ),
                    "key_does_not_exist" => JsonSerializer.SerializeToNode(value.Value, options),
                    "schema_does_not_exist" => JsonSerializer.SerializeToNode(value.Value, options),
                    "schema_unauthorized_access" => JsonSerializer.SerializeToNode(
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
    /// Discriminated union type for multiple_instances_for_schema
    /// </summary>
    [Serializable]
    public struct MultipleInstancesForSchema
    {
        public MultipleInstancesForSchema(
            Candid.Net.Encounters.V4.MultipleInstancesForSchemaError value
        )
        {
            Value = value;
        }

        internal Candid.Net.Encounters.V4.MultipleInstancesForSchemaError Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator SchemaInstanceValidationError.MultipleInstancesForSchema(
            Candid.Net.Encounters.V4.MultipleInstancesForSchemaError value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for value_does_not_match_key_type
    /// </summary>
    [Serializable]
    public struct ValueDoesNotMatchKeyType
    {
        public ValueDoesNotMatchKeyType(
            Candid.Net.Encounters.V4.ValueDoesNotMatchKeyTypeError value
        )
        {
            Value = value;
        }

        internal Candid.Net.Encounters.V4.ValueDoesNotMatchKeyTypeError Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator SchemaInstanceValidationError.ValueDoesNotMatchKeyType(
            Candid.Net.Encounters.V4.ValueDoesNotMatchKeyTypeError value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for key_does_not_exist
    /// </summary>
    [Serializable]
    public struct KeyDoesNotExist
    {
        public KeyDoesNotExist(Candid.Net.Encounters.V4.KeyDoesNotExistError value)
        {
            Value = value;
        }

        internal Candid.Net.Encounters.V4.KeyDoesNotExistError Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator SchemaInstanceValidationError.KeyDoesNotExist(
            Candid.Net.Encounters.V4.KeyDoesNotExistError value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for schema_does_not_exist
    /// </summary>
    [Serializable]
    public struct SchemaDoesNotExist
    {
        public SchemaDoesNotExist(Candid.Net.Encounters.V4.SchemaDoesNotExistError value)
        {
            Value = value;
        }

        internal Candid.Net.Encounters.V4.SchemaDoesNotExistError Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator SchemaInstanceValidationError.SchemaDoesNotExist(
            Candid.Net.Encounters.V4.SchemaDoesNotExistError value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for schema_unauthorized_access
    /// </summary>
    [Serializable]
    public struct SchemaUnauthorizedAccess
    {
        public SchemaUnauthorizedAccess(
            Candid.Net.Encounters.V4.SchemaUnauthorizedAccessError value
        )
        {
            Value = value;
        }

        internal Candid.Net.Encounters.V4.SchemaUnauthorizedAccessError Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator SchemaInstanceValidationError.SchemaUnauthorizedAccess(
            Candid.Net.Encounters.V4.SchemaUnauthorizedAccessError value
        ) => new(value);
    }
}
