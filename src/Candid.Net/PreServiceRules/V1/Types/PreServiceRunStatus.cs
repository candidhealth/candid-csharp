using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreServiceRules.V1;

[JsonConverter(typeof(PreServiceRunStatus.PreServiceRunStatusSerializer))]
[Serializable]
public readonly record struct PreServiceRunStatus : IStringEnum
{
    public static readonly PreServiceRunStatus InProgress = new(Values.InProgress);

    public static readonly PreServiceRunStatus Complete = new(Values.Complete);

    public static readonly PreServiceRunStatus Failed = new(Values.Failed);

    public PreServiceRunStatus(string value)
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
    public static PreServiceRunStatus FromCustom(string value)
    {
        return new PreServiceRunStatus(value);
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

    public static bool operator ==(PreServiceRunStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PreServiceRunStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PreServiceRunStatus value) => value.Value;

    public static explicit operator PreServiceRunStatus(string value) => new(value);

    internal class PreServiceRunStatusSerializer : JsonConverter<PreServiceRunStatus>
    {
        public override PreServiceRunStatus Read(
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
            return new PreServiceRunStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PreServiceRunStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PreServiceRunStatus ReadAsPropertyName(
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
            return new PreServiceRunStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PreServiceRunStatus value,
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
        public const string InProgress = "IN_PROGRESS";

        public const string Complete = "COMPLETE";

        public const string Failed = "FAILED";
    }
}
