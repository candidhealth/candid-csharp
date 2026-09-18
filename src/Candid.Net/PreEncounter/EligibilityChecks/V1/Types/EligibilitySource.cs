using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[JsonConverter(typeof(EligibilitySource.EligibilitySourceSerializer))]
[Serializable]
public readonly record struct EligibilitySource : IStringEnum
{
    public static readonly EligibilitySource Stedi = new(Values.Stedi);

    public static readonly EligibilitySource Availity = new(Values.Availity);

    public static readonly EligibilitySource PhoneAgent = new(Values.PhoneAgent);

    public static readonly EligibilitySource BrowserAgent = new(Values.BrowserAgent);

    public EligibilitySource(string value)
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
    public static EligibilitySource FromCustom(string value)
    {
        return new EligibilitySource(value);
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

    public static bool operator ==(EligibilitySource value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EligibilitySource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EligibilitySource value) => value.Value;

    public static explicit operator EligibilitySource(string value) => new(value);

    internal class EligibilitySourceSerializer : JsonConverter<EligibilitySource>
    {
        public override EligibilitySource Read(
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
            return new EligibilitySource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EligibilitySource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EligibilitySource ReadAsPropertyName(
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
            return new EligibilitySource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EligibilitySource value,
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
        public const string Stedi = "STEDI";

        public const string Availity = "AVAILITY";

        public const string PhoneAgent = "PHONE_AGENT";

        public const string BrowserAgent = "BROWSER_AGENT";
    }
}
