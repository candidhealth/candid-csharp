using System.Text.Json;
using System.Text.Json.Serialization;
using global::Candid.Net.Core;

namespace Candid.Net.ChargeCaptureBundles.V1;

[JsonConverter(typeof(ChargeCaptureClaimCreationStatus.ChargeCaptureClaimCreationStatusSerializer))]
[Serializable]
public readonly record struct ChargeCaptureClaimCreationStatus : IStringEnum
{
    public static readonly ChargeCaptureClaimCreationStatus NotStarted = new(Values.NotStarted);

    public static readonly ChargeCaptureClaimCreationStatus InError = new(Values.InError);

    public static readonly ChargeCaptureClaimCreationStatus Successful = new(Values.Successful);

    public static readonly ChargeCaptureClaimCreationStatus SuccessfulDryRun = new(
        Values.SuccessfulDryRun
    );

    public static readonly ChargeCaptureClaimCreationStatus Aborted = new(Values.Aborted);

    /// <summary>
    /// This Claim Creation has potential charges that are in a planned state, the Claim Creation will be held until those charges are converted
    /// </summary>
    public static readonly ChargeCaptureClaimCreationStatus Held = new(Values.Held);

    public ChargeCaptureClaimCreationStatus(string value)
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
    public static ChargeCaptureClaimCreationStatus FromCustom(string value)
    {
        return new ChargeCaptureClaimCreationStatus(value);
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

    public static bool operator ==(ChargeCaptureClaimCreationStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ChargeCaptureClaimCreationStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ChargeCaptureClaimCreationStatus value) => value.Value;

    public static explicit operator ChargeCaptureClaimCreationStatus(string value) => new(value);

    internal class ChargeCaptureClaimCreationStatusSerializer
        : JsonConverter<ChargeCaptureClaimCreationStatus>
    {
        public override ChargeCaptureClaimCreationStatus Read(
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
            return new ChargeCaptureClaimCreationStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChargeCaptureClaimCreationStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChargeCaptureClaimCreationStatus ReadAsPropertyName(
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
            return new ChargeCaptureClaimCreationStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChargeCaptureClaimCreationStatus value,
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
        public const string NotStarted = "not-started";

        public const string InError = "in-error";

        public const string Successful = "successful";

        public const string SuccessfulDryRun = "successful-dry-run";

        public const string Aborted = "aborted";

        /// <summary>
        /// This Claim Creation has potential charges that are in a planned state, the Claim Creation will be held until those charges are converted
        /// </summary>
        public const string Held = "held";
    }
}
