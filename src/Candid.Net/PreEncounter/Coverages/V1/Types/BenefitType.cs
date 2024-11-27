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

    [EnumMember(Value = "OOP_MAX")]
    OopMax,

    [EnumMember(Value = "OOP_MAX_REMAINING")]
    OopMaxRemaining,

    [EnumMember(Value = "COPAY")]
    Copay,

    [EnumMember(Value = "COINSURANCE")]
    Coinsurance,
}
