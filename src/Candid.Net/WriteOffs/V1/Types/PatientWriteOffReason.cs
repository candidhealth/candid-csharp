using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.WriteOffs.V1;

[JsonConverter(typeof(StringEnumSerializer<PatientWriteOffReason>))]
[Serializable]
public readonly record struct PatientWriteOffReason : IStringEnum
{
    public static readonly PatientWriteOffReason SmallBalance = new(Values.SmallBalance);

    public static readonly PatientWriteOffReason CharityOrFinancialAssistance = new(
        Values.CharityOrFinancialAssistance
    );

    public static readonly PatientWriteOffReason PatientExperienceOrServiceRecovery = new(
        Values.PatientExperienceOrServiceRecovery
    );

    public static readonly PatientWriteOffReason OonCourtesyAdjustment = new(
        Values.OonCourtesyAdjustment
    );

    public static readonly PatientWriteOffReason PromptPayDiscount = new(Values.PromptPayDiscount);

    public static readonly PatientWriteOffReason BadDebt = new(Values.BadDebt);

    public static readonly PatientWriteOffReason CollectionAgency = new(Values.CollectionAgency);

    public static readonly PatientWriteOffReason Other = new(Values.Other);

    public static readonly PatientWriteOffReason Unknown = new(Values.Unknown);

    public static readonly PatientWriteOffReason UncollectibleOrNonBillable = new(
        Values.UncollectibleOrNonBillable
    );

    public static readonly PatientWriteOffReason Deceased = new(Values.Deceased);

    public static readonly PatientWriteOffReason Bankruptcy = new(Values.Bankruptcy);

    public PatientWriteOffReason(string value)
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
    public static PatientWriteOffReason FromCustom(string value)
    {
        return new PatientWriteOffReason(value);
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

    public static bool operator ==(PatientWriteOffReason value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PatientWriteOffReason value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PatientWriteOffReason value) => value.Value;

    public static explicit operator PatientWriteOffReason(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string SmallBalance = "SMALL_BALANCE";

        public const string CharityOrFinancialAssistance = "CHARITY_OR_FINANCIAL_ASSISTANCE";

        public const string PatientExperienceOrServiceRecovery =
            "PATIENT_EXPERIENCE_OR_SERVICE_RECOVERY";

        public const string OonCourtesyAdjustment = "OON_COURTESY_ADJUSTMENT";

        public const string PromptPayDiscount = "PROMPT_PAY_DISCOUNT";

        public const string BadDebt = "BAD_DEBT";

        public const string CollectionAgency = "COLLECTION_AGENCY";

        public const string Other = "OTHER";

        public const string Unknown = "UNKNOWN";

        public const string UncollectibleOrNonBillable = "UNCOLLECTIBLE_OR_NON_BILLABLE";

        public const string Deceased = "DECEASED";

        public const string Bankruptcy = "BANKRUPTCY";
    }
}
