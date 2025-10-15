using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.Commons;

[JsonConverter(typeof(StringEnumSerializer<BillingProviderCommercialLicenseType>))]
[Serializable]
public readonly record struct BillingProviderCommercialLicenseType : IStringEnum
{
    public static readonly BillingProviderCommercialLicenseType LicensedClinicalSocialWorker = new(
        Values.LicensedClinicalSocialWorker
    );

    public static readonly BillingProviderCommercialLicenseType LicensedProfessionalCounselor = new(
        Values.LicensedProfessionalCounselor
    );

    public static readonly BillingProviderCommercialLicenseType LicensedMarriageAndFamilyCounselor =
        new(Values.LicensedMarriageAndFamilyCounselor);

    public static readonly BillingProviderCommercialLicenseType LicensedClinicalAlcoholAndDrugCounselor =
        new(Values.LicensedClinicalAlcoholAndDrugCounselor);

    public static readonly BillingProviderCommercialLicenseType Psychologist = new(
        Values.Psychologist
    );

    public static readonly BillingProviderCommercialLicenseType PsychiatricNurse = new(
        Values.PsychiatricNurse
    );

    public static readonly BillingProviderCommercialLicenseType Psychiatrist = new(
        Values.Psychiatrist
    );

    public static readonly BillingProviderCommercialLicenseType ChildAdolescentPsychiatrist = new(
        Values.ChildAdolescentPsychiatrist
    );

    public static readonly BillingProviderCommercialLicenseType PhysicianAssistant = new(
        Values.PhysicianAssistant
    );

    public static readonly BillingProviderCommercialLicenseType NurseCnp = new(Values.NurseCnp);

    public BillingProviderCommercialLicenseType(string value)
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
    public static BillingProviderCommercialLicenseType FromCustom(string value)
    {
        return new BillingProviderCommercialLicenseType(value);
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

    public static bool operator ==(BillingProviderCommercialLicenseType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BillingProviderCommercialLicenseType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BillingProviderCommercialLicenseType value) =>
        value.Value;

    public static explicit operator BillingProviderCommercialLicenseType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string LicensedClinicalSocialWorker = "0";

        public const string LicensedProfessionalCounselor = "A";

        public const string LicensedMarriageAndFamilyCounselor = "B";

        public const string LicensedClinicalAlcoholAndDrugCounselor = "C";

        public const string Psychologist = "D";

        public const string PsychiatricNurse = "E";

        public const string Psychiatrist = "F";

        public const string ChildAdolescentPsychiatrist = "G";

        public const string PhysicianAssistant = "H";

        public const string NurseCnp = "I";
    }
}
