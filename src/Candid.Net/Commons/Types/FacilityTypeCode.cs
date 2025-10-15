using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<FacilityTypeCode>))]
[Serializable]
public readonly record struct FacilityTypeCode : IStringEnum
{
    /// <summary>
    /// Pharmacy
    /// </summary>
    public static readonly FacilityTypeCode Pharmacy = new(Values.Pharmacy);

    /// <summary>
    /// Telehealth
    /// </summary>
    public static readonly FacilityTypeCode Telehealth = new(Values.Telehealth);

    /// <summary>
    /// School
    /// </summary>
    public static readonly FacilityTypeCode School = new(Values.School);

    /// <summary>
    /// Homeless Shelter
    /// </summary>
    public static readonly FacilityTypeCode HomelessShelter = new(Values.HomelessShelter);

    /// <summary>
    /// Indian Health Service (Free Standing)
    /// </summary>
    public static readonly FacilityTypeCode IndianHealthServiceFreeStanding = new(
        Values.IndianHealthServiceFreeStanding
    );

    /// <summary>
    /// Indian Health Service (Provider Based)
    /// </summary>
    public static readonly FacilityTypeCode IndianHealthServiceProviderBased = new(
        Values.IndianHealthServiceProviderBased
    );

    /// <summary>
    /// Tribal Free Standing
    /// </summary>
    public static readonly FacilityTypeCode TribalFreeStanding = new(Values.TribalFreeStanding);

    /// <summary>
    /// Tribal Provider Based
    /// </summary>
    public static readonly FacilityTypeCode TribalProviderBased = new(Values.TribalProviderBased);

    /// <summary>
    /// Prison or Correctional Facility
    /// </summary>
    public static readonly FacilityTypeCode PrisonOrCorrectionalFacility = new(
        Values.PrisonOrCorrectionalFacility
    );

    /// <summary>
    /// Telehealth Patient Home
    /// </summary>
    public static readonly FacilityTypeCode TelehealthPatientHome = new(
        Values.TelehealthPatientHome
    );

    /// <summary>
    /// Office
    /// </summary>
    public static readonly FacilityTypeCode Office = new(Values.Office);

    /// <summary>
    /// Home
    /// </summary>
    public static readonly FacilityTypeCode Home = new(Values.Home);

    /// <summary>
    /// Assisted Living Facility
    /// </summary>
    public static readonly FacilityTypeCode AssistedLivingFacility = new(
        Values.AssistedLivingFacility
    );

    /// <summary>
    /// Group Home
    /// </summary>
    public static readonly FacilityTypeCode GroupHome = new(Values.GroupHome);

    /// <summary>
    /// Mobile Unit
    /// </summary>
    public static readonly FacilityTypeCode MobileUnit = new(Values.MobileUnit);

    /// <summary>
    /// Temporary Lodging
    /// </summary>
    public static readonly FacilityTypeCode TemporaryLodging = new(Values.TemporaryLodging);

    /// <summary>
    /// Walk-in Retail Health Clinic
    /// </summary>
    public static readonly FacilityTypeCode WalkInRetailHealthClinic = new(
        Values.WalkInRetailHealthClinic
    );

    /// <summary>
    /// Place of Employment Worksite
    /// </summary>
    public static readonly FacilityTypeCode PlaceOfEmploymentWorksite = new(
        Values.PlaceOfEmploymentWorksite
    );

    /// <summary>
    /// Off Campus Outpatient Hospital
    /// </summary>
    public static readonly FacilityTypeCode OffCampusOutpatientHospital = new(
        Values.OffCampusOutpatientHospital
    );

    /// <summary>
    /// Urgent Care Facility
    /// </summary>
    public static readonly FacilityTypeCode UrgentCareFacility = new(Values.UrgentCareFacility);

    /// <summary>
    /// Inpatient Hospital
    /// </summary>
    public static readonly FacilityTypeCode InpatientHospital = new(Values.InpatientHospital);

    /// <summary>
    /// Outpatient Hospital
    /// </summary>
    public static readonly FacilityTypeCode OutpatientHospital = new(Values.OutpatientHospital);

    /// <summary>
    /// Emergency Room Hospital
    /// </summary>
    public static readonly FacilityTypeCode EmergencyRoomHospital = new(
        Values.EmergencyRoomHospital
    );

    /// <summary>
    /// Ambulatory Surgical Center
    /// </summary>
    public static readonly FacilityTypeCode AmbulatorySurgicalCenter = new(
        Values.AmbulatorySurgicalCenter
    );

    /// <summary>
    /// Birthing Center
    /// </summary>
    public static readonly FacilityTypeCode BirthingCenter = new(Values.BirthingCenter);

    /// <summary>
    /// Military Treatment Facility
    /// </summary>
    public static readonly FacilityTypeCode MilitaryTreatmentFacility = new(
        Values.MilitaryTreatmentFacility
    );

    /// <summary>
    /// Skilled Nursing Facility
    /// </summary>
    public static readonly FacilityTypeCode SkilledNursingFacility = new(
        Values.SkilledNursingFacility
    );

    /// <summary>
    /// Nursing Facility
    /// </summary>
    public static readonly FacilityTypeCode NursingFacility = new(Values.NursingFacility);

    /// <summary>
    /// Custodial Care Facility
    /// </summary>
    public static readonly FacilityTypeCode CustodialCareFacility = new(
        Values.CustodialCareFacility
    );

    /// <summary>
    /// Hospice
    /// </summary>
    public static readonly FacilityTypeCode Hospice = new(Values.Hospice);

    /// <summary>
    /// Ambulance (Land)
    /// </summary>
    public static readonly FacilityTypeCode AmbulanceLand = new(Values.AmbulanceLand);

    /// <summary>
    /// Ambulance (Air or Water)
    /// </summary>
    public static readonly FacilityTypeCode AmbulanceAirOrWater = new(Values.AmbulanceAirOrWater);

    /// <summary>
    /// Independent Clinic
    /// </summary>
    public static readonly FacilityTypeCode IndependentClinic = new(Values.IndependentClinic);

    /// <summary>
    /// Federally Qualified Health Center
    /// </summary>
    public static readonly FacilityTypeCode FederallyQualifiedHealthCenter = new(
        Values.FederallyQualifiedHealthCenter
    );

    /// <summary>
    /// Inpatient Psychiatric Facility
    /// </summary>
    public static readonly FacilityTypeCode InpatientPsychiatricFacility = new(
        Values.InpatientPsychiatricFacility
    );

    /// <summary>
    /// Psychiatric Facility (Partial Hospitalization)
    /// </summary>
    public static readonly FacilityTypeCode PsychiatricFacilityPartialHospitalization = new(
        Values.PsychiatricFacilityPartialHospitalization
    );

    /// <summary>
    /// Community Mental Health Center
    /// </summary>
    public static readonly FacilityTypeCode CommunityMentalHealthCenter = new(
        Values.CommunityMentalHealthCenter
    );

    /// <summary>
    /// Intermediate Care Facility/Individuals with Intellectual Disabilities
    /// </summary>
    public static readonly FacilityTypeCode IntermediateCareFacilityMentallyRetarded = new(
        Values.IntermediateCareFacilityMentallyRetarded
    );

    /// <summary>
    /// Residential Substance Abuse Treatment Facility
    /// </summary>
    public static readonly FacilityTypeCode ResidentialSubstanceAbuseTreatmentFacility = new(
        Values.ResidentialSubstanceAbuseTreatmentFacility
    );

    /// <summary>
    /// Psychiatric Residential Treatment Center
    /// </summary>
    public static readonly FacilityTypeCode PsychiatricResidentialTreatmentCenter = new(
        Values.PsychiatricResidentialTreatmentCenter
    );

    /// <summary>
    /// Non-residential Substance Abuse Treatment Facility
    /// </summary>
    public static readonly FacilityTypeCode NonResidentialSubstanceAbuseTreatmentFacility = new(
        Values.NonResidentialSubstanceAbuseTreatmentFacility
    );

    /// <summary>
    /// Non-residential Opioid Treatment Facility
    /// </summary>
    public static readonly FacilityTypeCode NonResidentialOpioidTreatmentFacility = new(
        Values.NonResidentialOpioidTreatmentFacility
    );

    /// <summary>
    /// Mass Immunization Center
    /// </summary>
    public static readonly FacilityTypeCode MassImmunizationCenter = new(
        Values.MassImmunizationCenter
    );

    /// <summary>
    /// Comprehensive Inpatient Rehabilitation Facility
    /// </summary>
    public static readonly FacilityTypeCode ComprehensiveInpatientRehabilitationFacility = new(
        Values.ComprehensiveInpatientRehabilitationFacility
    );

    /// <summary>
    /// Comprehensive Outpatient Rehabilitation Facility
    /// </summary>
    public static readonly FacilityTypeCode ComprehensiveOutpatientRehabilitationFacility = new(
        Values.ComprehensiveOutpatientRehabilitationFacility
    );

    /// <summary>
    /// End Stage Renal Disease Treatment Facility
    /// </summary>
    public static readonly FacilityTypeCode EndStageRenalDiseaseTreatmentFacility = new(
        Values.EndStageRenalDiseaseTreatmentFacility
    );

    /// <summary>
    /// State or Local Public Health Clinic
    /// </summary>
    public static readonly FacilityTypeCode StateOrLocalPublicHealthClinic = new(
        Values.StateOrLocalPublicHealthClinic
    );

    /// <summary>
    /// Rural Health Clinic
    /// </summary>
    public static readonly FacilityTypeCode RuralHealthClinic = new(Values.RuralHealthClinic);

    /// <summary>
    /// Independent Laboratory
    /// </summary>
    public static readonly FacilityTypeCode IndependentLaboratory = new(
        Values.IndependentLaboratory
    );

    /// <summary>
    /// Other Unlisted Facility
    /// </summary>
    public static readonly FacilityTypeCode OtherUnlistedFacility = new(
        Values.OtherUnlistedFacility
    );

    public FacilityTypeCode(string value)
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
    public static FacilityTypeCode FromCustom(string value)
    {
        return new FacilityTypeCode(value);
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

    public static bool operator ==(FacilityTypeCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FacilityTypeCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FacilityTypeCode value) => value.Value;

    public static explicit operator FacilityTypeCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Pharmacy
        /// </summary>
        public const string Pharmacy = "01";

        /// <summary>
        /// Telehealth
        /// </summary>
        public const string Telehealth = "02";

        /// <summary>
        /// School
        /// </summary>
        public const string School = "03";

        /// <summary>
        /// Homeless Shelter
        /// </summary>
        public const string HomelessShelter = "04";

        /// <summary>
        /// Indian Health Service (Free Standing)
        /// </summary>
        public const string IndianHealthServiceFreeStanding = "05";

        /// <summary>
        /// Indian Health Service (Provider Based)
        /// </summary>
        public const string IndianHealthServiceProviderBased = "06";

        /// <summary>
        /// Tribal Free Standing
        /// </summary>
        public const string TribalFreeStanding = "07";

        /// <summary>
        /// Tribal Provider Based
        /// </summary>
        public const string TribalProviderBased = "08";

        /// <summary>
        /// Prison or Correctional Facility
        /// </summary>
        public const string PrisonOrCorrectionalFacility = "09";

        /// <summary>
        /// Telehealth Patient Home
        /// </summary>
        public const string TelehealthPatientHome = "10";

        /// <summary>
        /// Office
        /// </summary>
        public const string Office = "11";

        /// <summary>
        /// Home
        /// </summary>
        public const string Home = "12";

        /// <summary>
        /// Assisted Living Facility
        /// </summary>
        public const string AssistedLivingFacility = "13";

        /// <summary>
        /// Group Home
        /// </summary>
        public const string GroupHome = "14";

        /// <summary>
        /// Mobile Unit
        /// </summary>
        public const string MobileUnit = "15";

        /// <summary>
        /// Temporary Lodging
        /// </summary>
        public const string TemporaryLodging = "16";

        /// <summary>
        /// Walk-in Retail Health Clinic
        /// </summary>
        public const string WalkInRetailHealthClinic = "17";

        /// <summary>
        /// Place of Employment Worksite
        /// </summary>
        public const string PlaceOfEmploymentWorksite = "18";

        /// <summary>
        /// Off Campus Outpatient Hospital
        /// </summary>
        public const string OffCampusOutpatientHospital = "19";

        /// <summary>
        /// Urgent Care Facility
        /// </summary>
        public const string UrgentCareFacility = "20";

        /// <summary>
        /// Inpatient Hospital
        /// </summary>
        public const string InpatientHospital = "21";

        /// <summary>
        /// Outpatient Hospital
        /// </summary>
        public const string OutpatientHospital = "22";

        /// <summary>
        /// Emergency Room Hospital
        /// </summary>
        public const string EmergencyRoomHospital = "23";

        /// <summary>
        /// Ambulatory Surgical Center
        /// </summary>
        public const string AmbulatorySurgicalCenter = "24";

        /// <summary>
        /// Birthing Center
        /// </summary>
        public const string BirthingCenter = "25";

        /// <summary>
        /// Military Treatment Facility
        /// </summary>
        public const string MilitaryTreatmentFacility = "26";

        /// <summary>
        /// Skilled Nursing Facility
        /// </summary>
        public const string SkilledNursingFacility = "31";

        /// <summary>
        /// Nursing Facility
        /// </summary>
        public const string NursingFacility = "32";

        /// <summary>
        /// Custodial Care Facility
        /// </summary>
        public const string CustodialCareFacility = "33";

        /// <summary>
        /// Hospice
        /// </summary>
        public const string Hospice = "34";

        /// <summary>
        /// Ambulance (Land)
        /// </summary>
        public const string AmbulanceLand = "41";

        /// <summary>
        /// Ambulance (Air or Water)
        /// </summary>
        public const string AmbulanceAirOrWater = "42";

        /// <summary>
        /// Independent Clinic
        /// </summary>
        public const string IndependentClinic = "49";

        /// <summary>
        /// Federally Qualified Health Center
        /// </summary>
        public const string FederallyQualifiedHealthCenter = "50";

        /// <summary>
        /// Inpatient Psychiatric Facility
        /// </summary>
        public const string InpatientPsychiatricFacility = "51";

        /// <summary>
        /// Psychiatric Facility (Partial Hospitalization)
        /// </summary>
        public const string PsychiatricFacilityPartialHospitalization = "52";

        /// <summary>
        /// Community Mental Health Center
        /// </summary>
        public const string CommunityMentalHealthCenter = "53";

        /// <summary>
        /// Intermediate Care Facility/Individuals with Intellectual Disabilities
        /// </summary>
        public const string IntermediateCareFacilityMentallyRetarded = "54";

        /// <summary>
        /// Residential Substance Abuse Treatment Facility
        /// </summary>
        public const string ResidentialSubstanceAbuseTreatmentFacility = "55";

        /// <summary>
        /// Psychiatric Residential Treatment Center
        /// </summary>
        public const string PsychiatricResidentialTreatmentCenter = "56";

        /// <summary>
        /// Non-residential Substance Abuse Treatment Facility
        /// </summary>
        public const string NonResidentialSubstanceAbuseTreatmentFacility = "57";

        /// <summary>
        /// Non-residential Opioid Treatment Facility
        /// </summary>
        public const string NonResidentialOpioidTreatmentFacility = "58";

        /// <summary>
        /// Mass Immunization Center
        /// </summary>
        public const string MassImmunizationCenter = "60";

        /// <summary>
        /// Comprehensive Inpatient Rehabilitation Facility
        /// </summary>
        public const string ComprehensiveInpatientRehabilitationFacility = "61";

        /// <summary>
        /// Comprehensive Outpatient Rehabilitation Facility
        /// </summary>
        public const string ComprehensiveOutpatientRehabilitationFacility = "62";

        /// <summary>
        /// End Stage Renal Disease Treatment Facility
        /// </summary>
        public const string EndStageRenalDiseaseTreatmentFacility = "65";

        /// <summary>
        /// State or Local Public Health Clinic
        /// </summary>
        public const string StateOrLocalPublicHealthClinic = "71";

        /// <summary>
        /// Rural Health Clinic
        /// </summary>
        public const string RuralHealthClinic = "72";

        /// <summary>
        /// Independent Laboratory
        /// </summary>
        public const string IndependentLaboratory = "81";

        /// <summary>
        /// Other Unlisted Facility
        /// </summary>
        public const string OtherUnlistedFacility = "99";
    }
}
