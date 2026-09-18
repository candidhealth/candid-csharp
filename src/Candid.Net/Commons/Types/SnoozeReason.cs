using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Commons;

[JsonConverter(typeof(SnoozeReason.SnoozeReasonSerializer))]
[Serializable]
public readonly record struct SnoozeReason : IStringEnum
{
    public static readonly SnoozeReason PendingAppeal = new(Values.PendingAppeal);

    public static readonly SnoozeReason PendingAdjudication = new(Values.PendingAdjudication);

    public static readonly SnoozeReason PendingReprocessing = new(Values.PendingReprocessing);

    public static readonly SnoozeReason PendingPaymentPosting = new(Values.PendingPaymentPosting);

    public static readonly SnoozeReason PendingEobConversion = new(Values.PendingEobConversion);

    public static readonly SnoozeReason PendingCredentialingOrContracting = new(
        Values.PendingCredentialingOrContracting
    );

    public static readonly SnoozeReason PendingDocumentationUpdate = new(
        Values.PendingDocumentationUpdate
    );

    public static readonly SnoozeReason PendingMedicalRecordsReview = new(
        Values.PendingMedicalRecordsReview
    );

    public static readonly SnoozeReason PendingPatientResponse = new(Values.PendingPatientResponse);

    public static readonly SnoozeReason PendingPayerResponse = new(Values.PendingPayerResponse);

    public static readonly SnoozeReason PendingRefundCheck = new(Values.PendingRefundCheck);

    public static readonly SnoozeReason PendingRecoupment = new(Values.PendingRecoupment);

    public static readonly SnoozeReason Other = new(Values.Other);

    public SnoozeReason(string value)
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
    public static SnoozeReason FromCustom(string value)
    {
        return new SnoozeReason(value);
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

    public static bool operator ==(SnoozeReason value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SnoozeReason value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SnoozeReason value) => value.Value;

    public static explicit operator SnoozeReason(string value) => new(value);

    internal class SnoozeReasonSerializer : JsonConverter<SnoozeReason>
    {
        public override SnoozeReason Read(
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
            return new SnoozeReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SnoozeReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SnoozeReason ReadAsPropertyName(
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
            return new SnoozeReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SnoozeReason value,
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
        public const string PendingAppeal = "Pending Appeal";

        public const string PendingAdjudication = "Pending Adjudication";

        public const string PendingReprocessing = "Pending Reprocessing";

        public const string PendingPaymentPosting = "Pending Payment Posting";

        public const string PendingEobConversion = "Pending EOB Conversion";

        public const string PendingCredentialingOrContracting =
            "Pending Credentialing or Contracting";

        public const string PendingDocumentationUpdate = "Pending Documentation Update";

        public const string PendingMedicalRecordsReview = "Pending Medical Records Review";

        public const string PendingPatientResponse = "Pending Patient Response";

        public const string PendingPayerResponse = "Pending Payer Response";

        public const string PendingRefundCheck = "Pending Refund Check";

        public const string PendingRecoupment = "Pending Recoupment";

        public const string Other = "Other";
    }
}
