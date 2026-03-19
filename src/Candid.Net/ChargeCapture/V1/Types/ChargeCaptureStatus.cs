using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.ChargeCapture.V1;

[JsonConverter(typeof(ChargeCaptureStatus.ChargeCaptureStatusSerializer))]
[Serializable]
public readonly record struct ChargeCaptureStatus : IStringEnum
{
    public static readonly ChargeCaptureStatus Planned = new(Values.Planned);

    public static readonly ChargeCaptureStatus NotBillable = new(Values.NotBillable);

    public static readonly ChargeCaptureStatus Billable = new(Values.Billable);

    public static readonly ChargeCaptureStatus Aborted = new(Values.Aborted);

    public static readonly ChargeCaptureStatus EnteredInError = new(Values.EnteredInError);

    public ChargeCaptureStatus(string value)
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
    public static ChargeCaptureStatus FromCustom(string value)
    {
        return new ChargeCaptureStatus(value);
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

    public static bool operator ==(ChargeCaptureStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ChargeCaptureStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ChargeCaptureStatus value) => value.Value;

    public static explicit operator ChargeCaptureStatus(string value) => new(value);

    internal class ChargeCaptureStatusSerializer : JsonConverter<ChargeCaptureStatus>
    {
        public override ChargeCaptureStatus Read(
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
            return new ChargeCaptureStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChargeCaptureStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChargeCaptureStatus ReadAsPropertyName(
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
            return new ChargeCaptureStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChargeCaptureStatus value,
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
        public const string Planned = "planned";

        public const string NotBillable = "not-billable";

        public const string Billable = "billable";

        public const string Aborted = "aborted";

        public const string EnteredInError = "entered-in-error";
    }
}
