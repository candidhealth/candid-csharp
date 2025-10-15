// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(Regions.JsonConverter))]
[Serializable]
public record Regions
{
    internal Regions(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of Regions with <see cref="Regions.States"/>.
    /// </summary>
    public Regions(Regions.States value)
    {
        Type = "states";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Regions with <see cref="Regions.National"/>.
    /// </summary>
    public Regions(Regions.National value)
    {
        Type = "national";
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
    /// Returns true if <see cref="Type"/> is "states"
    /// </summary>
    public bool IsStates => Type == "states";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "national"
    /// </summary>
    public bool IsNational => Type == "national";

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.Commons.RegionStates"/> if <see cref="Type"/> is 'states', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'states'.</exception>
    public Candid.Net.Commons.RegionStates AsStates() =>
        IsStates
            ? (Candid.Net.Commons.RegionStates)Value!
            : throw new Exception("Regions.Type is not 'states'");

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.Commons.RegionNational"/> if <see cref="Type"/> is 'national', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'national'.</exception>
    public Candid.Net.Commons.RegionNational AsNational() =>
        IsNational
            ? (Candid.Net.Commons.RegionNational)Value!
            : throw new Exception("Regions.Type is not 'national'");

    public T Match<T>(
        Func<Candid.Net.Commons.RegionStates, T> onStates,
        Func<Candid.Net.Commons.RegionNational, T> onNational,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "states" => onStates(AsStates()),
            "national" => onNational(AsNational()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<Candid.Net.Commons.RegionStates> onStates,
        Action<Candid.Net.Commons.RegionNational> onNational,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "states":
                onStates(AsStates());
                break;
            case "national":
                onNational(AsNational());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.Commons.RegionStates"/> and returns true if successful.
    /// </summary>
    public bool TryAsStates(out Candid.Net.Commons.RegionStates? value)
    {
        if (Type == "states")
        {
            value = (Candid.Net.Commons.RegionStates)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.Commons.RegionNational"/> and returns true if successful.
    /// </summary>
    public bool TryAsNational(out Candid.Net.Commons.RegionNational? value)
    {
        if (Type == "national")
        {
            value = (Candid.Net.Commons.RegionNational)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator Regions(Regions.States value) => new(value);

    public static implicit operator Regions(Regions.National value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<Regions>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(Regions).IsAssignableFrom(typeToConvert);

        public override Regions Read(
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
                "states" => json.Deserialize<Candid.Net.Commons.RegionStates>(options)
                    ?? throw new JsonException(
                        "Failed to deserialize Candid.Net.Commons.RegionStates"
                    ),
                "national" => json.Deserialize<Candid.Net.Commons.RegionNational>(options)
                    ?? throw new JsonException(
                        "Failed to deserialize Candid.Net.Commons.RegionNational"
                    ),
                _ => json.Deserialize<object?>(options),
            };
            return new Regions(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            Regions value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "states" => JsonSerializer.SerializeToNode(value.Value, options),
                    "national" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for states
    /// </summary>
    [Serializable]
    public struct States
    {
        public States(Candid.Net.Commons.RegionStates value)
        {
            Value = value;
        }

        internal Candid.Net.Commons.RegionStates Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator Regions.States(Candid.Net.Commons.RegionStates value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for national
    /// </summary>
    [Serializable]
    public struct National
    {
        public National(Candid.Net.Commons.RegionNational value)
        {
            Value = value;
        }

        internal Candid.Net.Commons.RegionNational Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator Regions.National(Candid.Net.Commons.RegionNational value) =>
            new(value);
    }
}
