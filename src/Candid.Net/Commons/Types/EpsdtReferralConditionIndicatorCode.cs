using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(EnumSerializer<EpsdtReferralConditionIndicatorCode>))]
public enum EpsdtReferralConditionIndicatorCode
{
    [EnumMember(Value = "AV")]
    Av,

    [EnumMember(Value = "NU")]
    Nu,

    [EnumMember(Value = "S2")]
    S2,

    [EnumMember(Value = "ST")]
    St,
}
