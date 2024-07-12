using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.ClaimSubmission.V1;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ClaimSubmission.V1;

[JsonConverter(typeof(StringEnumSerializer<ClaimFrequencyTypeCode>))]
public enum ClaimFrequencyTypeCode
{
    [EnumMember(Value = "1")]
    Original,

    [EnumMember(Value = "7")]
    Replacement,

    [EnumMember(Value = "8")]
    Void
}
