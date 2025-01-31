using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(EnumSerializer<AccountType>))]
public enum AccountType
{
    [EnumMember(Value = "PATIENT")]
    Patient,

    [EnumMember(Value = "INSURANCE")]
    Insurance,

    [EnumMember(Value = "THIRD_PARTY_PAYER")]
    ThirdPartyPayer,
}
