using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Encounters.V4;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<NoteCategory>))]
public enum NoteCategory
{
    [EnumMember(Value = "clinical")]
    Clinical,

    [EnumMember(Value = "care_plan")]
    CarePlan,

    [EnumMember(Value = "diagnoses")]
    Diagnoses,

    [EnumMember(Value = "vitals")]
    Vitals,

    [EnumMember(Value = "physical_exam")]
    PhysicalExam,

    [EnumMember(Value = "review_of_systems")]
    ReviewOfSystems,

    [EnumMember(Value = "medical_decisions")]
    MedicalDecisions,

    [EnumMember(Value = "history_of_present_illness")]
    HistoryOfPresentIllness,

    [EnumMember(Value = "patient_info")]
    PatientInfo,

    [EnumMember(Value = "chief_complaint")]
    ChiefComplaint,

    [EnumMember(Value = "health_record")]
    HealthRecord,

    [EnumMember(Value = "consent")]
    Consent,

    [EnumMember(Value = "procedure")]
    Procedure,

    [EnumMember(Value = "time_in_appointment")]
    TimeInAppointment
}
