using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

[JsonConverter(typeof(StringEnumSerializer<ServiceType>))]
public enum ServiceType
{
    [EnumMember(Value = "new_patient_video_appt")]
    NewPatientVideoAppt,

    [EnumMember(Value = "new_patient_prev_video_appt")]
    NewPatientPrevVideoAppt,

    [EnumMember(Value = "new_patient_office_appt")]
    NewPatientOfficeAppt,

    [EnumMember(Value = "established_patient_video_appt")]
    EstablishedPatientVideoAppt,

    [EnumMember(Value = "established_patient_prev_video_appt")]
    EstablishedPatientPrevVideoAppt,

    [EnumMember(Value = "established_patient_office_appt")]
    EstablishedPatientOfficeAppt,

    [EnumMember(Value = "patient_portal_with_qualified_physician")]
    PatientPortalWithQualifiedPhysician,

    [EnumMember(Value = "patient_portal_with_non_qualified_physician")]
    PatientPortalWithNonQualifiedPhysician,

    [EnumMember(Value = "group_therapy")]
    GroupTherapy,

    [EnumMember(Value = "phone_appt")]
    PhoneAppt,

    [EnumMember(Value = "annual_wellness_visit")]
    AnnualWellnessVisit,

    [EnumMember(Value = "remote_patient_monitoring")]
    RemotePatientMonitoring,

    [EnumMember(Value = "diagnostic")]
    Diagnostic,

    [EnumMember(Value = "cardiac_monitoring")]
    CardiacMonitoring,

    [EnumMember(Value = "cardiac_codes")]
    CardiacCodes,

    [EnumMember(Value = "psychotherapy")]
    Psychotherapy,

    [EnumMember(Value = "phone_therapy")]
    PhoneTherapy,

    [EnumMember(Value = "alcohol_abuse")]
    AlcoholAbuse,

    [EnumMember(Value = "smoking_cessation")]
    SmokingCessation,

    [EnumMember(Value = "speech_therapy")]
    SpeechTherapy,

    [EnumMember(Value = "home_visit")]
    HomeVisit,

    [EnumMember(Value = "medical_nutrition_therapy")]
    MedicalNutritionTherapy,

    [EnumMember(Value = "nutritional_counseling")]
    NutritionalCounseling,

    [EnumMember(Value = "dietitian_visit")]
    DietitianVisit,

    [EnumMember(Value = "preventative_medicine_counseling")]
    PreventativeMedicineCounseling,

    [EnumMember(Value = "chronic_care")]
    ChronicCare,

    [EnumMember(Value = "advance_care")]
    AdvanceCare,

    [EnumMember(Value = "collaborative_care_management")]
    CollaborativeCareManagement,

    [EnumMember(Value = "abortion_care")]
    AbortionCare,

    [EnumMember(Value = "abortion_drugs")]
    AbortionDrugs,

    [EnumMember(Value = "remote_therapeutic_monitoring")]
    RemoteTherapeuticMonitoring,

    [EnumMember(Value = "principal_care_mgmt")]
    PrincipalCareMgmt,

    [EnumMember(Value = "other_em")]
    OtherEm,

    [EnumMember(Value = "telehealth_oud")]
    TelehealthOud,

    [EnumMember(Value = "substance_abuse_treatment")]
    SubstanceAbuseTreatment,

    [EnumMember(Value = "acupuncture")]
    Acupuncture,

    [EnumMember(Value = "physical_therapy")]
    PhysicalTherapy,

    [EnumMember(Value = "lactation_consulting")]
    LactationConsulting,

    [EnumMember(Value = "sleep_study")]
    SleepStudy,

    [EnumMember(Value = "cms_telehealth_codes")]
    CmsTelehealthCodes,

    [EnumMember(Value = "cms_telehealth_audio_codes")]
    CmsTelehealthAudioCodes,
}
