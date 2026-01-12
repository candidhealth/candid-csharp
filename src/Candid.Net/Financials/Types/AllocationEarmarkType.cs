// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Financials;

/// <summary>
/// CURRENTLY UNIMPLEMENTED - Defines how a patient prepayment allocation should be earmarked for future auto-allocation.
/// When implemented, earmarks will hold the allocation until a matching encounter is created, then attempt to allocate to that encounter.
/// Only applicable for unattributed allocations.
/// </summary>
[JsonConverter(typeof(AllocationEarmarkType.JsonConverter))]
[Serializable]
public record AllocationEarmarkType
{
    internal AllocationEarmarkType(string type, object? value)
    {
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of AllocationEarmarkType with <see cref="AllocationEarmarkType.DateOfService"/>.
    /// </summary>
    public AllocationEarmarkType(AllocationEarmarkType.DateOfService value)
    {
        Type = "date_of_service";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of AllocationEarmarkType with <see cref="AllocationEarmarkType.ExternalEncounterId"/>.
    /// </summary>
    public AllocationEarmarkType(AllocationEarmarkType.ExternalEncounterId value)
    {
        Type = "external_encounter_id";
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
    /// Returns true if <see cref="Type"/> is "date_of_service"
    /// </summary>
    public bool IsDateOfService => Type == "date_of_service";

    /// <summary>
    /// Returns true if <see cref="Type"/> is "external_encounter_id"
    /// </summary>
    public bool IsExternalEncounterId => Type == "external_encounter_id";

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'date_of_service', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'date_of_service'.</exception>
    public string AsDateOfService() =>
        IsDateOfService
            ? (string)Value!
            : throw new global::System.Exception(
                "AllocationEarmarkType.Type is not 'date_of_service'"
            );

    /// <summary>
    /// Returns the value as a <see cref="string"/> if <see cref="Type"/> is 'external_encounter_id', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Type"/> is not 'external_encounter_id'.</exception>
    public string AsExternalEncounterId() =>
        IsExternalEncounterId
            ? (string)Value!
            : throw new global::System.Exception(
                "AllocationEarmarkType.Type is not 'external_encounter_id'"
            );

    public T Match<T>(
        Func<string, T> onDateOfService,
        Func<string, T> onExternalEncounterId,
        Func<string, object?, T> onUnknown_
    )
    {
        return Type switch
        {
            "date_of_service" => onDateOfService(AsDateOfService()),
            "external_encounter_id" => onExternalEncounterId(AsExternalEncounterId()),
            _ => onUnknown_(Type, Value),
        };
    }

    public void Visit(
        Action<string> onDateOfService,
        Action<string> onExternalEncounterId,
        Action<string, object?> onUnknown_
    )
    {
        switch (Type)
        {
            case "date_of_service":
                onDateOfService(AsDateOfService());
                break;
            case "external_encounter_id":
                onExternalEncounterId(AsExternalEncounterId());
                break;
            default:
                onUnknown_(Type, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="string"/> and returns true if successful.
    /// </summary>
    public bool TryAsDateOfService(out string? value)
    {
        if (Type == "date_of_service")
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
    public bool TryAsExternalEncounterId(out string? value)
    {
        if (Type == "external_encounter_id")
        {
            value = (string)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator AllocationEarmarkType(
        AllocationEarmarkType.DateOfService value
    ) => new(value);

    public static implicit operator AllocationEarmarkType(
        AllocationEarmarkType.ExternalEncounterId value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<AllocationEarmarkType>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(AllocationEarmarkType).IsAssignableFrom(typeToConvert);

        public override AllocationEarmarkType Read(
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
                "date_of_service" => json.GetProperty("value").Deserialize<string?>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                "external_encounter_id" => json.GetProperty("value").Deserialize<string?>(options)
                ?? throw new JsonException("Failed to deserialize string"),
                _ => json.Deserialize<object?>(options),
            };
            return new AllocationEarmarkType(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AllocationEarmarkType value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Type switch
                {
                    "date_of_service" => new JsonObject
                    {
                        ["value"] = JsonSerializer.SerializeToNode(value.Value, options),
                    },
                    "external_encounter_id" => new JsonObject
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
    /// Discriminated union type for date_of_service
    /// </summary>
    [Serializable]
    public record DateOfService
    {
        public DateOfService(string value)
        {
            Value = value;
        }

        internal string Value { get; set; }

        public override string ToString() => Value;

        public static implicit operator AllocationEarmarkType.DateOfService(string value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for external_encounter_id
    /// </summary>
    [Serializable]
    public record ExternalEncounterId
    {
        public ExternalEncounterId(string value)
        {
            Value = value;
        }

        internal string Value { get; set; }

        public override string ToString() => Value;

        public static implicit operator AllocationEarmarkType.ExternalEncounterId(string value) =>
            new(value);
    }
}
