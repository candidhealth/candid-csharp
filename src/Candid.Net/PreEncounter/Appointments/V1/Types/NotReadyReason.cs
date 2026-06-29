using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Appointments.V1;

[JsonConverter(typeof(NotReadyReason.NotReadyReasonSerializer))]
[Serializable]
public readonly record struct NotReadyReason : IStringEnum
{
    public static readonly NotReadyReason InactivePrimary = new(Values.InactivePrimary);

    public static readonly NotReadyReason InactiveSecondary = new(Values.InactiveSecondary);

    public static readonly NotReadyReason MedicareAdvantageConversion = new(
        Values.MedicareAdvantageConversion
    );

    public static readonly NotReadyReason MedicaidManagedConversion = new(
        Values.MedicaidManagedConversion
    );

    public static readonly NotReadyReason UnavailablePrimary = new(Values.UnavailablePrimary);

    public static readonly NotReadyReason UnavailableSecondary = new(Values.UnavailableSecondary);

    public static readonly NotReadyReason PendingPrimary = new(Values.PendingPrimary);

    public static readonly NotReadyReason PendingSecondary = new(Values.PendingSecondary);

    public static readonly NotReadyReason EligibilityCheckFailedPrimary = new(
        Values.EligibilityCheckFailedPrimary
    );

    public static readonly NotReadyReason EligibilityCheckFailedSecondary = new(
        Values.EligibilityCheckFailedSecondary
    );

    public static readonly NotReadyReason NewCombo = new(Values.NewCombo);

    public static readonly NotReadyReason NoCoverage = new(Values.NoCoverage);

    public static readonly NotReadyReason Error = new(Values.Error);

    public static readonly NotReadyReason Manual = new(Values.Manual);

    public NotReadyReason(string value)
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
    public static NotReadyReason FromCustom(string value)
    {
        return new NotReadyReason(value);
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

    public static bool operator ==(NotReadyReason value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(NotReadyReason value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(NotReadyReason value) => value.Value;

    public static explicit operator NotReadyReason(string value) => new(value);

    internal class NotReadyReasonSerializer : JsonConverter<NotReadyReason>
    {
        public override NotReadyReason Read(
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
            return new NotReadyReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            NotReadyReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override NotReadyReason ReadAsPropertyName(
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
            return new NotReadyReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            NotReadyReason value,
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
        public const string InactivePrimary = "INACTIVE_PRIMARY";

        public const string InactiveSecondary = "INACTIVE_SECONDARY";

        public const string MedicareAdvantageConversion = "MEDICARE_ADVANTAGE_CONVERSION";

        public const string MedicaidManagedConversion = "MEDICAID_MANAGED_CONVERSION";

        public const string UnavailablePrimary = "UNAVAILABLE_PRIMARY";

        public const string UnavailableSecondary = "UNAVAILABLE_SECONDARY";

        public const string PendingPrimary = "PENDING_PRIMARY";

        public const string PendingSecondary = "PENDING_SECONDARY";

        public const string EligibilityCheckFailedPrimary = "ELIGIBILITY_CHECK_FAILED_PRIMARY";

        public const string EligibilityCheckFailedSecondary = "ELIGIBILITY_CHECK_FAILED_SECONDARY";

        public const string NewCombo = "NEW_COMBO";

        public const string NoCoverage = "NO_COVERAGE";

        public const string Error = "ERROR";

        public const string Manual = "MANUAL";
    }
}
