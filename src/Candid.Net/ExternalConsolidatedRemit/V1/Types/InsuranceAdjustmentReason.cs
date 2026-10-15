using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

[JsonConverter(typeof(InsuranceAdjustmentReason.InsuranceAdjustmentReasonSerializer))]
[Serializable]
public readonly record struct InsuranceAdjustmentReason : IStringEnum
{
    public static readonly InsuranceAdjustmentReason SmallBalance = new(Values.SmallBalance);

    public static readonly InsuranceAdjustmentReason NoAuthorizationOrReferral = new(
        Values.NoAuthorizationOrReferral
    );

    public static readonly InsuranceAdjustmentReason TimelyFiling = new(Values.TimelyFiling);

    public static readonly InsuranceAdjustmentReason StaleDate = new(Values.StaleDate);

    public static readonly InsuranceAdjustmentReason TimelyFilingLateEncounter = new(
        Values.TimelyFilingLateEncounter
    );

    public static readonly InsuranceAdjustmentReason CredentialingOrContracting = new(
        Values.CredentialingOrContracting
    );

    public static readonly InsuranceAdjustmentReason NonCoveredMaxBenefit = new(
        Values.NonCoveredMaxBenefit
    );

    public static readonly InsuranceAdjustmentReason NotMedicallyNecessary = new(
        Values.NotMedicallyNecessary
    );

    public static readonly InsuranceAdjustmentReason BundledOrInclusive = new(
        Values.BundledOrInclusive
    );

    public static readonly InsuranceAdjustmentReason UncollectibleOrNonBillable = new(
        Values.UncollectibleOrNonBillable
    );

    public static readonly InsuranceAdjustmentReason EffortsExhausted = new(
        Values.EffortsExhausted
    );

    public static readonly InsuranceAdjustmentReason AdministrativeWriteOff = new(
        Values.AdministrativeWriteOff
    );

    public static readonly InsuranceAdjustmentReason CaseRateOrCapitated = new(
        Values.CaseRateOrCapitated
    );

    public static readonly InsuranceAdjustmentReason CharityOrFinancialAssistance = new(
        Values.CharityOrFinancialAssistance
    );

    public static readonly InsuranceAdjustmentReason PatientExperienceOrServiceRecovery = new(
        Values.PatientExperienceOrServiceRecovery
    );

    public static readonly InsuranceAdjustmentReason OonCourtesyAdjustment = new(
        Values.OonCourtesyAdjustment
    );

    public static readonly InsuranceAdjustmentReason PromptPayDiscount = new(
        Values.PromptPayDiscount
    );

    public static readonly InsuranceAdjustmentReason BadDebt = new(Values.BadDebt);

    public static readonly InsuranceAdjustmentReason CollectionAgency = new(
        Values.CollectionAgency
    );

    public static readonly InsuranceAdjustmentReason Other = new(Values.Other);

    public static readonly InsuranceAdjustmentReason Unknown = new(Values.Unknown);

    public static readonly InsuranceAdjustmentReason ContractualAdjustment = new(
        Values.ContractualAdjustment
    );

    public static readonly InsuranceAdjustmentReason Deceased = new(Values.Deceased);

    public static readonly InsuranceAdjustmentReason Bankruptcy = new(Values.Bankruptcy);

    public static readonly InsuranceAdjustmentReason PrimaryPaidMaxBenefits = new(
        Values.PrimaryPaidMaxBenefits
    );

    public static readonly InsuranceAdjustmentReason Interest = new(Values.Interest);

    public InsuranceAdjustmentReason(string value)
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
    public static InsuranceAdjustmentReason FromCustom(string value)
    {
        return new InsuranceAdjustmentReason(value);
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

    public static bool operator ==(InsuranceAdjustmentReason value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InsuranceAdjustmentReason value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InsuranceAdjustmentReason value) => value.Value;

    public static explicit operator InsuranceAdjustmentReason(string value) => new(value);

    internal class InsuranceAdjustmentReasonSerializer : JsonConverter<InsuranceAdjustmentReason>
    {
        public override InsuranceAdjustmentReason Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new InsuranceAdjustmentReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            InsuranceAdjustmentReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override InsuranceAdjustmentReason ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new InsuranceAdjustmentReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            InsuranceAdjustmentReason value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string SmallBalance = "SMALL_BALANCE";

        public const string NoAuthorizationOrReferral = "NO_AUTHORIZATION_OR_REFERRAL";

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

        public const string CharityOrFinancialAssistance = "CHARITY_OR_FINANCIAL_ASSISTANCE";

        public const string PatientExperienceOrServiceRecovery =
            "PATIENT_EXPERIENCE_OR_SERVICE_RECOVERY";

        public const string OonCourtesyAdjustment = "OON_COURTESY_ADJUSTMENT";

        public const string PromptPayDiscount = "PROMPT_PAY_DISCOUNT";

        public const string BadDebt = "BAD_DEBT";

        public const string CollectionAgency = "COLLECTION_AGENCY";

        public const string Other = "OTHER";

        public const string Unknown = "UNKNOWN";

        public const string ContractualAdjustment = "CONTRACTUAL_ADJUSTMENT";

        public const string Deceased = "DECEASED";

        public const string Bankruptcy = "BANKRUPTCY";

        public const string PrimaryPaidMaxBenefits = "PRIMARY_PAID_MAX_BENEFITS";

        public const string Interest = "INTEREST";
    }
}
