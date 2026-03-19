using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.ChargeCaptureBundles.V1;

[JsonConverter(
    typeof(ChargeCaptureClaimCreationSortField.ChargeCaptureClaimCreationSortFieldSerializer)
)]
[Serializable]
public readonly record struct ChargeCaptureClaimCreationSortField : IStringEnum
{
    public static readonly ChargeCaptureClaimCreationSortField CreatedAt = new(Values.CreatedAt);

    public ChargeCaptureClaimCreationSortField(string value)
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
    public static ChargeCaptureClaimCreationSortField FromCustom(string value)
    {
        return new ChargeCaptureClaimCreationSortField(value);
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

    public static bool operator ==(ChargeCaptureClaimCreationSortField value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ChargeCaptureClaimCreationSortField value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ChargeCaptureClaimCreationSortField value) =>
        value.Value;

    public static explicit operator ChargeCaptureClaimCreationSortField(string value) => new(value);

    internal class ChargeCaptureClaimCreationSortFieldSerializer
        : JsonConverter<ChargeCaptureClaimCreationSortField>
    {
        public override ChargeCaptureClaimCreationSortField Read(
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
            return new ChargeCaptureClaimCreationSortField(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChargeCaptureClaimCreationSortField value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChargeCaptureClaimCreationSortField ReadAsPropertyName(
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
            return new ChargeCaptureClaimCreationSortField(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChargeCaptureClaimCreationSortField value,
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
        public const string CreatedAt = "created_at";
    }
}
