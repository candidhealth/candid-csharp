// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V2;

[JsonConverter(typeof(ExpectedNetworkStatusV2.JsonConverter))]
[Serializable]
public record ExpectedNetworkStatusV2
{
    internal ExpectedNetworkStatusV2(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of ExpectedNetworkStatusV2 with <see cref="ExpectedNetworkStatusV2.InNetwork"/>.
    /// </summary>
    public ExpectedNetworkStatusV2(ExpectedNetworkStatusV2.InNetwork value)
    {
        Type = "in_network";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ExpectedNetworkStatusV2 with <see cref="ExpectedNetworkStatusV2.OutOfNetwork"/>.
    /// </summary>
    public ExpectedNetworkStatusV2(ExpectedNetworkStatusV2.OutOfNetwork value)
    {
        Type = "out_of_network";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ExpectedNetworkStatusV2 with <see cref="ExpectedNetworkStatusV2.Indeterminate"/>.
    /// </summary>
    public ExpectedNetworkStatusV2(ExpectedNetworkStatusV2.Indeterminate value)
    {
        Type = "indeterminate";
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
    /// Returns true if <see cref="Type"/> is "in_network"
    /// </summary>
    public bool IsInNetwork => Type == "in_network";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "out_of_network"
    /// </summary>
    public bool IsOutOfNetwork => Type == "out_of_network";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "indeterminate"
    /// </summary>
    public bool IsIndeterminate => Type == "indeterminate";

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.ExpectedNetworkStatus.V2.InNetworkStatus"/> if <see cref="Type"/> is 'in_network', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'in_network'.</exception>
    public Candid.Net.ExpectedNetworkStatus.V2.InNetworkStatus AsInNetwork() =>
        IsInNetwork
            ? (Candid.Net.ExpectedNetworkStatus.V2.InNetworkStatus)Value!
            : throw new Exception("ExpectedNetworkStatusV2.Type is not 'in_network'");

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus"/> if <see cref="Type"/> is 'out_of_network', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'out_of_network'.</exception>
    public Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus AsOutOfNetwork() =>
        IsOutOfNetwork
            ? (Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus)Value!
            : throw new Exception("ExpectedNetworkStatusV2.Type is not 'out_of_network'");

    /// <summary>
    /// Returns the value as a <see cref="Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus"/> if <see cref="Type"/> is 'indeterminate', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'indeterminate'.</exception>
    public Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus AsIndeterminate() =>
        IsIndeterminate
            ? (Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus)Value!
            : throw new Exception("ExpectedNetworkStatusV2.Type is not 'indeterminate'");

    public T Match<T>(
        Func<Candid.Net.ExpectedNetworkStatus.V2.InNetworkStatus, T> onInNetwork,
        Func<Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus, T> onOutOfNetwork,
        Func<Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus, T> onIndeterminate,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "in_network" => onInNetwork(AsInNetwork()),
            "out_of_network" => onOutOfNetwork(AsOutOfNetwork()),
            "indeterminate" => onIndeterminate(AsIndeterminate()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<Candid.Net.ExpectedNetworkStatus.V2.InNetworkStatus> onInNetwork,
        Action<Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus> onOutOfNetwork,
        Action<Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus> onIndeterminate,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "in_network":
                onInNetwork(AsInNetwork());
                break;
            case "out_of_network":
                onOutOfNetwork(AsOutOfNetwork());
                break;
            case "indeterminate":
                onIndeterminate(AsIndeterminate());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.ExpectedNetworkStatus.V2.InNetworkStatus"/> and returns true if successful.
    /// </summary>
    public bool TryAsInNetwork(out Candid.Net.ExpectedNetworkStatus.V2.InNetworkStatus? value)
    {
        if (Type == "in_network")
        {
            value = (Candid.Net.ExpectedNetworkStatus.V2.InNetworkStatus)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus"/> and returns true if successful.
    /// </summary>
    public bool TryAsOutOfNetwork(out Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus? value)
    {
        if (Type == "out_of_network")
        {
            value = (Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus"/> and returns true if successful.
    /// </summary>
    public bool TryAsIndeterminate(
        out Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus? value
    )
    {
        if (Type == "indeterminate")
        {
            value = (Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator ExpectedNetworkStatusV2(
        ExpectedNetworkStatusV2.InNetwork value
    ) => new(value);

    public static implicit operator ExpectedNetworkStatusV2(
        ExpectedNetworkStatusV2.OutOfNetwork value
    ) => new(value);

    public static implicit operator ExpectedNetworkStatusV2(
        ExpectedNetworkStatusV2.Indeterminate value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<ExpectedNetworkStatusV2>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(ExpectedNetworkStatusV2).IsAssignableFrom(typeToConvert);

        public override ExpectedNetworkStatusV2 Read(
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
                "in_network" =>
                    json.Deserialize<Candid.Net.ExpectedNetworkStatus.V2.InNetworkStatus>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.ExpectedNetworkStatus.V2.InNetworkStatus"
                        ),
                "out_of_network" =>
                    json.Deserialize<Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus"
                        ),
                "indeterminate" =>
                    json.Deserialize<Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new ExpectedNetworkStatusV2(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ExpectedNetworkStatusV2 value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "in_network" => JsonSerializer.SerializeToNode(value.Value, options),
                    "out_of_network" => JsonSerializer.SerializeToNode(value.Value, options),
                    "indeterminate" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for in_network
    /// </summary>
    [Serializable]
    public struct InNetwork
    {
        public InNetwork(Candid.Net.ExpectedNetworkStatus.V2.InNetworkStatus value)
        {
            Value = value;
        }

        internal Candid.Net.ExpectedNetworkStatus.V2.InNetworkStatus Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator ExpectedNetworkStatusV2.InNetwork(
            Candid.Net.ExpectedNetworkStatus.V2.InNetworkStatus value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for out_of_network
    /// </summary>
    [Serializable]
    public struct OutOfNetwork
    {
        public OutOfNetwork(Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus value)
        {
            Value = value;
        }

        internal Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator ExpectedNetworkStatusV2.OutOfNetwork(
            Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for indeterminate
    /// </summary>
    [Serializable]
    public struct Indeterminate
    {
        public Indeterminate(Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus value)
        {
            Value = value;
        }

        internal Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus Value { get; set; }

        public override string ToString() => Value.ToString();

        public static implicit operator ExpectedNetworkStatusV2.Indeterminate(
            Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus value
        ) => new(value);
    }
}
