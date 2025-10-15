using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[JsonConverter(typeof(StringEnumSerializer<ServiceTypeCode>))]
[Serializable]
public readonly record struct ServiceTypeCode : IStringEnum
{
    /// <summary>
    /// Medical Care
    /// </summary>
    public static readonly ServiceTypeCode MedicalCare = new(Values.MedicalCare);

    /// <summary>
    /// Surgical
    /// </summary>
    public static readonly ServiceTypeCode Surgical = new(Values.Surgical);

    /// <summary>
    /// Consultation
    /// </summary>
    public static readonly ServiceTypeCode Consultation = new(Values.Consultation);

    /// <summary>
    /// Diagnostic X-Ray
    /// </summary>
    public static readonly ServiceTypeCode DiagnosticXRay = new(Values.DiagnosticXRay);

    /// <summary>
    /// Diagnostic Lab
    /// </summary>
    public static readonly ServiceTypeCode DiagnosticLab = new(Values.DiagnosticLab);

    /// <summary>
    /// Radiation Therapy
    /// </summary>
    public static readonly ServiceTypeCode RadiationTherapy = new(Values.RadiationTherapy);

    /// <summary>
    /// Anesthesia
    /// </summary>
    public static readonly ServiceTypeCode Anesthesia = new(Values.Anesthesia);

    /// <summary>
    /// Surgical Assistance
    /// </summary>
    public static readonly ServiceTypeCode SurgicalAssistance = new(Values.SurgicalAssistance);

    /// <summary>
    /// Other Medical
    /// </summary>
    public static readonly ServiceTypeCode OtherMedical = new(Values.OtherMedical);

    /// <summary>
    /// Blood Charges
    /// </summary>
    public static readonly ServiceTypeCode BloodCharges = new(Values.BloodCharges);

    /// <summary>
    /// Used Durable Medical Equipment
    /// </summary>
    public static readonly ServiceTypeCode UsedDurableMedicalEquipment = new(
        Values.UsedDurableMedicalEquipment
    );

    /// <summary>
    /// Durable Medical Equipment Purchase
    /// </summary>
    public static readonly ServiceTypeCode DurableMedicalEquipmentPurchase = new(
        Values.DurableMedicalEquipmentPurchase
    );

    /// <summary>
    /// Ambulatory Service Center Facility
    /// </summary>
    public static readonly ServiceTypeCode AmbulatorySurgicalCenterFacility = new(
        Values.AmbulatorySurgicalCenterFacility
    );

    /// <summary>
    /// Renal Supplies in the Home
    /// </summary>
    public static readonly ServiceTypeCode RenalSuppliesInHome = new(Values.RenalSuppliesInHome);

    /// <summary>
    /// Alternate Method Dialysis
    /// </summary>
    public static readonly ServiceTypeCode AlternateMethodDialysis = new(
        Values.AlternateMethodDialysis
    );

    /// <summary>
    /// Chronic Renal Disease (CRD) Equipment
    /// </summary>
    public static readonly ServiceTypeCode ChronicRenalDiseaseEquipment = new(
        Values.ChronicRenalDiseaseEquipment
    );

    /// <summary>
    /// Pre-Admission Testing
    /// </summary>
    public static readonly ServiceTypeCode PreAdmissionTesting = new(Values.PreAdmissionTesting);

    /// <summary>
    /// Durable Medical Equipment Rental
    /// </summary>
    public static readonly ServiceTypeCode DurableMedicalEquipmentRental = new(
        Values.DurableMedicalEquipmentRental
    );

    /// <summary>
    /// Pneumonia Vaccine
    /// </summary>
    public static readonly ServiceTypeCode PneumoniaVaccine = new(Values.PneumoniaVaccine);

    /// <summary>
    /// Second Surgical Opinion
    /// </summary>
    public static readonly ServiceTypeCode SecondSurgicalOpinion = new(
        Values.SecondSurgicalOpinion
    );

    /// <summary>
    /// Third Surgical Opinion
    /// </summary>
    public static readonly ServiceTypeCode ThirdSurgicalOpinion = new(Values.ThirdSurgicalOpinion);

    /// <summary>
    /// Social Work
    /// </summary>
    public static readonly ServiceTypeCode SocialWork = new(Values.SocialWork);

    /// <summary>
    /// Diagnostic Dental
    /// </summary>
    public static readonly ServiceTypeCode DiagnosticDental = new(Values.DiagnosticDental);

    /// <summary>
    /// Periodontics
    /// </summary>
    public static readonly ServiceTypeCode Periodontics = new(Values.Periodontics);

    /// <summary>
    /// Restorative
    /// </summary>
    public static readonly ServiceTypeCode Restorative = new(Values.Restorative);

    /// <summary>
    /// Endodontics
    /// </summary>
    public static readonly ServiceTypeCode Endodontics = new(Values.Endodontics);

    /// <summary>
    /// Maxillofacial Prosthetics
    /// </summary>
    public static readonly ServiceTypeCode MaxillofacialProsthetics = new(
        Values.MaxillofacialProsthetics
    );

    /// <summary>
    /// Adjunctive Dental Services
    /// </summary>
    public static readonly ServiceTypeCode AdjunctiveDentalServices = new(
        Values.AdjunctiveDentalServices
    );

    /// <summary>
    /// Health Benefit Plan Coverage
    /// </summary>
    public static readonly ServiceTypeCode HealthBenefitPlanCoverage = new(
        Values.HealthBenefitPlanCoverage
    );

    /// <summary>
    /// Plan Waiting Period
    /// </summary>
    public static readonly ServiceTypeCode PlanWaitingPeriod = new(Values.PlanWaitingPeriod);

    /// <summary>
    /// Chiropractic
    /// </summary>
    public static readonly ServiceTypeCode Chiropractic = new(Values.Chiropractic);

    /// <summary>
    /// Chiropractic Office Visits
    /// </summary>
    public static readonly ServiceTypeCode ChiropracticOfficeVisits = new(
        Values.ChiropracticOfficeVisits
    );

    /// <summary>
    /// Dental Care
    /// </summary>
    public static readonly ServiceTypeCode DentalCare = new(Values.DentalCare);

    /// <summary>
    /// Dental Crowns
    /// </summary>
    public static readonly ServiceTypeCode DentalCrowns = new(Values.DentalCrowns);

    /// <summary>
    /// Dental Accident
    /// </summary>
    public static readonly ServiceTypeCode DentalAccident = new(Values.DentalAccident);

    /// <summary>
    /// Orthodontics
    /// </summary>
    public static readonly ServiceTypeCode Orthodontics = new(Values.Orthodontics);

    /// <summary>
    /// Prosthodontics
    /// </summary>
    public static readonly ServiceTypeCode Prosthodontics = new(Values.Prosthodontics);

    /// <summary>
    /// Oral Surgery
    /// </summary>
    public static readonly ServiceTypeCode OralSurgery = new(Values.OralSurgery);

    /// <summary>
    /// Routine (Preventive) Dental
    /// </summary>
    public static readonly ServiceTypeCode RoutinePreventiveDental = new(
        Values.RoutinePreventiveDental
    );

    /// <summary>
    /// Home Health Care
    /// </summary>
    public static readonly ServiceTypeCode HomeHealthCare = new(Values.HomeHealthCare);

    /// <summary>
    /// Home Health Prescriptions
    /// </summary>
    public static readonly ServiceTypeCode HomeHealthPrescriptions = new(
        Values.HomeHealthPrescriptions
    );

    /// <summary>
    /// Home Health Visits
    /// </summary>
    public static readonly ServiceTypeCode HomeHealthVisits = new(Values.HomeHealthVisits);

    /// <summary>
    /// Hospice
    /// </summary>
    public static readonly ServiceTypeCode Hospice = new(Values.Hospice);

    /// <summary>
    /// Respite Care
    /// </summary>
    public static readonly ServiceTypeCode RespiteCare = new(Values.RespiteCare);

    /// <summary>
    /// Hospital
    /// </summary>
    public static readonly ServiceTypeCode Hospital = new(Values.Hospital);

    /// <summary>
    /// Hospital - Inpatient
    /// </summary>
    public static readonly ServiceTypeCode HospitalInpatient = new(Values.HospitalInpatient);

    /// <summary>
    /// Hospital - Room and Board
    /// </summary>
    public static readonly ServiceTypeCode HospitalRoomAndBoard = new(Values.HospitalRoomAndBoard);

    /// <summary>
    /// Hospital - Outpatient
    /// </summary>
    public static readonly ServiceTypeCode HospitalOutpatient = new(Values.HospitalOutpatient);

    /// <summary>
    /// Hospital - Emergency Accident
    /// </summary>
    public static readonly ServiceTypeCode HospitalEmergencyAccident = new(
        Values.HospitalEmergencyAccident
    );

    /// <summary>
    /// Hospital - Emergency Medical
    /// </summary>
    public static readonly ServiceTypeCode HospitalEmergencyMedical = new(
        Values.HospitalEmergencyMedical
    );

    /// <summary>
    /// Hospital - Ambulatory Surgical
    /// </summary>
    public static readonly ServiceTypeCode HospitalAmbulatorySurgical = new(
        Values.HospitalAmbulatorySurgical
    );

    /// <summary>
    /// Long Term Care
    /// </summary>
    public static readonly ServiceTypeCode LongTermCare = new(Values.LongTermCare);

    /// <summary>
    /// Major Medical
    /// </summary>
    public static readonly ServiceTypeCode MajorMedical = new(Values.MajorMedical);

    /// <summary>
    /// Medically Related Transportation
    /// </summary>
    public static readonly ServiceTypeCode MedicallyRelatedTransportation = new(
        Values.MedicallyRelatedTransportation
    );

    /// <summary>
    /// Air Transportation
    /// </summary>
    public static readonly ServiceTypeCode AirTransportation = new(Values.AirTransportation);

    /// <summary>
    /// Cabulance
    /// </summary>
    public static readonly ServiceTypeCode Cabulance = new(Values.Cabulance);

    /// <summary>
    /// Licensed Ambulance
    /// </summary>
    public static readonly ServiceTypeCode LicensedAmbulance = new(Values.LicensedAmbulance);

    /// <summary>
    /// General Benefits
    /// </summary>
    public static readonly ServiceTypeCode GeneralBenefits = new(Values.GeneralBenefits);

    /// <summary>
    /// In-vitro Fertilization
    /// </summary>
    public static readonly ServiceTypeCode InVitroFertilization = new(Values.InVitroFertilization);

    /// <summary>
    /// MRI/CAT Scan
    /// </summary>
    public static readonly ServiceTypeCode MricatScan = new(Values.MricatScan);

    /// <summary>
    /// Donor Procedures
    /// </summary>
    public static readonly ServiceTypeCode DonorProcedures = new(Values.DonorProcedures);

    /// <summary>
    /// Acupuncture
    /// </summary>
    public static readonly ServiceTypeCode Acupuncture = new(Values.Acupuncture);

    /// <summary>
    /// Newborn Care
    /// </summary>
    public static readonly ServiceTypeCode NewbornCare = new(Values.NewbornCare);

    /// <summary>
    /// Pathology
    /// </summary>
    public static readonly ServiceTypeCode Pathology = new(Values.Pathology);

    /// <summary>
    /// Smoking Cessation
    /// </summary>
    public static readonly ServiceTypeCode SmokingCessation = new(Values.SmokingCessation);

    /// <summary>
    /// Well Baby Care
    /// </summary>
    public static readonly ServiceTypeCode WellBabyCare = new(Values.WellBabyCare);

    /// <summary>
    /// Maternity
    /// </summary>
    public static readonly ServiceTypeCode Maternity = new(Values.Maternity);

    /// <summary>
    /// Transplants
    /// </summary>
    public static readonly ServiceTypeCode Transplants = new(Values.Transplants);

    /// <summary>
    /// Audiology Exam
    /// </summary>
    public static readonly ServiceTypeCode AudiologyExam = new(Values.AudiologyExam);

    /// <summary>
    /// Inhalation Therapy
    /// </summary>
    public static readonly ServiceTypeCode InhalationTherapy = new(Values.InhalationTherapy);

    /// <summary>
    /// Diagnostic Medical
    /// </summary>
    public static readonly ServiceTypeCode DiagnosticMedical = new(Values.DiagnosticMedical);

    /// <summary>
    /// Private Duty Nursing
    /// </summary>
    public static readonly ServiceTypeCode PrivateDutyNursing = new(Values.PrivateDutyNursing);

    /// <summary>
    /// Prosthetic Device
    /// </summary>
    public static readonly ServiceTypeCode ProstheticDevice = new(Values.ProstheticDevice);

    /// <summary>
    /// Dialysis
    /// </summary>
    public static readonly ServiceTypeCode Dialysis = new(Values.Dialysis);

    /// <summary>
    /// Otological Exam
    /// </summary>
    public static readonly ServiceTypeCode OtologicalExam = new(Values.OtologicalExam);

    /// <summary>
    /// Chemotherapy
    /// </summary>
    public static readonly ServiceTypeCode Chemotherapy = new(Values.Chemotherapy);

    /// <summary>
    /// Allergy Testing
    /// </summary>
    public static readonly ServiceTypeCode AllergyTesting = new(Values.AllergyTesting);

    /// <summary>
    /// Immunizations
    /// </summary>
    public static readonly ServiceTypeCode Immunizations = new(Values.Immunizations);

    /// <summary>
    /// Routine Physical
    /// </summary>
    public static readonly ServiceTypeCode RoutinePhysical = new(Values.RoutinePhysical);

    /// <summary>
    /// Family Planning
    /// </summary>
    public static readonly ServiceTypeCode FamilyPlanning = new(Values.FamilyPlanning);

    /// <summary>
    /// Infertility
    /// </summary>
    public static readonly ServiceTypeCode Infertility = new(Values.Infertility);

    /// <summary>
    /// Abortion
    /// </summary>
    public static readonly ServiceTypeCode Abortion = new(Values.Abortion);

    /// <summary>
    /// AIDS
    /// </summary>
    public static readonly ServiceTypeCode Aids = new(Values.Aids);

    /// <summary>
    /// Emergency Services
    /// </summary>
    public static readonly ServiceTypeCode EmergencyServices = new(Values.EmergencyServices);

    /// <summary>
    /// Cancer
    /// </summary>
    public static readonly ServiceTypeCode Cancer = new(Values.Cancer);

    /// <summary>
    /// Pharmacy
    /// </summary>
    public static readonly ServiceTypeCode Pharmacy = new(Values.Pharmacy);

    /// <summary>
    /// Free Standing Prescription Drug
    /// </summary>
    public static readonly ServiceTypeCode FreeStandingPrescriptionDrug = new(
        Values.FreeStandingPrescriptionDrug
    );

    /// <summary>
    /// Mail Order Prescription Drug
    /// </summary>
    public static readonly ServiceTypeCode MailOrderPrescriptionDrug = new(
        Values.MailOrderPrescriptionDrug
    );

    /// <summary>
    /// Brand Name Prescription Drug
    /// </summary>
    public static readonly ServiceTypeCode BrandNamePrescriptionDrug = new(
        Values.BrandNamePrescriptionDrug
    );

    /// <summary>
    /// Generic Prescription Drug
    /// </summary>
    public static readonly ServiceTypeCode GenericPrescriptionDrug = new(
        Values.GenericPrescriptionDrug
    );

    /// <summary>
    /// Podiatry
    /// </summary>
    public static readonly ServiceTypeCode Podiatry = new(Values.Podiatry);

    /// <summary>
    /// Podiatry - Office Visits
    /// </summary>
    public static readonly ServiceTypeCode PodiatryOfficeVisits = new(Values.PodiatryOfficeVisits);

    /// <summary>
    /// Podiatry - Nursing Home Visits
    /// </summary>
    public static readonly ServiceTypeCode PodiatryNursingHomeVisits = new(
        Values.PodiatryNursingHomeVisits
    );

    /// <summary>
    /// Professional (Physician)
    /// </summary>
    public static readonly ServiceTypeCode ProfessionalPhysician = new(
        Values.ProfessionalPhysician
    );

    /// <summary>
    /// Anesthesiologist
    /// </summary>
    public static readonly ServiceTypeCode Anesthesiologist = new(Values.Anesthesiologist);

    /// <summary>
    /// Professional (Physician) Visit - Office
    /// </summary>
    public static readonly ServiceTypeCode ProfessionalPhysicianVisitOffice = new(
        Values.ProfessionalPhysicianVisitOffice
    );

    /// <summary>
    /// Professional (Physician) Visit - Inpatient
    /// </summary>
    public static readonly ServiceTypeCode ProfessionalPhysicianVisitInpatient = new(
        Values.ProfessionalPhysicianVisitInpatient
    );

    /// <summary>
    /// Professional (Physician) Visit - Outpatient
    /// </summary>
    public static readonly ServiceTypeCode ProfessionalPhysicianVisitOutpatient = new(
        Values.ProfessionalPhysicianVisitOutpatient
    );

    /// <summary>
    /// Professional (Physician) Visit - Nursing Home
    /// </summary>
    public static readonly ServiceTypeCode ProfessionalPhysicianVisitNursingHome = new(
        Values.ProfessionalPhysicianVisitNursingHome
    );

    /// <summary>
    /// Professional (Physician) Visit - Skilled Nursing Facility
    /// </summary>
    public static readonly ServiceTypeCode ProfessionalPhysicianVisitSkilledNursingFacility = new(
        Values.ProfessionalPhysicianVisitSkilledNursingFacility
    );

    /// <summary>
    /// Professional (Physician) Visit - Home
    /// </summary>
    public static readonly ServiceTypeCode ProfessionalPhysicianVisitHome = new(
        Values.ProfessionalPhysicianVisitHome
    );

    /// <summary>
    /// Psychiatric
    /// </summary>
    public static readonly ServiceTypeCode Psychiatric = new(Values.Psychiatric);

    /// <summary>
    /// Psychiatric - Room and Board
    /// </summary>
    public static readonly ServiceTypeCode PsychiatricRoomAndBoard = new(
        Values.PsychiatricRoomAndBoard
    );

    /// <summary>
    /// Psychotherapy
    /// </summary>
    public static readonly ServiceTypeCode Psychotherapy = new(Values.Psychotherapy);

    /// <summary>
    /// Psychiatric - Inpatient
    /// </summary>
    public static readonly ServiceTypeCode PsychiatricInpatient = new(Values.PsychiatricInpatient);

    /// <summary>
    /// Psychiatric - Outpatient
    /// </summary>
    public static readonly ServiceTypeCode PsychiatricOutpatient = new(
        Values.PsychiatricOutpatient
    );

    /// <summary>
    /// Rehabilitation
    /// </summary>
    public static readonly ServiceTypeCode Rehabilitation = new(Values.Rehabilitation);

    /// <summary>
    /// Rehabilitation - Room and Board
    /// </summary>
    public static readonly ServiceTypeCode RehabilitationRoomAndBoard = new(
        Values.RehabilitationRoomAndBoard
    );

    /// <summary>
    /// Rehabilitation - Inpatient
    /// </summary>
    public static readonly ServiceTypeCode RehabilitationInpatient = new(
        Values.RehabilitationInpatient
    );

    /// <summary>
    /// Rehabilitation - Outpatient
    /// </summary>
    public static readonly ServiceTypeCode RehabilitationOutpatient = new(
        Values.RehabilitationOutpatient
    );

    /// <summary>
    /// Occupational Therapy
    /// </summary>
    public static readonly ServiceTypeCode OccupationalTherapy = new(Values.OccupationalTherapy);

    /// <summary>
    /// Physical Medicine
    /// </summary>
    public static readonly ServiceTypeCode PhysicalMedicine = new(Values.PhysicalMedicine);

    /// <summary>
    /// Speech Therapy
    /// </summary>
    public static readonly ServiceTypeCode SpeechTherapy = new(Values.SpeechTherapy);

    /// <summary>
    /// Skilled Nursing Care
    /// </summary>
    public static readonly ServiceTypeCode SkilledNursingCare = new(Values.SkilledNursingCare);

    /// <summary>
    /// Skilled Nursing Care - Room and Board
    /// </summary>
    public static readonly ServiceTypeCode SkilledNursingCareRoomAndBoard = new(
        Values.SkilledNursingCareRoomAndBoard
    );

    /// <summary>
    /// Substance Abuse
    /// </summary>
    public static readonly ServiceTypeCode SubstanceAbuse = new(Values.SubstanceAbuse);

    /// <summary>
    /// Alcoholism
    /// </summary>
    public static readonly ServiceTypeCode Alcoholism = new(Values.Alcoholism);

    /// <summary>
    /// Drug Addiction
    /// </summary>
    public static readonly ServiceTypeCode DrugAddiction = new(Values.DrugAddiction);

    /// <summary>
    /// Vision (Optometry)
    /// </summary>
    public static readonly ServiceTypeCode VisionOptometry = new(Values.VisionOptometry);

    /// <summary>
    /// Frames
    /// </summary>
    public static readonly ServiceTypeCode Frames = new(Values.Frames);

    /// <summary>
    /// Routine Exam
    /// </summary>
    public static readonly ServiceTypeCode RoutineExam = new(Values.RoutineExam);

    /// <summary>
    /// Lenses
    /// </summary>
    public static readonly ServiceTypeCode Lenses = new(Values.Lenses);

    /// <summary>
    /// Nonmedically Necessary Physical
    /// </summary>
    public static readonly ServiceTypeCode NonmedicallyNecessaryPhysical = new(
        Values.NonmedicallyNecessaryPhysical
    );

    /// <summary>
    /// Experimental Drug Therapy
    /// </summary>
    public static readonly ServiceTypeCode ExperimentalDrugTherapy = new(
        Values.ExperimentalDrugTherapy
    );

    /// <summary>
    /// Burn Care
    /// </summary>
    public static readonly ServiceTypeCode BurnCare = new(Values.BurnCare);

    /// <summary>
    /// Brand Name Prescription Drug - Formulary
    /// </summary>
    public static readonly ServiceTypeCode BrandNamePrescriptionDrugFormulary = new(
        Values.BrandNamePrescriptionDrugFormulary
    );

    /// <summary>
    /// Brand Name Prescription Drug - Non-Formulary
    /// </summary>
    public static readonly ServiceTypeCode BrandNamePrescriptionDrugNonFormulary = new(
        Values.BrandNamePrescriptionDrugNonFormulary
    );

    /// <summary>
    /// Independent Medical Evaluation
    /// </summary>
    public static readonly ServiceTypeCode IndependentMedicalEvaluation = new(
        Values.IndependentMedicalEvaluation
    );

    /// <summary>
    /// Partial Hospitalization (Psychiatric)
    /// </summary>
    public static readonly ServiceTypeCode PartialHospitalizationPsychiatric = new(
        Values.PartialHospitalizationPsychiatric
    );

    /// <summary>
    /// Day Care (Psychiatric)
    /// </summary>
    public static readonly ServiceTypeCode DayCarePsychiatric = new(Values.DayCarePsychiatric);

    /// <summary>
    /// Cognitive Therapy
    /// </summary>
    public static readonly ServiceTypeCode CognitiveTherapy = new(Values.CognitiveTherapy);

    /// <summary>
    /// Massage Therapy
    /// </summary>
    public static readonly ServiceTypeCode MassageTherapy = new(Values.MassageTherapy);

    /// <summary>
    /// Pulmonary Rehabilitation
    /// </summary>
    public static readonly ServiceTypeCode PulmonaryRehabilitation = new(
        Values.PulmonaryRehabilitation
    );

    /// <summary>
    /// Cardiac Rehabilitation
    /// </summary>
    public static readonly ServiceTypeCode CardiacRehabilitation = new(
        Values.CardiacRehabilitation
    );

    /// <summary>
    /// Pediatric
    /// </summary>
    public static readonly ServiceTypeCode Pediatric = new(Values.Pediatric);

    /// <summary>
    /// Nursery
    /// </summary>
    public static readonly ServiceTypeCode Nursery = new(Values.Nursery);

    /// <summary>
    /// Skin
    /// </summary>
    public static readonly ServiceTypeCode Skin = new(Values.Skin);

    /// <summary>
    /// Orthopedic
    /// </summary>
    public static readonly ServiceTypeCode Orthopedic = new(Values.Orthopedic);

    /// <summary>
    /// Cardiac
    /// </summary>
    public static readonly ServiceTypeCode Cardiac = new(Values.Cardiac);

    /// <summary>
    /// Lymphatic
    /// </summary>
    public static readonly ServiceTypeCode Lymphatic = new(Values.Lymphatic);

    /// <summary>
    /// Gastrointestinal
    /// </summary>
    public static readonly ServiceTypeCode Gastrointestinal = new(Values.Gastrointestinal);

    /// <summary>
    /// Endocrine
    /// </summary>
    public static readonly ServiceTypeCode Endocrine = new(Values.Endocrine);

    /// <summary>
    /// Neurology
    /// </summary>
    public static readonly ServiceTypeCode Neurology = new(Values.Neurology);

    /// <summary>
    /// Eye
    /// </summary>
    public static readonly ServiceTypeCode Eye = new(Values.Eye);

    /// <summary>
    /// Invasive Procedures
    /// </summary>
    public static readonly ServiceTypeCode InvasiveProcedures = new(Values.InvasiveProcedures);

    /// <summary>
    /// Gynecological
    /// </summary>
    public static readonly ServiceTypeCode Gynecological = new(Values.Gynecological);

    /// <summary>
    /// Obstetrical
    /// </summary>
    public static readonly ServiceTypeCode Obstetrical = new(Values.Obstetrical);

    /// <summary>
    /// Obstetrical/Gynecological
    /// </summary>
    public static readonly ServiceTypeCode ObstetricalGynecological = new(
        Values.ObstetricalGynecological
    );

    /// <summary>
    /// Mail Order Prescription Drug - Brand Name
    /// </summary>
    public static readonly ServiceTypeCode MailOrderPrescriptionDrugBrandName = new(
        Values.MailOrderPrescriptionDrugBrandName
    );

    /// <summary>
    /// Mail Order Prescription Drug - Generic
    /// </summary>
    public static readonly ServiceTypeCode MailOrderPrescriptionDrugGeneric = new(
        Values.MailOrderPrescriptionDrugGeneric
    );

    /// <summary>
    /// Physician Visit - Office - Sick
    /// </summary>
    public static readonly ServiceTypeCode PhysicianVisitOfficeSick = new(
        Values.PhysicianVisitOfficeSick
    );

    /// <summary>
    /// Physician Visit - Office - Well
    /// </summary>
    public static readonly ServiceTypeCode PhysicianVisitOfficeWell = new(
        Values.PhysicianVisitOfficeWell
    );

    /// <summary>
    /// Coronary Care
    /// </summary>
    public static readonly ServiceTypeCode CoronaryCare = new(Values.CoronaryCare);

    /// <summary>
    /// Private Duty Nursing - Inpatient
    /// </summary>
    public static readonly ServiceTypeCode PrivateDutyNursingInpatient = new(
        Values.PrivateDutyNursingInpatient
    );

    /// <summary>
    /// Private Duty Nursing - Home
    /// </summary>
    public static readonly ServiceTypeCode PrivateDutyNursingHome = new(
        Values.PrivateDutyNursingHome
    );

    /// <summary>
    /// Surgical Benefits - Professional (Physician)
    /// </summary>
    public static readonly ServiceTypeCode SurgicalBenefitsProfessionalPhysician = new(
        Values.SurgicalBenefitsProfessionalPhysician
    );

    /// <summary>
    /// Surgical Benefits - Facility
    /// </summary>
    public static readonly ServiceTypeCode SurgicalBenefitsFacility = new(
        Values.SurgicalBenefitsFacility
    );

    /// <summary>
    /// Mental Health Provider - Inpatient
    /// </summary>
    public static readonly ServiceTypeCode MentalHealthProviderInpatient = new(
        Values.MentalHealthProviderInpatient
    );

    /// <summary>
    /// Mental Health Provider - Outpatient
    /// </summary>
    public static readonly ServiceTypeCode MentalHealthProviderOutpatient = new(
        Values.MentalHealthProviderOutpatient
    );

    /// <summary>
    /// Mental Health Facility - Inpatient
    /// </summary>
    public static readonly ServiceTypeCode MentalHealthFacilityInpatient = new(
        Values.MentalHealthFacilityInpatient
    );

    /// <summary>
    /// Mental Health Facility - Outpatient
    /// </summary>
    public static readonly ServiceTypeCode MentalHealthFacilityOutpatient = new(
        Values.MentalHealthFacilityOutpatient
    );

    /// <summary>
    /// Substance Abuse Facility - Inpatient
    /// </summary>
    public static readonly ServiceTypeCode SubstanceAbuseFacilityInpatient = new(
        Values.SubstanceAbuseFacilityInpatient
    );

    /// <summary>
    /// Substance Abuse Facility - Outpatient
    /// </summary>
    public static readonly ServiceTypeCode SubstanceAbuseFacilityOutpatient = new(
        Values.SubstanceAbuseFacilityOutpatient
    );

    /// <summary>
    /// Screening X-ray
    /// </summary>
    public static readonly ServiceTypeCode ScreeningXRay = new(Values.ScreeningXRay);

    /// <summary>
    /// Screening laboratory
    /// </summary>
    public static readonly ServiceTypeCode ScreeningLaboratory = new(Values.ScreeningLaboratory);

    /// <summary>
    /// Mammogram, High Risk Patient
    /// </summary>
    public static readonly ServiceTypeCode MammogramHighRiskPatient = new(
        Values.MammogramHighRiskPatient
    );

    /// <summary>
    /// Mammogram, Low Risk Patient
    /// </summary>
    public static readonly ServiceTypeCode MammogramLowRiskPatient = new(
        Values.MammogramLowRiskPatient
    );

    /// <summary>
    /// Flu Vaccination
    /// </summary>
    public static readonly ServiceTypeCode FluVaccination = new(Values.FluVaccination);

    /// <summary>
    /// Eyewear and Eyewear Accessories
    /// </summary>
    public static readonly ServiceTypeCode EyewearAndEyewearAccessories = new(
        Values.EyewearAndEyewearAccessories
    );

    /// <summary>
    /// Case Management
    /// </summary>
    public static readonly ServiceTypeCode CaseManagement = new(Values.CaseManagement);

    /// <summary>
    /// Dermatology
    /// </summary>
    public static readonly ServiceTypeCode Dermatology = new(Values.Dermatology);

    /// <summary>
    /// Durable Medical Equipment
    /// </summary>
    public static readonly ServiceTypeCode DurableMedicalEquipment = new(
        Values.DurableMedicalEquipment
    );

    /// <summary>
    /// Diabetic Supplies
    /// </summary>
    public static readonly ServiceTypeCode DiabeticSupplies = new(Values.DiabeticSupplies);

    /// <summary>
    /// Generic Prescription Drug - Formulary
    /// </summary>
    public static readonly ServiceTypeCode GenericPrescriptionDrugFormulary = new(
        Values.GenericPrescriptionDrugFormulary
    );

    /// <summary>
    /// Generic Prescription Drug - Non-Formulary
    /// </summary>
    public static readonly ServiceTypeCode GenericPrescriptionDrugNonFormulary = new(
        Values.GenericPrescriptionDrugNonFormulary
    );

    /// <summary>
    /// Allergy
    /// </summary>
    public static readonly ServiceTypeCode Allergy = new(Values.Allergy);

    /// <summary>
    /// Intensive Care
    /// </summary>
    public static readonly ServiceTypeCode IntensiveCare = new(Values.IntensiveCare);

    /// <summary>
    /// Mental Health
    /// </summary>
    public static readonly ServiceTypeCode MentalHealth = new(Values.MentalHealth);

    /// <summary>
    /// Neonatal Intensive Care
    /// </summary>
    public static readonly ServiceTypeCode NeonatalIntensiveCare = new(
        Values.NeonatalIntensiveCare
    );

    /// <summary>
    /// Oncology
    /// </summary>
    public static readonly ServiceTypeCode Oncology = new(Values.Oncology);

    /// <summary>
    /// Physical Therapy
    /// </summary>
    public static readonly ServiceTypeCode PhysicalTherapy = new(Values.PhysicalTherapy);

    /// <summary>
    /// Pulmonary
    /// </summary>
    public static readonly ServiceTypeCode Pulmonary = new(Values.Pulmonary);

    /// <summary>
    /// Renal
    /// </summary>
    public static readonly ServiceTypeCode Renal = new(Values.Renal);

    /// <summary>
    /// Residential Psychiatric Treatment
    /// </summary>
    public static readonly ServiceTypeCode ResidentialPsychiatricTreatment = new(
        Values.ResidentialPsychiatricTreatment
    );

    /// <summary>
    /// Transitional Care
    /// </summary>
    public static readonly ServiceTypeCode TransitionalCare = new(Values.TransitionalCare);

    /// <summary>
    /// Transitional Nursery Care
    /// </summary>
    public static readonly ServiceTypeCode TransitionalNurseryCare = new(
        Values.TransitionalNurseryCare
    );

    /// <summary>
    /// Urgent Care
    /// </summary>
    public static readonly ServiceTypeCode UrgentCare = new(Values.UrgentCare);

    public ServiceTypeCode(string value)
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
    public static ServiceTypeCode FromCustom(string value)
    {
        return new ServiceTypeCode(value);
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

    public static bool operator ==(ServiceTypeCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ServiceTypeCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ServiceTypeCode value) => value.Value;

    public static explicit operator ServiceTypeCode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// Medical Care
        /// </summary>
        public const string MedicalCare = "1";

        /// <summary>
        /// Surgical
        /// </summary>
        public const string Surgical = "2";

        /// <summary>
        /// Consultation
        /// </summary>
        public const string Consultation = "3";

        /// <summary>
        /// Diagnostic X-Ray
        /// </summary>
        public const string DiagnosticXRay = "4";

        /// <summary>
        /// Diagnostic Lab
        /// </summary>
        public const string DiagnosticLab = "5";

        /// <summary>
        /// Radiation Therapy
        /// </summary>
        public const string RadiationTherapy = "6";

        /// <summary>
        /// Anesthesia
        /// </summary>
        public const string Anesthesia = "7";

        /// <summary>
        /// Surgical Assistance
        /// </summary>
        public const string SurgicalAssistance = "8";

        /// <summary>
        /// Other Medical
        /// </summary>
        public const string OtherMedical = "9";

        /// <summary>
        /// Blood Charges
        /// </summary>
        public const string BloodCharges = "10";

        /// <summary>
        /// Used Durable Medical Equipment
        /// </summary>
        public const string UsedDurableMedicalEquipment = "11";

        /// <summary>
        /// Durable Medical Equipment Purchase
        /// </summary>
        public const string DurableMedicalEquipmentPurchase = "12";

        /// <summary>
        /// Ambulatory Service Center Facility
        /// </summary>
        public const string AmbulatorySurgicalCenterFacility = "13";

        /// <summary>
        /// Renal Supplies in the Home
        /// </summary>
        public const string RenalSuppliesInHome = "14";

        /// <summary>
        /// Alternate Method Dialysis
        /// </summary>
        public const string AlternateMethodDialysis = "15";

        /// <summary>
        /// Chronic Renal Disease (CRD) Equipment
        /// </summary>
        public const string ChronicRenalDiseaseEquipment = "16";

        /// <summary>
        /// Pre-Admission Testing
        /// </summary>
        public const string PreAdmissionTesting = "17";

        /// <summary>
        /// Durable Medical Equipment Rental
        /// </summary>
        public const string DurableMedicalEquipmentRental = "18";

        /// <summary>
        /// Pneumonia Vaccine
        /// </summary>
        public const string PneumoniaVaccine = "19";

        /// <summary>
        /// Second Surgical Opinion
        /// </summary>
        public const string SecondSurgicalOpinion = "20";

        /// <summary>
        /// Third Surgical Opinion
        /// </summary>
        public const string ThirdSurgicalOpinion = "21";

        /// <summary>
        /// Social Work
        /// </summary>
        public const string SocialWork = "22";

        /// <summary>
        /// Diagnostic Dental
        /// </summary>
        public const string DiagnosticDental = "23";

        /// <summary>
        /// Periodontics
        /// </summary>
        public const string Periodontics = "24";

        /// <summary>
        /// Restorative
        /// </summary>
        public const string Restorative = "25";

        /// <summary>
        /// Endodontics
        /// </summary>
        public const string Endodontics = "26";

        /// <summary>
        /// Maxillofacial Prosthetics
        /// </summary>
        public const string MaxillofacialProsthetics = "27";

        /// <summary>
        /// Adjunctive Dental Services
        /// </summary>
        public const string AdjunctiveDentalServices = "28";

        /// <summary>
        /// Health Benefit Plan Coverage
        /// </summary>
        public const string HealthBenefitPlanCoverage = "30";

        /// <summary>
        /// Plan Waiting Period
        /// </summary>
        public const string PlanWaitingPeriod = "32";

        /// <summary>
        /// Chiropractic
        /// </summary>
        public const string Chiropractic = "33";

        /// <summary>
        /// Chiropractic Office Visits
        /// </summary>
        public const string ChiropracticOfficeVisits = "34";

        /// <summary>
        /// Dental Care
        /// </summary>
        public const string DentalCare = "35";

        /// <summary>
        /// Dental Crowns
        /// </summary>
        public const string DentalCrowns = "36";

        /// <summary>
        /// Dental Accident
        /// </summary>
        public const string DentalAccident = "37";

        /// <summary>
        /// Orthodontics
        /// </summary>
        public const string Orthodontics = "38";

        /// <summary>
        /// Prosthodontics
        /// </summary>
        public const string Prosthodontics = "39";

        /// <summary>
        /// Oral Surgery
        /// </summary>
        public const string OralSurgery = "40";

        /// <summary>
        /// Routine (Preventive) Dental
        /// </summary>
        public const string RoutinePreventiveDental = "41";

        /// <summary>
        /// Home Health Care
        /// </summary>
        public const string HomeHealthCare = "42";

        /// <summary>
        /// Home Health Prescriptions
        /// </summary>
        public const string HomeHealthPrescriptions = "43";

        /// <summary>
        /// Home Health Visits
        /// </summary>
        public const string HomeHealthVisits = "44";

        /// <summary>
        /// Hospice
        /// </summary>
        public const string Hospice = "45";

        /// <summary>
        /// Respite Care
        /// </summary>
        public const string RespiteCare = "46";

        /// <summary>
        /// Hospital
        /// </summary>
        public const string Hospital = "47";

        /// <summary>
        /// Hospital - Inpatient
        /// </summary>
        public const string HospitalInpatient = "48";

        /// <summary>
        /// Hospital - Room and Board
        /// </summary>
        public const string HospitalRoomAndBoard = "49";

        /// <summary>
        /// Hospital - Outpatient
        /// </summary>
        public const string HospitalOutpatient = "50";

        /// <summary>
        /// Hospital - Emergency Accident
        /// </summary>
        public const string HospitalEmergencyAccident = "51";

        /// <summary>
        /// Hospital - Emergency Medical
        /// </summary>
        public const string HospitalEmergencyMedical = "52";

        /// <summary>
        /// Hospital - Ambulatory Surgical
        /// </summary>
        public const string HospitalAmbulatorySurgical = "53";

        /// <summary>
        /// Long Term Care
        /// </summary>
        public const string LongTermCare = "54";

        /// <summary>
        /// Major Medical
        /// </summary>
        public const string MajorMedical = "55";

        /// <summary>
        /// Medically Related Transportation
        /// </summary>
        public const string MedicallyRelatedTransportation = "56";

        /// <summary>
        /// Air Transportation
        /// </summary>
        public const string AirTransportation = "57";

        /// <summary>
        /// Cabulance
        /// </summary>
        public const string Cabulance = "58";

        /// <summary>
        /// Licensed Ambulance
        /// </summary>
        public const string LicensedAmbulance = "59";

        /// <summary>
        /// General Benefits
        /// </summary>
        public const string GeneralBenefits = "60";

        /// <summary>
        /// In-vitro Fertilization
        /// </summary>
        public const string InVitroFertilization = "61";

        /// <summary>
        /// MRI/CAT Scan
        /// </summary>
        public const string MricatScan = "62";

        /// <summary>
        /// Donor Procedures
        /// </summary>
        public const string DonorProcedures = "63";

        /// <summary>
        /// Acupuncture
        /// </summary>
        public const string Acupuncture = "64";

        /// <summary>
        /// Newborn Care
        /// </summary>
        public const string NewbornCare = "65";

        /// <summary>
        /// Pathology
        /// </summary>
        public const string Pathology = "66";

        /// <summary>
        /// Smoking Cessation
        /// </summary>
        public const string SmokingCessation = "67";

        /// <summary>
        /// Well Baby Care
        /// </summary>
        public const string WellBabyCare = "68";

        /// <summary>
        /// Maternity
        /// </summary>
        public const string Maternity = "69";

        /// <summary>
        /// Transplants
        /// </summary>
        public const string Transplants = "70";

        /// <summary>
        /// Audiology Exam
        /// </summary>
        public const string AudiologyExam = "71";

        /// <summary>
        /// Inhalation Therapy
        /// </summary>
        public const string InhalationTherapy = "72";

        /// <summary>
        /// Diagnostic Medical
        /// </summary>
        public const string DiagnosticMedical = "73";

        /// <summary>
        /// Private Duty Nursing
        /// </summary>
        public const string PrivateDutyNursing = "74";

        /// <summary>
        /// Prosthetic Device
        /// </summary>
        public const string ProstheticDevice = "75";

        /// <summary>
        /// Dialysis
        /// </summary>
        public const string Dialysis = "76";

        /// <summary>
        /// Otological Exam
        /// </summary>
        public const string OtologicalExam = "77";

        /// <summary>
        /// Chemotherapy
        /// </summary>
        public const string Chemotherapy = "78";

        /// <summary>
        /// Allergy Testing
        /// </summary>
        public const string AllergyTesting = "79";

        /// <summary>
        /// Immunizations
        /// </summary>
        public const string Immunizations = "80";

        /// <summary>
        /// Routine Physical
        /// </summary>
        public const string RoutinePhysical = "81";

        /// <summary>
        /// Family Planning
        /// </summary>
        public const string FamilyPlanning = "82";

        /// <summary>
        /// Infertility
        /// </summary>
        public const string Infertility = "83";

        /// <summary>
        /// Abortion
        /// </summary>
        public const string Abortion = "84";

        /// <summary>
        /// AIDS
        /// </summary>
        public const string Aids = "85";

        /// <summary>
        /// Emergency Services
        /// </summary>
        public const string EmergencyServices = "86";

        /// <summary>
        /// Cancer
        /// </summary>
        public const string Cancer = "87";

        /// <summary>
        /// Pharmacy
        /// </summary>
        public const string Pharmacy = "88";

        /// <summary>
        /// Free Standing Prescription Drug
        /// </summary>
        public const string FreeStandingPrescriptionDrug = "89";

        /// <summary>
        /// Mail Order Prescription Drug
        /// </summary>
        public const string MailOrderPrescriptionDrug = "90";

        /// <summary>
        /// Brand Name Prescription Drug
        /// </summary>
        public const string BrandNamePrescriptionDrug = "91";

        /// <summary>
        /// Generic Prescription Drug
        /// </summary>
        public const string GenericPrescriptionDrug = "92";

        /// <summary>
        /// Podiatry
        /// </summary>
        public const string Podiatry = "93";

        /// <summary>
        /// Podiatry - Office Visits
        /// </summary>
        public const string PodiatryOfficeVisits = "94";

        /// <summary>
        /// Podiatry - Nursing Home Visits
        /// </summary>
        public const string PodiatryNursingHomeVisits = "95";

        /// <summary>
        /// Professional (Physician)
        /// </summary>
        public const string ProfessionalPhysician = "96";

        /// <summary>
        /// Anesthesiologist
        /// </summary>
        public const string Anesthesiologist = "97";

        /// <summary>
        /// Professional (Physician) Visit - Office
        /// </summary>
        public const string ProfessionalPhysicianVisitOffice = "98";

        /// <summary>
        /// Professional (Physician) Visit - Inpatient
        /// </summary>
        public const string ProfessionalPhysicianVisitInpatient = "99";

        /// <summary>
        /// Professional (Physician) Visit - Outpatient
        /// </summary>
        public const string ProfessionalPhysicianVisitOutpatient = "A0";

        /// <summary>
        /// Professional (Physician) Visit - Nursing Home
        /// </summary>
        public const string ProfessionalPhysicianVisitNursingHome = "A1";

        /// <summary>
        /// Professional (Physician) Visit - Skilled Nursing Facility
        /// </summary>
        public const string ProfessionalPhysicianVisitSkilledNursingFacility = "A2";

        /// <summary>
        /// Professional (Physician) Visit - Home
        /// </summary>
        public const string ProfessionalPhysicianVisitHome = "A3";

        /// <summary>
        /// Psychiatric
        /// </summary>
        public const string Psychiatric = "A4";

        /// <summary>
        /// Psychiatric - Room and Board
        /// </summary>
        public const string PsychiatricRoomAndBoard = "A5";

        /// <summary>
        /// Psychotherapy
        /// </summary>
        public const string Psychotherapy = "A6";

        /// <summary>
        /// Psychiatric - Inpatient
        /// </summary>
        public const string PsychiatricInpatient = "A7";

        /// <summary>
        /// Psychiatric - Outpatient
        /// </summary>
        public const string PsychiatricOutpatient = "A8";

        /// <summary>
        /// Rehabilitation
        /// </summary>
        public const string Rehabilitation = "A9";

        /// <summary>
        /// Rehabilitation - Room and Board
        /// </summary>
        public const string RehabilitationRoomAndBoard = "AA";

        /// <summary>
        /// Rehabilitation - Inpatient
        /// </summary>
        public const string RehabilitationInpatient = "AB";

        /// <summary>
        /// Rehabilitation - Outpatient
        /// </summary>
        public const string RehabilitationOutpatient = "AC";

        /// <summary>
        /// Occupational Therapy
        /// </summary>
        public const string OccupationalTherapy = "AD";

        /// <summary>
        /// Physical Medicine
        /// </summary>
        public const string PhysicalMedicine = "AE";

        /// <summary>
        /// Speech Therapy
        /// </summary>
        public const string SpeechTherapy = "AF";

        /// <summary>
        /// Skilled Nursing Care
        /// </summary>
        public const string SkilledNursingCare = "AG";

        /// <summary>
        /// Skilled Nursing Care - Room and Board
        /// </summary>
        public const string SkilledNursingCareRoomAndBoard = "AH";

        /// <summary>
        /// Substance Abuse
        /// </summary>
        public const string SubstanceAbuse = "AI";

        /// <summary>
        /// Alcoholism
        /// </summary>
        public const string Alcoholism = "AJ";

        /// <summary>
        /// Drug Addiction
        /// </summary>
        public const string DrugAddiction = "AK";

        /// <summary>
        /// Vision (Optometry)
        /// </summary>
        public const string VisionOptometry = "AL";

        /// <summary>
        /// Frames
        /// </summary>
        public const string Frames = "AM";

        /// <summary>
        /// Routine Exam
        /// </summary>
        public const string RoutineExam = "AN";

        /// <summary>
        /// Lenses
        /// </summary>
        public const string Lenses = "AO";

        /// <summary>
        /// Nonmedically Necessary Physical
        /// </summary>
        public const string NonmedicallyNecessaryPhysical = "AQ";

        /// <summary>
        /// Experimental Drug Therapy
        /// </summary>
        public const string ExperimentalDrugTherapy = "AR";

        /// <summary>
        /// Burn Care
        /// </summary>
        public const string BurnCare = "B1";

        /// <summary>
        /// Brand Name Prescription Drug - Formulary
        /// </summary>
        public const string BrandNamePrescriptionDrugFormulary = "B2";

        /// <summary>
        /// Brand Name Prescription Drug - Non-Formulary
        /// </summary>
        public const string BrandNamePrescriptionDrugNonFormulary = "B3";

        /// <summary>
        /// Independent Medical Evaluation
        /// </summary>
        public const string IndependentMedicalEvaluation = "BA";

        /// <summary>
        /// Partial Hospitalization (Psychiatric)
        /// </summary>
        public const string PartialHospitalizationPsychiatric = "BB";

        /// <summary>
        /// Day Care (Psychiatric)
        /// </summary>
        public const string DayCarePsychiatric = "BC";

        /// <summary>
        /// Cognitive Therapy
        /// </summary>
        public const string CognitiveTherapy = "BD";

        /// <summary>
        /// Massage Therapy
        /// </summary>
        public const string MassageTherapy = "BE";

        /// <summary>
        /// Pulmonary Rehabilitation
        /// </summary>
        public const string PulmonaryRehabilitation = "BF";

        /// <summary>
        /// Cardiac Rehabilitation
        /// </summary>
        public const string CardiacRehabilitation = "BG";

        /// <summary>
        /// Pediatric
        /// </summary>
        public const string Pediatric = "BH";

        /// <summary>
        /// Nursery
        /// </summary>
        public const string Nursery = "BI";

        /// <summary>
        /// Skin
        /// </summary>
        public const string Skin = "BJ";

        /// <summary>
        /// Orthopedic
        /// </summary>
        public const string Orthopedic = "BK";

        /// <summary>
        /// Cardiac
        /// </summary>
        public const string Cardiac = "BL";

        /// <summary>
        /// Lymphatic
        /// </summary>
        public const string Lymphatic = "BM";

        /// <summary>
        /// Gastrointestinal
        /// </summary>
        public const string Gastrointestinal = "BN";

        /// <summary>
        /// Endocrine
        /// </summary>
        public const string Endocrine = "BP";

        /// <summary>
        /// Neurology
        /// </summary>
        public const string Neurology = "BQ";

        /// <summary>
        /// Eye
        /// </summary>
        public const string Eye = "BR";

        /// <summary>
        /// Invasive Procedures
        /// </summary>
        public const string InvasiveProcedures = "BS";

        /// <summary>
        /// Gynecological
        /// </summary>
        public const string Gynecological = "BT";

        /// <summary>
        /// Obstetrical
        /// </summary>
        public const string Obstetrical = "BU";

        /// <summary>
        /// Obstetrical/Gynecological
        /// </summary>
        public const string ObstetricalGynecological = "BV";

        /// <summary>
        /// Mail Order Prescription Drug - Brand Name
        /// </summary>
        public const string MailOrderPrescriptionDrugBrandName = "BW";

        /// <summary>
        /// Mail Order Prescription Drug - Generic
        /// </summary>
        public const string MailOrderPrescriptionDrugGeneric = "BX";

        /// <summary>
        /// Physician Visit - Office - Sick
        /// </summary>
        public const string PhysicianVisitOfficeSick = "BY";

        /// <summary>
        /// Physician Visit - Office - Well
        /// </summary>
        public const string PhysicianVisitOfficeWell = "BZ";

        /// <summary>
        /// Coronary Care
        /// </summary>
        public const string CoronaryCare = "C1";

        /// <summary>
        /// Private Duty Nursing - Inpatient
        /// </summary>
        public const string PrivateDutyNursingInpatient = "CA";

        /// <summary>
        /// Private Duty Nursing - Home
        /// </summary>
        public const string PrivateDutyNursingHome = "CB";

        /// <summary>
        /// Surgical Benefits - Professional (Physician)
        /// </summary>
        public const string SurgicalBenefitsProfessionalPhysician = "CC";

        /// <summary>
        /// Surgical Benefits - Facility
        /// </summary>
        public const string SurgicalBenefitsFacility = "CD";

        /// <summary>
        /// Mental Health Provider - Inpatient
        /// </summary>
        public const string MentalHealthProviderInpatient = "CE";

        /// <summary>
        /// Mental Health Provider - Outpatient
        /// </summary>
        public const string MentalHealthProviderOutpatient = "CF";

        /// <summary>
        /// Mental Health Facility - Inpatient
        /// </summary>
        public const string MentalHealthFacilityInpatient = "CG";

        /// <summary>
        /// Mental Health Facility - Outpatient
        /// </summary>
        public const string MentalHealthFacilityOutpatient = "CH";

        /// <summary>
        /// Substance Abuse Facility - Inpatient
        /// </summary>
        public const string SubstanceAbuseFacilityInpatient = "CI";

        /// <summary>
        /// Substance Abuse Facility - Outpatient
        /// </summary>
        public const string SubstanceAbuseFacilityOutpatient = "CJ";

        /// <summary>
        /// Screening X-ray
        /// </summary>
        public const string ScreeningXRay = "CK";

        /// <summary>
        /// Screening laboratory
        /// </summary>
        public const string ScreeningLaboratory = "CL";

        /// <summary>
        /// Mammogram, High Risk Patient
        /// </summary>
        public const string MammogramHighRiskPatient = "CM";

        /// <summary>
        /// Mammogram, Low Risk Patient
        /// </summary>
        public const string MammogramLowRiskPatient = "CN";

        /// <summary>
        /// Flu Vaccination
        /// </summary>
        public const string FluVaccination = "CO";

        /// <summary>
        /// Eyewear and Eyewear Accessories
        /// </summary>
        public const string EyewearAndEyewearAccessories = "CP";

        /// <summary>
        /// Case Management
        /// </summary>
        public const string CaseManagement = "CQ";

        /// <summary>
        /// Dermatology
        /// </summary>
        public const string Dermatology = "DG";

        /// <summary>
        /// Durable Medical Equipment
        /// </summary>
        public const string DurableMedicalEquipment = "DM";

        /// <summary>
        /// Diabetic Supplies
        /// </summary>
        public const string DiabeticSupplies = "DS";

        /// <summary>
        /// Generic Prescription Drug - Formulary
        /// </summary>
        public const string GenericPrescriptionDrugFormulary = "GF";

        /// <summary>
        /// Generic Prescription Drug - Non-Formulary
        /// </summary>
        public const string GenericPrescriptionDrugNonFormulary = "GN";

        /// <summary>
        /// Allergy
        /// </summary>
        public const string Allergy = "GY";

        /// <summary>
        /// Intensive Care
        /// </summary>
        public const string IntensiveCare = "IC";

        /// <summary>
        /// Mental Health
        /// </summary>
        public const string MentalHealth = "MH";

        /// <summary>
        /// Neonatal Intensive Care
        /// </summary>
        public const string NeonatalIntensiveCare = "NI";

        /// <summary>
        /// Oncology
        /// </summary>
        public const string Oncology = "ON";

        /// <summary>
        /// Physical Therapy
        /// </summary>
        public const string PhysicalTherapy = "PT";

        /// <summary>
        /// Pulmonary
        /// </summary>
        public const string Pulmonary = "PU";

        /// <summary>
        /// Renal
        /// </summary>
        public const string Renal = "RN";

        /// <summary>
        /// Residential Psychiatric Treatment
        /// </summary>
        public const string ResidentialPsychiatricTreatment = "RT";

        /// <summary>
        /// Transitional Care
        /// </summary>
        public const string TransitionalCare = "TC";

        /// <summary>
        /// Transitional Nursery Care
        /// </summary>
        public const string TransitionalNurseryCare = "TN";

        /// <summary>
        /// Urgent Care
        /// </summary>
        public const string UrgentCare = "UC";
    }
}
