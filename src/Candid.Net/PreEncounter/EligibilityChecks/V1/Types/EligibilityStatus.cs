using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[JsonConverter(typeof(EligibilityStatus.EligibilityStatusSerializer))]
[Serializable]
public readonly record struct EligibilityStatus : IStringEnum
{
    public static readonly EligibilityStatus Active = new(Values.Active);

    public static readonly EligibilityStatus Inactive = new(Values.Inactive);

    public static readonly EligibilityStatus Unknown = new(Values.Unknown);

    public EligibilityStatus(string value)
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
    public static EligibilityStatus FromCustom(string value)
    {
        return new EligibilityStatus(value);
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

    public static bool operator ==(EligibilityStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EligibilityStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EligibilityStatus value) => value.Value;

    public static explicit operator EligibilityStatus(string value) => new(value);

    internal class EligibilityStatusSerializer : JsonConverter<EligibilityStatus>
    {
        public override EligibilityStatus Read(
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
            return new EligibilityStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EligibilityStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EligibilityStatus ReadAsPropertyName(
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
            return new EligibilityStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EligibilityStatus value,
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
        public const string Active = "ACTIVE";

        public const string Inactive = "INACTIVE";

        public const string Unknown = "UNKNOWN";
    }
}
