using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.HealthCareCodeInformation.V1;

[JsonConverter(typeof(EnumSerializer<OccurrenceSpanCode>))]
public enum OccurrenceSpanCode
{
    [EnumMember(Value = "70")]
    C70,

    [EnumMember(Value = "71")]
    C71,

    [EnumMember(Value = "72")]
    C72,

    [EnumMember(Value = "73")]
    C73,

    [EnumMember(Value = "74")]
    C74,

    [EnumMember(Value = "75")]
    C75,

    [EnumMember(Value = "76")]
    C76,

    [EnumMember(Value = "77")]
    C77,

    [EnumMember(Value = "78")]
    C78,

    [EnumMember(Value = "79")]
    C79,

    [EnumMember(Value = "80")]
    C80,

    [EnumMember(Value = "81")]
    C81,

    [EnumMember(Value = "82")]
    C82,
}
