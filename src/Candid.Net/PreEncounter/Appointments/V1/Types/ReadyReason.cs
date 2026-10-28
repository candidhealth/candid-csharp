using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Appointments.V1;

[JsonConverter(typeof(ReadyReason.ReadyReasonSerializer))]
[Serializable]
public readonly record struct ReadyReason : IStringEnum
{
    public static readonly ReadyReason ReviewedRte = new(Values.ReviewedRte);

    public static readonly ReadyReason CheckedPayerPortal = new(Values.CheckedPayerPortal);

    public static readonly ReadyReason CalledPayer = new(Values.CalledPayer);

    public static readonly ReadyReason PriorAppointmentReady = new(Values.PriorAppointmentReady);

    public ReadyReason(string value)
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
    public static ReadyReason FromCustom(string value)
    {
        return new ReadyReason(value);
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

    public static bool operator ==(ReadyReason value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReadyReason value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReadyReason value) => value.Value;

    public static explicit operator ReadyReason(string value) => new(value);

    internal class ReadyReasonSerializer : JsonConverter<ReadyReason>
    {
        public override ReadyReason Read(
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
            return new ReadyReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ReadyReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ReadyReason ReadAsPropertyName(
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
            return new ReadyReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ReadyReason value,
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
        public const string ReviewedRte = "REVIEWED_RTE";

        public const string CheckedPayerPortal = "CHECKED_PAYER_PORTAL";

        public const string CalledPayer = "CALLED_PAYER";

        public const string PriorAppointmentReady = "PRIOR_APPOINTMENT_READY";
    }
}
