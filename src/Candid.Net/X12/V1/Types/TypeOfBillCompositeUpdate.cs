// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.X12.V1;

/// <summary>
/// A type of bill can either be seen as a compositio of structured parts, or as a literal string.
/// This union represents the potential to express a type of bill either as one of those two shapes.
/// Passing a string, this update will be seen as a complete 4 digit code, along with a padding code 0, that
/// should match a valid composition.
/// Passing as a structure, the update will be seen as three parts and will be joined together by the server
/// to represent a valid composition for you.
/// Which you use depends upon whether you are "passing through" coded information or making a decision about its
/// structure explicitly.
/// </summary>
[JsonConverter(typeof(TypeOfBillCompositeUpdate.JsonConverter))]
[Serializable]
public record TypeOfBillCompositeUpdate
{
    internal TypeOfBillCompositeUpdate(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of TypeOfBillCompositeUpdate with <see cref="TypeOfBillCompositeUpdate.RawCode"/>.
    /// </summary>
    public TypeOfBillCompositeUpdate(TypeOfBillCompositeUpdate.RawCode value)
    {
        Type = "raw_code";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of TypeOfBillCompositeUpdate with <see cref="TypeOfBillCompositeUpdate.CompositeCodes"/>.
    /// </summary>
    public TypeOfBillCompositeUpdate(TypeOfBillCompositeUpdate.CompositeCodes value)
    {
        Type = "composite_codes";
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
    /// Returns true if <see cref="Type"/> is "raw_code"
    /// </summary>
    public bool IsRawCode => Type == "raw_code";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "composite_codes"
    /// </summary>
    public bool IsCompositeCodes => Type == "composite_codes";

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'raw_code', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'raw_code'.</exception>
    public string AsRawCode() =>
        IsRawCode
            ? (string)Value!
            : throw new global::System.Exception(
                "TypeOfBillCompositeUpdate.Type is not 'raw_code'"
            );

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.X12.V1.TypeOfBillCompositeBase"/> if <see cref="Type"/> is 'composite_codes', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'composite_codes'.</exception>
    public global::Candid.Net.X12.V1.TypeOfBillCompositeBase AsCompositeCodes() =>
        IsCompositeCodes
            ? (global::Candid.Net.X12.V1.TypeOfBillCompositeBase)Value!
            : throw new global::System.Exception(
                "TypeOfBillCompositeUpdate.Type is not 'composite_codes'"
            );

    public T Match<T>(
        Func<string, T> onRawCode,
        Func<global::Candid.Net.X12.V1.TypeOfBillCompositeBase, T> onCompositeCodes,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "raw_code" => onRawCode(AsRawCode()),
            "composite_codes" => onCompositeCodes(AsCompositeCodes()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<string> onRawCode,
        Action<global::Candid.Net.X12.V1.TypeOfBillCompositeBase> onCompositeCodes,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "raw_code":
                onRawCode(AsRawCode());
                break;
            case "composite_codes":
                onCompositeCodes(AsCompositeCodes());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="string"/> and returns true if successful.
    /// </summary>
    public bool TryAsRawCode(out string? value)
    {
        if (Type == "raw_code")
        {
            value = (string)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.X12.V1.TypeOfBillCompositeBase"/> and returns true if successful.
    /// </summary>
    public bool TryAsCompositeCodes(out global::Candid.Net.X12.V1.TypeOfBillCompositeBase? value)
    {
        if (Type == "composite_codes")
        {
            value = (global::Candid.Net.X12.V1.TypeOfBillCompositeBase)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator TypeOfBillCompositeUpdate(
        TypeOfBillCompositeUpdate.RawCode value
    ) => new(value);

    public static implicit operator TypeOfBillCompositeUpdate(
        TypeOfBillCompositeUpdate.CompositeCodes value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<TypeOfBillCompositeUpdate>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(TypeOfBillCompositeUpdate).IsAssignableFrom(typeToConvert);

        public override TypeOfBillCompositeUpdate Read(
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
                "raw_code" => json.GetProperty("value").Deserialize<string?>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                "composite_codes" =>
                    json.Deserialize<global::Candid.Net.X12.V1.TypeOfBillCompositeBase?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.X12.V1.TypeOfBillCompositeBase"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new TypeOfBillCompositeUpdate(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TypeOfBillCompositeUpdate value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "raw_code" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    "composite_codes" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for raw_code
    /// </summary>
    [Serializable]
    public record RawCode
    {
        public RawCode(string value)
        {
            Value = value;
        }

        internal string Value { get; set; }

        public override string ToString() => Value;

        public static implicit operator TypeOfBillCompositeUpdate.RawCode(string value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for composite_codes
    /// </summary>
    [Serializable]
    public struct CompositeCodes
    {
        public CompositeCodes(global::Candid.Net.X12.V1.TypeOfBillCompositeBase value)
        {
            Value = value;
        }

        internal global::Candid.Net.X12.V1.TypeOfBillCompositeBase Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator TypeOfBillCompositeUpdate.CompositeCodes(
            global::Candid.Net.X12.V1.TypeOfBillCompositeBase value
        ) => new(value);
    }
}
