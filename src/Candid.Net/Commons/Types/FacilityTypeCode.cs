using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<FacilityTypeCode>))]
public enum FacilityTypeCode
{
    [EnumMember(Value = "01")]
    Pharmacy,

    [EnumMember(Value = "02")]
    Telehealth,

    [EnumMember(Value = "03")]
    School,

    [EnumMember(Value = "04")]
    HomelessShelter,

    [EnumMember(Value = "05")]
    IndianHealthServiceFreeStanding,

    [EnumMember(Value = "06")]
    IndianHealthServiceProviderBased,

    [EnumMember(Value = "07")]
    TribalFreeStanding,

    [EnumMember(Value = "08")]
    TribalProviderBased,

    [EnumMember(Value = "09")]
    PrisonOrCorrectionalFacility,

    [EnumMember(Value = "10")]
    TelehealthPatientHome,

    [EnumMember(Value = "11")]
    Office,

    [EnumMember(Value = "12")]
    Home,

    [EnumMember(Value = "13")]
    AssistedLivingFacility,

    [EnumMember(Value = "14")]
    GroupHome,

    [EnumMember(Value = "15")]
    MobileUnit,

    [EnumMember(Value = "16")]
    TemporaryLodging,

    [EnumMember(Value = "17")]
    WalkInRetailHealthClinic,

    [EnumMember(Value = "18")]
    PlaceOfEmploymentWorksite,

    [EnumMember(Value = "19")]
    OffCampusOutpatientHospital,

    [EnumMember(Value = "20")]
    UrgentCareFacility,

    [EnumMember(Value = "21")]
    InpatientHospital,

    [EnumMember(Value = "22")]
    OutpatientHospital,

    [EnumMember(Value = "23")]
    EmergencyRoomHospital,

    [EnumMember(Value = "24")]
    AmbulatorySurgicalCenter,

    [EnumMember(Value = "25")]
    BirthingCenter,

    [EnumMember(Value = "26")]
    MilitaryTreatmentFacility,

    [EnumMember(Value = "31")]
    SkilledNursingFacility,

    [EnumMember(Value = "32")]
    NursingFacility,

    [EnumMember(Value = "33")]
    CustodialCareFacility,

    [EnumMember(Value = "34")]
    Hospice,

    [EnumMember(Value = "41")]
    AmbulanceLand,

    [EnumMember(Value = "42")]
    AmbulanceAirOrWater,

    [EnumMember(Value = "49")]
    IndependentClinic,

    [EnumMember(Value = "50")]
    FederallyQualifiedHealthCenter,

    [EnumMember(Value = "51")]
    InpatientPsychiatricFacility,

    [EnumMember(Value = "52")]
    PsychiatricFacilityPartialHospitalization,

    [EnumMember(Value = "53")]
    CommunityMentalHealthCenter,

    [EnumMember(Value = "54")]
    IntermediateCareFacilityMentallyRetarded,

    [EnumMember(Value = "55")]
    ResidentialSubstanceAbuseTreatmentFacility,

    [EnumMember(Value = "56")]
    PsychiatricResidentialTreatmentCenter,

    [EnumMember(Value = "57")]
    NonResidentialSubstanceAbuseTreatmentFacility,

    [EnumMember(Value = "58")]
    NonResidentialOpioidTreatmentFacility,

    [EnumMember(Value = "60")]
    MassImmunizationCenter,

    [EnumMember(Value = "61")]
    ComprehensiveInpatientRehabilitationFacility,

    [EnumMember(Value = "62")]
    ComprehensiveOutpatientRehabilitationFacility,

    [EnumMember(Value = "65")]
    EndStageRenalDiseaseTreatmentFacility,

    [EnumMember(Value = "71")]
    StateOrLocalPublicHealthClinic,

    [EnumMember(Value = "72")]
    RuralHealthClinic,

    [EnumMember(Value = "81")]
    IndependentLaboratory,

    [EnumMember(Value = "99")]
    OtherUnlistedFacility,
}
