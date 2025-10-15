// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Contracts.V2;

[JsonConverter(typeof(InsuranceTypes.JsonConverter))]
[Serializable]
public record InsuranceTypes
{
    internal InsuranceTypes(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of InsuranceTypes with <see cref="InsuranceTypes.AllApply"/>.
    /// </summary>
    public InsuranceTypes(InsuranceTypes.AllApply value)
    {
        Type = "allApply";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of InsuranceTypes with <see cref="InsuranceTypes.NoneApply"/>.
    /// </summary>
    public InsuranceTypes(InsuranceTypes.NoneApply value)
    {
        Type = "noneApply";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of InsuranceTypes with <see cref="InsuranceTypes.TheseApply"/>.
    /// </summary>
    public InsuranceTypes(InsuranceTypes.TheseApply value)
    {
        Type = "theseApply";
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
    /// Returns true if <see cref="Type"/> is "allApply"
    /// </summary>
    public bool IsAllApply => Type == "allApply";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "noneApply"
    /// </summary>
    public bool IsNoneApply => Type == "noneApply";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "theseApply"
    /// </summary>
    public bool IsTheseApply => Type == "theseApply";

    /// <summary>
    /// Returns the value as a <see cref="object"/> if <see cref="Type"/> is 'allApply', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'allApply'.</exception>
    public object AsAllApply() =>
        IsAllApply
            ? Value!
            : throw new global::System.Exception("InsuranceTypes.Type is not 'allApply'");

    /// <summary>
    /// Returns the value as a <see cref="object"/> if <see cref="Type"/> is 'noneApply', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'noneApply'.</exception>
    public object AsNoneApply() =>
        IsNoneApply
            ? Value!
            : throw new global::System.Exception("InsuranceTypes.Type is not 'noneApply'");

    /// <summary>
    /// Returns the value as a <see cref="HashSet<global::Candid.Net.Commons.InsuranceTypeCode>"/> if <see cref="Type"/> is 'theseApply', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'theseApply'.</exception>
    public HashSet<global::Candid.Net.Commons.InsuranceTypeCode> AsTheseApply() =>
        IsTheseApply
            ? (HashSet<global::Candid.Net.Commons.InsuranceTypeCode>)Value!
            : throw new global::System.Exception("InsuranceTypes.Type is not 'theseApply'");

    public T Match<T>(
        Func<object, T> onAllApply,
        Func<object, T> onNoneApply,
        Func<HashSet<global::Candid.Net.Commons.InsuranceTypeCode>, T> onTheseApply,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "allApply" => onAllApply(AsAllApply()),
            "noneApply" => onNoneApply(AsNoneApply()),
            "theseApply" => onTheseApply(AsTheseApply()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<object> onAllApply,
        Action<object> onNoneApply,
        Action<HashSet<global::Candid.Net.Commons.InsuranceTypeCode>> onTheseApply,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "allApply":
                onAllApply(AsAllApply());
                break;
            case "noneApply":
                onNoneApply(AsNoneApply());
                break;
            case "theseApply":
                onTheseApply(AsTheseApply());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="object"/> and returns true if successful.
    /// </summary>
    public bool TryAsAllApply(out object? value)
    {
        if (Type == "allApply")
        {
            value = Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="object"/> and returns true if successful.
    /// </summary>
    public bool TryAsNoneApply(out object? value)
    {
        if (Type == "noneApply")
        {
            value = Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="HashSet<global::Candid.Net.Commons.InsuranceTypeCode>"/> and returns true if successful.
    /// </summary>
    public bool TryAsTheseApply(out HashSet<global::Candid.Net.Commons.InsuranceTypeCode>? value)
    {
        if (Type == "theseApply")
        {
            value = (HashSet<global::Candid.Net.Commons.InsuranceTypeCode>)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator InsuranceTypes(InsuranceTypes.TheseApply value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<InsuranceTypes>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(InsuranceTypes).IsAssignableFrom(typeToConvert);

        public override InsuranceTypes Read(
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
                "allApply" => new { },
                "noneApply" => new { },
                "theseApply" => json.GetProperty("value")
                    .Deserialize<HashSet<global::Candid.Net.Commons.InsuranceTypeCode>?>(options)
                ?? throw new JsonException(
                        "Failed to deserialize HashSet<global::Candid.Net.Commons.InsuranceTypeCode>"
                    ),
                _ => json.Deserialize<object?>(options),
            };
            return new InsuranceTypes(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InsuranceTypes value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "allApply" => null,
                    "noneApply" => null,
                    "theseApply" => new JsonObject
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
    /// Discriminated union type for allApply
    /// </summary>
    [Serializable]
    public record AllApply
    {
        internal object Value => new { };

        public override string ToString() => Value.ToString() ?? "null";
    }

    /// <summary>
    /// Discriminated union type for noneApply
    /// </summary>
    [Serializable]
    public record NoneApply
    {
        internal object Value => new { };

        public override string ToString() => Value.ToString() ?? "null";
    }

    /// <summary>
    /// Discriminated union type for theseApply
    /// </summary>
    [Serializable]
    public record TheseApply
    {
        public TheseApply(HashSet<global::Candid.Net.Commons.InsuranceTypeCode> value)
        {
            Value = value;
        }

        internal HashSet<global::Candid.Net.Commons.InsuranceTypeCode> Value { get; set; } =
            new HashSet<global::Candid.Net.Commons.InsuranceTypeCode>();

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator InsuranceTypes.TheseApply(
            HashSet<global::Candid.Net.Commons.InsuranceTypeCode> value
        ) => new(value);
    }
}
