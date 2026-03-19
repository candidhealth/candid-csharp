using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(IntendedSubmissionMedium.IntendedSubmissionMediumSerializer))]
[Serializable]
public readonly record struct IntendedSubmissionMedium : IStringEnum
{
    public static readonly IntendedSubmissionMedium Paper = new(Values.Paper);

    public static readonly IntendedSubmissionMedium Electronic = new(Values.Electronic);

    public IntendedSubmissionMedium(string value)
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
    public static IntendedSubmissionMedium FromCustom(string value)
    {
        return new IntendedSubmissionMedium(value);
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

    public static bool operator ==(IntendedSubmissionMedium value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(IntendedSubmissionMedium value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(IntendedSubmissionMedium value) => value.Value;

    public static explicit operator IntendedSubmissionMedium(string value) => new(value);

    internal class IntendedSubmissionMediumSerializer : JsonConverter<IntendedSubmissionMedium>
    {
        public override IntendedSubmissionMedium Read(
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
            return new IntendedSubmissionMedium(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            IntendedSubmissionMedium value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override IntendedSubmissionMedium ReadAsPropertyName(
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
            return new IntendedSubmissionMedium(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            IntendedSubmissionMedium value,
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
        public const string Paper = "paper";

        public const string Electronic = "electronic";
    }
}
