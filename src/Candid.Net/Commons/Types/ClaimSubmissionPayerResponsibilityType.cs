using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(StringEnumSerializer<ClaimSubmissionPayerResponsibilityType>))]
public enum ClaimSubmissionPayerResponsibilityType
{
    [EnumMember(Value = "primary")]
    Primary,

    [EnumMember(Value = "secondary")]
    Secondary
}
