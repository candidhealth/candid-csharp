using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Patients.V1;

[JsonConverter(typeof(StringEnumSerializer<SpecializationCategory>))]
[Serializable]
public readonly record struct SpecializationCategory : IStringEnum
{
    public static readonly SpecializationCategory BehavioralHealthTherapy = new(
        Values.BehavioralHealthTherapy
    );

    public static readonly SpecializationCategory Cardiology = new(Values.Cardiology);

    public static readonly SpecializationCategory Dermatology = new(Values.Dermatology);

    public static readonly SpecializationCategory Endocrinology = new(Values.Endocrinology);

    public static readonly SpecializationCategory Ent = new(Values.Ent);

    public static readonly SpecializationCategory Gastroenterology = new(Values.Gastroenterology);

    public static readonly SpecializationCategory GeneralSurgery = new(Values.GeneralSurgery);

    public static readonly SpecializationCategory Genetics = new(Values.Genetics);

    public static readonly SpecializationCategory Hematology = new(Values.Hematology);

    public static readonly SpecializationCategory InfectiousDisease = new(Values.InfectiousDisease);

    public static readonly SpecializationCategory Neurology = new(Values.Neurology);

    public static readonly SpecializationCategory NutritionalTherapy = new(
        Values.NutritionalTherapy
    );

    public static readonly SpecializationCategory ObGyn = new(Values.ObGyn);

    public static readonly SpecializationCategory Oncology = new(Values.Oncology);

    public static readonly SpecializationCategory Ophthalmology = new(Values.Ophthalmology);

    public static readonly SpecializationCategory Orthopedics = new(Values.Orthopedics);

    public static readonly SpecializationCategory PainManagement = new(Values.PainManagement);

    public static readonly SpecializationCategory Pediatrics = new(Values.Pediatrics);

    public static readonly SpecializationCategory PhysicalTherapy = new(Values.PhysicalTherapy);

    public static readonly SpecializationCategory Podiatry = new(Values.Podiatry);

    public static readonly SpecializationCategory PrimaryCare = new(Values.PrimaryCare);

    public static readonly SpecializationCategory Psychiatry = new(Values.Psychiatry);

    public static readonly SpecializationCategory Pulmonology = new(Values.Pulmonology);

    public static readonly SpecializationCategory Radiology = new(Values.Radiology);

    public static readonly SpecializationCategory Rheumatology = new(Values.Rheumatology);

    public static readonly SpecializationCategory Screening = new(Values.Screening);

    public static readonly SpecializationCategory Urology = new(Values.Urology);

    public static readonly SpecializationCategory Other = new(Values.Other);

    public SpecializationCategory(string value)
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
    public static SpecializationCategory FromCustom(string value)
    {
        return new SpecializationCategory(value);
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

    public static bool operator ==(SpecializationCategory value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SpecializationCategory value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SpecializationCategory value) => value.Value;

    public static explicit operator SpecializationCategory(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string BehavioralHealthTherapy = "BEHAVIORAL_HEALTH_THERAPY";

        public const string Cardiology = "CARDIOLOGY";

        public const string Dermatology = "DERMATOLOGY";

        public const string Endocrinology = "ENDOCRINOLOGY";

        public const string Ent = "ENT";

        public const string Gastroenterology = "GASTROENTEROLOGY";

        public const string GeneralSurgery = "GENERAL_SURGERY";

        public const string Genetics = "GENETICS";

        public const string Hematology = "HEMATOLOGY";

        public const string InfectiousDisease = "INFECTIOUS_DISEASE";

        public const string Neurology = "NEUROLOGY";

        public const string NutritionalTherapy = "NUTRITIONAL_THERAPY";

        public const string ObGyn = "OB_GYN";

        public const string Oncology = "ONCOLOGY";

        public const string Ophthalmology = "OPHTHALMOLOGY";

        public const string Orthopedics = "ORTHOPEDICS";

        public const string PainManagement = "PAIN_MANAGEMENT";

        public const string Pediatrics = "PEDIATRICS";

        public const string PhysicalTherapy = "PHYSICAL_THERAPY";

        public const string Podiatry = "PODIATRY";

        public const string PrimaryCare = "PRIMARY_CARE";

        public const string Psychiatry = "PSYCHIATRY";

        public const string Pulmonology = "PULMONOLOGY";

        public const string Radiology = "RADIOLOGY";

        public const string Rheumatology = "RHEUMATOLOGY";

        public const string Screening = "SCREENING";

        public const string Urology = "UROLOGY";

        public const string Other = "OTHER";
    }
}
