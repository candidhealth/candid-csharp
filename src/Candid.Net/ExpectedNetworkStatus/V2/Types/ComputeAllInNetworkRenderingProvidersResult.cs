// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V2;

[JsonConverter(typeof(ComputeAllInNetworkRenderingProvidersResult.JsonConverter))]
[Serializable]
public record ComputeAllInNetworkRenderingProvidersResult
{
    internal ComputeAllInNetworkRenderingProvidersResult(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of ComputeAllInNetworkRenderingProvidersResult with <see cref="ComputeAllInNetworkRenderingProvidersResult.RenderingProviders"/>.
    /// </summary>
    public ComputeAllInNetworkRenderingProvidersResult(
        ComputeAllInNetworkRenderingProvidersResult.RenderingProviders value
    )
    {
        Type = "rendering_providers";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ComputeAllInNetworkRenderingProvidersResult with <see cref="ComputeAllInNetworkRenderingProvidersResult.Indeterminate"/>.
    /// </summary>
    public ComputeAllInNetworkRenderingProvidersResult(
        ComputeAllInNetworkRenderingProvidersResult.Indeterminate value
    )
    {
        Type = "indeterminate";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of ComputeAllInNetworkRenderingProvidersResult with <see cref="ComputeAllInNetworkRenderingProvidersResult.OutOfNetwork"/>.
    /// </summary>
    public ComputeAllInNetworkRenderingProvidersResult(
        ComputeAllInNetworkRenderingProvidersResult.OutOfNetwork value
    )
    {
        Type = "out_of_network";
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
    /// Returns true if <see cref="Type"/> is "rendering_providers"
    /// </summary>
    public bool IsRenderingProviders => Type == "rendering_providers";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "indeterminate"
    /// </summary>
    public bool IsIndeterminate => Type == "indeterminate";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "out_of_network"
    /// </summary>
    public bool IsOutOfNetwork => Type == "out_of_network";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.ExpectedNetworkStatus.V2.InNetworkRenderingProvidersDetail"/> if <see cref="Type"/> is 'rendering_providers', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'rendering_providers'.</exception>
    public global::Candid.Net.ExpectedNetworkStatus.V2.InNetworkRenderingProvidersDetail AsRenderingProviders() =>
        IsRenderingProviders
            ? (global::Candid.Net.ExpectedNetworkStatus.V2.InNetworkRenderingProvidersDetail)Value!
            : throw new global::System.Exception(
                "ComputeAllInNetworkRenderingProvidersResult.Type is not 'rendering_providers'"
            );

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus"/> if <see cref="Type"/> is 'indeterminate', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'indeterminate'.</exception>
    public global::Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus AsIndeterminate() =>
        IsIndeterminate
            ? (global::Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus)Value!
            : throw new global::System.Exception(
                "ComputeAllInNetworkRenderingProvidersResult.Type is not 'indeterminate'"
            );

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus"/> if <see cref="Type"/> is 'out_of_network', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'out_of_network'.</exception>
    public global::Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus AsOutOfNetwork() =>
        IsOutOfNetwork
            ? (global::Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus)Value!
            : throw new global::System.Exception(
                "ComputeAllInNetworkRenderingProvidersResult.Type is not 'out_of_network'"
            );

    public T Match<T>(
        Func<
            global::Candid.Net.ExpectedNetworkStatus.V2.InNetworkRenderingProvidersDetail,
            T
        > onRenderingProviders,
        Func<
            global::Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus,
            T
        > onIndeterminate,
        Func<global::Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus, T> onOutOfNetwork,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "rendering_providers" => onRenderingProviders(AsRenderingProviders()),
            "indeterminate" => onIndeterminate(AsIndeterminate()),
            "out_of_network" => onOutOfNetwork(AsOutOfNetwork()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.ExpectedNetworkStatus.V2.InNetworkRenderingProvidersDetail> onRenderingProviders,
        Action<global::Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus> onIndeterminate,
        Action<global::Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus> onOutOfNetwork,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "rendering_providers":
                onRenderingProviders(AsRenderingProviders());
                break;
            case "indeterminate":
                onIndeterminate(AsIndeterminate());
                break;
            case "out_of_network":
                onOutOfNetwork(AsOutOfNetwork());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.ExpectedNetworkStatus.V2.InNetworkRenderingProvidersDetail"/> and returns true if successful.
    /// </summary>
    public bool TryAsRenderingProviders(
        out global::Candid.Net.ExpectedNetworkStatus.V2.InNetworkRenderingProvidersDetail? value
    )
    {
        if (Type == "rendering_providers")
        {
            value = (global::Candid.Net.ExpectedNetworkStatus.V2.InNetworkRenderingProvidersDetail)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus"/> and returns true if successful.
    /// </summary>
    public bool TryAsIndeterminate(
        out global::Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus? value
    )
    {
        if (Type == "indeterminate")
        {
            value = (global::Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus"/> and returns true if successful.
    /// </summary>
    public bool TryAsOutOfNetwork(
        out global::Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus? value
    )
    {
        if (Type == "out_of_network")
        {
            value = (global::Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator ComputeAllInNetworkRenderingProvidersResult(
        ComputeAllInNetworkRenderingProvidersResult.RenderingProviders value
    ) => new(value);

    public static implicit operator ComputeAllInNetworkRenderingProvidersResult(
        ComputeAllInNetworkRenderingProvidersResult.Indeterminate value
    ) => new(value);

    public static implicit operator ComputeAllInNetworkRenderingProvidersResult(
        ComputeAllInNetworkRenderingProvidersResult.OutOfNetwork value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<ComputeAllInNetworkRenderingProvidersResult>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(ComputeAllInNetworkRenderingProvidersResult).IsAssignableFrom(typeToConvert);

        public override ComputeAllInNetworkRenderingProvidersResult Read(
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
                "rendering_providers" =>
                    json.Deserialize<global::Candid.Net.ExpectedNetworkStatus.V2.InNetworkRenderingProvidersDetail?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.ExpectedNetworkStatus.V2.InNetworkRenderingProvidersDetail"
                        ),
                "indeterminate" =>
                    json.Deserialize<global::Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus"
                        ),
                "out_of_network" =>
                    json.Deserialize<global::Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new ComputeAllInNetworkRenderingProvidersResult(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ComputeAllInNetworkRenderingProvidersResult value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "rendering_providers" => JsonSerializer.SerializeToNode(value.Value, options),
                    "indeterminate" => JsonSerializer.SerializeToNode(value.Value, options),
                    "out_of_network" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["type"] = value.Type;
            json.WriteTo(writer, options);
        }
    }

    /// <summary>
    /// Discriminated union type for rendering_providers
    /// </summary>
    [Serializable]
    public struct RenderingProviders
    {
        public RenderingProviders(
            global::Candid.Net.ExpectedNetworkStatus.V2.InNetworkRenderingProvidersDetail value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.ExpectedNetworkStatus.V2.InNetworkRenderingProvidersDetail Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ComputeAllInNetworkRenderingProvidersResult.RenderingProviders(
            global::Candid.Net.ExpectedNetworkStatus.V2.InNetworkRenderingProvidersDetail value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for indeterminate
    /// </summary>
    [Serializable]
    public struct Indeterminate
    {
        public Indeterminate(
            global::Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus value
        )
        {
            Value = value;
        }

        internal global::Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ComputeAllInNetworkRenderingProvidersResult.Indeterminate(
            global::Candid.Net.ExpectedNetworkStatus.V2.IndeterminateNetworkStatus value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for out_of_network
    /// </summary>
    [Serializable]
    public struct OutOfNetwork
    {
        public OutOfNetwork(global::Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus value)
        {
            Value = value;
        }

        internal global::Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator ComputeAllInNetworkRenderingProvidersResult.OutOfNetwork(
            global::Candid.Net.ExpectedNetworkStatus.V2.OutOfNetworkStatus value
        ) => new(value);
    }
}
