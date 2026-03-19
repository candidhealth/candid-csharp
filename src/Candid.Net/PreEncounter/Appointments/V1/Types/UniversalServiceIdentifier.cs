using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.Appointments.V1;

[JsonConverter(typeof(UniversalServiceIdentifier.UniversalServiceIdentifierSerializer))]
[Serializable]
public readonly record struct UniversalServiceIdentifier : IStringEnum
{
    public static readonly UniversalServiceIdentifier MdVisit = new(Values.MdVisit);

    public static readonly UniversalServiceIdentifier Treatment = new(Values.Treatment);

    public static readonly UniversalServiceIdentifier Tests = new(Values.Tests);

    public static readonly UniversalServiceIdentifier Activity = new(Values.Activity);

    public UniversalServiceIdentifier(string value)
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
    public static UniversalServiceIdentifier FromCustom(string value)
    {
        return new UniversalServiceIdentifier(value);
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

    public static bool operator ==(UniversalServiceIdentifier value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UniversalServiceIdentifier value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UniversalServiceIdentifier value) => value.Value;

    public static explicit operator UniversalServiceIdentifier(string value) => new(value);

    internal class UniversalServiceIdentifierSerializer : JsonConverter<UniversalServiceIdentifier>
    {
        public override UniversalServiceIdentifier Read(
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
            return new UniversalServiceIdentifier(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UniversalServiceIdentifier value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UniversalServiceIdentifier ReadAsPropertyName(
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
            return new UniversalServiceIdentifier(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UniversalServiceIdentifier value,
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
        public const string MdVisit = "MD_Visit";

        public const string Treatment = "Treatment";

        public const string Tests = "Tests";

        public const string Activity = "Activity";
    }
}
