using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

[JsonConverter(typeof(TargetType.TargetTypeSerializer))]
[Serializable]
public readonly record struct TargetType : IStringEnum
{
    public static readonly TargetType Organization = new(Values.Organization);

    public static readonly TargetType Provider = new(Values.Provider);

    public static readonly TargetType ExternalProvider = new(Values.ExternalProvider);

    public static readonly TargetType Claim = new(Values.Claim);

    public static readonly TargetType ServiceLine = new(Values.ServiceLine);

    public static readonly TargetType Appointment = new(Values.Appointment);

    public TargetType(string value)
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
    public static TargetType FromCustom(string value)
    {
        return new TargetType(value);
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

    public static bool operator ==(TargetType value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(TargetType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TargetType value) => value.Value;

    public static explicit operator TargetType(string value) => new(value);

    internal class TargetTypeSerializer : JsonConverter<TargetType>
    {
        public override TargetType Read(
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
            return new TargetType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TargetType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TargetType ReadAsPropertyName(
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
            return new TargetType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TargetType value,
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
        public const string Organization = "ORGANIZATION";

        public const string Provider = "PROVIDER";

        public const string ExternalProvider = "EXTERNAL_PROVIDER";

        public const string Claim = "CLAIM";

        public const string ServiceLine = "SERVICE_LINE";

        public const string Appointment = "APPOINTMENT";
    }
}
