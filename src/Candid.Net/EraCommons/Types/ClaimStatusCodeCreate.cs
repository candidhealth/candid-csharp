using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<ClaimStatusCodeCreate>))]
public enum ClaimStatusCodeCreate
{
    [EnumMember(Value = "1")]
    ProcessedAsPrimary,

    [EnumMember(Value = "2")]
    ProcessedAsSecondary,

    [EnumMember(Value = "3")]
    ProcessedAsTertiary,

    [EnumMember(Value = "4")]
    Denied,

    [EnumMember(Value = "19")]
    ProcessedAsPrimaryForwarded,

    [EnumMember(Value = "20")]
    ProcessedAsSecondaryForwarded,

    [EnumMember(Value = "21")]
    ProcessedAsTertiaryForwarded,

    [EnumMember(Value = "22")]
    ReversalOfPreviousPayment,

    [EnumMember(Value = "23")]
    NotOurClaimForwarded
}
