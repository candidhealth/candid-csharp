using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(EnumSerializer<YesNoIndicator>))]
public enum YesNoIndicator
{
    [EnumMember(Value = "YES")]
    Yes,

    [EnumMember(Value = "NO")]
    No,

    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    [EnumMember(Value = "NOT_APPLICABLE")]
    NotApplicable,
}
