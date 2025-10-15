// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Remits.V1;

[JsonConverter(typeof(PayeeIdentifier.JsonConverter))]
[Serializable]
public record PayeeIdentifier
{
    internal PayeeIdentifier(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of PayeeIdentifier with <see cref="PayeeIdentifier.Npi"/>.
    /// </summary>
    public PayeeIdentifier(PayeeIdentifier.Npi value)
    {
        Type = "npi";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PayeeIdentifier with <see cref="PayeeIdentifier.Tin"/>.
    /// </summary>
    public PayeeIdentifier(PayeeIdentifier.Tin value)
    {
        Type = "tin";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PayeeIdentifier with <see cref="PayeeIdentifier.CmsPlanId"/>.
    /// </summary>
    public PayeeIdentifier(PayeeIdentifier.CmsPlanId value)
    {
        Type = "cms_plan_id";
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
    /// Returns true if <see cref="Type"/> is "npi"
    /// </summary>
    public bool IsNpi => Type == "npi";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "tin"
    /// </summary>
    public bool IsTin => Type == "tin";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "cms_plan_id"
    /// </summary>
    public bool IsCmsPlanId => Type == "cms_plan_id";

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'npi', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'npi'.</exception>
    public string AsNpi() =>
        IsNpi
            ? (string)Value!
            : throw new global::System.Exception("PayeeIdentifier.Type is not 'npi'");

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'tin', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'tin'.</exception>
    public string AsTin() =>
        IsTin
            ? (string)Value!
            : throw new global::System.Exception("PayeeIdentifier.Type is not 'tin'");

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'cms_plan_id', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'cms_plan_id'.</exception>
    public string AsCmsPlanId() =>
        IsCmsPlanId
            ? (string)Value!
            : throw new global::System.Exception("PayeeIdentifier.Type is not 'cms_plan_id'");

    public T Match<T>(
        Func<string, T> onNpi,
        Func<string, T> onTin,
        Func<string, T> onCmsPlanId,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "npi" => onNpi(AsNpi()),
            "tin" => onTin(AsTin()),
            "cms_plan_id" => onCmsPlanId(AsCmsPlanId()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<string> onNpi,
        Action<string> onTin,
        Action<string> onCmsPlanId,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "npi":
                onNpi(AsNpi());
                break;
            case "tin":
                onTin(AsTin());
                break;
            case "cms_plan_id":
                onCmsPlanId(AsCmsPlanId());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="string"/> and returns true if successful.
    /// </summary>
    public bool TryAsNpi(out string? value)
    {
        if (Type == "npi")
        {
            value = (string)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="string"/> and returns true if successful.
    /// </summary>
    public bool TryAsTin(out string? value)
    {
        if (Type == "tin")
        {
            value = (string)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="string"/> and returns true if successful.
    /// </summary>
    public bool TryAsCmsPlanId(out string? value)
    {
        if (Type == "cms_plan_id")
        {
            value = (string)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator PayeeIdentifier(PayeeIdentifier.Npi value) => new(value);

    public static implicit operator PayeeIdentifier(PayeeIdentifier.Tin value) => new(value);

    public static implicit operator PayeeIdentifier(PayeeIdentifier.CmsPlanId value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<PayeeIdentifier>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(PayeeIdentifier).IsAssignableFrom(typeToConvert);

        public override PayeeIdentifier Read(
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
                "npi" => json.GetProperty("value").Deserialize<string?>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                "tin" => json.GetProperty("value").Deserialize<string?>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                "cms_plan_id" => json.GetProperty("value").Deserialize<string?>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                _ => json.Deserialize<object?>(options),
            };
            return new PayeeIdentifier(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PayeeIdentifier value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "npi" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    "tin" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    "cms_plan_id" => new JsonObject
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
    /// Discriminated union type for npi
    /// </summary>
    [Serializable]
    public record Npi
    {
        public Npi(string value)
        {
            Value = value;
        }

        internal string Value { get; set; }

        public override string ToString() => Value;

        public static implicit operator PayeeIdentifier.Npi(string value) => new(value);
    }

    /// <summary>
    /// Discriminated union type for tin
    /// </summary>
    [Serializable]
    public record Tin
    {
        public Tin(string value)
        {
            Value = value;
        }

        internal string Value { get; set; }

        public override string ToString() => Value;

        public static implicit operator PayeeIdentifier.Tin(string value) => new(value);
    }

    /// <summary>
    /// Discriminated union type for cms_plan_id
    /// </summary>
    [Serializable]
    public record CmsPlanId
    {
        public CmsPlanId(string value)
        {
            Value = value;
        }

        internal string Value { get; set; }

        public override string ToString() => Value;

        public static implicit operator PayeeIdentifier.CmsPlanId(string value) => new(value);
    }
}
