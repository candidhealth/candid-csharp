using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

[JsonConverter(typeof(EnumSerializer<BenefitType>))]
public enum BenefitType
{
    [EnumMember(Value = "DEDUCTIBLE")]
    Deductible,

    [EnumMember(Value = "DEDUCTIBLE_REMAINING")]
    DeductibleRemaining,

    [EnumMember(Value = "DEDUCTIBLE_YEAR_TO_DATE")]
    DeductibleYearToDate,

    [EnumMember(Value = "OOP_MAX")]
    OopMax,

    [EnumMember(Value = "OOP_MAX_REMAINING")]
    OopMaxRemaining,

    [EnumMember(Value = "OOP_YEAR_TO_DATE")]
    OopYearToDate,

    [EnumMember(Value = "COPAY")]
    Copay,

    [EnumMember(Value = "COINSURANCE")]
    Coinsurance,
}
