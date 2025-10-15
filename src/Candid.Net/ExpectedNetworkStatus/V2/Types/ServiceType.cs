using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V2;

[JsonConverter(typeof(StringEnumSerializer<ServiceType>))]
[Serializable]
public readonly record struct ServiceType : IStringEnum
{
    public static readonly ServiceType NewPatientVideoAppt = new(Values.NewPatientVideoAppt);

    public static readonly ServiceType NewPatientPrevVideoAppt = new(
        Values.NewPatientPrevVideoAppt
    );

    public static readonly ServiceType NewPatientOfficeAppt = new(Values.NewPatientOfficeAppt);

    public static readonly ServiceType EstablishedPatientVideoAppt = new(
        Values.EstablishedPatientVideoAppt
    );

    public static readonly ServiceType EstablishedPatientPrevVideoAppt = new(
        Values.EstablishedPatientPrevVideoAppt
    );

    public static readonly ServiceType EstablishedPatientOfficeAppt = new(
        Values.EstablishedPatientOfficeAppt
    );

    public static readonly ServiceType PatientPortalWithQualifiedPhysician = new(
        Values.PatientPortalWithQualifiedPhysician
    );

    public static readonly ServiceType PatientPortalWithNonQualifiedPhysician = new(
        Values.PatientPortalWithNonQualifiedPhysician
    );

    public static readonly ServiceType GroupTherapy = new(Values.GroupTherapy);

    public static readonly ServiceType PhoneAppt = new(Values.PhoneAppt);

    public static readonly ServiceType AnnualWellnessVisit = new(Values.AnnualWellnessVisit);

    public static readonly ServiceType RemotePatientMonitoring = new(
        Values.RemotePatientMonitoring
    );

    public static readonly ServiceType Diagnostic = new(Values.Diagnostic);

    public static readonly ServiceType CardiacMonitoring = new(Values.CardiacMonitoring);

    public static readonly ServiceType CardiacCodes = new(Values.CardiacCodes);

    public static readonly ServiceType Psychotherapy = new(Values.Psychotherapy);

    public static readonly ServiceType PhoneTherapy = new(Values.PhoneTherapy);

    public static readonly ServiceType AlcoholAbuse = new(Values.AlcoholAbuse);

    public static readonly ServiceType SmokingCessation = new(Values.SmokingCessation);

    public static readonly ServiceType SpeechTherapy = new(Values.SpeechTherapy);

    public static readonly ServiceType HomeVisit = new(Values.HomeVisit);

    public static readonly ServiceType MedicalNutritionTherapy = new(
        Values.MedicalNutritionTherapy
    );

    public static readonly ServiceType NutritionalCounseling = new(Values.NutritionalCounseling);

    public static readonly ServiceType DietitianVisit = new(Values.DietitianVisit);

    public static readonly ServiceType PreventativeMedicineCounseling = new(
        Values.PreventativeMedicineCounseling
    );

    public static readonly ServiceType ChronicCare = new(Values.ChronicCare);

    public static readonly ServiceType AdvanceCare = new(Values.AdvanceCare);

    public static readonly ServiceType CollaborativeCareManagement = new(
        Values.CollaborativeCareManagement
    );

    public static readonly ServiceType AbortionCare = new(Values.AbortionCare);

    public static readonly ServiceType AbortionDrugs = new(Values.AbortionDrugs);

    public static readonly ServiceType RemoteTherapeuticMonitoring = new(
        Values.RemoteTherapeuticMonitoring
    );

    public static readonly ServiceType PrincipalCareMgmt = new(Values.PrincipalCareMgmt);

    public static readonly ServiceType OtherEm = new(Values.OtherEm);

    public static readonly ServiceType TelehealthOud = new(Values.TelehealthOud);

    public static readonly ServiceType SubstanceAbuseTreatment = new(
        Values.SubstanceAbuseTreatment
    );

    public static readonly ServiceType Acupuncture = new(Values.Acupuncture);

    public static readonly ServiceType PhysicalTherapy = new(Values.PhysicalTherapy);

    public static readonly ServiceType LactationConsulting = new(Values.LactationConsulting);

    public static readonly ServiceType SleepStudy = new(Values.SleepStudy);

    public static readonly ServiceType CmsTelehealthCodes = new(Values.CmsTelehealthCodes);

    public static readonly ServiceType CmsTelehealthAudioCodes = new(
        Values.CmsTelehealthAudioCodes
    );

    public ServiceType(string value)
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
    public static ServiceType FromCustom(string value)
    {
        return new ServiceType(value);
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

    public static bool operator ==(ServiceType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ServiceType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ServiceType value) => value.Value;

    public static explicit operator ServiceType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string NewPatientVideoAppt = "new_patient_video_appt";

        public const string NewPatientPrevVideoAppt = "new_patient_prev_video_appt";

        public const string NewPatientOfficeAppt = "new_patient_office_appt";

        public const string EstablishedPatientVideoAppt = "established_patient_video_appt";

        public const string EstablishedPatientPrevVideoAppt = "established_patient_prev_video_appt";

        public const string EstablishedPatientOfficeAppt = "established_patient_office_appt";

        public const string PatientPortalWithQualifiedPhysician =
            "patient_portal_with_qualified_physician";

        public const string PatientPortalWithNonQualifiedPhysician =
            "patient_portal_with_non_qualified_physician";

        public const string GroupTherapy = "group_therapy";

        public const string PhoneAppt = "phone_appt";

        public const string AnnualWellnessVisit = "annual_wellness_visit";

        public const string RemotePatientMonitoring = "remote_patient_monitoring";

        public const string Diagnostic = "diagnostic";

        public const string CardiacMonitoring = "cardiac_monitoring";

        public const string CardiacCodes = "cardiac_codes";

        public const string Psychotherapy = "psychotherapy";

        public const string PhoneTherapy = "phone_therapy";

        public const string AlcoholAbuse = "alcohol_abuse";

        public const string SmokingCessation = "smoking_cessation";

        public const string SpeechTherapy = "speech_therapy";

        public const string HomeVisit = "home_visit";

        public const string MedicalNutritionTherapy = "medical_nutrition_therapy";

        public const string NutritionalCounseling = "nutritional_counseling";

        public const string DietitianVisit = "dietitian_visit";

        public const string PreventativeMedicineCounseling = "preventative_medicine_counseling";

        public const string ChronicCare = "chronic_care";

        public const string AdvanceCare = "advance_care";

        public const string CollaborativeCareManagement = "collaborative_care_management";

        public const string AbortionCare = "abortion_care";

        public const string AbortionDrugs = "abortion_drugs";

        public const string RemoteTherapeuticMonitoring = "remote_therapeutic_monitoring";

        public const string PrincipalCareMgmt = "principal_care_mgmt";

        public const string OtherEm = "other_em";

        public const string TelehealthOud = "telehealth_oud";

        public const string SubstanceAbuseTreatment = "substance_abuse_treatment";

        public const string Acupuncture = "acupuncture";

        public const string PhysicalTherapy = "physical_therapy";

        public const string LactationConsulting = "lactation_consulting";

        public const string SleepStudy = "sleep_study";

        public const string CmsTelehealthCodes = "cms_telehealth_codes";

        public const string CmsTelehealthAudioCodes = "cms_telehealth_audio_codes";
    }
}
