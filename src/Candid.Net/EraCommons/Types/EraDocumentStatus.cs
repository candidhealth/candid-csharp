using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EraCommons;

[JsonConverter(typeof(EraDocumentStatus.EraDocumentStatusSerializer))]
[Serializable]
public readonly record struct EraDocumentStatus : IStringEnum
{
    public static readonly EraDocumentStatus Queued = new(Values.Queued);

    public static readonly EraDocumentStatus Processed = new(Values.Processed);

    public static readonly EraDocumentStatus Failed = new(Values.Failed);

    public static readonly EraDocumentStatus ManualIntervention = new(Values.ManualIntervention);

    public EraDocumentStatus(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static EraDocumentStatus FromCustom(string value)
    {
        return new EraDocumentStatus(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(EraDocumentStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EraDocumentStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EraDocumentStatus value) => value.Value;

    public static explicit operator EraDocumentStatus(string value) => new(value);

    internal class EraDocumentStatusSerializer : JsonConverter<EraDocumentStatus>
    {
        public override EraDocumentStatus Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new EraDocumentStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EraDocumentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EraDocumentStatus ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new EraDocumentStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EraDocumentStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Queued = "queued";

        public const string Processed = "processed";

        public const string Failed = "failed";

        public const string ManualIntervention = "manual_intervention";
    }
}
