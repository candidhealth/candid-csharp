using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<NoteCategory>))]
[Serializable]
public readonly record struct NoteCategory : IStringEnum
{
    public static readonly NoteCategory Clinical = new(Values.Clinical);

    public static readonly NoteCategory CarePlan = new(Values.CarePlan);

    public static readonly NoteCategory Diagnoses = new(Values.Diagnoses);

    public static readonly NoteCategory Vitals = new(Values.Vitals);

    public static readonly NoteCategory PhysicalExam = new(Values.PhysicalExam);

    public static readonly NoteCategory ReviewOfSystems = new(Values.ReviewOfSystems);

    public static readonly NoteCategory MedicalDecisions = new(Values.MedicalDecisions);

    public static readonly NoteCategory HistoryOfPresentIllness = new(
        Values.HistoryOfPresentIllness
    );

    public static readonly NoteCategory PatientInfo = new(Values.PatientInfo);

    public static readonly NoteCategory ChiefComplaint = new(Values.ChiefComplaint);

    public static readonly NoteCategory HealthRecord = new(Values.HealthRecord);

    public static readonly NoteCategory Consent = new(Values.Consent);

    public static readonly NoteCategory Procedure = new(Values.Procedure);

    public static readonly NoteCategory TimeInAppointment = new(Values.TimeInAppointment);

    public NoteCategory(string value)
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
    public static NoteCategory FromCustom(string value)
    {
        return new NoteCategory(value);
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

    public static bool operator ==(NoteCategory value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(NoteCategory value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(NoteCategory value) => value.Value;

    public static explicit operator NoteCategory(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Clinical = "clinical";

        public const string CarePlan = "care_plan";

        public const string Diagnoses = "diagnoses";

        public const string Vitals = "vitals";

        public const string PhysicalExam = "physical_exam";

        public const string ReviewOfSystems = "review_of_systems";

        public const string MedicalDecisions = "medical_decisions";

        public const string HistoryOfPresentIllness = "history_of_present_illness";

        public const string PatientInfo = "patient_info";

        public const string ChiefComplaint = "chief_complaint";

        public const string HealthRecord = "health_record";

        public const string Consent = "consent";

        public const string Procedure = "procedure";

        public const string TimeInAppointment = "time_in_appointment";
    }
}
