using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<AccountType>))]
public enum AccountType
{
    [EnumMember(Value = "PATIENT")]
    Patient,

    [EnumMember(Value = "INSURANCE")]
    Insurance
}
