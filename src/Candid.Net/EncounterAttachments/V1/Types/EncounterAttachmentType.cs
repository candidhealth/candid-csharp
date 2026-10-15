using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EncounterAttachments.V1;

[JsonConverter(typeof(EncounterAttachmentType.EncounterAttachmentTypeSerializer))]
[Serializable]
public readonly record struct EncounterAttachmentType : IStringEnum
{
    public static readonly EncounterAttachmentType AppealLetter = new(Values.AppealLetter);

    public static readonly EncounterAttachmentType Certification = new(Values.Certification);

    public static readonly EncounterAttachmentType ConsentForm = new(Values.ConsentForm);

    public static readonly EncounterAttachmentType Documentation = new(Values.Documentation);

    public static readonly EncounterAttachmentType Eob = new(Values.Eob);

    public static readonly EncounterAttachmentType JustificationOfAdmission = new(
        Values.JustificationOfAdmission
    );

    public static readonly EncounterAttachmentType LaboratoryResults = new(
        Values.LaboratoryResults
    );

    public static readonly EncounterAttachmentType MedicalRecordAttachment = new(
        Values.MedicalRecordAttachment
    );

    public static readonly EncounterAttachmentType OperativeNote = new(Values.OperativeNote);

    public static readonly EncounterAttachmentType Other = new(Values.Other);

    public static readonly EncounterAttachmentType PhysicalTherapyNote = new(
        Values.PhysicalTherapyNote
    );

    public static readonly EncounterAttachmentType ReferralForm = new(Values.ReferralForm);

    public static readonly EncounterAttachmentType SupportDataForClaim = new(
        Values.SupportDataForClaim
    );

    public EncounterAttachmentType(string value)
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
    public static EncounterAttachmentType FromCustom(string value)
    {
        return new EncounterAttachmentType(value);
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

    public static bool operator ==(EncounterAttachmentType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EncounterAttachmentType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EncounterAttachmentType value) => value.Value;

    public static explicit operator EncounterAttachmentType(string value) => new(value);

    internal class EncounterAttachmentTypeSerializer : JsonConverter<EncounterAttachmentType>
    {
        public override EncounterAttachmentType Read(
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
            return new EncounterAttachmentType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EncounterAttachmentType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EncounterAttachmentType ReadAsPropertyName(
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
            return new EncounterAttachmentType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EncounterAttachmentType value,
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
        public const string AppealLetter = "APPEAL_LETTER";

        public const string Certification = "CERTIFICATION";

        public const string ConsentForm = "CONSENT_FORM";

        public const string Documentation = "DOCUMENTATION";

        public const string Eob = "EOB";

        public const string JustificationOfAdmission = "JUSTIFICATION_OF_ADMISSION";

        public const string LaboratoryResults = "LABORATORY_RESULTS";

        public const string MedicalRecordAttachment = "MEDICAL_RECORD_ATTACHMENT";

        public const string OperativeNote = "OPERATIVE_NOTE";

        public const string Other = "OTHER";

        public const string PhysicalTherapyNote = "PHYSICAL_THERAPY_NOTE";

        public const string ReferralForm = "REFERRAL_FORM";

        public const string SupportDataForClaim = "SUPPORT_DATA_FOR_CLAIM";
    }
}
