using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.WriteOffs.V1;

[JsonConverter(typeof(EnumSerializer<PatientWriteOffReason>))]
public enum PatientWriteOffReason
{
    [EnumMember(Value = "SMALL_BALANCE")]
    SmallBalance,

    [EnumMember(Value = "CHARITY_OR_FINANCIAL_ASSISTANCE")]
    CharityOrFinancialAssistance,

    [EnumMember(Value = "PATIENT_EXPERIENCE_OR_SERVICE_RECOVERY")]
    PatientExperienceOrServiceRecovery,

    [EnumMember(Value = "OON_COURTESY_ADJUSTMENT")]
    OonCourtesyAdjustment,

    [EnumMember(Value = "PROMPT_PAY_DISCOUNT")]
    PromptPayDiscount,

    [EnumMember(Value = "BAD_DEBT")]
    BadDebt,

    [EnumMember(Value = "COLLECTION_AGENCY")]
    CollectionAgency,

    [EnumMember(Value = "OTHER")]
    Other,

    [EnumMember(Value = "UNKNOWN")]
    Unknown,
}
