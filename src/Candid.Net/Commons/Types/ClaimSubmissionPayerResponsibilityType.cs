using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Commons;

[JsonConverter(typeof(EnumSerializer<ClaimSubmissionPayerResponsibilityType>))]
public enum ClaimSubmissionPayerResponsibilityType
{
    [EnumMember(Value = "primary")]
    Primary,

    [EnumMember(Value = "secondary")]
    Secondary,
}
