using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.OrganizationServiceFacilities.V2;

[JsonConverter(typeof(StringEnumSerializer<ServiceFacilityType>))]
[Serializable]
public readonly record struct ServiceFacilityType : IStringEnum
{
    /// <summary>
    /// A practice setting where diagnostic procedures or therapeutic interventions are performed.
    /// </summary>
    public static readonly ServiceFacilityType DiagnosticsOrTherapeuticsUnit = new(
        Values.DiagnosticsOrTherapeuticsUnit
    );

    /// <summary>
    /// A practice setting where cardiovascular diagnostic procedures or therapeutic interventions are performed.
    /// </summary>
    public static readonly ServiceFacilityType CardiovascularDiagnosticsOrTherapeuticsUnit = new(
        Values.CardiovascularDiagnosticsOrTherapeuticsUnit
    );

    /// <summary>
    /// Cardiac catheterization lab.
    /// </summary>
    public static readonly ServiceFacilityType CardiacCatheterizationLab = new(
        Values.CardiacCatheterizationLab
    );

    /// <summary>
    /// Echocardiography lab.
    /// </summary>
    public static readonly ServiceFacilityType EchocardiographyLab = new(
        Values.EchocardiographyLab
    );

    /// <summary>
    /// A practice setting where GI procedures (such as endoscopies) are performed.
    /// </summary>
    public static readonly ServiceFacilityType GastroenterologyDiagnosticsOrTherapeuticsLab = new(
        Values.GastroenterologyDiagnosticsOrTherapeuticsLab
    );

    /// <summary>
    /// (X12N 261QD0000N)
    /// </summary>
    public static readonly ServiceFacilityType EndoscopyLab = new(Values.EndoscopyLab);

    /// <summary>
    /// A practice setting where radiology services (diagnostic or therapeutic) are provided (X12N 261QR0200N).
    /// </summary>
    public static readonly ServiceFacilityType RadiologyDiagnosticsOrTherapeuticsUnit = new(
        Values.RadiologyDiagnosticsOrTherapeuticsUnit
    );

    /// <summary>
    /// (X12N 261QX0203N)
    /// </summary>
    public static readonly ServiceFacilityType RadiationOncologyUnit = new(
        Values.RadiationOncologyUnit
    );

    /// <summary>
    /// Neuroradiology unit.
    /// </summary>
    public static readonly ServiceFacilityType NeuroradiologyUnit = new(Values.NeuroradiologyUnit);

    /// <summary>
    /// An acute care institution that provides medical, surgical, or psychiatric care and treatment for the sick or the injured.
    /// </summary>
    public static readonly ServiceFacilityType Hospital = new(Values.Hospital);

    /// <summary>
    /// (1) A hospital including a physical plant and personnel that provides multidisciplinary diagnosis and treatment for diseases  that have one or more of the following characteristics: is permanent; leaves residual disability; is caused by nonreversible  pathological alteration; requires special training of the patient for rehabilitation; and/or may be expected to require a long  period of supervision or care. In addition, patients require the safety, security, and shelter of these specialized inpatient  or partial hospitalization settings. (2) A hospital that provides medical and skilled nursing services to patients with  long-term illnesses who are not in an acute phase but who require an intensity of services not available in nursing homes.
    /// </summary>
    public static readonly ServiceFacilityType ChronicCareFacility = new(
        Values.ChronicCareFacility
    );

    /// <summary>
    /// (X12N 282N00000N)
    /// </summary>
    public static readonly ServiceFacilityType HospitalsGeneralAcuteCareHospital = new(
        Values.HospitalsGeneralAcuteCareHospital
    );

    /// <summary>
    /// A health care facility operated by the Department of Defense or other military operation.
    /// </summary>
    public static readonly ServiceFacilityType MilitaryHospital = new(Values.MilitaryHospital);

    /// <summary>
    /// Healthcare facility that cares for patients with psychiatric illness(s).
    /// </summary>
    public static readonly ServiceFacilityType PsychatricCareFacility = new(
        Values.PsychatricCareFacility
    );

    /// <summary>
    /// (X12N 283X00000N)
    /// </summary>
    public static readonly ServiceFacilityType RehabilitationHospital = new(
        Values.RehabilitationHospital
    );

    /// <summary>
    /// A location that plays the role of delivering services which may include life training and/or social support to people with addictions.
    /// </summary>
    public static readonly ServiceFacilityType AddictionTreatmentCenter = new(
        Values.AddictionTreatmentCenter
    );

    /// <summary>
    /// A location that plays the role of delivering services which may include adaptation, rehabilitation and social integration services for people with intellectual and/or pervasive development disorders such as autism or severe behaviour disorder.
    /// </summary>
    public static readonly ServiceFacilityType IntellectualImpairmentCenter = new(
        Values.IntellectualImpairmentCenter
    );

    /// <summary>
    /// A location that plays the role of delivering services which may social support services for adolescents who are pregnant or have child and are experiencing adaptation issues/difficulties in their current or eventual parenting role.
    /// </summary>
    public static readonly ServiceFacilityType ParentsWithAdjustmentDifficultiesCenter = new(
        Values.ParentsWithAdjustmentDifficultiesCenter
    );

    /// <summary>
    /// A location that plays the role of delivering services which may include adaptation, rehabilitation and social integration services for people with physical impairments.
    /// </summary>
    public static readonly ServiceFacilityType PhysicalImpairmentCenter = new(
        Values.PhysicalImpairmentCenter
    );

    /// <summary>
    /// A location that plays the role of delivering services for people with hearing impairments.
    /// </summary>
    public static readonly ServiceFacilityType PhysicalImpairmentHearingCenter = new(
        Values.PhysicalImpairmentHearingCenter
    );

    /// <summary>
    /// A location that plays the role of delivering services for people with motor skill impairments.
    /// </summary>
    public static readonly ServiceFacilityType PhysicalImpairmentMotorSkillsCenter = new(
        Values.PhysicalImpairmentMotorSkillsCenter
    );

    /// <summary>
    /// A location that plays the role of delivering services for people with visual skill impairments.
    /// </summary>
    public static readonly ServiceFacilityType PhysicalImpairmentVisualSkillsCenter = new(
        Values.PhysicalImpairmentVisualSkillsCenter
    );

    /// <summary>
    /// A location that plays the role of delivering services which may include life training and/or social support services for the adaptation, rehabilitation and social integration of youths with adjustment difficulties.
    /// </summary>
    public static readonly ServiceFacilityType YouthsWithAdjustmentDifficultiesCenter = new(
        Values.YouthsWithAdjustmentDifficultiesCenter
    );

    /// <summary>
    /// Hospital unit.
    /// </summary>
    public static readonly ServiceFacilityType HospitalUnit = new(Values.HospitalUnit);

    /// <summary>
    /// Bone marrow transplant unit.
    /// </summary>
    public static readonly ServiceFacilityType BoneMarrowTransplantUnit = new(
        Values.BoneMarrowTransplantUnit
    );

    /// <summary>
    /// Coronary care unit.
    /// </summary>
    public static readonly ServiceFacilityType CoronaryCareUnit = new(Values.CoronaryCareUnit);

    /// <summary>
    /// A specialty unit in hospital that focuses on chronic respirator patients. and pulmonary failure
    /// </summary>
    public static readonly ServiceFacilityType ChestUnit = new(Values.ChestUnit);

    /// <summary>
    /// Epilepsy unit.
    /// </summary>
    public static readonly ServiceFacilityType EpilepsyUnit = new(Values.EpilepsyUnit);

    /// <summary>
    /// The section of a health care facility for providing rapid treatment to victims of sudden illness or trauma.
    /// </summary>
    public static readonly ServiceFacilityType EmergencyRoom = new(Values.EmergencyRoom);

    /// <summary>
    /// Emergency trauma unit.
    /// </summary>
    public static readonly ServiceFacilityType EmergencyTraumaUnit = new(
        Values.EmergencyTraumaUnit
    );

    /// <summary>
    /// Hemodialysis unit.
    /// </summary>
    public static readonly ServiceFacilityType HemodialysisUnit = new(Values.HemodialysisUnit);

    /// <summary>
    /// A location that plays the role of delivering services which may include tests done based on clinical specimens to get health information about a patient as pertaining to the diagnosis"
    /// </summary>
    public static readonly ServiceFacilityType HospitalLaboratory = new(Values.HospitalLaboratory);

    /// <summary>
    /// A location that plays the role of delivering services which may include tests are done on clinical specimens to get health information about a patient pertaining to the diagnosis.
    /// </summary>
    public static readonly ServiceFacilityType InpatientLaboratory = new(
        Values.InpatientLaboratory
    );

    /// <summary>
    /// A location that plays the role of delivering services which may include tests are done on clinical specimens to get health information about a patient pertaining to the diagnosis
    /// </summary>
    public static readonly ServiceFacilityType OutpatientLaboratory = new(
        Values.OutpatientLaboratory
    );

    /// <summary>
    /// A location that plays the role of delivering services which may include the branch of medicine that uses ionizing and non-ionizing radiation to diagnose and treat diseases. The radiology unit may be further dividedinto subspecialties such as Imaging, Cardiovascular, Thoracic, and Ultrasound.
    /// </summary>
    public static readonly ServiceFacilityType RadiologyUnit = new(Values.RadiologyUnit);

    /// <summary>
    /// A location that plays the role of delivering services which may include collecting specimens and/or samples from patients for laboratory testing purposes.
    /// </summary>
    public static readonly ServiceFacilityType SpecimenCollectionSite = new(
        Values.SpecimenCollectionSite
    );

    /// <summary>
    /// Intensive care unit.
    /// </summary>
    public static readonly ServiceFacilityType IntensiveCareUnit = new(Values.IntensiveCareUnit);

    /// <summary>
    /// Pediatric intensive care unit
    /// </summary>
    public static readonly ServiceFacilityType PediatricIntensiveCareUnit = new(
        Values.PediatricIntensiveCareUnit
    );

    /// <summary>
    /// Pediatric neonatal intensive care unit.
    /// </summary>
    public static readonly ServiceFacilityType PediatricNeonatalIntensiveCareUnit = new(
        Values.PediatricNeonatalIntensiveCareUnit
    );

    /// <summary>
    /// A location that plays the role of delivering services which may include providing judicious, safe, efficacious, appropriate and cost effective use of medicines for treatment of patients for visits longer than one day. The distinction between inpatient pharmacies and retail (or outpatient) pharmacies is that they are part of a patient's continuity of care while staying in the hospital.
    /// </summary>
    public static readonly ServiceFacilityType InpatientPharmacy = new(Values.InpatientPharmacy);

    /// <summary>
    /// A location that plays the role of delivering services which include biochemistry, hematology, microbiology, immunochemistry, and toxicology.
    /// </summary>
    public static readonly ServiceFacilityType MedicalLaboratory = new(Values.MedicalLaboratory);

    /// <summary>
    /// Neurology critical care and stroke unit.
    /// </summary>
    public static readonly ServiceFacilityType NeurologyCriticalCareAndStrokeUnit = new(
        Values.NeurologyCriticalCareAndStrokeUnit
    );

    /// <summary>
    /// Neurosurgery unit.
    /// </summary>
    public static readonly ServiceFacilityType NeurosurgeryUnit = new(Values.NeurosurgeryUnit);

    /// <summary>
    /// A location that plays the role of delivering services which may include providing judicious, safe, efficacious, appropriate and cost effective use of medicines for treatment of patients for outpatient visits and may also be used for discharge prescriptions.
    /// </summary>
    public static readonly ServiceFacilityType OutpatientPharmacy = new(Values.OutpatientPharmacy);

    /// <summary>
    /// Pediatric unit.
    /// </summary>
    public static readonly ServiceFacilityType PediatricUnit = new(Values.PediatricUnit);

    /// <summary>
    /// (X12N 273R00000N)
    /// </summary>
    public static readonly ServiceFacilityType PsychiatricHospitalUnit = new(
        Values.PsychiatricHospitalUnit
    );

    /// <summary>
    /// Rehabilitation hospital unit.
    /// </summary>
    public static readonly ServiceFacilityType RehabilitationHospitalUnit = new(
        Values.RehabilitationHospitalUnit
    );

    /// <summary>
    /// (X12N 261QA1200N)
    /// </summary>
    public static readonly ServiceFacilityType SleepDisordersUnit = new(Values.SleepDisordersUnit);

    /// <summary>
    /// Nursing or custodial care facility.
    /// </summary>
    public static readonly ServiceFacilityType NursingOrCustodialCareFacility = new(
        Values.NursingOrCustodialCareFacility
    );

    /// <summary>
    /// (X12N 314000000N)
    /// </summary>
    public static readonly ServiceFacilityType SkilledNursingFacility = new(
        Values.SkilledNursingFacility
    );

    /// <summary>
    /// Outpatient facility.
    /// </summary>
    public static readonly ServiceFacilityType OutpatientFacility = new(Values.OutpatientFacility);

    /// <summary>
    /// Allergy clinic.
    /// </summary>
    public static readonly ServiceFacilityType AllergyClinic = new(Values.AllergyClinic);

    /// <summary>
    /// Amputee clinic.
    /// </summary>
    public static readonly ServiceFacilityType AmputeeClinic = new(Values.AmputeeClinic);

    /// <summary>
    /// Bone marrow transplant clinic.
    /// </summary>
    public static readonly ServiceFacilityType BoneMarrowTransplantClinic = new(
        Values.BoneMarrowTransplantClinic
    );

    /// <summary>
    /// Breast clinic.
    /// </summary>
    public static readonly ServiceFacilityType BreastClinic = new(Values.BreastClinic);

    /// <summary>
    /// Child and adolescent neurology clinic.
    /// </summary>
    public static readonly ServiceFacilityType ChildAndAdolescentNeurologyClinic = new(
        Values.ChildAndAdolescentNeurologyClinic
    );

    /// <summary>
    /// Child and adolescent psychiatry clinic.
    /// </summary>
    public static readonly ServiceFacilityType ChildAndAdolescentPsychiatryClinic = new(
        Values.ChildAndAdolescentPsychiatryClinic
    );

    /// <summary>
    /// Ambulatory Health Care Facilities; Clinic/Center; Rehabilitation: Cardiac Facilities.
    /// </summary>
    public static readonly ServiceFacilityType AmbulatoryHealthCareFacilitiesClinicCenterRehabilitationCardiacFacilities =
        new(Values.AmbulatoryHealthCareFacilitiesClinicCenterRehabilitationCardiacFacilities);

    /// <summary>
    /// Pediatric cardiology clinic.
    /// </summary>
    public static readonly ServiceFacilityType PediatricCardiologyClinic = new(
        Values.PediatricCardiologyClinic
    );

    /// <summary>
    /// Coagulation clinic.
    /// </summary>
    public static readonly ServiceFacilityType CoagulationClinic = new(Values.CoagulationClinic);

    /// <summary>
    /// Colon and rectal surgery clinic.
    /// </summary>
    public static readonly ServiceFacilityType ColonAndRectalSurgeryClinic = new(
        Values.ColonAndRectalSurgeryClinic
    );

    /// <summary>
    /// Dermatology clinic.
    /// </summary>
    public static readonly ServiceFacilityType DermatologyClinic = new(Values.DermatologyClinic);

    /// <summary>
    /// Endocrinology clinic.
    /// </summary>
    public static readonly ServiceFacilityType EndocrinologyClinic = new(
        Values.EndocrinologyClinic
    );

    /// <summary>
    /// Pediatric endocrinology clinic.
    /// </summary>
    public static readonly ServiceFacilityType PediatricEndocrinologyClinic = new(
        Values.PediatricEndocrinologyClinic
    );

    /// <summary>
    /// Otorhinolaryngology clinic.
    /// </summary>
    public static readonly ServiceFacilityType OtorhinolaryngologyClinic = new(
        Values.OtorhinolaryngologyClinic
    );

    /// <summary>
    /// Family medicine clinic.
    /// </summary>
    public static readonly ServiceFacilityType FamilyMedicineClinic = new(
        Values.FamilyMedicineClinic
    );

    /// <summary>
    /// Gastroenterology clinic.
    /// </summary>
    public static readonly ServiceFacilityType GastroenterologyClinic = new(
        Values.GastroenterologyClinic
    );

    /// <summary>
    /// Pediatric gastroenterology clinic.
    /// </summary>
    public static readonly ServiceFacilityType PediatricGastroenterologyClinic = new(
        Values.PediatricGastroenterologyClinic
    );

    /// <summary>
    /// General internal medicine clinic.
    /// </summary>
    public static readonly ServiceFacilityType GeneralInternalMedicineClinic = new(
        Values.GeneralInternalMedicineClinic
    );

    /// <summary>
    /// Gynecology clinic.
    /// </summary>
    public static readonly ServiceFacilityType GynecologyClinic = new(Values.GynecologyClinic);

    /// <summary>
    /// Hematology clinic.
    /// </summary>
    public static readonly ServiceFacilityType HematologyClinic = new(Values.HematologyClinic);

    /// <summary>
    /// Pediatric hematology clinic.
    /// </summary>
    public static readonly ServiceFacilityType PediatricHematologyClinic = new(
        Values.PediatricHematologyClinic
    );

    /// <summary>
    /// Hypertension clinic.
    /// </summary>
    public static readonly ServiceFacilityType HypertensionClinic = new(Values.HypertensionClinic);

    /// <summary>
    /// Focuses on assessing disability.
    /// </summary>
    public static readonly ServiceFacilityType ImpairmentEvaluationCenter = new(
        Values.ImpairmentEvaluationCenter
    );

    /// <summary>
    /// Infectious disease clinic.
    /// </summary>
    public static readonly ServiceFacilityType InfectiousDiseaseClinic = new(
        Values.InfectiousDiseaseClinic
    );

    /// <summary>
    /// Pediatric infectious disease clinic.
    /// </summary>
    public static readonly ServiceFacilityType PediatricInfectiousDiseaseClinic = new(
        Values.PediatricInfectiousDiseaseClinic
    );

    /// <summary>
    /// Infertility clinic.
    /// </summary>
    public static readonly ServiceFacilityType InfertilityClinic = new(Values.InfertilityClinic);

    /// <summary>
    /// Lympedema clinic.
    /// </summary>
    public static readonly ServiceFacilityType LympedemaClinic = new(Values.LympedemaClinic);

    /// <summary>
    /// Medical genetics clinic.
    /// </summary>
    public static readonly ServiceFacilityType MedicalGeneticsClinic = new(
        Values.MedicalGeneticsClinic
    );

    /// <summary>
    /// Nephrology clinic.
    /// </summary>
    public static readonly ServiceFacilityType NephrologyClinic = new(Values.NephrologyClinic);

    /// <summary>
    /// Pediatric nephrology clinic.
    /// </summary>
    public static readonly ServiceFacilityType PediatricNephrologyClinic = new(
        Values.PediatricNephrologyClinic
    );

    /// <summary>
    /// Neurology clinic.
    /// </summary>
    public static readonly ServiceFacilityType NeurologyClinic = new(Values.NeurologyClinic);

    /// <summary>
    /// Obstetrics clinic.
    /// </summary>
    public static readonly ServiceFacilityType ObstetricsClinic = new(Values.ObstetricsClinic);

    /// <summary>
    /// Oral and maxillofacial surgery clinic.
    /// </summary>
    public static readonly ServiceFacilityType OralAndMaxillofacialSurgeryClinic = new(
        Values.OralAndMaxillofacialSurgeryClinic
    );

    /// <summary>
    /// Medical oncology clinic.
    /// </summary>
    public static readonly ServiceFacilityType MedicalOncologyClinic = new(
        Values.MedicalOncologyClinic
    );

    /// <summary>
    /// Pediatric oncology clinic.
    /// </summary>
    public static readonly ServiceFacilityType PediatricOncologyClinic = new(
        Values.PediatricOncologyClinic
    );

    /// <summary>
    /// Opthalmology clinic.
    /// </summary>
    public static readonly ServiceFacilityType OpthalmologyClinic = new(Values.OpthalmologyClinic);

    /// <summary>
    /// A location that plays the role of delivering services which may include examination, diagnosis, treatment, management, and prevention of diseases and disorders of the eye as well as prescribing and fitting appropriate corrective lenses (glasses or contact lenses) as needed. Optometry clinics may also provide tests for visual field screening, measuring intra-ocular pressure and ophthalmoscopy, as and when required.
    /// </summary>
    public static readonly ServiceFacilityType OptometryClinic = new(Values.OptometryClinic);

    /// <summary>
    /// Orthopedics clinic.
    /// </summary>
    public static readonly ServiceFacilityType OrthopedicsClinic = new(Values.OrthopedicsClinic);

    /// <summary>
    /// Hand clinic.
    /// </summary>
    public static readonly ServiceFacilityType HandClinic = new(Values.HandClinic);

    /// <summary>
    /// (X12N 261QP3300N)
    /// </summary>
    public static readonly ServiceFacilityType PainClinic = new(Values.PainClinic);

    /// <summary>
    /// (X12N 261QP2300N)
    /// </summary>
    public static readonly ServiceFacilityType PrimaryCareClinic = new(Values.PrimaryCareClinic);

    /// <summary>
    /// Pediatrics clinic.
    /// </summary>
    public static readonly ServiceFacilityType PediatricsClinic = new(Values.PediatricsClinic);

    /// <summary>
    /// Pediatric rheumatology clinic.
    /// </summary>
    public static readonly ServiceFacilityType PediatricRheumatologyClinic = new(
        Values.PediatricRheumatologyClinic
    );

    /// <summary>
    /// (X12N 261QP1100N)
    /// </summary>
    public static readonly ServiceFacilityType PodiatryClinic = new(Values.PodiatryClinic);

    /// <summary>
    /// Preventive medicine clinic.
    /// </summary>
    public static readonly ServiceFacilityType PreventiveMedicineClinic = new(
        Values.PreventiveMedicineClinic
    );

    /// <summary>
    /// Proctology clinic.
    /// </summary>
    public static readonly ServiceFacilityType ProctologyClinic = new(Values.ProctologyClinic);

    /// <summary>
    /// Location where healthcare service was delivered.
    /// </summary>
    public static readonly ServiceFacilityType ProvidersOffice = new(Values.ProvidersOffice);

    /// <summary>
    /// Prosthodontics clinic.
    /// </summary>
    public static readonly ServiceFacilityType ProsthodonticsClinic = new(
        Values.ProsthodonticsClinic
    );

    /// <summary>
    /// Psychology clinic.
    /// </summary>
    public static readonly ServiceFacilityType PsychologyClinic = new(Values.PsychologyClinic);

    /// <summary>
    /// Psychiatry clinic.
    /// </summary>
    public static readonly ServiceFacilityType PsychiatryClinic = new(Values.PsychiatryClinic);

    /// <summary>
    /// Rheumatology clinic.
    /// </summary>
    public static readonly ServiceFacilityType RheumatologyClinic = new(Values.RheumatologyClinic);

    /// <summary>
    /// Sports medicine clinic.
    /// </summary>
    public static readonly ServiceFacilityType SportsMedicineClinic = new(
        Values.SportsMedicineClinic
    );

    /// <summary>
    /// Surgery clinic.
    /// </summary>
    public static readonly ServiceFacilityType SurgeryClinic = new(Values.SurgeryClinic);

    /// <summary>
    /// Plastic surgery clinic.
    /// </summary>
    public static readonly ServiceFacilityType PlasticSurgeryClinic = new(
        Values.PlasticSurgeryClinic
    );

    /// <summary>
    /// Urology clinic.
    /// </summary>
    public static readonly ServiceFacilityType UrologyClinic = new(Values.UrologyClinic);

    /// <summary>
    /// Transplant clinic.
    /// </summary>
    public static readonly ServiceFacilityType TransplantClinic = new(Values.TransplantClinic);

    /// <summary>
    /// Travel and geographic medicine clinic.
    /// </summary>
    public static readonly ServiceFacilityType TravelAndGeographicMedicineClinic = new(
        Values.TravelAndGeographicMedicineClinic
    );

    /// <summary>
    /// Wound clinic.
    /// </summary>
    public static readonly ServiceFacilityType WoundClinic = new(Values.WoundClinic);

    /// <summary>
    /// Residential treatment facility.
    /// </summary>
    public static readonly ServiceFacilityType ResidentialTreatmentFacility = new(
        Values.ResidentialTreatmentFacility
    );

    /// <summary>
    /// Pain rehabilitation center.
    /// </summary>
    public static readonly ServiceFacilityType PainRehabilitationCenter = new(
        Values.PainRehabilitationCenter
    );

    /// <summary>
    /// (X12N 324500000N)
    /// </summary>
    public static readonly ServiceFacilityType SubstanceUseRehabilitationFacility = new(
        Values.SubstanceUseRehabilitationFacility
    );

    /// <summary>
    /// Location address where medical supplies were transported to for use.
    /// </summary>
    public static readonly ServiceFacilityType DeliveryAddress = new(Values.DeliveryAddress);

    /// <summary>
    /// Location (mobile) where healthcare service was delivered.
    /// </summary>
    public static readonly ServiceFacilityType MobileUnit = new(Values.MobileUnit);

    /// <summary>
    /// Location (mobile) where healthcare service was delivered, identified specifically as an ambulance.
    /// </summary>
    public static readonly ServiceFacilityType Ambulance = new(Values.Ambulance);

    /// <summary>
    /// Location where healthcare service was delivered.
    /// </summary>
    public static readonly ServiceFacilityType Pharmacy = new(Values.Pharmacy);

    /// <summary>
    /// Location of an accident where healthcare service was delivered.
    /// </summary>
    public static readonly ServiceFacilityType AccidentSite = new(Values.AccidentSite);

    /// <summary>
    /// Community location where healthcare is delivered.
    /// </summary>
    public static readonly ServiceFacilityType CommunityLocation = new(Values.CommunityLocation);

    /// <summary>
    /// A location that plays the role of delivering services which may include providing front-line services to the population of a  defined geographic area such as: healthcare services and social services.
    /// </summary>
    public static readonly ServiceFacilityType CommunityServiceCenter = new(
        Values.CommunityServiceCenter
    );

    /// <summary>
    /// location where healthcare was delivered which is the residence of the Patient.
    /// </summary>
    public static readonly ServiceFacilityType PatientsResidence = new(Values.PatientsResidence);

    /// <summary>
    /// Location where healthcare service was delivered.
    /// </summary>
    public static readonly ServiceFacilityType School = new(Values.School);

    /// <summary>
    /// A location that plays the role of delivering services which may include:  social emergency services required for a young person as required under any jurisdictional youth laws.
    /// </summary>
    public static readonly ServiceFacilityType UnderageProtectionCenter = new(
        Values.UnderageProtectionCenter
    );

    /// <summary>
    /// Location where healthcare service was delivered.
    /// </summary>
    public static readonly ServiceFacilityType WorkSite = new(Values.WorkSite);

    public ServiceFacilityType(string value)
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
    public static ServiceFacilityType FromCustom(string value)
    {
        return new ServiceFacilityType(value);
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

    public static bool operator ==(ServiceFacilityType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ServiceFacilityType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ServiceFacilityType value) => value.Value;

    public static explicit operator ServiceFacilityType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        /// <summary>
        /// A practice setting where diagnostic procedures or therapeutic interventions are performed.
        /// </summary>
        public const string DiagnosticsOrTherapeuticsUnit = "DX";

        /// <summary>
        /// A practice setting where cardiovascular diagnostic procedures or therapeutic interventions are performed.
        /// </summary>
        public const string CardiovascularDiagnosticsOrTherapeuticsUnit = "CVDX";

        /// <summary>
        /// Cardiac catheterization lab.
        /// </summary>
        public const string CardiacCatheterizationLab = "CATH";

        /// <summary>
        /// Echocardiography lab.
        /// </summary>
        public const string EchocardiographyLab = "ECHO";

        /// <summary>
        /// A practice setting where GI procedures (such as endoscopies) are performed.
        /// </summary>
        public const string GastroenterologyDiagnosticsOrTherapeuticsLab = "GIDX";

        /// <summary>
        /// (X12N 261QD0000N)
        /// </summary>
        public const string EndoscopyLab = "ENDOS";

        /// <summary>
        /// A practice setting where radiology services (diagnostic or therapeutic) are provided (X12N 261QR0200N).
        /// </summary>
        public const string RadiologyDiagnosticsOrTherapeuticsUnit = "RADDX";

        /// <summary>
        /// (X12N 261QX0203N)
        /// </summary>
        public const string RadiationOncologyUnit = "RADO";

        /// <summary>
        /// Neuroradiology unit.
        /// </summary>
        public const string NeuroradiologyUnit = "RNEU";

        /// <summary>
        /// An acute care institution that provides medical, surgical, or psychiatric care and treatment for the sick or the injured.
        /// </summary>
        public const string Hospital = "HOSP";

        /// <summary>
        /// (1) A hospital including a physical plant and personnel that provides multidisciplinary diagnosis and treatment for diseases  that have one or more of the following characteristics: is permanent; leaves residual disability; is caused by nonreversible  pathological alteration; requires special training of the patient for rehabilitation; and/or may be expected to require a long  period of supervision or care. In addition, patients require the safety, security, and shelter of these specialized inpatient  or partial hospitalization settings. (2) A hospital that provides medical and skilled nursing services to patients with  long-term illnesses who are not in an acute phase but who require an intensity of services not available in nursing homes.
        /// </summary>
        public const string ChronicCareFacility = "CHR";

        /// <summary>
        /// (X12N 282N00000N)
        /// </summary>
        public const string HospitalsGeneralAcuteCareHospital = "GACH";

        /// <summary>
        /// A health care facility operated by the Department of Defense or other military operation.
        /// </summary>
        public const string MilitaryHospital = "MHSP";

        /// <summary>
        /// Healthcare facility that cares for patients with psychiatric illness(s).
        /// </summary>
        public const string PsychatricCareFacility = "PSYCHF";

        /// <summary>
        /// (X12N 283X00000N)
        /// </summary>
        public const string RehabilitationHospital = "RH";

        /// <summary>
        /// A location that plays the role of delivering services which may include life training and/or social support to people with addictions.
        /// </summary>
        public const string AddictionTreatmentCenter = "RHAT";

        /// <summary>
        /// A location that plays the role of delivering services which may include adaptation, rehabilitation and social integration services for people with intellectual and/or pervasive development disorders such as autism or severe behaviour disorder.
        /// </summary>
        public const string IntellectualImpairmentCenter = "RHII";

        /// <summary>
        /// A location that plays the role of delivering services which may social support services for adolescents who are pregnant or have child and are experiencing adaptation issues/difficulties in their current or eventual parenting role.
        /// </summary>
        public const string ParentsWithAdjustmentDifficultiesCenter = "RHMAD";

        /// <summary>
        /// A location that plays the role of delivering services which may include adaptation, rehabilitation and social integration services for people with physical impairments.
        /// </summary>
        public const string PhysicalImpairmentCenter = "RHPI";

        /// <summary>
        /// A location that plays the role of delivering services for people with hearing impairments.
        /// </summary>
        public const string PhysicalImpairmentHearingCenter = "RHPIH";

        /// <summary>
        /// A location that plays the role of delivering services for people with motor skill impairments.
        /// </summary>
        public const string PhysicalImpairmentMotorSkillsCenter = "RHPIMS";

        /// <summary>
        /// A location that plays the role of delivering services for people with visual skill impairments.
        /// </summary>
        public const string PhysicalImpairmentVisualSkillsCenter = "RHPIVS";

        /// <summary>
        /// A location that plays the role of delivering services which may include life training and/or social support services for the adaptation, rehabilitation and social integration of youths with adjustment difficulties.
        /// </summary>
        public const string YouthsWithAdjustmentDifficultiesCenter = "RHYAD";

        /// <summary>
        /// Hospital unit.
        /// </summary>
        public const string HospitalUnit = "HU";

        /// <summary>
        /// Bone marrow transplant unit.
        /// </summary>
        public const string BoneMarrowTransplantUnit = "BMTU";

        /// <summary>
        /// Coronary care unit.
        /// </summary>
        public const string CoronaryCareUnit = "CCU";

        /// <summary>
        /// A specialty unit in hospital that focuses on chronic respirator patients. and pulmonary failure
        /// </summary>
        public const string ChestUnit = "CHEST";

        /// <summary>
        /// Epilepsy unit.
        /// </summary>
        public const string EpilepsyUnit = "EPIL";

        /// <summary>
        /// The section of a health care facility for providing rapid treatment to victims of sudden illness or trauma.
        /// </summary>
        public const string EmergencyRoom = "ER";

        /// <summary>
        /// Emergency trauma unit.
        /// </summary>
        public const string EmergencyTraumaUnit = "ETU";

        /// <summary>
        /// Hemodialysis unit.
        /// </summary>
        public const string HemodialysisUnit = "HD";

        /// <summary>
        /// A location that plays the role of delivering services which may include tests done based on clinical specimens to get health information about a patient as pertaining to the diagnosis"
        /// </summary>
        public const string HospitalLaboratory = "HLAB";

        /// <summary>
        /// A location that plays the role of delivering services which may include tests are done on clinical specimens to get health information about a patient pertaining to the diagnosis.
        /// </summary>
        public const string InpatientLaboratory = "INLAB";

        /// <summary>
        /// A location that plays the role of delivering services which may include tests are done on clinical specimens to get health information about a patient pertaining to the diagnosis
        /// </summary>
        public const string OutpatientLaboratory = "OUTLAB";

        /// <summary>
        /// A location that plays the role of delivering services which may include the branch of medicine that uses ionizing and non-ionizing radiation to diagnose and treat diseases. The radiology unit may be further dividedinto subspecialties such as Imaging, Cardiovascular, Thoracic, and Ultrasound.
        /// </summary>
        public const string RadiologyUnit = "HRAD";

        /// <summary>
        /// A location that plays the role of delivering services which may include collecting specimens and/or samples from patients for laboratory testing purposes.
        /// </summary>
        public const string SpecimenCollectionSite = "HUSCS";

        /// <summary>
        /// Intensive care unit.
        /// </summary>
        public const string IntensiveCareUnit = "ICU";

        /// <summary>
        /// Pediatric intensive care unit
        /// </summary>
        public const string PediatricIntensiveCareUnit = "PEDICU";

        /// <summary>
        /// Pediatric neonatal intensive care unit.
        /// </summary>
        public const string PediatricNeonatalIntensiveCareUnit = "PEDNICU";

        /// <summary>
        /// A location that plays the role of delivering services which may include providing judicious, safe, efficacious, appropriate and cost effective use of medicines for treatment of patients for visits longer than one day. The distinction between inpatient pharmacies and retail (or outpatient) pharmacies is that they are part of a patient's continuity of care while staying in the hospital.
        /// </summary>
        public const string InpatientPharmacy = "INPHARM";

        /// <summary>
        /// A location that plays the role of delivering services which include biochemistry, hematology, microbiology, immunochemistry, and toxicology.
        /// </summary>
        public const string MedicalLaboratory = "MBL";

        /// <summary>
        /// Neurology critical care and stroke unit.
        /// </summary>
        public const string NeurologyCriticalCareAndStrokeUnit = "NCCS";

        /// <summary>
        /// Neurosurgery unit.
        /// </summary>
        public const string NeurosurgeryUnit = "NS";

        /// <summary>
        /// A location that plays the role of delivering services which may include providing judicious, safe, efficacious, appropriate and cost effective use of medicines for treatment of patients for outpatient visits and may also be used for discharge prescriptions.
        /// </summary>
        public const string OutpatientPharmacy = "OUTPHARM";

        /// <summary>
        /// Pediatric unit.
        /// </summary>
        public const string PediatricUnit = "PEDU";

        /// <summary>
        /// (X12N 273R00000N)
        /// </summary>
        public const string PsychiatricHospitalUnit = "PHU";

        /// <summary>
        /// Rehabilitation hospital unit.
        /// </summary>
        public const string RehabilitationHospitalUnit = "RHU";

        /// <summary>
        /// (X12N 261QA1200N)
        /// </summary>
        public const string SleepDisordersUnit = "SLEEP";

        /// <summary>
        /// Nursing or custodial care facility.
        /// </summary>
        public const string NursingOrCustodialCareFacility = "NCCF";

        /// <summary>
        /// (X12N 314000000N)
        /// </summary>
        public const string SkilledNursingFacility = "SNF";

        /// <summary>
        /// Outpatient facility.
        /// </summary>
        public const string OutpatientFacility = "OF";

        /// <summary>
        /// Allergy clinic.
        /// </summary>
        public const string AllergyClinic = "ALL";

        /// <summary>
        /// Amputee clinic.
        /// </summary>
        public const string AmputeeClinic = "AMPUT";

        /// <summary>
        /// Bone marrow transplant clinic.
        /// </summary>
        public const string BoneMarrowTransplantClinic = "BMTC";

        /// <summary>
        /// Breast clinic.
        /// </summary>
        public const string BreastClinic = "BREAST";

        /// <summary>
        /// Child and adolescent neurology clinic.
        /// </summary>
        public const string ChildAndAdolescentNeurologyClinic = "CANC";

        /// <summary>
        /// Child and adolescent psychiatry clinic.
        /// </summary>
        public const string ChildAndAdolescentPsychiatryClinic = "CAPC";

        /// <summary>
        /// Ambulatory Health Care Facilities; Clinic/Center; Rehabilitation: Cardiac Facilities.
        /// </summary>
        public const string AmbulatoryHealthCareFacilitiesClinicCenterRehabilitationCardiacFacilities =
            "CARD";

        /// <summary>
        /// Pediatric cardiology clinic.
        /// </summary>
        public const string PediatricCardiologyClinic = "PEDCARD";

        /// <summary>
        /// Coagulation clinic.
        /// </summary>
        public const string CoagulationClinic = "COAG";

        /// <summary>
        /// Colon and rectal surgery clinic.
        /// </summary>
        public const string ColonAndRectalSurgeryClinic = "CRS";

        /// <summary>
        /// Dermatology clinic.
        /// </summary>
        public const string DermatologyClinic = "DERM";

        /// <summary>
        /// Endocrinology clinic.
        /// </summary>
        public const string EndocrinologyClinic = "ENDO";

        /// <summary>
        /// Pediatric endocrinology clinic.
        /// </summary>
        public const string PediatricEndocrinologyClinic = "PEDE";

        /// <summary>
        /// Otorhinolaryngology clinic.
        /// </summary>
        public const string OtorhinolaryngologyClinic = "ENT";

        /// <summary>
        /// Family medicine clinic.
        /// </summary>
        public const string FamilyMedicineClinic = "FMC";

        /// <summary>
        /// Gastroenterology clinic.
        /// </summary>
        public const string GastroenterologyClinic = "GI";

        /// <summary>
        /// Pediatric gastroenterology clinic.
        /// </summary>
        public const string PediatricGastroenterologyClinic = "PEDGI";

        /// <summary>
        /// General internal medicine clinic.
        /// </summary>
        public const string GeneralInternalMedicineClinic = "GIM";

        /// <summary>
        /// Gynecology clinic.
        /// </summary>
        public const string GynecologyClinic = "GYN";

        /// <summary>
        /// Hematology clinic.
        /// </summary>
        public const string HematologyClinic = "HEM";

        /// <summary>
        /// Pediatric hematology clinic.
        /// </summary>
        public const string PediatricHematologyClinic = "PEDHEM";

        /// <summary>
        /// Hypertension clinic.
        /// </summary>
        public const string HypertensionClinic = "HTN";

        /// <summary>
        /// Focuses on assessing disability.
        /// </summary>
        public const string ImpairmentEvaluationCenter = "IEC";

        /// <summary>
        /// Infectious disease clinic.
        /// </summary>
        public const string InfectiousDiseaseClinic = "INFD";

        /// <summary>
        /// Pediatric infectious disease clinic.
        /// </summary>
        public const string PediatricInfectiousDiseaseClinic = "PEDID";

        /// <summary>
        /// Infertility clinic.
        /// </summary>
        public const string InfertilityClinic = "INV";

        /// <summary>
        /// Lympedema clinic.
        /// </summary>
        public const string LympedemaClinic = "LYMPH";

        /// <summary>
        /// Medical genetics clinic.
        /// </summary>
        public const string MedicalGeneticsClinic = "MGEN";

        /// <summary>
        /// Nephrology clinic.
        /// </summary>
        public const string NephrologyClinic = "NEPH";

        /// <summary>
        /// Pediatric nephrology clinic.
        /// </summary>
        public const string PediatricNephrologyClinic = "PEDNEPH";

        /// <summary>
        /// Neurology clinic.
        /// </summary>
        public const string NeurologyClinic = "NEUR";

        /// <summary>
        /// Obstetrics clinic.
        /// </summary>
        public const string ObstetricsClinic = "OB";

        /// <summary>
        /// Oral and maxillofacial surgery clinic.
        /// </summary>
        public const string OralAndMaxillofacialSurgeryClinic = "OMS";

        /// <summary>
        /// Medical oncology clinic.
        /// </summary>
        public const string MedicalOncologyClinic = "ONCL";

        /// <summary>
        /// Pediatric oncology clinic.
        /// </summary>
        public const string PediatricOncologyClinic = "PEDHO";

        /// <summary>
        /// Opthalmology clinic.
        /// </summary>
        public const string OpthalmologyClinic = "OPH";

        /// <summary>
        /// A location that plays the role of delivering services which may include examination, diagnosis, treatment, management, and prevention of diseases and disorders of the eye as well as prescribing and fitting appropriate corrective lenses (glasses or contact lenses) as needed. Optometry clinics may also provide tests for visual field screening, measuring intra-ocular pressure and ophthalmoscopy, as and when required.
        /// </summary>
        public const string OptometryClinic = "OPTC";

        /// <summary>
        /// Orthopedics clinic.
        /// </summary>
        public const string OrthopedicsClinic = "ORTHO";

        /// <summary>
        /// Hand clinic.
        /// </summary>
        public const string HandClinic = "HAND";

        /// <summary>
        /// (X12N 261QP3300N)
        /// </summary>
        public const string PainClinic = "PAINCL";

        /// <summary>
        /// (X12N 261QP2300N)
        /// </summary>
        public const string PrimaryCareClinic = "PC";

        /// <summary>
        /// Pediatrics clinic.
        /// </summary>
        public const string PediatricsClinic = "PEDC";

        /// <summary>
        /// Pediatric rheumatology clinic.
        /// </summary>
        public const string PediatricRheumatologyClinic = "PEDRHEUM";

        /// <summary>
        /// (X12N 261QP1100N)
        /// </summary>
        public const string PodiatryClinic = "POD";

        /// <summary>
        /// Preventive medicine clinic.
        /// </summary>
        public const string PreventiveMedicineClinic = "PREV";

        /// <summary>
        /// Proctology clinic.
        /// </summary>
        public const string ProctologyClinic = "PROCTO";

        /// <summary>
        /// Location where healthcare service was delivered.
        /// </summary>
        public const string ProvidersOffice = "PROFF";

        /// <summary>
        /// Prosthodontics clinic.
        /// </summary>
        public const string ProsthodonticsClinic = "PROS";

        /// <summary>
        /// Psychology clinic.
        /// </summary>
        public const string PsychologyClinic = "PSI";

        /// <summary>
        /// Psychiatry clinic.
        /// </summary>
        public const string PsychiatryClinic = "PSY";

        /// <summary>
        /// Rheumatology clinic.
        /// </summary>
        public const string RheumatologyClinic = "RHEUM";

        /// <summary>
        /// Sports medicine clinic.
        /// </summary>
        public const string SportsMedicineClinic = "SPMED";

        /// <summary>
        /// Surgery clinic.
        /// </summary>
        public const string SurgeryClinic = "SU";

        /// <summary>
        /// Plastic surgery clinic.
        /// </summary>
        public const string PlasticSurgeryClinic = "PLS";

        /// <summary>
        /// Urology clinic.
        /// </summary>
        public const string UrologyClinic = "URO";

        /// <summary>
        /// Transplant clinic.
        /// </summary>
        public const string TransplantClinic = "TR";

        /// <summary>
        /// Travel and geographic medicine clinic.
        /// </summary>
        public const string TravelAndGeographicMedicineClinic = "TRAVEL";

        /// <summary>
        /// Wound clinic.
        /// </summary>
        public const string WoundClinic = "WND";

        /// <summary>
        /// Residential treatment facility.
        /// </summary>
        public const string ResidentialTreatmentFacility = "RTF";

        /// <summary>
        /// Pain rehabilitation center.
        /// </summary>
        public const string PainRehabilitationCenter = "PRC";

        /// <summary>
        /// (X12N 324500000N)
        /// </summary>
        public const string SubstanceUseRehabilitationFacility = "SURF";

        /// <summary>
        /// Location address where medical supplies were transported to for use.
        /// </summary>
        public const string DeliveryAddress = "DADDR";

        /// <summary>
        /// Location (mobile) where healthcare service was delivered.
        /// </summary>
        public const string MobileUnit = "MOBL";

        /// <summary>
        /// Location (mobile) where healthcare service was delivered, identified specifically as an ambulance.
        /// </summary>
        public const string Ambulance = "AMB";

        /// <summary>
        /// Location where healthcare service was delivered.
        /// </summary>
        public const string Pharmacy = "PHARM";

        /// <summary>
        /// Location of an accident where healthcare service was delivered.
        /// </summary>
        public const string AccidentSite = "ACC";

        /// <summary>
        /// Community location where healthcare is delivered.
        /// </summary>
        public const string CommunityLocation = "COMM";

        /// <summary>
        /// A location that plays the role of delivering services which may include providing front-line services to the population of a  defined geographic area such as: healthcare services and social services.
        /// </summary>
        public const string CommunityServiceCenter = "CSC";

        /// <summary>
        /// location where healthcare was delivered which is the residence of the Patient.
        /// </summary>
        public const string PatientsResidence = "PTRES";

        /// <summary>
        /// Location where healthcare service was delivered.
        /// </summary>
        public const string School = "SCHOOL";

        /// <summary>
        /// A location that plays the role of delivering services which may include:  social emergency services required for a young person as required under any jurisdictional youth laws.
        /// </summary>
        public const string UnderageProtectionCenter = "UPC";

        /// <summary>
        /// Location where healthcare service was delivered.
        /// </summary>
        public const string WorkSite = "WORK";
    }
}
