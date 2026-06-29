// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.PatientMerges.V1;

/// <summary>
/// The merge status of a patient.
/// </summary>
[JsonConverter(typeof(PatientMergeStatus.JsonConverter))]
[Serializable]
public record PatientMergeStatus
{
    internal PatientMergeStatus(string type, object? value)
    {
        MergeStatus = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of PatientMergeStatus with <see cref="PatientMergeStatus.None"/>.
    /// </summary>
    public PatientMergeStatus(PatientMergeStatus.None value)
    {
        MergeStatus = "none";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PatientMergeStatus with <see cref="PatientMergeStatus.Alternative"/>.
    /// </summary>
    public PatientMergeStatus(PatientMergeStatus.Alternative value)
    {
        MergeStatus = "alternative";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of PatientMergeStatus with <see cref="PatientMergeStatus.Primary"/>.
    /// </summary>
    public PatientMergeStatus(PatientMergeStatus.Primary value)
    {
        MergeStatus = "primary";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("merge_status")]
    public string MergeStatus { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="MergeStatus"/> is "none"
    /// </summary>
    public bool IsNone => MergeStatus == "none";

    /// <summary>
    /// Returns true if <see cref="MergeStatus"/> is "alternative"
    /// </summary>
    public bool IsAlternative => MergeStatus == "alternative";

    /// <summary>
    /// Returns true if <see cref="MergeStatus"/> is "primary"
    /// </summary>
    public bool IsPrimary => MergeStatus == "primary";

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.PreEncounter.PatientMerges.V1.NoneStatus"/> if <see cref="MergeStatus"/> is 'none', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="MergeStatus"/> is not 'none'.</exception>
    public global::Candid.Net.PreEncounter.PatientMerges.V1.NoneStatus AsNone() =>
        IsNone
            ? (global::Candid.Net.PreEncounter.PatientMerges.V1.NoneStatus)Value!
            : throw new global::System.Exception("PatientMergeStatus.MergeStatus is not 'none'");

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.PreEncounter.PatientMerges.V1.AlternativeStatus"/> if <see cref="MergeStatus"/> is 'alternative', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="MergeStatus"/> is not 'alternative'.</exception>
    public global::Candid.Net.PreEncounter.PatientMerges.V1.AlternativeStatus AsAlternative() =>
        IsAlternative
            ? (global::Candid.Net.PreEncounter.PatientMerges.V1.AlternativeStatus)Value!
            : throw new global::System.Exception(
                "PatientMergeStatus.MergeStatus is not 'alternative'"
            );

    /// <summary>
    /// Returns the value as a <see cref="global::Candid.Net.PreEncounter.PatientMerges.V1.PrimaryStatus"/> if <see cref="MergeStatus"/> is 'primary', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="MergeStatus"/> is not 'primary'.</exception>
    public global::Candid.Net.PreEncounter.PatientMerges.V1.PrimaryStatus AsPrimary() =>
        IsPrimary
            ? (global::Candid.Net.PreEncounter.PatientMerges.V1.PrimaryStatus)Value!
            : throw new global::System.Exception("PatientMergeStatus.MergeStatus is not 'primary'");

    public T Match<T>(
        Func<global::Candid.Net.PreEncounter.PatientMerges.V1.NoneStatus, T> onNone,
        Func<global::Candid.Net.PreEncounter.PatientMerges.V1.AlternativeStatus, T> onAlternative,
        Func<global::Candid.Net.PreEncounter.PatientMerges.V1.PrimaryStatus, T> onPrimary,
        Func<string, object?, T> onUnknown_
    )
    {
        return MergeStatus switch
        {
            "none" => onNone(AsNone()),
            "alternative" => onAlternative(AsAlternative()),
            "primary" => onPrimary(AsPrimary()),
            _ => onUnknown_(MergeStatus, Value),
        };
    }

    public void Visit(
        Action<global::Candid.Net.PreEncounter.PatientMerges.V1.NoneStatus> onNone,
        Action<global::Candid.Net.PreEncounter.PatientMerges.V1.AlternativeStatus> onAlternative,
        Action<global::Candid.Net.PreEncounter.PatientMerges.V1.PrimaryStatus> onPrimary,
        Action<string, object?> onUnknown_
    )
    {
        switch (MergeStatus)
        {
            case "none":
                onNone(AsNone());
                break;
            case "alternative":
                onAlternative(AsAlternative());
                break;
            case "primary":
                onPrimary(AsPrimary());
                break;
            default:
                onUnknown_(MergeStatus, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.PreEncounter.PatientMerges.V1.NoneStatus"/> and returns true if successful.
    /// </summary>
    public bool TryAsNone(out global::Candid.Net.PreEncounter.PatientMerges.V1.NoneStatus? value)
    {
        if (MergeStatus == "none")
        {
            value = (global::Candid.Net.PreEncounter.PatientMerges.V1.NoneStatus)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.PreEncounter.PatientMerges.V1.AlternativeStatus"/> and returns true if successful.
    /// </summary>
    public bool TryAsAlternative(
        out global::Candid.Net.PreEncounter.PatientMerges.V1.AlternativeStatus? value
    )
    {
        if (MergeStatus == "alternative")
        {
            value = (global::Candid.Net.PreEncounter.PatientMerges.V1.AlternativeStatus)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="global::Candid.Net.PreEncounter.PatientMerges.V1.PrimaryStatus"/> and returns true if successful.
    /// </summary>
    public bool TryAsPrimary(
        out global::Candid.Net.PreEncounter.PatientMerges.V1.PrimaryStatus? value
    )
    {
        if (MergeStatus == "primary")
        {
            value = (global::Candid.Net.PreEncounter.PatientMerges.V1.PrimaryStatus)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator PatientMergeStatus(PatientMergeStatus.None value) => new(value);

    public static implicit operator PatientMergeStatus(PatientMergeStatus.Alternative value) =>
        new(value);

    public static implicit operator PatientMergeStatus(PatientMergeStatus.Primary value) =>
        new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<PatientMergeStatus>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(PatientMergeStatus).IsAssignableFrom(typeToConvert);

        public override PatientMergeStatus Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("merge_status", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'merge_status'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'merge_status' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'merge_status' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'merge_status' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("merge_status");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "none" =>
                    jsonWithoutDiscriminator.Deserialize<global::Candid.Net.PreEncounter.PatientMerges.V1.NoneStatus?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.PreEncounter.PatientMerges.V1.NoneStatus"
                        ),
                "alternative" =>
                    jsonWithoutDiscriminator.Deserialize<global::Candid.Net.PreEncounter.PatientMerges.V1.AlternativeStatus?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.PreEncounter.PatientMerges.V1.AlternativeStatus"
                        ),
                "primary" =>
                    jsonWithoutDiscriminator.Deserialize<global::Candid.Net.PreEncounter.PatientMerges.V1.PrimaryStatus?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize global::Candid.Net.PreEncounter.PatientMerges.V1.PrimaryStatus"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new PatientMergeStatus(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PatientMergeStatus value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.MergeStatus switch
                {
                    "none" => JsonSerializer.SerializeToNode(value.Value, options),
                    "alternative" => JsonSerializer.SerializeToNode(value.Value, options),
                    "primary" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["merge_status"] = value.MergeStatus;
            json.WriteTo(writer, options);
        }

        public override PatientMergeStatus ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new PatientMergeStatus(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PatientMergeStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.MergeStatus);
        }
    }

    /// <summary>
    /// Discriminated union type for none
    /// </summary>
    [Serializable]
    public struct None
    {
        public None(global::Candid.Net.PreEncounter.PatientMerges.V1.NoneStatus value)
        {
            Value = value;
        }

        internal global::Candid.Net.PreEncounter.PatientMerges.V1.NoneStatus Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PatientMergeStatus.None(
            global::Candid.Net.PreEncounter.PatientMerges.V1.NoneStatus value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for alternative
    /// </summary>
    [Serializable]
    public struct Alternative
    {
        public Alternative(global::Candid.Net.PreEncounter.PatientMerges.V1.AlternativeStatus value)
        {
            Value = value;
        }

        internal global::Candid.Net.PreEncounter.PatientMerges.V1.AlternativeStatus Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PatientMergeStatus.Alternative(
            global::Candid.Net.PreEncounter.PatientMerges.V1.AlternativeStatus value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for primary
    /// </summary>
    [Serializable]
    public struct Primary
    {
        public Primary(global::Candid.Net.PreEncounter.PatientMerges.V1.PrimaryStatus value)
        {
            Value = value;
        }

        internal global::Candid.Net.PreEncounter.PatientMerges.V1.PrimaryStatus Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator PatientMergeStatus.Primary(
            global::Candid.Net.PreEncounter.PatientMerges.V1.PrimaryStatus value
        ) => new(value);
    }
}
