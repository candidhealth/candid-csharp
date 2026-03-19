using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

[JsonConverter(typeof(DisabilityStatus.DisabilityStatusSerializer))]
[Serializable]
public readonly record struct DisabilityStatus : IStringEnum
{
    public static readonly DisabilityStatus Disabled = new(Values.Disabled);

    public static readonly DisabilityStatus NonDisabled = new(Values.NonDisabled);

    public DisabilityStatus(string value)
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
    public static DisabilityStatus FromCustom(string value)
    {
        return new DisabilityStatus(value);
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

    public static bool operator ==(DisabilityStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DisabilityStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DisabilityStatus value) => value.Value;

    public static explicit operator DisabilityStatus(string value) => new(value);

    internal class DisabilityStatusSerializer : JsonConverter<DisabilityStatus>
    {
        public override DisabilityStatus Read(
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
            return new DisabilityStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DisabilityStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DisabilityStatus ReadAsPropertyName(
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
            return new DisabilityStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DisabilityStatus value,
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
        public const string Disabled = "DISABLED";

        public const string NonDisabled = "NON_DISABLED";
    }
}
