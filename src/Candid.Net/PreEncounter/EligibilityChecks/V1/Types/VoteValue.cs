using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[JsonConverter(typeof(VoteValue.VoteValueSerializer))]
[Serializable]
public readonly record struct VoteValue : IStringEnum
{
    public static readonly VoteValue Upvote = new(Values.Upvote);

    public static readonly VoteValue Downvote = new(Values.Downvote);

    public VoteValue(string value)
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
    public static VoteValue FromCustom(string value)
    {
        return new VoteValue(value);
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

    public static bool operator ==(VoteValue value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(VoteValue value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(VoteValue value) => value.Value;

    public static explicit operator VoteValue(string value) => new(value);

    internal class VoteValueSerializer : JsonConverter<VoteValue>
    {
        public override VoteValue Read(
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
            return new VoteValue(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            VoteValue value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override VoteValue ReadAsPropertyName(
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
            return new VoteValue(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            VoteValue value,
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
        public const string Upvote = "UPVOTE";

        public const string Downvote = "DOWNVOTE";
    }
}
