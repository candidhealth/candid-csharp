using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.OrganizationServiceFacilities.V2;

[JsonConverter(typeof(StringEnumSerializer<ServiceFacilityType>))]
public enum ServiceFacilityType
{
    [EnumMember(Value = "DX")]
    DiagnosticsOrTherapeuticsUnit,

    [EnumMember(Value = "CVDX")]
    CardiovascularDiagnosticsOrTherapeuticsUnit,

    [EnumMember(Value = "CATH")]
    CardiacCatheterizationLab,

    [EnumMember(Value = "ECHO")]
    EchocardiographyLab,

    [EnumMember(Value = "GIDX")]
    GastroenterologyDiagnosticsOrTherapeuticsLab,

    [EnumMember(Value = "ENDOS")]
    EndoscopyLab,

    [EnumMember(Value = "RADDX")]
    RadiologyDiagnosticsOrTherapeuticsUnit,

    [EnumMember(Value = "RADO")]
    RadiationOncologyUnit,

    [EnumMember(Value = "RNEU")]
    NeuroradiologyUnit,

    [EnumMember(Value = "HOSP")]
    Hospital,

    [EnumMember(Value = "CHR")]
    ChronicCareFacility,

    [EnumMember(Value = "GACH")]
    HospitalsGeneralAcuteCareHospital,

    [EnumMember(Value = "MHSP")]
    MilitaryHospital,

    [EnumMember(Value = "PSYCHF")]
    PsychatricCareFacility,

    [EnumMember(Value = "RH")]
    RehabilitationHospital,

    [EnumMember(Value = "RHAT")]
    AddictionTreatmentCenter,

    [EnumMember(Value = "RHII")]
    IntellectualImpairmentCenter,

    [EnumMember(Value = "RHMAD")]
    ParentsWithAdjustmentDifficultiesCenter,

    [EnumMember(Value = "RHPI")]
    PhysicalImpairmentCenter,

    [EnumMember(Value = "RHPIH")]
    PhysicalImpairmentHearingCenter,

    [EnumMember(Value = "RHPIMS")]
    PhysicalImpairmentMotorSkillsCenter,

    [EnumMember(Value = "RHPIVS")]
    PhysicalImpairmentVisualSkillsCenter,

    [EnumMember(Value = "RHYAD")]
    YouthsWithAdjustmentDifficultiesCenter,

    [EnumMember(Value = "HU")]
    HospitalUnit,

    [EnumMember(Value = "BMTU")]
    BoneMarrowTransplantUnit,

    [EnumMember(Value = "CCU")]
    CoronaryCareUnit,

    [EnumMember(Value = "CHEST")]
    ChestUnit,

    [EnumMember(Value = "EPIL")]
    EpilepsyUnit,

    [EnumMember(Value = "ER")]
    EmergencyRoom,

    [EnumMember(Value = "ETU")]
    EmergencyTraumaUnit,

    [EnumMember(Value = "HD")]
    HemodialysisUnit,

    [EnumMember(Value = "HLAB")]
    HospitalLaboratory,

    [EnumMember(Value = "INLAB")]
    InpatientLaboratory,

    [EnumMember(Value = "OUTLAB")]
    OutpatientLaboratory,

    [EnumMember(Value = "HRAD")]
    RadiologyUnit,

    [EnumMember(Value = "HUSCS")]
    SpecimenCollectionSite,

    [EnumMember(Value = "ICU")]
    IntensiveCareUnit,

    [EnumMember(Value = "PEDICU")]
    PediatricIntensiveCareUnit,

    [EnumMember(Value = "PEDNICU")]
    PediatricNeonatalIntensiveCareUnit,

    [EnumMember(Value = "INPHARM")]
    InpatientPharmacy,

    [EnumMember(Value = "MBL")]
    MedicalLaboratory,

    [EnumMember(Value = "NCCS")]
    NeurologyCriticalCareAndStrokeUnit,

    [EnumMember(Value = "NS")]
    NeurosurgeryUnit,

    [EnumMember(Value = "OUTPHARM")]
    OutpatientPharmacy,

    [EnumMember(Value = "PEDU")]
    PediatricUnit,

    [EnumMember(Value = "PHU")]
    PsychiatricHospitalUnit,

    [EnumMember(Value = "RHU")]
    RehabilitationHospitalUnit,

    [EnumMember(Value = "SLEEP")]
    SleepDisordersUnit,

    [EnumMember(Value = "NCCF")]
    NursingOrCustodialCareFacility,

    [EnumMember(Value = "SNF")]
    SkilledNursingFacility,

    [EnumMember(Value = "OF")]
    OutpatientFacility,

    [EnumMember(Value = "ALL")]
    AllergyClinic,

    [EnumMember(Value = "AMPUT")]
    AmputeeClinic,

    [EnumMember(Value = "BMTC")]
    BoneMarrowTransplantClinic,

    [EnumMember(Value = "BREAST")]
    BreastClinic,

    [EnumMember(Value = "CANC")]
    ChildAndAdolescentNeurologyClinic,

    [EnumMember(Value = "CAPC")]
    ChildAndAdolescentPsychiatryClinic,

    [EnumMember(Value = "CARD")]
    AmbulatoryHealthCareFacilitiesClinicCenterRehabilitationCardiacFacilities,

    [EnumMember(Value = "PEDCARD")]
    PediatricCardiologyClinic,

    [EnumMember(Value = "COAG")]
    CoagulationClinic,

    [EnumMember(Value = "CRS")]
    ColonAndRectalSurgeryClinic,

    [EnumMember(Value = "DERM")]
    DermatologyClinic,

    [EnumMember(Value = "ENDO")]
    EndocrinologyClinic,

    [EnumMember(Value = "PEDE")]
    PediatricEndocrinologyClinic,

    [EnumMember(Value = "ENT")]
    OtorhinolaryngologyClinic,

    [EnumMember(Value = "FMC")]
    FamilyMedicineClinic,

    [EnumMember(Value = "GI")]
    GastroenterologyClinic,

    [EnumMember(Value = "PEDGI")]
    PediatricGastroenterologyClinic,

    [EnumMember(Value = "GIM")]
    GeneralInternalMedicineClinic,

    [EnumMember(Value = "GYN")]
    GynecologyClinic,

    [EnumMember(Value = "HEM")]
    HematologyClinic,

    [EnumMember(Value = "PEDHEM")]
    PediatricHematologyClinic,

    [EnumMember(Value = "HTN")]
    HypertensionClinic,

    [EnumMember(Value = "IEC")]
    ImpairmentEvaluationCenter,

    [EnumMember(Value = "INFD")]
    InfectiousDiseaseClinic,

    [EnumMember(Value = "PEDID")]
    PediatricInfectiousDiseaseClinic,

    [EnumMember(Value = "INV")]
    InfertilityClinic,

    [EnumMember(Value = "LYMPH")]
    LympedemaClinic,

    [EnumMember(Value = "MGEN")]
    MedicalGeneticsClinic,

    [EnumMember(Value = "NEPH")]
    NephrologyClinic,

    [EnumMember(Value = "PEDNEPH")]
    PediatricNephrologyClinic,

    [EnumMember(Value = "NEUR")]
    NeurologyClinic,

    [EnumMember(Value = "OB")]
    ObstetricsClinic,

    [EnumMember(Value = "OMS")]
    OralAndMaxillofacialSurgeryClinic,

    [EnumMember(Value = "ONCL")]
    MedicalOncologyClinic,

    [EnumMember(Value = "PEDHO")]
    PediatricOncologyClinic,

    [EnumMember(Value = "OPH")]
    OpthalmologyClinic,

    [EnumMember(Value = "OPTC")]
    OptometryClinic,

    [EnumMember(Value = "ORTHO")]
    OrthopedicsClinic,

    [EnumMember(Value = "HAND")]
    HandClinic,

    [EnumMember(Value = "PAINCL")]
    PainClinic,

    [EnumMember(Value = "PC")]
    PrimaryCareClinic,

    [EnumMember(Value = "PEDC")]
    PediatricsClinic,

    [EnumMember(Value = "PEDRHEUM")]
    PediatricRheumatologyClinic,

    [EnumMember(Value = "POD")]
    PodiatryClinic,

    [EnumMember(Value = "PREV")]
    PreventiveMedicineClinic,

    [EnumMember(Value = "PROCTO")]
    ProctologyClinic,

    [EnumMember(Value = "PROFF")]
    ProvidersOffice,

    [EnumMember(Value = "PROS")]
    ProsthodonticsClinic,

    [EnumMember(Value = "PSI")]
    PsychologyClinic,

    [EnumMember(Value = "PSY")]
    PsychiatryClinic,

    [EnumMember(Value = "RHEUM")]
    RheumatologyClinic,

    [EnumMember(Value = "SPMED")]
    SportsMedicineClinic,

    [EnumMember(Value = "SU")]
    SurgeryClinic,

    [EnumMember(Value = "PLS")]
    PlasticSurgeryClinic,

    [EnumMember(Value = "URO")]
    UrologyClinic,

    [EnumMember(Value = "TR")]
    TransplantClinic,

    [EnumMember(Value = "TRAVEL")]
    TravelAndGeographicMedicineClinic,

    [EnumMember(Value = "WND")]
    WoundClinic,

    [EnumMember(Value = "RTF")]
    ResidentialTreatmentFacility,

    [EnumMember(Value = "PRC")]
    PainRehabilitationCenter,

    [EnumMember(Value = "SURF")]
    SubstanceUseRehabilitationFacility,

    [EnumMember(Value = "DADDR")]
    DeliveryAddress,

    [EnumMember(Value = "MOBL")]
    MobileUnit,

    [EnumMember(Value = "AMB")]
    Ambulance,

    [EnumMember(Value = "PHARM")]
    Pharmacy,

    [EnumMember(Value = "ACC")]
    AccidentSite,

    [EnumMember(Value = "COMM")]
    CommunityLocation,

    [EnumMember(Value = "CSC")]
    CommunityServiceCenter,

    [EnumMember(Value = "PTRES")]
    PatientsResidence,

    [EnumMember(Value = "SCHOOL")]
    School,

    [EnumMember(Value = "UPC")]
    UnderageProtectionCenter,

    [EnumMember(Value = "WORK")]
    WorkSite,
}
