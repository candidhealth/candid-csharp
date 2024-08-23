using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

[JsonConverter(typeof(StringEnumSerializer<ServiceTypeCode>))]
public enum ServiceTypeCode
{
    [EnumMember(Value = "1")]
    MedicalCare,

    [EnumMember(Value = "2")]
    Surgical,

    [EnumMember(Value = "3")]
    Consultation,

    [EnumMember(Value = "4")]
    DiagnosticXRay,

    [EnumMember(Value = "5")]
    DiagnosticLab,

    [EnumMember(Value = "6")]
    RadiationTherapy,

    [EnumMember(Value = "7")]
    Anesthesia,

    [EnumMember(Value = "8")]
    SurgicalAssistance,

    [EnumMember(Value = "9")]
    OtherMedical,

    [EnumMember(Value = "10")]
    BloodCharges,

    [EnumMember(Value = "11")]
    UsedDurableMedicalEquipment,

    [EnumMember(Value = "12")]
    DurableMedicalEquipmentPurchase,

    [EnumMember(Value = "13")]
    AmbulatorySurgicalCenterFacility,

    [EnumMember(Value = "14")]
    RenalSuppliesInHome,

    [EnumMember(Value = "15")]
    AlternateMethodDialysis,

    [EnumMember(Value = "16")]
    ChronicRenalDiseaseEquipment,

    [EnumMember(Value = "17")]
    PreAdmissionTesting,

    [EnumMember(Value = "18")]
    DurableMedicalEquipmentRental,

    [EnumMember(Value = "19")]
    PneumoniaVaccine,

    [EnumMember(Value = "20")]
    SecondSurgicalOpinion,

    [EnumMember(Value = "21")]
    ThirdSurgicalOpinion,

    [EnumMember(Value = "22")]
    SocialWork,

    [EnumMember(Value = "23")]
    DiagnosticDental,

    [EnumMember(Value = "24")]
    Periodontics,

    [EnumMember(Value = "25")]
    Restorative,

    [EnumMember(Value = "26")]
    Endodontics,

    [EnumMember(Value = "27")]
    MaxillofacialProsthetics,

    [EnumMember(Value = "28")]
    AdjunctiveDentalServices,

    [EnumMember(Value = "30")]
    HealthBenefitPlanCoverage,

    [EnumMember(Value = "32")]
    PlanWaitingPeriod,

    [EnumMember(Value = "33")]
    Chiropractic,

    [EnumMember(Value = "34")]
    ChiropracticOfficeVisits,

    [EnumMember(Value = "35")]
    DentalCare,

    [EnumMember(Value = "36")]
    DentalCrowns,

    [EnumMember(Value = "37")]
    DentalAccident,

    [EnumMember(Value = "38")]
    Orthodontics,

    [EnumMember(Value = "39")]
    Prosthodontics,

    [EnumMember(Value = "40")]
    OralSurgery,

    [EnumMember(Value = "41")]
    RoutinePreventiveDental,

    [EnumMember(Value = "42")]
    HomeHealthCare,

    [EnumMember(Value = "43")]
    HomeHealthPrescriptions,

    [EnumMember(Value = "44")]
    HomeHealthVisits,

    [EnumMember(Value = "45")]
    Hospice,

    [EnumMember(Value = "46")]
    RespiteCare,

    [EnumMember(Value = "47")]
    Hospital,

    [EnumMember(Value = "48")]
    HospitalInpatient,

    [EnumMember(Value = "49")]
    HospitalRoomAndBoard,

    [EnumMember(Value = "50")]
    HospitalOutpatient,

    [EnumMember(Value = "51")]
    HospitalEmergencyAccident,

    [EnumMember(Value = "52")]
    HospitalEmergencyMedical,

    [EnumMember(Value = "53")]
    HospitalAmbulatorySurgical,

    [EnumMember(Value = "54")]
    LongTermCare,

    [EnumMember(Value = "55")]
    MajorMedical,

    [EnumMember(Value = "56")]
    MedicallyRelatedTransportation,

    [EnumMember(Value = "57")]
    AirTransportation,

    [EnumMember(Value = "58")]
    Cabulance,

    [EnumMember(Value = "59")]
    LicensedAmbulance,

    [EnumMember(Value = "60")]
    GeneralBenefits,

    [EnumMember(Value = "61")]
    InVitroFertilization,

    [EnumMember(Value = "62")]
    MricatScan,

    [EnumMember(Value = "63")]
    DonorProcedures,

    [EnumMember(Value = "64")]
    Acupuncture,

    [EnumMember(Value = "65")]
    NewbornCare,

    [EnumMember(Value = "66")]
    Pathology,

    [EnumMember(Value = "67")]
    SmokingCessation,

    [EnumMember(Value = "68")]
    WellBabyCare,

    [EnumMember(Value = "69")]
    Maternity,

    [EnumMember(Value = "70")]
    Transplants,

    [EnumMember(Value = "71")]
    AudiologyExam,

    [EnumMember(Value = "72")]
    InhalationTherapy,

    [EnumMember(Value = "73")]
    DiagnosticMedical,

    [EnumMember(Value = "74")]
    PrivateDutyNursing,

    [EnumMember(Value = "75")]
    ProstheticDevice,

    [EnumMember(Value = "76")]
    Dialysis,

    [EnumMember(Value = "77")]
    OtologicalExam,

    [EnumMember(Value = "78")]
    Chemotherapy,

    [EnumMember(Value = "79")]
    AllergyTesting,

    [EnumMember(Value = "80")]
    Immunizations,

    [EnumMember(Value = "81")]
    RoutinePhysical,

    [EnumMember(Value = "82")]
    FamilyPlanning,

    [EnumMember(Value = "83")]
    Infertility,

    [EnumMember(Value = "84")]
    Abortion,

    [EnumMember(Value = "85")]
    Aids,

    [EnumMember(Value = "86")]
    EmergencyServices,

    [EnumMember(Value = "87")]
    Cancer,

    [EnumMember(Value = "88")]
    Pharmacy,

    [EnumMember(Value = "89")]
    FreeStandingPrescriptionDrug,

    [EnumMember(Value = "90")]
    MailOrderPrescriptionDrug,

    [EnumMember(Value = "91")]
    BrandNamePrescriptionDrug,

    [EnumMember(Value = "92")]
    GenericPrescriptionDrug,

    [EnumMember(Value = "93")]
    Podiatry,

    [EnumMember(Value = "94")]
    PodiatryOfficeVisits,

    [EnumMember(Value = "95")]
    PodiatryNursingHomeVisits,

    [EnumMember(Value = "96")]
    ProfessionalPhysician,

    [EnumMember(Value = "97")]
    Anesthesiologist,

    [EnumMember(Value = "98")]
    ProfessionalPhysicianVisitOffice,

    [EnumMember(Value = "99")]
    ProfessionalPhysicianVisitInpatient,

    [EnumMember(Value = "A0")]
    ProfessionalPhysicianVisitOutpatient,

    [EnumMember(Value = "A1")]
    ProfessionalPhysicianVisitNursingHome,

    [EnumMember(Value = "A2")]
    ProfessionalPhysicianVisitSkilledNursingFacility,

    [EnumMember(Value = "A3")]
    ProfessionalPhysicianVisitHome,

    [EnumMember(Value = "A4")]
    Psychiatric,

    [EnumMember(Value = "A5")]
    PsychiatricRoomAndBoard,

    [EnumMember(Value = "A6")]
    Psychotherapy,

    [EnumMember(Value = "A7")]
    PsychiatricInpatient,

    [EnumMember(Value = "A8")]
    PsychiatricOutpatient,

    [EnumMember(Value = "A9")]
    Rehabilitation,

    [EnumMember(Value = "AA")]
    RehabilitationRoomAndBoard,

    [EnumMember(Value = "AB")]
    RehabilitationInpatient,

    [EnumMember(Value = "AC")]
    RehabilitationOutpatient,

    [EnumMember(Value = "AD")]
    OccupationalTherapy,

    [EnumMember(Value = "AE")]
    PhysicalMedicine,

    [EnumMember(Value = "AF")]
    SpeechTherapy,

    [EnumMember(Value = "AG")]
    SkilledNursingCare,

    [EnumMember(Value = "AH")]
    SkilledNursingCareRoomAndBoard,

    [EnumMember(Value = "AI")]
    SubstanceAbuse,

    [EnumMember(Value = "AJ")]
    Alcoholism,

    [EnumMember(Value = "AK")]
    DrugAddiction,

    [EnumMember(Value = "AL")]
    VisionOptometry,

    [EnumMember(Value = "AM")]
    Frames,

    [EnumMember(Value = "AN")]
    RoutineExam,

    [EnumMember(Value = "AO")]
    Lenses,

    [EnumMember(Value = "AQ")]
    NonmedicallyNecessaryPhysical,

    [EnumMember(Value = "AR")]
    ExperimentalDrugTherapy,

    [EnumMember(Value = "B1")]
    BurnCare,

    [EnumMember(Value = "B2")]
    BrandNamePrescriptionDrugFormulary,

    [EnumMember(Value = "B3")]
    BrandNamePrescriptionDrugNonFormulary,

    [EnumMember(Value = "BA")]
    IndependentMedicalEvaluation,

    [EnumMember(Value = "BB")]
    PartialHospitalizationPsychiatric,

    [EnumMember(Value = "BC")]
    DayCarePsychiatric,

    [EnumMember(Value = "BD")]
    CognitiveTherapy,

    [EnumMember(Value = "BE")]
    MassageTherapy,

    [EnumMember(Value = "BF")]
    PulmonaryRehabilitation,

    [EnumMember(Value = "BG")]
    CardiacRehabilitation,

    [EnumMember(Value = "BH")]
    Pediatric,

    [EnumMember(Value = "BI")]
    Nursery,

    [EnumMember(Value = "BJ")]
    Skin,

    [EnumMember(Value = "BK")]
    Orthopedic,

    [EnumMember(Value = "BL")]
    Cardiac,

    [EnumMember(Value = "BM")]
    Lymphatic,

    [EnumMember(Value = "BN")]
    Gastrointestinal,

    [EnumMember(Value = "BP")]
    Endocrine,

    [EnumMember(Value = "BQ")]
    Neurology,

    [EnumMember(Value = "BR")]
    Eye,

    [EnumMember(Value = "BS")]
    InvasiveProcedures,

    [EnumMember(Value = "BT")]
    Gynecological,

    [EnumMember(Value = "BU")]
    Obstetrical,

    [EnumMember(Value = "BV")]
    ObstetricalGynecological,

    [EnumMember(Value = "BW")]
    MailOrderPrescriptionDrugBrandName,

    [EnumMember(Value = "BX")]
    MailOrderPrescriptionDrugGeneric,

    [EnumMember(Value = "BY")]
    PhysicianVisitOfficeSick,

    [EnumMember(Value = "BZ")]
    PhysicianVisitOfficeWell,

    [EnumMember(Value = "C1")]
    CoronaryCare,

    [EnumMember(Value = "CA")]
    PrivateDutyNursingInpatient,

    [EnumMember(Value = "CB")]
    PrivateDutyNursingHome,

    [EnumMember(Value = "CC")]
    SurgicalBenefitsProfessionalPhysician,

    [EnumMember(Value = "CD")]
    SurgicalBenefitsFacility,

    [EnumMember(Value = "CE")]
    MentalHealthProviderInpatient,

    [EnumMember(Value = "CF")]
    MentalHealthProviderOutpatient,

    [EnumMember(Value = "CG")]
    MentalHealthFacilityInpatient,

    [EnumMember(Value = "CH")]
    MentalHealthFacilityOutpatient,

    [EnumMember(Value = "CI")]
    SubstanceAbuseFacilityInpatient,

    [EnumMember(Value = "CJ")]
    SubstanceAbuseFacilityOutpatient,

    [EnumMember(Value = "CK")]
    ScreeningXRay,

    [EnumMember(Value = "CL")]
    ScreeningLaboratory,

    [EnumMember(Value = "CM")]
    MammogramHighRiskPatient,

    [EnumMember(Value = "CN")]
    MammogramLowRiskPatient,

    [EnumMember(Value = "CO")]
    FluVaccination,

    [EnumMember(Value = "CP")]
    EyewearAndEyewearAccessories,

    [EnumMember(Value = "CQ")]
    CaseManagement,

    [EnumMember(Value = "DG")]
    Dermatology,

    [EnumMember(Value = "DM")]
    DurableMedicalEquipment,

    [EnumMember(Value = "DS")]
    DiabeticSupplies,

    [EnumMember(Value = "GF")]
    GenericPrescriptionDrugFormulary,

    [EnumMember(Value = "GN")]
    GenericPrescriptionDrugNonFormulary,

    [EnumMember(Value = "GY")]
    Allergy,

    [EnumMember(Value = "IC")]
    IntensiveCare,

    [EnumMember(Value = "MH")]
    MentalHealth,

    [EnumMember(Value = "NI")]
    NeonatalIntensiveCare,

    [EnumMember(Value = "ON")]
    Oncology,

    [EnumMember(Value = "PT")]
    PhysicalTherapy,

    [EnumMember(Value = "PU")]
    Pulmonary,

    [EnumMember(Value = "RN")]
    Renal,

    [EnumMember(Value = "RT")]
    ResidentialPsychiatricTreatment,

    [EnumMember(Value = "TC")]
    TransitionalCare,

    [EnumMember(Value = "TN")]
    TransitionalNurseryCare,

    [EnumMember(Value = "UC")]
    UrgentCare
}
