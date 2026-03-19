using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

[JsonConverter(typeof(ContactPointUse.ContactPointUseSerializer))]
[Serializable]
public readonly record struct ContactPointUse : IStringEnum
{
    public static readonly ContactPointUse Home = new(Values.Home);

    public static readonly ContactPointUse Work = new(Values.Work);

    public static readonly ContactPointUse Temp = new(Values.Temp);

    public static readonly ContactPointUse Old = new(Values.Old);

    public static readonly ContactPointUse Mobile = new(Values.Mobile);

    public ContactPointUse(string value)
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
    public static ContactPointUse FromCustom(string value)
    {
        return new ContactPointUse(value);
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

    public static bool operator ==(ContactPointUse value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ContactPointUse value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ContactPointUse value) => value.Value;

    public static explicit operator ContactPointUse(string value) => new(value);

    internal class ContactPointUseSerializer : JsonConverter<ContactPointUse>
    {
        public override ContactPointUse Read(
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
            return new ContactPointUse(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ContactPointUse value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ContactPointUse ReadAsPropertyName(
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
            return new ContactPointUse(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ContactPointUse value,
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
        public const string Home = "HOME";

        public const string Work = "WORK";

        public const string Temp = "TEMP";

        public const string Old = "OLD";

        public const string Mobile = "MOBILE";
    }
}
