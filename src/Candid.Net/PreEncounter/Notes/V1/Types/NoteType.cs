using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Notes.V1;

[JsonConverter(typeof(NoteType.NoteTypeSerializer))]
[Serializable]
public readonly record struct NoteType : IStringEnum
{
    public static readonly NoteType General = new(Values.General);

    public static readonly NoteType Eligibility = new(Values.Eligibility);

    public NoteType(string value)
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
    public static NoteType FromCustom(string value)
    {
        return new NoteType(value);
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

    public static bool operator ==(NoteType value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(NoteType value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(NoteType value) => value.Value;

    public static explicit operator NoteType(string value) => new(value);

    internal class NoteTypeSerializer : JsonConverter<NoteType>
    {
        public override NoteType Read(
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
            return new NoteType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            NoteType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override NoteType ReadAsPropertyName(
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
            return new NoteType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            NoteType value,
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
        public const string General = "GENERAL";

        public const string Eligibility = "ELIGIBILITY";
    }
}
