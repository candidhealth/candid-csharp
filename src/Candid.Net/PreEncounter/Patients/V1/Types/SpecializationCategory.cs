using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(EnumSerializer<SpecializationCategory>))]
public enum SpecializationCategory
{
    [EnumMember(Value = "BEHAVIORAL_HEALTH_THERAPY")]
    BehavioralHealthTherapy,

    [EnumMember(Value = "CARDIOLOGY")]
    Cardiology,

    [EnumMember(Value = "DERMATOLOGY")]
    Dermatology,

    [EnumMember(Value = "ENDOCRINOLOGY")]
    Endocrinology,

    [EnumMember(Value = "ENT")]
    Ent,

    [EnumMember(Value = "GASTROENTEROLOGY")]
    Gastroenterology,

    [EnumMember(Value = "GENERAL_SURGERY")]
    GeneralSurgery,

    [EnumMember(Value = "GENETICS")]
    Genetics,

    [EnumMember(Value = "HEMATOLOGY")]
    Hematology,

    [EnumMember(Value = "INFECTIOUS_DISEASE")]
    InfectiousDisease,

    [EnumMember(Value = "NEUROLOGY")]
    Neurology,

    [EnumMember(Value = "NUTRITIONAL_THERAPY")]
    NutritionalTherapy,

    [EnumMember(Value = "OB_GYN")]
    ObGyn,

    [EnumMember(Value = "ONCOLOGY")]
    Oncology,

    [EnumMember(Value = "OPHTHALMOLOGY")]
    Ophthalmology,

    [EnumMember(Value = "ORTHOPEDICS")]
    Orthopedics,

    [EnumMember(Value = "PAIN_MANAGEMENT")]
    PainManagement,

    [EnumMember(Value = "PEDIATRICS")]
    Pediatrics,

    [EnumMember(Value = "PHYSICAL_THERAPY")]
    PhysicalTherapy,

    [EnumMember(Value = "PODIATRY")]
    Podiatry,

    [EnumMember(Value = "PRIMARY_CARE")]
    PrimaryCare,

    [EnumMember(Value = "PSYCHIATRY")]
    Psychiatry,

    [EnumMember(Value = "PULMONOLOGY")]
    Pulmonology,

    [EnumMember(Value = "RADIOLOGY")]
    Radiology,

    [EnumMember(Value = "RHEUMATOLOGY")]
    Rheumatology,

    [EnumMember(Value = "SCREENING")]
    Screening,

    [EnumMember(Value = "UROLOGY")]
    Urology,

    [EnumMember(Value = "OTHER")]
    Other,
}
