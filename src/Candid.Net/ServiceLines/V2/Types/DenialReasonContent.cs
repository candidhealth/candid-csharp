using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

[JsonConverter(typeof(EnumSerializer<DenialReasonContent>))]
public enum DenialReasonContent
{
    [EnumMember(Value = "Authorization Required")]
    AuthorizationRequired,

    [EnumMember(Value = "Referral Required")]
    ReferralRequired,

    [EnumMember(Value = "Medical Records Requested")]
    MedicalRecordsRequested,

    [EnumMember(Value = "Timely Filing")]
    TimelyFiling,

    [EnumMember(Value = "Duplicate Claim")]
    DuplicateClaim,

    [EnumMember(Value = "Incorrect Place of Service")]
    IncorrectPlaceOfService,

    [EnumMember(Value = "Incorrect Patient Gender")]
    IncorrectPatientGender,

    [EnumMember(Value = "Bundled")]
    Bundled,

    [EnumMember(Value = "Exceeded Billable Time")]
    ExceededBillableTime,

    [EnumMember(Value = "Invalid Provider Information")]
    InvalidProviderInformation,

    [EnumMember(Value = "Invalid Diagnosis Code")]
    InvalidDiagnosisCode,

    [EnumMember(Value = "Incorrect Procedure Code")]
    IncorrectProcedureCode,

    [EnumMember(Value = "Invalid Modifier")]
    InvalidModifier,

    [EnumMember(Value = "Missing NDC Code")]
    MissingNdcCode,

    [EnumMember(Value = "Invalid Insurance Data")]
    InvalidInsuranceData,

    [EnumMember(Value = "No Active Coverage")]
    NoActiveCoverage,

    [EnumMember(Value = "Coordination of Benefits")]
    CoordinationOfBenefits,

    [EnumMember(Value = "Incorrect Payer")]
    IncorrectPayer,

    [EnumMember(Value = "Credentialing")]
    Credentialing,

    [EnumMember(Value = "No Effective Contract")]
    NoEffectiveContract,

    [EnumMember(Value = "Missing W-9")]
    MissingW9,

    [EnumMember(Value = "Missing Contract Linkage")]
    MissingContractLinkage,

    [EnumMember(Value = "Non-Covered Benefit")]
    NonCoveredBenefit,

    [EnumMember(Value = "Experimental Procedure")]
    ExperimentalProcedure,

    [EnumMember(Value = "Not Medically Necessary")]
    NotMedicallyNecessary,

    [EnumMember(Value = "Info Requested from Provider")]
    InfoRequestedFromProvider,

    [EnumMember(Value = "Info Requested from Patient")]
    InfoRequestedFromPatient,

    [EnumMember(Value = "Billing Error")]
    BillingError,

    [EnumMember(Value = "Unknown")]
    Unknown,

    [EnumMember(Value = "Max Benefit Reached")]
    MaxBenefitReached,
}
