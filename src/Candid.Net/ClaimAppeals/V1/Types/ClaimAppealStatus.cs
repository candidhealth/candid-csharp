using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ClaimAppeals.V1;

[JsonConverter(typeof(ClaimAppealStatus.ClaimAppealStatusSerializer))]
[Serializable]
public readonly record struct ClaimAppealStatus : IStringEnum
{
    public static readonly ClaimAppealStatus Appealable = new(Values.Appealable);

    public static readonly ClaimAppealStatus Preparing = new(Values.Preparing);

    public static readonly ClaimAppealStatus Submitted = new(Values.Submitted);

    public static readonly ClaimAppealStatus RequiresAdditionalInfo = new(
        Values.RequiresAdditionalInfo
    );

    public static readonly ClaimAppealStatus Overturned = new(Values.Overturned);

    public static readonly ClaimAppealStatus Upheld = new(Values.Upheld);

    public static readonly ClaimAppealStatus Dismissed = new(Values.Dismissed);

    public static readonly ClaimAppealStatus Discarded = new(Values.Discarded);

    public ClaimAppealStatus(string value)
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
    public static ClaimAppealStatus FromCustom(string value)
    {
        return new ClaimAppealStatus(value);
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

    public static bool operator ==(ClaimAppealStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ClaimAppealStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ClaimAppealStatus value) => value.Value;

    public static explicit operator ClaimAppealStatus(string value) => new(value);

    internal class ClaimAppealStatusSerializer : JsonConverter<ClaimAppealStatus>
    {
        public override ClaimAppealStatus Read(
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
            return new ClaimAppealStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ClaimAppealStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ClaimAppealStatus ReadAsPropertyName(
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
            return new ClaimAppealStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ClaimAppealStatus value,
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
        public const string Appealable = "appealable";

        public const string Preparing = "preparing";

        public const string Submitted = "submitted";

        public const string RequiresAdditionalInfo = "requires_additional_info";

        public const string Overturned = "overturned";

        public const string Upheld = "upheld";

        public const string Dismissed = "dismissed";

        public const string Discarded = "discarded";
    }
}
