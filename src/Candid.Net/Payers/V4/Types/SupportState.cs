using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Payers.V4;

[JsonConverter(typeof(EnumSerializer<SupportState>))]
public enum SupportState
{
    [EnumMember(Value = "NOT_SUPPORTED")]
    NotSupported,

    [EnumMember(Value = "SUPPORTED_ENROLLMENT_NOT_REQUIRED")]
    SupportedEnrollmentNotRequired,

    [EnumMember(Value = "SUPPORTED_ENROLLMENT_REQUIRED")]
    SupportedEnrollmentRequired,
}
