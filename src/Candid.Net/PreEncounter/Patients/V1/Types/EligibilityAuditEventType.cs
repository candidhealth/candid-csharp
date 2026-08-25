using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(EligibilityAuditEventType.EligibilityAuditEventTypeSerializer))]
[Serializable]
public readonly record struct EligibilityAuditEventType : IStringEnum
{
    public static readonly EligibilityAuditEventType AppointmentStatusChanged = new(
        Values.AppointmentStatusChanged
    );

    public static readonly EligibilityAuditEventType AppointmentWorkQueueChanged = new(
        Values.AppointmentWorkQueueChanged
    );

    public static readonly EligibilityAuditEventType AppointmentCopayUpdated = new(
        Values.AppointmentCopayUpdated
    );

    public static readonly EligibilityAuditEventType CoverageCreated = new(Values.CoverageCreated);

    public static readonly EligibilityAuditEventType CoverageUpdated = new(Values.CoverageUpdated);

    public static readonly EligibilityAuditEventType EligCheckCompleted = new(
        Values.EligCheckCompleted
    );

    public static readonly EligibilityAuditEventType PatientTagsUpdated = new(
        Values.PatientTagsUpdated
    );

    public EligibilityAuditEventType(string value)
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
    public static EligibilityAuditEventType FromCustom(string value)
    {
        return new EligibilityAuditEventType(value);
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

    public static bool operator ==(EligibilityAuditEventType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EligibilityAuditEventType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EligibilityAuditEventType value) => value.Value;

    public static explicit operator EligibilityAuditEventType(string value) => new(value);

    internal class EligibilityAuditEventTypeSerializer : JsonConverter<EligibilityAuditEventType>
    {
        public override EligibilityAuditEventType Read(
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
            return new EligibilityAuditEventType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EligibilityAuditEventType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EligibilityAuditEventType ReadAsPropertyName(
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
            return new EligibilityAuditEventType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EligibilityAuditEventType value,
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
        public const string AppointmentStatusChanged = "APPOINTMENT_STATUS_CHANGED";

        public const string AppointmentWorkQueueChanged = "APPOINTMENT_WORK_QUEUE_CHANGED";

        public const string AppointmentCopayUpdated = "APPOINTMENT_COPAY_UPDATED";

        public const string CoverageCreated = "COVERAGE_CREATED";

        public const string CoverageUpdated = "COVERAGE_UPDATED";

        public const string EligCheckCompleted = "ELIG_CHECK_COMPLETED";

        public const string PatientTagsUpdated = "PATIENT_TAGS_UPDATED";
    }
}
