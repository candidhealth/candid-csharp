using System.Text.Json.Serialization;
using Candid.Net.Core;

namespace Candid.Net.ServiceLines.V2;

[JsonConverter(typeof(StringEnumSerializer<DenialReasonContent>))]
[Serializable]
public readonly record struct DenialReasonContent : IStringEnum
{
    public static readonly DenialReasonContent AuthorizationRequired = new(
        Values.AuthorizationRequired
    );

    public static readonly DenialReasonContent ReferralRequired = new(Values.ReferralRequired);

    public static readonly DenialReasonContent MedicalRecordsRequested = new(
        Values.MedicalRecordsRequested
    );

    public static readonly DenialReasonContent TimelyFiling = new(Values.TimelyFiling);

    public static readonly DenialReasonContent DuplicateClaim = new(Values.DuplicateClaim);

    public static readonly DenialReasonContent FullContractualAdjustment = new(
        Values.FullContractualAdjustment
    );

    public static readonly DenialReasonContent IncorrectPlaceOfService = new(
        Values.IncorrectPlaceOfService
    );

    public static readonly DenialReasonContent IncorrectPatientGender = new(
        Values.IncorrectPatientGender
    );

    public static readonly DenialReasonContent IncorrectPatientInfo = new(
        Values.IncorrectPatientInfo
    );

    public static readonly DenialReasonContent Bundled = new(Values.Bundled);

    public static readonly DenialReasonContent ExceededBillableTime = new(
        Values.ExceededBillableTime
    );

    public static readonly DenialReasonContent InvalidProviderInformation = new(
        Values.InvalidProviderInformation
    );

    public static readonly DenialReasonContent InvalidDiagnosisCode = new(
        Values.InvalidDiagnosisCode
    );

    public static readonly DenialReasonContent IncorrectProcedureCode = new(
        Values.IncorrectProcedureCode
    );

    public static readonly DenialReasonContent InvalidModifier = new(Values.InvalidModifier);

    public static readonly DenialReasonContent MissingNdcCode = new(Values.MissingNdcCode);

    public static readonly DenialReasonContent InvalidInsuranceData = new(
        Values.InvalidInsuranceData
    );

    public static readonly DenialReasonContent NoActiveCoverage = new(Values.NoActiveCoverage);

    public static readonly DenialReasonContent CoordinationOfBenefits = new(
        Values.CoordinationOfBenefits
    );

    public static readonly DenialReasonContent IncorrectPayer = new(Values.IncorrectPayer);

    public static readonly DenialReasonContent Credentialing = new(Values.Credentialing);

    public static readonly DenialReasonContent NoEffectiveContract = new(
        Values.NoEffectiveContract
    );

    public static readonly DenialReasonContent MissingW9 = new(Values.MissingW9);

    public static readonly DenialReasonContent MissingContractLinkage = new(
        Values.MissingContractLinkage
    );

    public static readonly DenialReasonContent NonCoveredBenefit = new(Values.NonCoveredBenefit);

    public static readonly DenialReasonContent ExperimentalProcedure = new(
        Values.ExperimentalProcedure
    );

    public static readonly DenialReasonContent NotMedicallyNecessary = new(
        Values.NotMedicallyNecessary
    );

    public static readonly DenialReasonContent InfoRequestedFromProvider = new(
        Values.InfoRequestedFromProvider
    );

    public static readonly DenialReasonContent InfoRequestedFromPatient = new(
        Values.InfoRequestedFromPatient
    );

    public static readonly DenialReasonContent BillingError = new(Values.BillingError);

    public static readonly DenialReasonContent Unknown = new(Values.Unknown);

    public static readonly DenialReasonContent MaxBenefitReached = new(Values.MaxBenefitReached);

    public DenialReasonContent(string value)
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
    public static DenialReasonContent FromCustom(string value)
    {
        return new DenialReasonContent(value);
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

    public static bool operator ==(DenialReasonContent value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DenialReasonContent value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DenialReasonContent value) => value.Value;

    public static explicit operator DenialReasonContent(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AuthorizationRequired = "Authorization Required";

        public const string ReferralRequired = "Referral Required";

        public const string MedicalRecordsRequested = "Medical Records Requested";

        public const string TimelyFiling = "Timely Filing";

        public const string DuplicateClaim = "Duplicate Claim";

        public const string FullContractualAdjustment = "Full Contractual Adjustment";

        public const string IncorrectPlaceOfService = "Incorrect Place of Service";

        public const string IncorrectPatientGender = "Incorrect Patient Gender";

        public const string IncorrectPatientInfo = "Incorrect Patient Info";

        public const string Bundled = "Bundled";

        public const string ExceededBillableTime = "Exceeded Billable Time";

        public const string InvalidProviderInformation = "Invalid Provider Information";

        public const string InvalidDiagnosisCode = "Invalid Diagnosis Code";

        public const string IncorrectProcedureCode = "Incorrect Procedure Code";

        public const string InvalidModifier = "Invalid Modifier";

        public const string MissingNdcCode = "Missing NDC Code";

        public const string InvalidInsuranceData = "Invalid Insurance Data";

        public const string NoActiveCoverage = "No Active Coverage";

        public const string CoordinationOfBenefits = "Coordination of Benefits";

        public const string IncorrectPayer = "Incorrect Payer";

        public const string Credentialing = "Credentialing";

        public const string NoEffectiveContract = "No Effective Contract";

        public const string MissingW9 = "Missing W-9";

        public const string MissingContractLinkage = "Missing Contract Linkage";

        public const string NonCoveredBenefit = "Non-Covered Benefit";

        public const string ExperimentalProcedure = "Experimental Procedure";

        public const string NotMedicallyNecessary = "Not Medically Necessary";

        public const string InfoRequestedFromProvider = "Info Requested from Provider";

        public const string InfoRequestedFromPatient = "Info Requested from Patient";

        public const string BillingError = "Billing Error";

        public const string Unknown = "Unknown";

        public const string MaxBenefitReached = "Max Benefit Reached";
    }
}
