using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

[JsonConverter(typeof(StringEnumSerializer<InsuranceWriteOffReason>))]
public enum InsuranceWriteOffReason
{
    [EnumMember(Value = "SMALL_BALANCE")]
    SmallBalance,

    [EnumMember(Value = "NO_AUTHORIZATION_REFERRAL")]
    NoAuthorizationReferral,

    [EnumMember(Value = "TIMELY_FILING")]
    TimelyFiling,

    [EnumMember(Value = "STALE_DATE")]
    StaleDate,

    [EnumMember(Value = "TIMELY_FILING_LATE_ENCOUNTER")]
    TimelyFilingLateEncounter,

    [EnumMember(Value = "CREDENTIALING_OR_CONTRACTING")]
    CredentialingOrContracting,

    [EnumMember(Value = "NON_COVERED_MAX_BENEFIT")]
    NonCoveredMaxBenefit,

    [EnumMember(Value = "NOT_MEDICALLY_NECESSARY")]
    NotMedicallyNecessary,

    [EnumMember(Value = "BUNDLED_OR_INCLUSIVE")]
    BundledOrInclusive,

    [EnumMember(Value = "UNCOLLECTIBLE_OR_NON_BILLABLE")]
    UncollectibleOrNonBillable,

    [EnumMember(Value = "EFFORTS_EXHAUSTED")]
    EffortsExhausted,

    [EnumMember(Value = "ADMINISTRATIVE_WRITE_OFF")]
    AdministrativeWriteOff,

    [EnumMember(Value = "CASE_RATE_OR_CAPITATED")]
    CaseRateOrCapitated,

    [EnumMember(Value = "OTHER")]
    Other,

    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    [EnumMember(Value = "CONTRACTUAL_ADJUSTMENT")]
    ContractualAdjustment
}
