using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.WriteOffs.V1;

[JsonConverter(typeof(StringEnumSerializer<InsuranceWriteOffReason>))]
[Serializable]
public readonly record struct InsuranceWriteOffReason : IStringEnum
{
    public static readonly InsuranceWriteOffReason SmallBalance = new(Values.SmallBalance);

    public static readonly InsuranceWriteOffReason NoAuthorizationReferral = new(
        Values.NoAuthorizationReferral
    );

    public static readonly InsuranceWriteOffReason TimelyFiling = new(Values.TimelyFiling);

    public static readonly InsuranceWriteOffReason StaleDate = new(Values.StaleDate);

    public static readonly InsuranceWriteOffReason TimelyFilingLateEncounter = new(
        Values.TimelyFilingLateEncounter
    );

    public static readonly InsuranceWriteOffReason CredentialingOrContracting = new(
        Values.CredentialingOrContracting
    );

    public static readonly InsuranceWriteOffReason NonCoveredMaxBenefit = new(
        Values.NonCoveredMaxBenefit
    );

    public static readonly InsuranceWriteOffReason NotMedicallyNecessary = new(
        Values.NotMedicallyNecessary
    );

    public static readonly InsuranceWriteOffReason BundledOrInclusive = new(
        Values.BundledOrInclusive
    );

    public static readonly InsuranceWriteOffReason UncollectibleOrNonBillable = new(
        Values.UncollectibleOrNonBillable
    );

    public static readonly InsuranceWriteOffReason EffortsExhausted = new(Values.EffortsExhausted);

    public static readonly InsuranceWriteOffReason AdministrativeWriteOff = new(
        Values.AdministrativeWriteOff
    );

    public static readonly InsuranceWriteOffReason CaseRateOrCapitated = new(
        Values.CaseRateOrCapitated
    );

    public static readonly InsuranceWriteOffReason Other = new(Values.Other);

    public static readonly InsuranceWriteOffReason Unknown = new(Values.Unknown);

    public static readonly InsuranceWriteOffReason ContractualAdjustment = new(
        Values.ContractualAdjustment
    );

    public static readonly InsuranceWriteOffReason PrimaryPaidMaxBenefits = new(
        Values.PrimaryPaidMaxBenefits
    );

    public InsuranceWriteOffReason(string value)
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
    public static InsuranceWriteOffReason FromCustom(string value)
    {
        return new InsuranceWriteOffReason(value);
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

    public static bool operator ==(InsuranceWriteOffReason value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InsuranceWriteOffReason value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InsuranceWriteOffReason value) => value.Value;

    public static explicit operator InsuranceWriteOffReason(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string SmallBalance = "SMALL_BALANCE";

        public const string NoAuthorizationReferral = "NO_AUTHORIZATION_REFERRAL";

        public const string TimelyFiling = "TIMELY_FILING";

        public const string StaleDate = "STALE_DATE";

        public const string TimelyFilingLateEncounter = "TIMELY_FILING_LATE_ENCOUNTER";

        public const string CredentialingOrContracting = "CREDENTIALING_OR_CONTRACTING";

        public const string NonCoveredMaxBenefit = "NON_COVERED_MAX_BENEFIT";

        public const string NotMedicallyNecessary = "NOT_MEDICALLY_NECESSARY";

        public const string BundledOrInclusive = "BUNDLED_OR_INCLUSIVE";

        public const string UncollectibleOrNonBillable = "UNCOLLECTIBLE_OR_NON_BILLABLE";

        public const string EffortsExhausted = "EFFORTS_EXHAUSTED";

        public const string AdministrativeWriteOff = "ADMINISTRATIVE_WRITE_OFF";

        public const string CaseRateOrCapitated = "CASE_RATE_OR_CAPITATED";

        public const string Other = "OTHER";

        public const string Unknown = "UNKNOWN";

        public const string ContractualAdjustment = "CONTRACTUAL_ADJUSTMENT";

        public const string PrimaryPaidMaxBenefits = "PRIMARY_PAID_MAX_BENEFITS";
    }
}
